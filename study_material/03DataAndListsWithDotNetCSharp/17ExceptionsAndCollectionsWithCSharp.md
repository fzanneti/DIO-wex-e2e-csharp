# 💡 Exceções e Coleções em C#

Este material faz parte do repositório de estudos em C# e tem como objetivo apresentar de forma **clara, prática e didática** como funcionam os conceitos de **exceções** (erros) e **coleções** (estruturas para armazenar dados) na linguagem C#.

---

### 📌 O que você vai aprender

- O que são exceções e como tratá-las  
- Como ler arquivos com segurança  
- Como criar e tratar erros personalizados  
- O que são e como usar filas, pilhas e dicionários  
- Práticas profissionais de programação defensiva  

---

## 💥 Exceções em C#

### 🔹 O que são exceções?

São **erros que ocorrem em tempo de execução**, ou seja, enquanto o programa está rodando. Elas interrompem o fluxo normal da aplicação, e por isso precisam ser **tratadas com cuidado**.

---

### 📁 Lendo arquivos com segurança

```csharp

try
{
    string conteudo = File.ReadAllText("arquivo.txt");
    Console.WriteLine("Conteúdo do arquivo:");
    Console.WriteLine(conteudo);
}
catch (FileNotFoundException)
{
    Console.WriteLine("Erro: Arquivo não encontrado.");
}

```

✔️ Aqui usamos `try-catch` para capturar o erro se o arquivo não existir, evitando que o programa pare de funcionar.

---

### 🚨 Criando nossos próprios erros

```csharp

int idade = -5;

if (idade < 0)
{
    throw new ArgumentException("A idade não pode ser negativa.");
}

```

✔️ `throw` lança uma exceção personalizada, útil para validar regras de negócio.

---

### 🛡️ Tratando erros com `try-catch`

```csharp

try
{
    int numero = int.Parse("abc");
}
catch (FormatException)
{
    Console.WriteLine("Erro: Valor inserido não é um número válido.");
}

```

✔️ Evita que a aplicação trave ao tentar converter um valor inválido.

---

### 🧩 Exceção Genérica vs Específica

```csharp

try
{
    // Código propenso a erro
}
catch (Exception ex) // genérica
{
    Console.WriteLine($"Erro genérico: {ex.Message}");
}

```

✔️ Sempre que possível, use exceções específicas (`FormatException`, `FileNotFoundException`, etc.) para um tratamento mais preciso.

---

### 🔚 Bloco finally

```csharp

try
{
    // Operações com risco de erro
}
finally
{
    Console.WriteLine("Esta linha será executada sempre, com ou sem erro.");
}

```

✔️ Ideal para liberar recursos, como fechar arquivos, conexões, etc.

---

### ↪️ Reutilizando exceções com `throw`

```csharp

try
{
    throw new InvalidOperationException("Operação não permitida.");
}
catch (InvalidOperationException ex)
{
    Console.WriteLine("Tratando erro...");
    throw; // repassa para outro nível do sistema
}

```

---

### 📦 Coleções em C\#

Coleções são estruturas que permitem **armazenar, organizar e manipular dados** de forma eficiente.

---

### 🔁 Fila (`Queue<T>`) – Primeiro que entra, primeiro que sai (FIFO)

```csharp

Queue<string> fila = new Queue<string>();
fila.Enqueue("Cliente 1");
fila.Enqueue("Cliente 2");

Console.WriteLine(fila.Dequeue()); // Saída: Cliente 1

```

✔️ Ideal para sistemas de atendimento, impressão, etc.

---

### 🧱 Pilha (`Stack<T>`) – Último que entra, primeiro que sai (LIFO)

```csharp

Stack<string> pilha = new Stack<string>();
pilha.Push("Página 1");
pilha.Push("Página 2");

Console.WriteLine(pilha.Pop()); // Saída: Página 2

```

✔️ Muito usada em navegação (voltar páginas), controle de estados, etc.

---

### 📘 Dicionário (`Dictionary<TKey, TValue>`)

Estrutura chave-valor. Permite associar uma chave a um valor.

```csharp

Dictionary<string, int> notas = new Dictionary<string, int>();
notas["Fabio"] = 10;
notas["Ana"] = 9;

Console.WriteLine(notas["Fabio"]); // Saída: 10

```

---

### ✏️ Alterando e Removendo valores

```csharp

notas["Ana"] = 8; // altera
notas.Remove("Fabio"); // remove

```

---

## 🧱 Links Complementares de Estudo – Exceções e Coleções em C#

### 🎯 Parte 1: Exceções em C#

Tratamento de exceções é essencial para garantir que sua aplicação reaja bem a erros inesperados, mantendo a estabilidade e mostrando mensagens claras ao usuário.

---

### 🎓 Aulas e Vídeos Gratuitos

- [Tratamento de Exceções em C# – Balta.io](https://www.youtube.com/watch?v=1DYwz7ECxJ0)
- [Exceções no C# – DevAprender](https://www.youtube.com/watch?v=kdAodQkDHLs)
- [CFBCursos – Tratamento de Erros em C#](https://www.youtube.com/watch?v=Uax3P8VXLWY)

---

### 📚 Documentação Microsoft

- [Tratamento de Exceções (Microsoft Docs)](https://learn.microsoft.com/pt-br/dotnet/csharp/fundamentals/exceptions/)
- [Exceções Personalizadas – Como Criar](https://learn.microsoft.com/pt-br/dotnet/standard/exceptions/how-to-create-user-defined-exceptions)

---

### 🧠 Artigos Técnicos

- [Boas práticas no uso de Exceções (Medium)](https://medium.com/@wesleywillians/boas-pr%C3%A1ticas-no-tratamento-de-exce%C3%A7%C3%B5es-em-c-b2409ef1cb59)

---

### 📦 Parte 2: Coleções em C#

Coleções permitem armazenar e manipular conjuntos de dados como listas, filas e dicionários. São a base para trabalhar com dados em memória.

---

### 🎓 Aulas e Tutoriais Gratuitos

- [Coleções em C# (List, Dictionary, Stack, Queue) – Balta.io](https://www.youtube.com/watch?v=K6E1dEpCGdU)
- [Listas e Arrays em C# – DevAprender](https://www.youtube.com/watch?v=SGvUu2hEqyA)
- [Coleções Genéricas – CFBCursos](https://www.youtube.com/watch?v=eYZ1kGBMRzM)

---

### 📚 Documentação Microsoft

- [Coleções Genéricas – System.Collections.Generic](https://learn.microsoft.com/pt-br/dotnet/api/system.collections.generic?view=net-8.0)
- [Array vs List – Quando usar](https://learn.microsoft.com/pt-br/dotnet/standard/collections/when-to-use-generic-collections)
- [Foreach e Iteração de Coleções](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/foreach-in)

---

### 💡 Extras

- [Comparando Coleções em C# (Alura)](https://www.alura.com.br/artigos/comparando-colecoes-em-csharp)
- [Visualizando coleções com LINQPad](https://www.linqpad.net/)

---

#### ✅ Encerramento

Você agora aprendeu:

✔️ Como proteger seu código contra falhas (exceções).  
✔️ Como usar coleções para manipular dados de forma estruturada e eficiente

---

##### ✍️ **Seção criada por:** *Fabio Zanneti* 🎯 Projeto: **WEX - End to End Engineering**
