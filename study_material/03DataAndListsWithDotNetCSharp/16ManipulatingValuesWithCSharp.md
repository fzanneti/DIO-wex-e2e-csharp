# 🧮 Manipulando Valores com C#

Este módulo apresenta as formas mais comuns e eficientes de **manipular valores em C#**, incluindo strings, números, datas e moedas. A manipulação correta dessas informações é essencial para aplicações reais, como exibição de dados ao usuário, armazenamento e cálculos.

---

### 📌 Introdução - Manipulando Valores

Em C#, os dados são frequentemente manipulados antes de serem exibidos, armazenados ou processados. Isso inclui:

- Formatação de textos;
- Representação de números e datas;
- Localização (culture) e internacionalização;
- Conversões seguras e tratamento de exceções.

---

### 🔤 Concatenando Strings

A concatenação de strings é o processo de unir duas ou mais cadeias de texto.

```csharp

string nome = "Fabio";
string saudacao = "Olá, " + nome + "!";
Console.WriteLine(saudacao); // Olá, Fabio!

```

---

### 🧩 Interpolação de Strings

Forma moderna, legível e segura de construir textos com variáveis embutidas.

```csharp

string nome = "Fabio";
int idade = 43;
Console.WriteLine($"Olá, {nome}! Você tem {idade} anos.");

```

---

### 🔢 Ajustando a Numeração

Você pode formatar números com casas decimais, separadores de milhar, ou alinhamento.

```csharp

double valor = 1234.56;
Console.WriteLine(valor.ToString("N2")); // 1.234,56

```

---

### ➕ Concatenação de Valores

Você pode concatenar valores não textuais com strings usando o método `ToString()`:

```csharp

int idade = 43;
string mensagem = "Idade: " + idade.ToString();

```

---

### 💰 Formatando Valores Monetários

Para exibir valores como moeda, use `"C"` com o `ToString()`.

```csharp

decimal preco = 59.90M;
Console.WriteLine(preco.ToString("C")); // R$ 59,90 (pt-BR)

```

---

### 🌍 Alterando a Localização do Código

A localização (`CultureInfo`) afeta como números e datas são formatados.

```csharp

using System.Globalization;

CultureInfo.CurrentCulture = new CultureInfo("en-US");
decimal preco = 59.90M;
Console.WriteLine(preco.ToString("C")); // $59.90

```

---

### 🌐 Alterando a Localização da Cultura

Além do `CurrentCulture`, podemos alterar a cultura de forma específica em uma chamada:

```csharp

decimal preco = 1234.56M;
Console.WriteLine(preco.ToString("C", new CultureInfo("ja-JP"))); // ￥1,234

```

---

### 🎯 Formatação Personalizada

Você pode criar máscaras personalizadas para exibição.

```csharp

double numero = 1234.5678;
Console.WriteLine(numero.ToString("000000.00")); // 001234.57

```

---

### 📈 Representando Porcentagem

Para exibir como porcentagem:

```csharp

double taxa = 0.256;
Console.WriteLine(taxa.ToString("P")); // 25,60%

```

---

### 🗓️ Formatando o tipo DateTime

Datas e horas também possuem formatações próprias.

```csharp

DateTime hoje = DateTime.Now;
Console.WriteLine(hoje.ToString("dd/MM/yyyy HH:mm")); // 28/05/2025 14:35

```

---

### 🕒 Formatando Data e Hora

Formatos comuns:

```csharp

DateTime data = DateTime.Now;
Console.WriteLine(data.ToString("D")); // quarta-feira, 28 de maio de 2025
Console.WriteLine(data.ToString("t")); // 14:35

```

---

### 🧪 DateTime com TryParse

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

### ✅ Validando o Retorno do TryParse

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

## ⚙️ Links Complementares de Estudo – Manipulando Valores com C#

Trabalhar bem com valores em C# significa dominar tipos primitivos, variáveis, operadores, conversões e expressões — tudo que você usa pra fazer a lógica acontecer.

---

### 🎓 Cursos e Vídeos Gratuitos

- [Tipos de Dados e Variáveis em C# – Balta.io](https://www.youtube.com/watch?v=OdpntmqoyKs)
- [Operadores em C# – Curso em Vídeo](https://www.youtube.com/watch?v=ZoOe0NHS9jw)
- [Conversão de Tipos em C# – DevAprender](https://www.youtube.com/watch?v=jp5Q6MtUl_g)

---

### 📚 Documentação Oficial Microsoft

- [Tipos de Dados C# – Microsoft Docs](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/built-in-types)
- [Variáveis e Escopo – Microsoft Learn](https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/inside-a-program/variables)
- [Operadores C# – Microsoft Learn](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/)
- [Conversões de Tipo e Casting](https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/types/casting-and-type-conversions)

---

### 🧠 Artigos Técnicos e Explicações

- [Entendendo Variáveis e Tipos em C# (DevMedia)](https://www.devmedia.com.br/entendendo-variaveis-e-tipos-de-dados-em-c/30506)
- [Conversão de Tipos em C# – Alura](https://www.alura.com.br/artigos/conversoes-de-tipos-em-c-sharp)
- [Operadores em C#: Guia Completo (Medium)](https://medium.com/@wilsonneto/operadores-em-c-75ccdfd9bb55)

---

### 💡 Extras

- [DotNetFiddle](https://dotnetfiddle.net/)
- [LINQPad](https://www.linqpad.net/)

---

#### 🧠 Conclusão

Manipular valores em C# vai além de converter números e datas. Trata-se de tornar a **interação com o usuário clara, precisa e amigável**, respeitando formatações regionais e evitando falhas no código com boas práticas como o uso de `TryParse`.

---

##### ✍️ **Seção criada por:** *Fabio Zanneti* 🎯 Projeto: **WEX - End to End Engineering**
