# 🔢 Arrays e Listas em C#

Material de apoio referente ao módulo de Arrays e Listas em C# do curso WEX - End to End Engineering (DIO).

---

### 🧠 Introdução aos Arrays

Arrays são estruturas de dados que armazenam **uma coleção de elementos do mesmo tipo**, com **tamanho fixo**.

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

## 📚 Links Complementares de Estudo – Arrays e Listas em C#

Trabalhar com Arrays e Listas é essencial pra manipular conjuntos de dados em C#. Arrays são fixos e listas são dinâmicas, e entender a diferença e uso correto faz toda a diferença.

---

### 🎓 Cursos e Vídeos Gratuitos

- [Arrays em C# – Curso em Vídeo](https://www.youtube.com/watch?v=KoJ8PfRpQBY)
- [Listas em C# (List<T>) – Balta.io](https://www.youtube.com/watch?v=SGvUu2hEqyA)
- [Arrays vs Listas em C# – DevAprender](https://www.youtube.com/watch?v=K6E1dEpCGdU)

---

### 📚 Documentação Oficial Microsoft

- [Array Class – System.Array](https://learn.microsoft.com/pt-br/dotnet/api/system.array?view=net-8.0)
- [List<T> Class – System.Collections.Generic.List](https://learn.microsoft.com/pt-br/dotnet/api/system.collections.generic.list-1?view=net-8.0)
- [Como percorrer coleções em C# (foreach)](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/foreach-in)

---

### 🧠 Artigos e Explicações Técnicas

- [Arrays e Listas em C# – DevMedia](https://www.devmedia.com.br/arrays-e-listas-em-c/28021)
- [Diferença entre Array e List em C# (Medium)](https://medium.com/@jrodrigues/diferen%C3%A7a-entre-array-e-list-em-c-4a36f7d6b535)
- [Manipulando Listas em C# (Alura)](https://www.alura.com.br/artigos/listas-em-csharp)

---

### 💡 Ferramentas para Prática

- [DotNetFiddle](https://dotnetfiddle.net/)
- [LINQPad](https://www.linqpad.net/)

---

### ✅ Encerramento do Tema

- Use **arrays** quando souber exatamente quantos elementos irá armazenar.
- Prefira **listas** (`List<T>`) para manipular coleções dinâmicas.
- Lembre-se de tratar exceções ao acessar arrays com índices inválidos.
- Explore métodos utilitários da classe `Array` e a flexibilidade das listas.

---

### 💡 Dica

Use `var` com listas quando o tipo for evidente:

```csharp

var numeros = new List<int> { 1, 2, 3 };

```

---

##### ✍️ **Seção criada por:** *Fabio Zanneti* 🎯 Projeto: **WEX - End to End Engineering**
