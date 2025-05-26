# 📘 Propriedades, Métodos e Construtores em C\#

Este módulo apresenta os fundamentos da programação orientada a objetos em C#, abordando a estrutura e o funcionamento de **propriedades**, **métodos** e **construtores** — pilares essenciais para construir programas robustos e organizados.

---

#### 📍 Introdução ao Módulo

Em C#, as **classes** são moldes que representam entidades do mundo real. Para torná-las funcionais e interativas, usamos **propriedades** (dados), **métodos** (ações) e **construtores** (modo de criação de objetos). Esses recursos formam a base para escrever códigos reutilizáveis, claros e seguros.

---

### 🏷️ Propriedades

#### ✅ Introdução às Propriedades

As propriedades são membros de uma classe que funcionam como **acessadores de dados**. Elas encapsulam campos privados e controlam como os valores são lidos ou alterados.

```csharp
public class Pessoa
{
    private string nome;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }
}
```

#### 🛠️ Propriedades na Prática

Propriedades podem incluir regras de validação ou simplesmente delegar leitura e escrita direta ao campo interno:

```csharp
public int Idade
{
    get { return idade; }
    set 
    {
        if (value >= 0) idade = value;
    }
}
```

---

### ⚙️ Métodos

#### ✨ Criando um Método

Um método executa uma **ação**. É definido com um **tipo de retorno**, um nome e, opcionalmente, parâmetros.

```csharp
public void ExibirNome()
{
    Console.WriteLine("Nome: " + Nome);
}
```

#### 🔎 Validações no GET e SET

O `get` pode ser usado para **formatar ou calcular** o valor de retorno, e o `set` para **verificar regras de negócio** antes de alterar valores.

```csharp
public string Email
{
    get { return email.ToLower(); }
    set 
    {
        if (value.Contains("@")) email = value;
    }
}
```

---

#### 🧾 Body Expressions

Uma forma simplificada de propriedades com `=>` (lambda), usada para propriedades simples e somente leitura.

```csharp
public string NomeCompleto => $"{Nome} {Sobrenome}";
```

---

#### 🧪 Validando a Propriedade Idade

Exemplo prático de propriedade com validação:

```csharp
private int idade;

public int Idade
{
    get => idade;
    set
    {
        if (value >= 0 && value <= 120)
            idade = value;
    }
}
```

---

#### 🔐 Modificadores de Acesso

Controlam a visibilidade dos membros de uma classe:

| Modificador | Visível para                     |
| ----------- | -------------------------------- |
| `public`    | Todas as classes                 |
| `private`   | Somente dentro da própria classe |
| `protected` | Classe atual e herdeiras         |
| `internal`  | Dentro do mesmo assembly         |

---

#### 🔒 Propriedades Somente Leitura

Você pode definir uma propriedade que só pode ser lida, útil para dados imutáveis.

```csharp
public string Codigo { get; } = Guid.NewGuid().ToString();
```

---

#### ⚡ Introdução aos Métodos

Métodos representam **comportamentos** de uma classe. Podem receber dados (parâmetros), retornar dados (tipo de retorno), e encapsular lógicas.

---

#### 🧱 Implementando a Classe Curso

```csharp
public class Curso
{
    public string Nome { get; set; }
    public List<string> Alunos { get; set; } = new List<string>();
}
```

---

#### 🔁 Tipo de Retorno

O tipo de retorno define o que o método irá devolver ao final da execução:

```csharp
public int ObterQuantidadeAlunos()
{
    return Alunos.Count;
}
```

---

#### 🧹 Método Remover

```csharp
public void RemoverAluno(string nome)
{
    Alunos.Remove(nome);
}
```

---

#### 📋 Método Listar Alunos

```csharp
public void ListarAlunos()
{
    foreach (var aluno in Alunos)
    {
        Console.WriteLine(aluno);
    }
}
```

---

### 🏗️ Construtores

#### 🏁 Trabalhando com Construtores

O **construtor** é um método especial chamado automaticamente quando um objeto é criado.

```csharp
public Curso(string nome)
{
    Nome = nome;
}
```

---

#### 🛠️ Implementando o Construtor

```csharp
public class Pessoa
{
    public string Nome { get; set; }

    public Pessoa(string nome)
    {
        Nome = nome;
    }
}
```

---

#### ✅ Finalização

Neste módulo, você aprendeu:

* O que são propriedades e como usá-las com validações.
* Como criar métodos reutilizáveis e claros.
* O que são construtores e como inicializar objetos corretamente.
* Aplicações práticas com as classes `Pessoa` e `Curso`.

Esses conhecimentos são fundamentais para qualquer projeto em C#, especialmente ao trabalhar com **orientação a objetos, reuso de código e organização de lógica**.

---

#### 🔗 Referências

* [Documentação Oficial do C# (Microsoft)](https://learn.microsoft.com/pt-br/dotnet/csharp/)
* [Guia de Estilo C#](https://learn.microsoft.com/pt-br/dotnet/csharp/fundamentals/coding-style/coding-conventions)
* [Construtores em C# - Alura](https://www.alura.com.br/artigos/entendendo-construtores-csharp)

---

