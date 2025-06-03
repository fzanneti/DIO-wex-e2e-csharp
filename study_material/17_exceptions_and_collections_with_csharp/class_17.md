# ⚙️ Exceções e Coleções em C#

Neste módulo, exploramos dois conceitos fundamentais em C#: o tratamento de **exceções** (erros que ocorrem em tempo de execução) e o uso de **coleções**, como filas, pilhas e dicionários. Esses recursos são essenciais para garantir **resiliência e organização** na manipulação de dados e processos da aplicação.

---

#### 💥 Introdução - Exceções

Exceções ocorrem quando o programa encontra um erro em tempo de execução. Por exemplo:

- Arquivo não encontrado
- Divisão por zero
- Dados mal formatados

Em C#, exceções são objetos derivados da classe `Exception`.

---

#### 📁 Realizando a Leitura de um Arquivo

```csharp
try
{
    string conteudo = File.ReadAllText("arquivo.txt");
    Console.WriteLine(conteudo);
}
catch (FileNotFoundException ex)
{
    Console.WriteLine("Arquivo não encontrado.");
}
````

---

#### 🚨 Disparando uma Exceção

Você pode lançar uma exceção personalizada usando `throw`.

```csharp
int idade = -1;

if (idade < 0)
    throw new ArgumentException("Idade não pode ser negativa.");
```

---

#### 🛠️ Tratando uma Exceção

Utilizamos blocos `try`, `catch` e `finally` para capturar erros e continuar a execução:

```csharp
try
{
    int numero = int.Parse("abc");
}
catch (FormatException)
{
    Console.WriteLine("Formato inválido.");
}
```

---

#### 🎯 Exceção Genérica e Específica

* **Genérica:** captura qualquer tipo de erro.

```csharp
catch (Exception ex)
{
    Console.WriteLine("Erro genérico: " + ex.Message);
}
```

* **Específica:** captura erros específicos, como `IndexOutOfRangeException`.

---

#### 🔚 Entendendo o Bloco Finally

Executa sempre, mesmo se houver exceção.

```csharp
try
{
    // código
}
catch
{
    // tratamento
}
finally
{
    Console.WriteLine("Encerrando operação...");
}
```

---

#### 🧨 Usando o Throw

Permite repassar a exceção para outro ponto do código:

```csharp
try
{
    throw new InvalidOperationException("Operação inválida.");
}
catch (Exception ex)
{
    Console.WriteLine("Erro: " + ex.Message);
    throw; // relança
}
```

---

#### 📦 Introdução a Filas (`Queue<T>`)

Estrutura do tipo **FIFO** (First In, First Out).

```csharp
Queue<string> fila = new Queue<string>();
fila.Enqueue("João");
fila.Enqueue("Maria");

Console.WriteLine(fila.Dequeue()); // João
```

---

#### 🛠️ Fila na Prática

```csharp
Queue<string> atendimento = new Queue<string>();
atendimento.Enqueue("Cliente 1");
atendimento.Enqueue("Cliente 2");

while (atendimento.Count > 0)
{
    Console.WriteLine($"Atendendo: {atendimento.Dequeue()}");
}
```

---

#### 🧱 Introdução a Pilhas (`Stack<T>`)

Estrutura do tipo **LIFO** (Last In, First Out).

```csharp
Stack<string> pilha = new Stack<string>();
pilha.Push("Livro 1");
pilha.Push("Livro 2");

Console.WriteLine(pilha.Pop()); // Livro 2
```

---

#### 🧪 Pilha na Prática

```csharp
Stack<string> historico = new Stack<string>();
historico.Push("Página 1");
historico.Push("Página 2");

while (historico.Count > 0)
{
    Console.WriteLine($"Voltando para: {historico.Pop()}");
}
```

---

#### 📘 Introdução ao Dictionary

Armazena pares **chave-valor**.

```csharp
Dictionary<string, int> alunos = new Dictionary<string, int>();
alunos["Fabio"] = 10;
alunos["Ana"] = 9;

Console.WriteLine(alunos["Ana"]); // 9
```

---

#### ✏️ Removendo e Alterando Elementos

```csharp
alunos["Ana"] = 8; // altera
alunos.Remove("Fabio"); // remove
```

---

#### ✅ Finalização

O domínio de **tratamento de exceções** e o uso de **coleções genéricas** é essencial para criar aplicações C#:

* Mais seguras
* Menos propensas a falhas
* Mais fáceis de manter e evoluir

---

##### Seção criada por: *Fabio Zanneti - Projeto: WEX - End to End Engineering* - Guia de estudos.