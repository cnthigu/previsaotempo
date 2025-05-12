# Previsão do Tempo

Projeto simples de uma aplicação web desenvolvida com **ASP.NET Core MVC**, que consome a **API da OpenWeather** para exibir informações climáticas atualizadas. A interface permite consultar rapidamente a previsão do tempo de qualquer cidade do mundo, exibindo dados como temperatura, umidade, condições do céu e velocidade do vento.

Este projeto demonstra a aplicação prática de conceitos fundamentais em consumo de APIs, estruturação de projetos MVC e boas práticas de desenvolvimento backend em C#.

---

## Visão Geral

A aplicação permite que o usuário:

- Busque o clima atual de qualquer cidade.
- Visualize informações como:
  - Temperatura (°C)
  - Condição do tempo (ex: céu limpo, nublado, etc.)
  - Umidade relativa do ar
  - Velocidade do vento

---

## Tecnologias Utilizadas

- **ASP.NET Core MVC** – Estrutura principal da aplicação.
- **C#** – Linguagem para construção da lógica de negócio.
- **Razor Pages** – Para renderização das views.
- **HttpClient** – Para chamadas assíncronas à API externa.
- **OpenWeather API** – Fonte oficial dos dados de clima.
- **Newtonsoft.Json (JObject)** – Para parse e leitura dinâmica dos dados JSON.

---

## O que foi aprendido

Durante o desenvolvimento deste projeto, foi possível consolidar conhecimentos em:

- Estruturação de projetos no padrão **MVC**.
- Utilização do **HttpClient** para consumo de APIs externas.
- Manipulação e tratamento de respostas JSON com **JObject**.
- Leitura de configurações seguras com **IConfiguration** (via `appsettings.json`).
- Boas práticas de **tratamento de erros** e respostas HTTP.
- Exibição de dados dinamicamente nas views com **Razor Pages**.
- Escrita de código limpo, organizado e orientado a propósito.

---

## Como Executar Localmente

1. Clone este repositório:
   ```bash
   git clone https://github.com/cnthigu/previsaotempo.git
   ```

2. Abra o projeto no **Visual Studio** ou no seu editor preferido.

3. Adicione sua chave da OpenWeather em `appsettings.json`:
   ```json
   "TempoAPI": {
     "ApiKey": "SUA_CHAVE_AQUI"
   }
   ```
---

## Demonstração

[ Video Rapido](https://www.youtube.com/watch?v=TTa6sNbezso)

---

Desenvolvido com atenção aos detalhes, mesmo sendo um projeto de escopo simples, com foco em boas práticas e clareza no código.
