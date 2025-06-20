# 🧱 Classes Abstratas e Interfaces em C#

Neste módulo vamos entender conceitos fundamentais da Programação Orientada a Objetos com C#, como **classes abstratas**, **classes seladas**, **interfaces** e o papel da **classe base object**.

---

### 📌 Introdução: Classe Abstrata

Uma **classe abstrata** é uma classe que **não pode ser instanciada** diretamente. Ela serve como **modelo base** para outras classes e pode conter métodos com ou sem implementação.

✅ Usada para criar **estruturas comuns** para classes derivadas.

---

### 🛠️ Classe Abstrata na Prática

```csharp

public abstract class Animal
{
    public abstract void EmitirSom(); // Método sem corpo (obrigatório nas filhas)
    public void Dormir()
    {
        Console.WriteLine("Animal dormindo...");
    }
}

public class Gato : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("Miau!");
    }
}

```

---

### 🔁 Construtor por Herança

Mesmo sendo abstrata, a classe base **pode ter construtores**, que serão executados pelas classes filhas através da chamada `base()`:

```csharp

public abstract class Pessoa
{
    public string Nome { get; set; }
    public Pessoa(string nome)
    {
        Nome = nome;
    }
}

public class Aluno : Pessoa
{
    public Aluno(string nome) : base(nome) { }
}

```

---

### 🔒 Introdução: Classe Selada

Uma **classe selada (sealed)** **não pode ser herdada**. Ela garante que nenhuma outra classe estenda sua implementação, sendo usada por **motivos de segurança, performance ou integridade da lógica**.

---

### 🧪 Classe Selada na Prática

```csharp

public sealed class Relatorio
{
    public void Gerar()
    {
        Console.WriteLine("Relatório gerado.");
    }
}

// ERRO: class NovoRelatorio : Relatorio { } ← não permitido

```

---

### 🚫 Método Selado na Prática

Você também pode **selar apenas um método** dentro de uma hierarquia com `sealed override`.

```csharp

public class Documento
{
    public virtual void Imprimir() => Console.WriteLine("Imprimindo documento");
}

public class PDF : Documento
{
    public sealed override void Imprimir() => Console.WriteLine("PDF gerado");
}

public class PDFColorido : PDF
{
    // ERRO: não é possível sobrescrever Imprimir aqui
}

```

---

### 👤 Introdução: Classe Object

Toda classe em C# herda **implícita ou explicitamente da classe `object`**, a **base de todos os tipos no .NET**.

Ela fornece métodos como:

* `ToString()`
* `Equals()`
* `GetHashCode()`
* `GetType()`

---

### 🧪 Classe Object na Prática

```csharp

public class Produto
{
    public string Nome { get; set; }

    public override string ToString()
    {
        return $"Produto: {Nome}";
    }
}

// Uso

Produto p = new Produto { Nome = "Caderno" };
Console.WriteLine(p.ToString()); // Saída: Produto: Caderno

```

---

### 📢 Introdução: Interfaces

Uma **interface** é um **contrato** que define **quais membros uma classe deve implementar**, sem fornecer lógica.

Diferente de uma classe abstrata:

* **Não possui campos**
* **Não contém implementação obrigatória (até o C# 8)**
* Pode ser **implementada por múltiplas classes** (C# não tem herança múltipla, mas aceita várias interfaces)

---

### 💼 Interface na Prática

```csharp

public interface INotificavel
{
    void Notificar(string mensagem);
}

public class EmailService : INotificavel
{
    public void Notificar(string mensagem)
    {
        Console.WriteLine($"Enviando e-mail: {mensagem}");
    }
}

```

---

### 🧩 Método Padrão na Interface (C# 8+)

Desde o C# 8, **interfaces podem ter implementações padrão** com `default`:

```csharp

public interface ILog
{
    void Logar(string mensagem)
    {
        Console.WriteLine($"[LOG]: {mensagem}");
    }
}

public class Logger : ILog { }

// Logger já tem comportamento padrão sem precisar implementar nada

```
---

## 🧩 Links Complementares de Estudo

Estudar a fundo o uso de **classes abstratas** e **interfaces** é essencial para aplicar corretamente os conceitos de **POO (Programação Orientada a Objetos)** em C#. Abaixo estão materiais para reforçar o conteúdo:

### 🎓 Cursos e Vídeos Gratuitos

- [Curso sobre Classes Abstratas e Interfaces - Balta.io](https://www.youtube.com/watch?v=qZev0U_U85I)
- [Interfaces vs Classes Abstratas em C# - DevAprender](https://www.youtube.com/watch?v=qk_ZTZ6Yqew)
- [C# POO - Classes Abstratas e Interfaces (CFBCursos)](https://www.youtube.com/watch?v=mGzG5qX99CM)

### 📚 Documentações Oficiais da Microsoft

- [Documentação sobre Interfaces (C#)](https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/interfaces/)
- [Classes Abstratas (abstract)](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/abstract)

- [Interface vs Abstract Class - StackOverflow (Explicação objetiva)](https://stackoverflow.com/questions/1913098/what-is-the-difference-between-an-abstract-class-and-an-interface-in-c)

### 🧠 Artigos e Leitura Técnica

- [Interfaces x Classes Abstratas – Qual usar e quando?](https://www.treinaweb.com.br/blog/interfaces-x-classes-abstratas-qual-usar-e-quando)
- [Quando usar uma Interface ou Classe Abstrata? - DevMedia](https://www.devmedia.com.br/interfaces-e-classes-abstratas-em-c/27709)
- [Diferença entre Interface e Classe Abstrata (Medium)](https://medium.com/@wilsonneto/diferen%C3%A7a-entre-interface-e-classe-abstrata-em-c-3f5cb3686b53)

---

#### ✅ Finalização

| Conceito        | Pode ter implementação? | Pode ser herdada? | Pode ser instanciada? |
| --------------- | ----------------------- | ----------------- | --------------------- |
| Classe Abstrata | Sim                     | Sim               | Não                   |
| Classe Selada   | Sim                     | Não               | Sim                   |
| Interface       | Apenas a partir do C# 8 | Sim (múltiplas)   | Não                   |

🎯 Use **classes abstratas** quando quiser **compartilhar código entre classes relacionadas**.
🎯 Use **interfaces** quando quiser **forçar um contrato** de implementação, com ou sem herança entre classes.

📌 Dominar esses conceitos é essencial para aplicar princípios de design como SOLID, Clean Code e Injeção de Dependência no .NET.

---

##### ✍️ **Seção criada por:** *Fabio Zanneti* 🎯 Projeto: **WEX - End to End Engineering**