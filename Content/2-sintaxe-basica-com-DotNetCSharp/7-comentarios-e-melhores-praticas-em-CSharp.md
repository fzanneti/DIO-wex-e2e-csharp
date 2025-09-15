# WEX - End to End Engineering

## Comentários e Boas Práticas em C#

![GitHub repo size](https://img.shields.io/github/repo-size/fzanneti/wex-e2e-csharp)
![GitHub forks](https://img.shields.io/github/forks/fzanneti/wex-e2e-csharp?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/fzanneti/wex-e2e-csharp?style=social)
![Linguagem](https://img.shields.io/badge/Linguagem-CSharp-blue)
![Bootcamp](https://img.shields.io/badge/WEX-End--to--End%20Engineering-blueviolet?logo=vercel&logoColor=white)
![Plataforma](https://img.shields.io/badge/Powered%20by-DIO.io-red?logo=data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjZmZmIiB2aWV3Qm94PSIwIDAgMzIgMzIiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PHBhdGggZD0iTTYuNzEgMy4yNWMtMi44OCAxLjQxLTUuMDcgNC4yMy01LjA3IDcuNzYgMCAzLjU4IDIuMjggNi43IDUuMzMgOC4xNSAxLjgzLS42MiAyLjQtMi4yNiAyLjQtMy44MSAwLS4yMy0uMDItLjQ1LS4wNS0uNjZBLjQ0LjQ0IDAgMDExMC4xIDExYy4yNC0uNzUuMTEtMS41My0uMy0yLjIyQzguOTIgNy45NiA3LjMzIDcuNSA1Ljc0IDcuNjZhNS41NSA1LjU1IDAgM)
![Autor](https://img.shields.io/badge/Autor-fzanneti-blue?style=flat-square&logo=github)

No Bootcamp WEX, você está aprendendo C#, .NET, Git e GitHub. **Comentários** e **boas práticas** são essenciais para escrever códigos legíveis e manuteníveis. Este módulo explora tipos de comentários, documentação XML e princípios de Clean Code.

---

### Introdução aos Comentários

Comentários são trechos ignorados pelo compilador, usados para:

- Explicar trechos complexos de código
- Documentar intenções ou lógica
- Marcar pontos de atenção
- Criar documentação automatizada (em ferramentas como o XML Docs)

> Comentário bom é aquele que realmente **ajuda a entender o "porquê" do código**, e não apenas repetir o que ele já faz.

---

### Comentário de Linha Única

Para comentários simples, use `//`:

```csharp

int idade = 30; // idade do usuário

```

> Use-os para **resumos rápidos** ou **explicações pontuais**.

---

### Comentário de Múltiplas Linhas

Quando precisar explicar com mais detalhes:

```csharp

/*
 Este bloco realiza o cálculo do
 desconto progressivo com base
 no valor total da compra.
*/
double desconto = CalculaDesconto(totalCompra);

```

Pode ser útil para **ocultar temporariamente** trechos de código durante testes:

```csharp

/*
Console.WriteLine("Teste de saída");
Console.WriteLine("Outro teste");
*/

```

---

### Comentando Nossas Classes

É importante documentar o propósito das classes e sua responsabilidade:

```csharp

/// <summary>
/// Representa um aluno com nome, idade e matrícula.
/// </summary>
public class Aluno
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}

```

> Essa abordagem permite a geração de documentação XML e integração com ferramentas como o IntelliSense.

---

### Comentários nos Métodos - Documentação XML

Documente o comportamento e parâmetros dos métodos:

```csharp

/// <summary>
/// Calcula o valor total com desconto.
/// </summary>
/// <param name="valor">Valor base do produto.</param>
/// <param name="porcentagem">Porcentagem de desconto aplicada.</param>
/// <returns>Valor final com desconto.</returns>
public double CalcularDesconto(double valor, double porcentagem)
{
    return valor - (valor * porcentagem / 100);
}

```

> Utilize sempre que criar **métodos públicos ou complexos**, mesmo que sejam simples hoje — isso ajuda quem vai manter o código no futuro (inclusive você mesmo).

---

### Dica de Boas Práticas

| Boa Prática                                 | Evite                                  |
| ------------------------------------------- | -------------------------------------- |
| Comentários explicativos sobre decisões     | Comentários que explicam o óbvio       |
| Documentar APIs públicas                    | Comentários redundantes                |
| Comentar códigos temporários com TODO/FIXME | Comentários desatualizados ou confusos |

---

### Exemplo com `TODO` e `FIXME`:

```csharp

// TODO: Criar validação de CPF
// FIXME: Corrigir erro de arredondamento

```

---

### Leitura Complementar

🔗[Guia de Estilo para C# – Microsoft](https://learn.microsoft.com/pt-br/dotnet/csharp/fundamentals/coding-style/coding-conventions)     
🔗[Clean Code com C# – Medium](https://medium.com/@danieloliveira/clean-code-com-c-dicas-pr%C3%A1ticas-6ffb2c275f7a)     
🔗[Boas práticas de desenvolvimento – Alura](https://www.alura.com.br/artigos/boas-praticas-codigo-limpo)    

---

### Desafio do Módulo 2 - Estacionamento

[![Repo Card](https://github-readme-stats.vercel.app/api/pin/?username=fzanneti&repo=dio-and-wex-parking-challenge&bg_color=261d31&border_color=7a49c6&show_icons=true&icon_color=7a49c6&title_color=37ccab&text_color=FFF)](https://github.com/fzanneti/dio-and-wex-parking-challenge)

### Certificado

<img src="https://github.com/fzanneti/DIO-wex-e2e-csharp/blob/main/Assets/images/certificados/13-construindo-um-sistema-para-um-estacionamento-com-CSharp" alt="Certificado" width="600px">

---

### Considerações Finais

- **Use comentários com moderação**. Um código bem escrito deve ser, por si só, fácil de entender.
- **Comente intenções, não implementações óbvias**.
- **Evite comentários desatualizados**, eles são mais prejudiciais do que não comentar.
- **Nunca use comentários para justificar "gambiarras"** — o ideal é refatorar.

---

### Certificado

<img src="https://github.com/fzanneti/DIO-wex-e2e-csharp/blob/main/Assets/images/certificados/12-comentarios-e-boas-praticas-em-CSharp.jpg" alt="Certificado" width="600px">

---

##### ✍️ Seção criada por: *Fabio Zanneti* - 🎯 Bootcamp: **WEX - End to End Engineering**
[![GitHub](https://img.shields.io/badge/GitHub-fzanneti-181717?style=flat&logo=github)](https://github.com/fzanneti)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-fzanneti-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/fzanneti)