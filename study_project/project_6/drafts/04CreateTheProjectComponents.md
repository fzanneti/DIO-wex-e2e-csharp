# 🧠 O que vamos construir agora:

JarbasBot vai responder mensagens como:

> “Fala meu chapa, aqui é o JarbasBot! Sobre isso aí que cê mandou... olha só: ...”

💬 Estilo informal, mas útil. Vai ser uma IA com carisma 😄

---

![GitHub repo size](https://img.shields.io/github/repo-size/fzanneti/wex-e2e-csharp)
![GitHub forks](https://img.shields.io/github/forks/fzanneti/wex-e2e-csharp?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/fzanneti/wex-e2e-csharp?style=social)
![Bootcamp](https://img.shields.io/badge/WEX-End--to--End%20Engineering-blueviolet?logo=vercel&logoColor=white)
![Plataforma](https://img.shields.io/badge/Powered%20by-DIO.io-red?logo=data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjZmZmIiB2aWV3Qm94PSIwIDAgMzIgMzIiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PHBhdGggZD0iTTYuNzEgMy4yNWMtMi44OCAxLjQxLTUuMDcgNC4yMy01LjA3IDcuNzYgMCAzLjU4IDIuMjggNi43IDUuMzMgOC4xNSAxLjgzLS42MiAyLjQtMi4yNiAyLjQtMy44MSAwLS4yMy0uMDItLjQ1LS4wNS0uNjZBLjQ0LjQ0IDAgMDExMC4xIDExYy4yNC0uNzUuMTEtMS41My0uMy0yLjIyQzguOTIgNy45NiA3LjMzIDcuNSA1Ljc0IDcuNjZhNS41NSA1LjU1IDAgM)
![Autor](https://img.shields.io/badge/Autor-fzanneti-blue?style=flat-square&logo=github)

---

### 📁 Organização da estrutura

Estamos na pasta `JarbasBot/`, e vamos criar:

```

JarbasBot/
├── Controllers/
│   └── ChatController.cs ✅
├── Models/
│   ├── ChatRequest.cs ✅
│   └── ChatResponse.cs ✅
├── Services/
│   └── OpenAiService.cs ✅
├── Program.cs (já está OK)

```

---

## ✍️ ETAPA 1 – Criar os Models

### 📄 `Models/ChatRequest.cs`

```csharp

namespace JarbasBot.Models
{
    public class ChatRequest
    {
        public string Question { get; set; } = string.Empty;
    }
}

```

### 📄 `Models/ChatResponse.cs`

```csharp

namespace JarbasBot.Models
{
    public class ChatResponse
    {
        public string Answer { get; set; } = string.Empty;
    }
}

```

---

## ✍️ ETAPA 2 – Criar o serviço que conversa com a OpenAI

### 📄 `Services/OpenAiService.cs`

```csharp

public async Task<string> AskJarbas(string pergunta)
{
    if (string.IsNullOrWhiteSpace(pergunta))
    {
        return "Ô meu, manda uma pergunta direito aí!";
    }

    var requestBody = new
    {
        model = "meta-llama/llama-4-maverick:free",
        messages = new[]
        {
            new
            {
                role = "system",
                content = "Você é o Jarbas, um assistente informal e carismático que fala com gírias e bom humor. Sempre responde como um amigo experiente e direto."
            },
            new { role = "user", content = pergunta }
        },
        max_tokens = 1000,
        temperature = 0.7
    };

    try
    {
        using var content = new StringContent(
            JsonSerializer.Serialize(requestBody, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            }),
            Encoding.UTF8,
            "application/json"
        );

        using var request = new HttpRequestMessage(HttpMethod.Post, "https://openrouter.ai/api/v1/chat/completions");
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _apiKey);
        request.Content = content;

        using var response = await _httpClient.SendAsync(request);
        response.EnsureSuccessStatusCode();

        var responseString = await response.Content.ReadAsStringAsync();

        using JsonDocument json = JsonDocument.Parse(responseString);

        if (json.RootElement.TryGetProperty("choices", out var choices) &&
            choices.GetArrayLength() > 0 &&
            choices[0].TryGetProperty("message", out var message) &&
            message.TryGetProperty("content", out var contentProp))
        {
            return contentProp.GetString()?.Trim() ?? "Poxa, não consegui entender a resposta da API...";
        }

        return "Eita, a resposta da API veio estranha, véi!";
    }
    catch (HttpRequestException ex)
    {
        return $"Deu zica na conexão: {ex.Message} (Status: {(int?)ex.StatusCode ?? 0})";
    }
    catch (JsonException)
    {
        return "Opa, o formato da resposta tá zoado!";
    }
    catch (Exception ex)
    {
        return $"Eita, algo deu ruim: {ex.Message}";
    }
}

```

---

## ✍️ ETAPA 3 – Criar o Controller principal da API

### 📄 `Controllers/ChatController.cs`

```csharp

using Microsoft.AspNetCore.Mvc;
using JarbasBot.Models;
using JarbasBot.Services;

namespace JarbasBot.Controllers
{
    [ApiController]
    [Route("api/chat")]
    public class ChatController : ControllerBase
    {
        private readonly OpenAiService _openAiService;

        public ChatController(OpenAiService openAiService)
        {
            _openAiService = openAiService;
        }

        [HttpPost("chat")]
        public async Task<IActionResult> Chat([FromBody] ChatRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Question))
                return BadRequest("A pergunta tá vazia, parça! Manda alguma coisa aí.");

            var response = await _openAiService.AskJarbas(request.Question);
            return Ok(response);
        }
    }
}

```

---

## ✍️ ETAPA 4 – Registrar tudo no `Program.cs`

No `Program.cs`, adicione:

```csharp

using JarbasBot.Services;

//...

var builder = WebApplication.CreateBuilder(args);

// Serviços
builder.Services.AddControllers();                  // ← Obrigatório para Controllers
builder.Services.AddEndpointsApiExplorer();         // ← Necessário para Swagger
builder.Services.AddSwaggerGen();                   // ← Gera os arquivos Swagger

var app = builder.Build();

// Middleware
app.UseSwagger();                                   // ← Gera o JSON
app.UseSwaggerUI();                                 // ← Interface visual

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();

```

---

## ⚙️ ETAPA 5 – Colocar a API Key de forma segura

### 📌 Melhor prática: passar pelo `docker-compose.yml`

No `docker-compose.yml`, adicione a variável de ambiente:

```yaml

jarbasbot:
  ...
  environment:
    - ASPNETCORE_ENVIRONMENT=Development
    - OPENAI_API_KEY=sua-chave-aqui

```

---

### 🔐 Onde conseguir a sua chave da OpenAI

1. Acesse o site: [https://platform.openai.com](https://platform.openai.com)
2. Faça login com sua conta
3. No menu superior direito, clique no seu nome → **"View API keys"** ou vá direto para [https://platform.openai.com/account/api-keys](https://platform.openai.com/account/api-keys)
4. Clique em **"Create new secret key"**
5. Copie a chave gerada (ela começa com `sk-...`)

> ⚠️ **Importante**: você só verá essa chave uma vez — copie e guarde em um local seguro.

---

Depois, no `OpenAiService.cs`, altere:

```csharp

_apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY") ?? "";

```

---

## ✅ Finalizando

Reconstrua:

```bash

docker-compose down
docker-compose up --build

```

---

## 🧪 Teste no Swagger

* Acesse: `http://192.168.1.48:5000/swagger`
* Teste o endpoint: `POST /api/chat/chat`
* Corpo da requisição:

```json

{

  "question": "Quem é você?"

}

```

Resposta:

```json

{
  "answer": "Fala meu parceiro! Eu sou o JarbasBot, seu assistente digital firmeza. Tô aqui pra te ajudar, bater papo e resolver o que puder, beleza? Manda ver na pergunta aí!"
}

```

---

### 🚀 Projeto JarbasBot online!

Firmeza total, Fabio. Com isso você tem:

* Backend C# com Docker
* API REST com integração GPT
* Resposta com personalidade
* Estrutura pronta pra colocar no GitHub

---

##### ✍️ Criado por: Fabio Zanneti - 🎯 Projeto: WEX - End to End Engineering
[![GitHub](https://img.shields.io/badge/GitHub-fzanneti-181717?style=flat&logo=github)](https://github.com/fzanneti)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-fzanneti-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/fzanneti)