# WEX - End to End Engineering

## 3.2 - Manipulando Valores com C#

![GitHub repo size](https://img.shields.io/github/repo-size/fzanneti/wex-e2e-csharp)
![GitHub forks](https://img.shields.io/github/forks/fzanneti/wex-e2e-csharp?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/fzanneti/wex-e2e-csharp?style=social)
![Linguagem](https://img.shields.io/badge/Linguagem-CSharp-blue)
![Bootcamp](https://img.shields.io/badge/WEX-End--to--End%20Engineering-blueviolet?logo=vercel&logoColor=white)
![Plataforma](https://img.shields.io/badge/Powered%20by-DIO.io-red?logo=data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjZmZmIiB2aWV3Qm94PSIwIDAgMzIgMzIiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PHBhdGggZD0iTTYuNzEgMy4yNWMtMi44OCAxLjQxLTUuMDcgNC4yMy01LjA3IDcuNzYgMCAzLjU4IDIuMjggNi43IDUuMzMgOC4xNSAxLjgzLS42MiAyLjQtMi4yNiAyLjQtMy44MSAwLS4yMy0uMDItLjQ1LS4wNS0uNjZBLjQ0LjQ0IDAgMDExMC4xIDExYy4yNC0uNzUuMTEtMS41My0uMy0yLjIyQzguOTIgNy45NiA3LjMzIDcuNSA1Ljc0IDcuNjZhNS41NSA1LjU1IDAgM)
![Autor](https://img.shields.io/badge/Autor-fzanneti-blue?style=flat-square&logo=github)

No Bootcamp WEX, você está aprendendo C#, .NET, Git e GitHub. A **manipulação de valores** é essencial para processar dados, formatar saídas e realizar cálculos precisos. Este módulo explora strings, números, datas, moedas e localização.

---

### Introdução - Manipulando Valores

Em C#, os dados são frequentemente manipulados antes de serem exibidos, armazenados ou processados. Isso inclui:

- Formatação de textos;
- Representação de números e datas;
- Localização (culture) e internacionalização;
- Conversões seguras e tratamento de exceções.

---

### Concatenando Strings

A concatenação de strings é o processo de unir duas ou mais cadeias de texto.

```csharp

string nome = "Fabio";
string saudacao = "Olá, " + nome + "!";
Console.WriteLine(saudacao); // Olá, Fabio!

```

---

### Interpolação de Strings

Forma moderna, legível e segura de construir textos com variáveis embutidas.

```csharp

string nome = "Fabio";
int idade = 43;
Console.WriteLine($"Olá, {nome}! Você tem {idade} anos.");

```

---

### Ajustando a Numeração

Você pode formatar números com casas decimais, separadores de milhar, ou alinhamento.

```csharp

double valor = 1234.56;
Console.WriteLine(valor.ToString("N2")); // 1.234,56

```

---

### Concatenação de Valores

Você pode concatenar valores não textuais com strings usando o método `ToString()`:

```csharp

int idade = 43;
string mensagem = "Idade: " + idade.ToString();

```

---

### Formatando Valores Monetários

Para exibir valores como moeda, use `"C"` com o `ToString()`.

```csharp

decimal preco = 59.90M;
Console.WriteLine(preco.ToString("C")); // R$ 59,90 (pt-BR)

```

---

### Alterando a Localização do Código

A localização (`CultureInfo`) afeta como números e datas são formatados.

```csharp

using System.Globalization;

CultureInfo.CurrentCulture = new CultureInfo("en-US");
decimal preco = 59.90M;
Console.WriteLine(preco.ToString("C")); // $59.90

```

---

### Alterando a Localização da Cultura

Além do `CurrentCulture`, podemos alterar a cultura de forma específica em uma chamada:

```csharp

decimal preco = 1234.56M;
Console.WriteLine(preco.ToString("C", new CultureInfo("ja-JP"))); // ￥1,234

```

---

### Formatação Personalizada

Você pode criar máscaras personalizadas para exibição.

```csharp

double numero = 1234.5678;
Console.WriteLine(numero.ToString("000000.00")); // 001234.57

```

---

### Representando Porcentagem

Para exibir como porcentagem:

```csharp

double taxa = 0.256;
Console.WriteLine(taxa.ToString("P")); // 25,60%

```

---

### Formatando o tipo DateTime

Datas e horas também possuem formatações próprias.

```csharp

DateTime hoje = DateTime.Now;
Console.WriteLine(hoje.ToString("dd/MM/yyyy HH:mm")); // 28/05/2025 14:35

```

---

### Formatando Data e Hora

Formatos comuns:

```csharp

DateTime data = DateTime.Now;
Console.WriteLine(data.ToString("D")); // quarta-feira, 28 de maio de 2025
Console.WriteLine(data.ToString("t")); // 14:35

```

---

### DateTime com TryParse

O método `TryParse` evita erros ao converter strings para `DateTime`.

```csharp

string entrada = "28/05/2025";
DateTime data;

if (DateTime.TryParse(entrada, out data))
{
    Console.WriteLine("Data válida: " + data.ToShortDateString());
}
else
{
    Console.WriteLine("Data inválida!");
}

```

---

### Validando o Retorno do TryParse

Sempre que usar `TryParse`, valide o retorno booleano para evitar exceções:

```csharp

string valor = "abc";
int numero;

if (int.TryParse(valor, out numero))
{
    Console.WriteLine("Número válido: " + numero);
}
else
{
    Console.WriteLine("Entrada inválida. Não é um número.");
}

```

---

### Documentação Oficial Microsoft

🔗[Tipos de Dados C#](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/built-in-types)      
🔗[Variáveis e Escopo](https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/inside-a-program/variables)      
🔗[Formatação de Strings](https://learn.microsoft.com/pt-br/dotnet/standard/base-types/string-formats)     
🔗[CultureInfo](https://learn.microsoft.com/pt-br/dotnet/api/system.globalization.cultureinfo)     
🔗[Operadores C#](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/)     
🔗[Conversões de Tipo e Casting](https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/types/casting-and-type-conversions)     
🔗[DotNetFiddle](https://dotnetfiddle.net/)     
🔗[LINQPad](https://www.linqpad.net/)     

---

### Conclusão

Manipular valores em C# vai além de converter números e datas. Trata-se de tornar a **interação com o usuário clara, precisa e amigável**, respeitando formatações regionais e evitando falhas no código com boas práticas como o uso de `TryParse`.

---

### Certificado

<img src="https://github.com/fzanneti/DIO-wex-e2e-csharp/blob/main/Assets/images/certificados/15-manipulando-valores-com-CSharp.jpg" alt="Certificado" width="600px">

---

##### ✍️ Seção criada por: *Fabio Zanneti* - 🎯 Bootcamp: **WEX - End to End Engineering**
[![GitHub](https://img.shields.io/badge/GitHub-fzanneti-181717?style=flat&logo=github)](https://github.com/fzanneti)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-fzanneti-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/fzanneti)