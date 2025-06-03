# 💡 Exceções e Coleções em C#

Este material faz parte do repositório de estudos em C# e tem como objetivo apresentar de forma **clara, prática e didática** como funcionam os conceitos de **exceções** (erros) e **coleções** (estruturas para armazenar dados) na linguagem C#.

---

#### 📌 O que você vai aprender

- O que são exceções e como tratá-las  
- Como ler arquivos com segurança  
- Como criar e tratar erros personalizados  
- O que são e como usar filas, pilhas e dicionários  
- Práticas profissionais de programação defensiva  

---

### 💥 Exceções em C#

#### 🔹 O que são exceções?

São **erros que ocorrem em tempo de execução**, ou seja, enquanto o programa está rodando. Elas interrompem o fluxo normal da aplicação, e por isso precisam ser **tratadas com cuidado**.

---

#### 📁 Lendo arquivos com segurança

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
````

✔️ Aqui usamos `try-catch` para capturar o erro se o arquivo não existir, evitando que o programa pare de funcionar.

---

#### 🚨 Criando nossos próprios erros

```csharp
int idade = -5;

if (idade < 0)
{
    throw new ArgumentException("A idade não pode ser negativa.");
}
```

✔️ `throw` lança uma exceção personalizada, útil para validar regras de negócio.

---

#### 🛡️ Tratando erros com `try-catch`

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

#### 🧩 Exceção Genérica vs Específica

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

#### 🔚 Bloco finally

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

#### ↪️ Reutilizando exceções com `throw`

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

#### 🔁 Fila (`Queue<T>`) – Primeiro que entra, primeiro que sai (FIFO)

```csharp
Queue<string> fila = new Queue<string>();
fila.Enqueue("Cliente 1");
fila.Enqueue("Cliente 2");

Console.WriteLine(fila.Dequeue()); // Saída: Cliente 1
```

✔️ Ideal para sistemas de atendimento, impressão, etc.

---

#### 🧱 Pilha (`Stack<T>`) – Último que entra, primeiro que sai (LIFO)

```csharp
Stack<string> pilha = new Stack<string>();
pilha.Push("Página 1");
pilha.Push("Página 2");

Console.WriteLine(pilha.Pop()); // Saída: Página 2
```

✔️ Muito usada em navegação (voltar páginas), controle de estados, etc.

---

#### 📘 Dicionário (`Dictionary<TKey, TValue>`)

Estrutura chave-valor. Permite associar uma chave a um valor.

```csharp
Dictionary<string, int> notas = new Dictionary<string, int>();
notas["Fabio"] = 10;
notas["Ana"] = 9;

Console.WriteLine(notas["Fabio"]); // Saída: 10
```

---

#### ✏️ Alterando e Removendo valores

```csharp
notas["Ana"] = 8; // altera
notas.Remove("Fabio"); // remove
```

---

### ✅ Encerramento

Você agora aprendeu:

✔️ Como proteger seu código contra falhas (exceções).  
✔️ Como usar coleções para manipular dados de forma estruturada e eficiente

---

📂 Repositório mantido por: [Fabio Zanneti](https://github.com/seu-usuario)
💻 Projeto de estudos em C# com foco profissional e didático.

---

🧠 **Dica bônus**: Experimente criar um mini sistema que use fila para simular uma fila de atendimento, e pilha para navegar entre páginas de um sistema!

```

---

##### Seção criada por: *Fabio Zanneti - Projeto: WEX - End to End Engineering* - Guia de estudos.