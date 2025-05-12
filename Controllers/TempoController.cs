using System.Runtime.InteropServices.JavaScript;
using Microsoft.AspNetCore.Mvc;
using Microsoft.JSInterop.Implementation;
using Newtonsoft.Json.Linq;
using previsãotempo.Models;

namespace previsãotempo.Controllers
{
    public class TempoController : Controller
    {
        
        private readonly HttpClient _httpClient;
        private readonly string _chaveApi;

        public TempoController(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _chaveApi = configuration["TempoAPI:ApiKey"];
        }

        public async Task<IActionResult> Index(string cidade)
        {

            if (string.IsNullOrEmpty(cidade))
            {
                return View();
                    
            }
            
            var dadosTempo = await ObterTempoClima(cidade);

            if (dadosTempo == null) {
                ViewBag.MensagemErro = "Erro na solicitação ou Cidade não encontrada!";
                return View();
            }

            return View(dadosTempo);
        }


        private async Task<DadosTempo> ObterTempoClima(string cidade)
        {
            try
            {
                var url = $"https://api.openweathermap.org/data/2.5/weather?q={cidade}" +
                          $"&appid={_chaveApi}&units=metric&lang=pt_br";

                var response = await _httpClient.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                {
                    var erroJson = await response.Content.ReadAsStringAsync();
                    ViewBag.MensagemErro = $"API retornou {(int)response.StatusCode}: veja console";
                    return null;
                }

                var resposta = await response.Content.ReadAsStringAsync();
                var dados = JObject.Parse(resposta);

                return new DadosTempo
                {
                    Cidade = dados["name"]?.ToString(),
                    Temperatura = dados["main"]?["temp"]?.ToString(),
                    Condicao = dados["weather"]?[0]?["description"]?.ToString(),
                    Umidade = dados["main"]?["humidity"]?.ToString(),
                    Velocidade = dados["wind"]?["speed"]?.ToString()
                };
            }
            catch (Exception ex)
            {
                ViewBag.MensagemErro = "Erro interno ao consultar API";
                return null;
            }
        }
    }
}   
