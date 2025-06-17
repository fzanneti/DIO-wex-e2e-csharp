# 🌐 Introdução às APIs com C#

Este módulo apresenta os conceitos fundamentais de **APIs (Application Programming Interfaces)** com foco no desenvolvimento em **C# utilizando ASP.NET Core**. Também explora exemplos práticos de consumo de APIs públicas e a criação de uma API RESTful do zero.

---

### 📌 O que é uma API?

Uma **API** é uma interface que permite que diferentes sistemas se comuniquem.  
Ela define regras e formatos para **requisições** e **respostas**, geralmente via protocolo HTTP, utilizando padrões como:

- GET (buscar dados)
- POST (criar dados)
- PUT/PATCH (atualizar dados)
- DELETE (remover dados)

---

### 🎯 Exemplo: API de Feriados

A [API Nager.Date](https://date.nager.at/) é um exemplo de API pública que fornece dados de feriados por país e ano.

**Exemplo de chamada (GET):**

```

[https://date.nager.at/api/v3/PublicHolidays/2025/BR](https://date.nager.at/api/v3/PublicHolidays/2025/BR)

```

**Resposta esperada (JSON):**

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

### 📑 Documentação e retornos

Uma boa API fornece **documentação clara** (Swagger, Postman ou markdown) com:

* Endpoints disponíveis
* Parâmetros de entrada
* Tipos de resposta
* Códigos de status HTTP (200, 404, 500)

---

### 🧪 Exemplo de uso em C\#

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

### 🐶 Usando a Dog API

[Dog API](https://dog.ceo/dog-api/) é uma API pública que retorna imagens de cachorros aleatórios.

**Chamada:**

```
https://dog.ceo/api/breeds/image/random
```

**Resposta:**

```json

{
  "message": "https://images.dog.ceo/breeds/hound-afghan/n02088094_1003.jpg",
  "status": "success"
}

```

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

### ⚙️ Criando Nossa API com ASP.NET Core

1. Crie um novo projeto Web API no Visual Studio ou via CLI:

```bash

dotnet new webapi -n MinhaApiExemplo

```

2. Estrutura básica gerada:

* `Program.cs` / `Startup.cs`: configurações da aplicação
* `Controllers`: onde ficam os endpoints
* `appsettings.json`: configurações

---

### 🧭 Criando a Controller

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

### 🔀 Entendendo as Rotas

A rota `"api/[controller]"` será automaticamente substituída por `"api/produtos"`.

Você também pode configurar rotas manualmente:

```csharp

[Route("api/meusprodutos")]

```

---

### 📥 Endpoint com Parâmetros

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

### ✅ Encerramento

* Uma API permite comunicação entre sistemas de forma simples e segura.
* Em C#, usamos **ASP.NET Core** para criar APIs REST com estrutura limpa e robusta.
* A prática de consumir e criar APIs ajuda no desenvolvimento web, mobile, IoT, integrações e mais.

---

#### 🚀 Recomendações Finais

* Use ferramentas como **Postman**, **Insomnia** e **Swagger** para testar suas APIs.
* Sempre valide as entradas e trate exceções para evitar erros inesperados.
* Siga boas práticas de versionamento (ex: `/api/v1/produtos`) para evoluir sua API com estabilidade.

---

## 📘 Links Complementares de Estudo

Aqui estão alguns materiais gratuitos e de qualidade para reforçar os conhecimentos sobre APIs REST com C# e ASP.NET Core:

### 🎓 Cursos e Tutoriais Gratuitos

- [Criando Web APIs com ASP.NET Core - Microsoft Learn](https://learn.microsoft.com/pt-br/training/modules/build-web-api-aspnet-core/)
  > Curso oficial da Microsoft com passo a passo para criar APIs REST com ASP.NET Core.

- [Curso Web API com .NET Core 6 (Balta.io)](https://www.youtube.com/watch?v=3nLuucv3rkE)
  > Curso gratuito no YouTube do Balta explicando como montar uma API REST do zero com .NET 6.

- [Web API RESTful com ASP.NET Core - DevAprender](https://www.youtube.com/watch?v=IufAwzGE2C8)
  > Tutorial prático explicando como criar e consumir APIs em C# com ASP.NET Core.

### 📚 Documentações Oficiais

- [Documentação ASP.NET Core Web API](https://learn.microsoft.com/pt-br/aspnet/core/web-api/?view=aspnetcore-8.0)
  > Tudo sobre criação de APIs REST com ASP.NET Core.

- [Referência da Classe ControllerBase (Microsoft)](https://learn.microsoft.com/pt-br/dotnet/api/microsoft.aspnetcore.mvc.controllerbase?view=aspnetcore-8.0)
  > Documentação da base para criação de controladores de API no ASP.NET.

### 📦 Ferramentas e Testes de API

- [Postman](https://www.postman.com/)
  > Ferramenta essencial para testar endpoints de API de forma visual.

- [Insomnia](https://insomnia.rest/)
  > Alternativa ao Postman para testes de APIs, leve e intuitiva.

- [Swagger UI (Swashbuckle)](https://learn.microsoft.com/pt-br/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-8.0&tabs=visual-studio)
  > Como documentar e testar sua API de forma interativa com Swagger.

### 💡 Extras Interessantes

- [RESTful API Design - Best Practices](https://restfulapi.net/)
  > Guia completo com boas práticas no design de APIs REST.

- [Top 10 REST API Best Practices](https://www.freecodecamp.org/news/rest-api-best-practices/)
  > Artigo com dicas práticas para estruturar melhor suas APIs.

---

> ✍️ **Seção criada por:** *Fabio Zanneti*
> 🎯 Projeto: **WEX - End to End Engineering**