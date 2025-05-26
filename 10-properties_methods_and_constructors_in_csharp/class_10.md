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

### 🧠 O Que Está Acontecendo Aqui?

#### 🎯 Objetivo:

Criar uma **propriedade chamada `Idade`** que permita **acessar** (ler) e **definir** (escrever) a idade de uma pessoa, **com uma validação** que impede que valores negativos sejam atribuídos.

---

### 🔍 Linha por Linha

#### 🟩 `public int Idade`

* `public` → A propriedade será visível para qualquer classe.
* `int` → O tipo da propriedade é inteiro.
* `Idade` → Nome da propriedade que representa a idade da pessoa.

> Até aqui, estamos apenas **declarando uma propriedade pública chamada `Idade`, do tipo `int`**.

---

#### 🔵 `{ get { return idade; } ... }`

Este é o **acessador de leitura** (`get`).

* `get` permite que o valor atual da idade seja **lido de fora da classe**.

* Dentro do `get`, temos:

  ```csharp
  return idade;
  ```

* Isso quer dizer que ao **chamar `pessoa.Idade` em outro lugar do código**, será retornado o **valor armazenado na variável interna `idade`**.

### 🔴 `{ set { if (value >= 0) idade = value; } }`

Este é o **acessador de escrita** (`set`).

* O `set` é usado para **atribuir um valor à propriedade**.
* `value` é uma **palavra-chave especial** dentro do `set` que representa **o valor que está sendo atribuído à propriedade**.

> Exemplo:
>
> ```csharp
> pessoa.Idade = 25;
> ```
>
> Nesse caso, `value` dentro do `set` será 25.

* A linha:

  ```csharp
  if (value >= 0) idade = value;
  ```

  faz o seguinte:

  * **Verifica** se o valor fornecido é maior ou igual a 0.
  * Se for, **atribui esse valor à variável privada `idade`**.
  * Se não for, **ignora a atribuição** (protegendo o dado).

---

## 🧩 Mas de onde vem `idade`?

O código está usando um **campo privado interno** chamado `idade`. Ele **precisa ser declarado antes da propriedade**, assim:

```csharp
private int idade;
```

> Assim, `idade` é o **dado "cru"**, e `Idade` é a **interface segura e controlada para trabalhar com esse dado**.

---

## ✅ Por Que Usar Isso?

* Evita dados inválidos (como `-5` anos).
* Encapsula a lógica de acesso: quem usa a classe não precisa saber como a validação acontece.
* Permite que, futuramente, você altere a lógica interna sem quebrar o código que usa a propriedade.

---

## 🔁 Exemplo Completo

```csharp
public class Pessoa
{
    private int idade;

    public int Idade
    {
        get { return idade; }
        set 
        {
            if (value >= 0) idade = value;
        }
    }
}
```

### Uso no código:

```csharp
Pessoa p = new Pessoa();
p.Idade = 30;
Console.WriteLine(p.Idade); // Saída: 30

p.Idade = -5;
Console.WriteLine(p.Idade); // Ainda 30, pois -5 foi ignorado
```

---

## 🧱 Alternativas com Expressões Simples (a partir do C# 6)

Se não precisar de validação:

```csharp
public int Idade { get; set; }
```

Ou somente leitura:

```csharp
public int Idade { get; } = 18;
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

##### Seção criada por: *Fabio Zanneti - Projeto: WEX - End to End Engineering* - Guia de estudos.
