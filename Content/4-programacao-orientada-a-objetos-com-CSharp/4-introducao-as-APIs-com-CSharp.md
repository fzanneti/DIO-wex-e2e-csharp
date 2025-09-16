# WEX - End to End Engineering

## 4.4 - Introdução às APIs com C#

![GitHub repo size](https://img.shields.io/github/repo-size/fzanneti/wex-e2e-csharp)
![GitHub forks](https://img.shields.io/github/forks/fzanneti/wex-e2e-csharp?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/fzanneti/wex-e2e-csharp?style=social)
![Linguagem](https://img.shields.io/badge/Linguagem-CSharp-blue)
![Bootcamp](https://img.shields.io/badge/WEX-End--to--End%20Engineering-blueviolet?logo=vercel&logoColor=white)
![Plataforma](https://img.shields.io/badge/Powered%20by-DIO.io-red?logo=data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjZmZmIiB2aWV3Qm94PSIwIDAgMzIgMzIiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PHBhdGggZD0iTTYuNzEgMy4yNWMtMi44OCAxLjQxLTUuMDcgNC4yMy01LjA3IDcuNzYgMCAzLjU4IDIuMjggNi43IDUuMzMgOC4xNSAxLjgzLS42MiAyLjQtMi4yNiAyLjQtMy44MSAwLS4yMy0uMDItLjQ1LS4wNS0uNjZBLjQ0LjQ0IDAgMDExMC4xIDExYy4yNC0uNzUuMTEtMS41My0uMy0yLjIyQzguOTIgNy45NiA3LjMzIDcuNSA1Ljc0IDcuNjZhNS41NSA1LjU1IDAgM)
![Autor](https://img.shields.io/badge/Autor-fzanneti-blue?style=flat-square&logo=github)

No Bootcamp WEX, você está aprendendo C#, .NET, Git e GitHub. **APIs** permitem comunicação entre sistemas. Este módulo explora como criar e consumir APIs RESTful com **ASP.NET Core**.

---

### O que é uma API?

Uma **API** é uma interface que permite que diferentes sistemas se comuniquem.  
Ela define regras e formatos para **requisições** e **respostas**, geralmente via protocolo HTTP, utilizando padrões como:

- GET (buscar dados)
- POST (criar dados)
- PUT/PATCH (atualizar dados)
- DELETE (remover dados)

---

### Exemplo: API de Feriados

A [API Nager.Date](https://date.nager.at/) é um exemplo de API pública que fornece dados de feriados por país e ano.

---

**Chamada (GET):**

API Nager.Date 🔗[https://date.nager.at/api/v3/PublicHolidays/2025/BR](https://date.nager.at/api/v3/PublicHolidays/2025/BR)

---

**Resposta (JSON):**

```json

[
  {
    "date": "2025-01-01",
    "localName": "Confraternização Universal",
    "name": "New Year's Day",
    "countryCode": "BR",
    "global": true
  }
]

```

---

### Documentação e retornos

Uma boa API fornece **documentação clara** (Swagger, Postman ou markdown) com:

* Endpoints disponíveis
* Parâmetros de entrada
* Tipos de resposta
* Códigos de status HTTP (200, 404, 500)

---

### Exemplo de uso em C\#

```csharp

using System.Net.Http;
using System.Threading.Tasks;

public class ApiFeriados
{
    public static async Task ObterFeriados()
    {
        using var client = new HttpClient();
        var resposta = await client.GetStringAsync("https://date.nager.at/api/v3/PublicHolidays/2025/BR");
        Console.WriteLine(resposta);
    }
}

```

---

### Usando a Dog API

[Dog API](https://dog.ceo/dog-api/) é uma API pública que retorna imagens de cachorros aleatórios.

---

**Chamada:**


API Dog 🔗[https://dog.ceo/api/breeds/image/random](https://dog.ceo/api/breeds/image/random)

---

**Resposta:**

```json

{
  "message": "https://images.dog.ceo/breeds/hound-afghan/n02088094_1003.jpg",
  "status": "success"
}

```

---

**Uso em C#:**

```csharp

public async Task BuscarImagemAsync()
{
    using var http = new HttpClient();
    var json = await http.GetStringAsync("https://dog.ceo/api/breeds/image/random");
    Console.WriteLine(json);
}

```

---

### Criando Nossa API com ASP.NET Core

1. Crie um novo projeto Web API no Visual Studio ou via CLI:

```bash

dotnet new webapi -n MinhaApiExemplo

```
2. Estrutura básica gerada:

* `Program.cs` / `Startup.cs`: configurações da aplicação
* `Controllers`: onde ficam os endpoints
* `appsettings.json`: configurações

---

### Criando a Controller

```csharp

[ApiController]
[Route("api/[controller]")]
public class ProdutosController : ControllerBase
{
    [HttpGet]
    public IActionResult Listar()
    {
        var produtos = new[] { "Notebook", "Mouse", "Teclado" };
        return Ok(produtos);
    }
}

```

---

### Entendendo as Rotas

A rota `"api/[controller]"` será automaticamente substituída por `"api/produtos"`.

Você também pode configurar rotas manualmente:

```csharp

[Route("api/meusprodutos")]

```

---

### Endpoint com Parâmetros

```csharp

[HttpGet("{id}")]
public IActionResult BuscarPorId(int id)
{
    if (id == 1)
        return Ok("Notebook");
    else
        return NotFound("Produto não encontrado");
}

```

---

### Links Complementares de Estudo

Aqui estão alguns materiais gratuitos e de qualidade para reforçar os conhecimentos sobre APIs REST com C# e ASP.NET Core:

🔗[Criando Web APIs com ASP.NET Core](https://learn.microsoft.com/pt-br/training/modules/build-web-api-aspnet-core/)     
🔗[ASP.NET Core Web API](https://learn.microsoft.com/pt-br/aspnet/core/web-api/?view=aspnetcore-8.0)      
🔗[System.Text.Json](https://learn.microsoft.com/pt-br/dotnet/standard/serialization/system-text-json/overview)     
🔗[Autenticação no ASP.NET Core](https://learn.microsoft.com/pt-br/aspnet/core/security/authentication/?view=aspnetcore-8.0)     
🔗[Postman](https://www.postman.com/)       
🔗[Insomnia](https://insomnia.rest/)        
🔗[Swagger UI (Swashbuckle)](https://learn.microsoft.com/pt-br/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-8.0&tabs=visual-studio)     
🔗[RESTful API Design - Best Practices](https://restfulapi.net/)      

---

### Encerramento

- Uma API permite comunicação entre sistemas de forma simples e segura.
- Em C#, usamos **ASP.NET Core** para criar APIs REST com estrutura limpa e robusta.
- A prática de consumir e criar APIs ajuda no desenvolvimento web, mobile, IoT, integrações e mais.
- Use ferramentas como **Postman**, **Insomnia** e **Swagger** para testar suas APIs.
- Sempre valide as entradas e trate exceções para evitar erros inesperados.
- Siga boas práticas de versionamento (ex: `/api/v1/produtos`) para evoluir sua API com estabilidade.

---

### Certificado

<img src="https://github.com/fzanneti/DIO-wex-e2e-csharp/blob/main/Assets/images/certificados/20-classes-abstratas-e-interfaces-com-CSharp.jpg" alt="Certificado" width="600px">

---

##### ✍️ Seção criada por: *Fabio Zanneti* - 🎯 Bootcamp: **WEX - End to End Engineering**
[![GitHub](https://img.shields.io/badge/GitHub-fzanneti-181717?style=flat&logo=github)](https://github.com/fzanneti)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-fzanneti-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/fzanneti)
