# 🧱 Classes Abstratas e Interfaces em C#

Neste módulo vamos entender conceitos fundamentais da Programação Orientada a Objetos com C#, como **classes abstratas**, **classes seladas**, **interfaces** e o papel da **classe base object**.

---

#### 📌 Introdução: Classe Abstrata

Uma **classe abstrata** é uma classe que **não pode ser instanciada** diretamente. Ela serve como **modelo base** para outras classes e pode conter métodos com ou sem implementação.

✅ Usada para criar **estruturas comuns** para classes derivadas.

---

#### 🛠️ Classe Abstrata na Prática

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

#### 🔁 Construtor por Herança

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

#### 🔒 Introdução: Classe Selada

Uma **classe selada (sealed)** **não pode ser herdada**. Ela garante que nenhuma outra classe estenda sua implementação, sendo usada por **motivos de segurança, performance ou integridade da lógica**.

---

#### 🧪 Classe Selada na Prática

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

#### 🚫 Método Selado na Prática

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

#### 👤 Introdução: Classe Object

Toda classe em C# herda **implícita ou explicitamente da classe `object`**, a **base de todos os tipos no .NET**.

Ela fornece métodos como:

* `ToString()`
* `Equals()`
* `GetHashCode()`
* `GetType()`

---

#### 🧪 Classe Object na Prática

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

#### 📢 Introdução: Interfaces

Uma **interface** é um **contrato** que define **quais membros uma classe deve implementar**, sem fornecer lógica.

Diferente de uma classe abstrata:

* **Não possui campos**
* **Não contém implementação obrigatória (até o C# 8)**
* Pode ser **implementada por múltiplas classes** (C# não tem herança múltipla, mas aceita várias interfaces)

---

#### 💼 Interface na Prática

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

#### 🧩 Método Padrão na Interface (C# 8+)

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

#### ✅ Finalização

| Conceito        | Pode ter implementação? | Pode ser herdada? | Pode ser instanciada? |
| --------------- | ----------------------- | ----------------- | --------------------- |
| Classe Abstrata | Sim                     | Sim               | Não                   |
| Classe Selada   | Sim                     | Não               | Sim                   |
| Interface       | Apenas a partir do C# 8 | Sim (múltiplas)   | Não                   |

---

🎯 Use **classes abstratas** quando quiser **compartilhar código entre classes relacionadas**.
🎯 Use **interfaces** quando quiser **forçar um contrato** de implementação, com ou sem herança entre classes.

📌 Dominar esses conceitos é essencial para aplicar princípios de design como SOLID, Clean Code e Injeção de Dependência no .NET.

---

##### Seção criada por: *Fabio Zanneti - Projeto: WEX - End to End Engineering* - Guia de estudos.