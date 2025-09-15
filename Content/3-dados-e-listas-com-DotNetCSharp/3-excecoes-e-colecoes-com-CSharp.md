# WEX - End to End Engineering

## 3.3 - Exceções e Coleções em C#

![GitHub repo size](https://img.shields.io/github/repo-size/fzanneti/wex-e2e-csharp)
![GitHub forks](https://img.shields.io/github/forks/fzanneti/wex-e2e-csharp?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/fzanneti/wex-e2e-csharp?style=social)
![Linguagem](https://img.shields.io/badge/Linguagem-CSharp-blue)
![Bootcamp](https://img.shields.io/badge/WEX-End--to--End%20Engineering-blueviolet?logo=vercel&logoColor=white)
![Plataforma](https://img.shields.io/badge/Powered%20by-DIO.io-red?logo=data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjZmZmIiB2aWV3Qm94PSIwIDAgMzIgMzIiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PHBhdGggZD0iTTYuNzEgMy4yNWMtMi44OCAxLjQxLTUuMDcgNC4yMy01LjA3IDcuNzYgMCAzLjU4IDIuMjggNi43IDUuMzMgOC4xNSAxLjgzLS42MiAyLjQtMi4yNiAyLjQtMy44MSAwLS4yMy0uMDItLjQ1LS4wNS0uNjZBLjQ0LjQ0IDAgMDExMC4xIDExYy4yNC0uNzUuMTEtMS41My0uMy0yLjIyQzguOTIgNy45NiA3LjMzIDcuNSA1Ljc0IDcuNjZhNS41NSA1LjU1IDAgM)
![Autor](https://img.shields.io/badge/Autor-fzanneti-blue?style=flat-square&logo=github)

Este material faz parte do repositório de estudos em C# e tem como objetivo apresentar de forma **clara, prática e didática** como funcionam os conceitos de **exceções** (erros) e **coleções** (estruturas para armazenar dados) na linguagem C#.

---

### O que você vai aprender

No Bootcamp WEX, você está aprendendo C#, .NET, Git e GitHub. **Exceções** garantem que seu código lide com erros de forma segura, enquanto **coleções** organizam dados eficientemente. Este módulo explora tratamento de erros e estruturas como filas, pilhas e dicionários.

- O que são exceções e como tratá-las  
- Como ler arquivos com segurança  
- Como criar e tratar erros personalizados  
- O que são e como usar filas, pilhas e dicionários  
- Práticas profissionais de programação defensiva  

---

## Exceções em C#

**O que são exceções?**

São **erros que ocorrem em tempo de execução**, ou seja, enquanto o programa está rodando. Elas interrompem o fluxo normal da aplicação, e por isso precisam ser **tratadas com cuidado**.

---

### Lendo arquivos com segurança

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

> Aqui usamos `try-catch` para capturar o erro se o arquivo não existir, evitando que o programa pare de funcionar.

---

### Criando nossos próprios erros

```csharp

int idade = -5;

if (idade < 0)
{
    throw new ArgumentException("A idade não pode ser negativa.");
}

```

✔️ `throw` lança uma exceção personalizada, útil para validar regras de negócio.

---

### Tratando erros com `try-catch`

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

> Evita que a aplicação trave ao tentar converter um valor inválido.

---

### Exceção Genérica vs Específica

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

> Sempre que possível, use exceções específicas (`FormatException`, `FileNotFoundException`, etc.) para um tratamento mais preciso.

---

### Bloco finally

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

> Ideal para liberar recursos, como fechar arquivos, conexões, etc.

---

### Reutilizando exceções com `throw`

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

### Coleções em C\#

Coleções são estruturas que permitem **armazenar, organizar e manipular dados** de forma eficiente.

---

### Fila (`Queue<T>`) – Primeiro que entra, primeiro que sai (FIFO)

```csharp

Queue<string> fila = new Queue<string>();
fila.Enqueue("Cliente 1");
fila.Enqueue("Cliente 2");

Console.WriteLine(fila.Dequeue()); // Saída: Cliente 1

```

> Ideal para sistemas de atendimento, impressão, etc.

---

### Pilha (`Stack<T>`) – Último que entra, primeiro que sai (LIFO)

```csharp

Stack<string> pilha = new Stack<string>();
pilha.Push("Página 1");
pilha.Push("Página 2");

Console.WriteLine(pilha.Pop()); // Saída: Página 2

```

> Muito usada em navegação (voltar páginas), controle de estados, etc.

---

### Dicionário (`Dictionary<TKey, TValue>`)

Estrutura chave-valor. Permite associar uma chave a um valor.

```csharp

Dictionary<string, int> notas = new Dictionary<string, int>();
notas["Fabio"] = 10;
notas["Ana"] = 9;

Console.WriteLine(notas["Fabio"]); // Saída: 10

```

---

### Alterando e Removendo valores

```csharp

notas["Ana"] = 8; // altera
notas.Remove("Fabio"); // remove

```

---

### Links Complementares de Estudo – Exceções e Coleções em C#

**Parte 1: Exceções em C#**

Tratamento de exceções é essencial para garantir que sua aplicação reaja bem a erros inesperados, mantendo a estabilidade e mostrando mensagens claras ao usuário.

🔗[Tratamento de Exceções](https://learn.microsoft.com/pt-br/dotnet/csharp/fundamentals/exceptions/)   
🔗[Exceções Personalizadas](https://learn.microsoft.com/pt-br/dotnet/standard/exceptions/how-to-create-user-defined-exceptions)   
🔗[Coleções Genéricas – System.Collections.Generic](https://learn.microsoft.com/pt-br/dotnet/api/system.collections.generic?view=net-8.0)    
🔗[Array vs List](https://learn.microsoft.com/pt-br/dotnet/standard/collections/when-to-use-generic-collections)    
🔗[Foreach e Iteração de Coleções](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/foreach-in)    
🔗[Comparando Coleções em C# (Alura)](https://www.alura.com.br/artigos/comparando-colecoes-em-csharp)    
🔗[Visualizando coleções com LINQPad](https://www.linqpad.net/)   

---

### Encerramento

Exceções e coleções são fundamentais para projetos .NET no Bootcamp WEX. Use `try-catch` para proteger seu código e coleções como `Queue<T>`, `Stack<T>`, `Dictionary<TKey, TValue>`, `List<T>` e `HashSet<T>` para manipular dados. Continue praticando!

Você agora aprendeu:

- Como proteger seu código contra falhas (exceções).  
- Como usar coleções para manipular dados de forma estruturada e eficiente

---

### Desafio do Módulo 3 - Hotel

[![Repo Card](https://github-readme-stats.vercel.app/api/pin/?username=fzanneti&repo=DIO-and-wex-hotel-challenge&bg_color=261d31&border_color=7a49c6&show_icons=true&icon_color=7a49c6&title_color=37ccab&text_color=FFF)](https://github.com/fzanneti/DIO-and-wex-hotel-challenge)

### Certificado

<img src="https://github.com/fzanneti/DIO-wex-e2e-csharp/blob/main/Assets/images/certificados/17-construindo-um-sistema-de-hospedagem-de-um-hotel-no-CSharp.jpg" alt="Certificado" width="600px">

---

### Certificado

<img src="https://github.com/fzanneti/DIO-wex-e2e-csharp/blob/main/Assets/images/certificados/16-excecoes-e-colecoes-com-CSharp.jpg" alt="Certificado" width="600px">

---

##### ✍️ Seção criada por: *Fabio Zanneti* - 🎯 Bootcamp: **WEX - End to End Engineering**
[![GitHub](https://img.shields.io/badge/GitHub-fzanneti-181717?style=flat&logo=github)](https://github.com/fzanneti)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-fzanneti-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/fzanneti)