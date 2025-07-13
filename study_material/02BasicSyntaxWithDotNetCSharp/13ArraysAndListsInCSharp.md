# 🔢 Arrays e Listas em C#

Material de apoio referente ao módulo de Arrays e Listas em C# do curso WEX - End to End Engineering (DIO).

![GitHub repo size](https://img.shields.io/github/repo-size/fzanneti/wex-e2e-csharp)
![GitHub forks](https://img.shields.io/github/forks/fzanneti/wex-e2e-csharp?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/fzanneti/wex-e2e-csharp?style=social)
![Linguagem](https://img.shields.io/badge/Linguagem-CSharp-blue)
![Bootcamp](https://img.shields.io/badge/WEX-End--to--End%20Engineering-blueviolet?logo=vercel&logoColor=white)
![Plataforma](https://img.shields.io/badge/Powered%20by-DIO.io-red?logo=data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjZmZmIiB2aWV3Qm94PSIwIDAgMzIgMzIiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PHBhdGggZD0iTTYuNzEgMy4yNWMtMi44OCAxLjQxLTUuMDcgNC4yMy01LjA3IDcuNzYgMCAzLjU4IDIuMjggNi43IDUuMzMgOC4xNSAxLjgzLS42MiAyLjQtMi4yNiAyLjQtMy44MSAwLS4yMy0uMDItLjQ1LS4wNS0uNjZBLjQ0LjQ0IDAgMDExMC4xIDExYy4yNC0uNzUuMTEtMS41My0uMy0yLjIyQzguOTIgNy45NiA3LjMzIDcuNSA1Ljc0IDcuNjZhNS41NSA1LjU1IDAgM)
![Autor](https://img.shields.io/badge/Autor-fzanneti-blue?style=flat-square&logo=github)

---

### 🧠 Introdução aos Arrays

No Bootcamp WEX, você está aprendendo C#, .NET, Git e GitHub. **Arrays** e **listas** são fundamentais para manipular coleções de dados em projetos como cadastros ou APIs. Este módulo explora arrays, listas, seus métodos e boas práticas.

---

## 🧠 Arrays

### Exemplo:

```csharp

int[] numeros = new int[5]; // array de 5 inteiros

```

Você também pode inicializar com valores:

```csharp

string[] frutas = { "Maçã", "Banana", "Pêra" };

```

---

### 🔨 Implementando um Array de Inteiros

```csharp

int[] numeros = new int[3];
numeros[0] = 10;
numeros[1] = 20;
numeros[2] = 30;

Console.WriteLine(numeros[1]); // Saída: 20

```

---

### ⚠️ Acessando um Índice Inválido

```csharp

int[] valores = new int[2];
valores[0] = 5;
valores[1] = 10;

// valores[2] = 15; // Erro! Índice fora do intervalo.

```

Esse tipo de erro lança uma exceção:

```plaintext

System.IndexOutOfRangeException

```

---

### 🔁 Percorrendo um Array com `foreach`

```csharp

string[] nomes = { "Ana", "Carlos", "João" };

foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}

```

O `foreach` é ideal quando você não precisa modificar os dados e quer apenas percorrer os elementos.

---

### 🐞 Debugando um Array

Durante o debug no Visual Studio, é possível ver:

* Cada índice do array
* O valor armazenado em cada posição
* O comprimento total (`Length`)

### Exemplo:

```csharp

Console.WriteLine(nomes.Length); // Quantos elementos há

```

---

### 🔄 Redimensionando um Array

Arrays são estáticos, mas é possível redimensioná-los com `Array.Resize()`:

```csharp

int[] numeros = { 1, 2, 3 };
Array.Resize(ref numeros, 5);
numeros[3] = 4;
numeros[4] = 5;

```

⚠️ Isso cria uma **nova instância** do array e copia os valores antigos.

---

### 📋 Copiando um Array para Outro

```csharp

int[] origem = { 1, 2, 3 };
int[] destino = new int[3];

Array.Copy(origem, destino, origem.Length);

```

Você também pode usar `Clone()`:

```csharp

int[] copia = (int[])origem.Clone();

```

---

### 📚 Trabalhando com Listas (`List<T>`)

Diferente dos arrays, as listas são **dinâmicas** — você pode adicionar e remover elementos facilmente.

### Exemplo básico:

```csharp

List<string> nomes = new List<string>();
nomes.Add("Carlos");
nomes.Add("Ana");
nomes.Add("Pedro");

foreach (var nome in nomes)
{
    Console.WriteLine(nome);
}

```

### Outras operações:

```csharp

nomes.Remove("Ana");         // Remove elemento
Console.WriteLine(nomes.Count);  // Conta os itens
nomes.Clear();               // Limpa a lista

```
---

### 🛡️ Tratamento de Erros

```csharp

try
{
    int[] numeros = new int[2];
    numeros[2] = 10; // Lança IndexOutOfRangeException
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("Erro: Índice fora do intervalo!");
}

```

---

## 📚 Links Complementares de Estudo – Arrays e Listas em C#

Trabalhar com Arrays e Listas é essencial pra manipular conjuntos de dados em C#. Arrays são fixos e listas são dinâmicas, e entender a diferença e uso correto faz toda a diferença.

---

### 📚 Documentação Oficial Microsoft

- [Array Class – System.Array](https://learn.microsoft.com/pt-br/dotnet/api/system.array?view=net-8.0)
- [List<T> Class – System.Collections.Generic.List](https://learn.microsoft.com/pt-br/dotnet/api/system.collections.generic.list-1?view=net-8.0)
- [Como percorrer coleções em C# (foreach)](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/foreach-in)

---

### 💡 Ferramentas para Prática

- [DotNetFiddle](https://dotnetfiddle.net/)
- [LINQPad](https://www.linqpad.net/)

---

### ✅ Encerramento do Tema

Use **arrays** para coleções fixas e **listas** para coleções dinâmicas. Trate erros como índices inválidos e use métodos como `Sort` e `Find` para manipulações eficientes. Continue praticando no Bootcamp WEX para dominar coleções!

---

##### ✍️ Seção criada por: *Fabio Zanneti* - 🎯 Bootcamp: **WEX - End to End Engineering**
[![GitHub](https://img.shields.io/badge/GitHub-fzanneti-181717?style=flat&logo=github)](https://github.com/fzanneti)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-fzanneti-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/fzanneti)