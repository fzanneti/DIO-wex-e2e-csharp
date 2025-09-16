# WEX - End to End Engineering

## 4.3 - Classes Abstratas e Interfaces em C#

![GitHub repo size](https://img.shields.io/github/repo-size/fzanneti/wex-e2e-csharp)
![GitHub forks](https://img.shields.io/github/forks/fzanneti/wex-e2e-csharp?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/fzanneti/wex-e2e-csharp?style=social)
![Linguagem](https://img.shields.io/badge/Linguagem-CSharp-blue)
![Bootcamp](https://img.shields.io/badge/WEX-End--to--End%20Engineering-blueviolet?logo=vercel&logoColor=white)
![Plataforma](https://img.shields.io/badge/Powered%20by-DIO.io-red?logo=data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjZmZmIiB2aWV3Qm94PSIwIDAgMzIgMzIiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PHBhdGggZD0iTTYuNzEgMy4yNWMtMi44OCAxLjQxLTUuMDcgNC4yMy01LjA3IDcuNzYgMCAzLjU4IDIuMjggNi43IDUuMzMgOC4xNSAxLjgzLS42MiAyLjQtMi4yNiAyLjQtMy44MSAwLS4yMy0uMDItLjQ1LS4wNS0uNjZBLjQ0LjQ0IDAgMDExMC4xIDExYy4yNC0uNzUuMTEtMS41My0uMy0yLjIyQzguOTIgNy45NiA3LjMzIDcuNSA1Ljc0IDcuNjZhNS41NSA1LjU1IDAgM)
![Autor](https://img.shields.io/badge/Autor-fzanneti-blue?style=flat-square&logo=github)

No Bootcamp WEX, você está aprendendo C#, .NET, Git e GitHub. **Classes abstratas**, **classes seladas** e **interfaces** são ferramentas da POO que garantem flexibilidade e segurança. Este módulo explora como definir contratos e compartilhar código.

---

### Introdução: Classe Abstrata

Uma **classe abstrata** é uma classe que **não pode ser instanciada** diretamente. Ela serve como **modelo base** para outras classes e pode conter métodos com ou sem implementação.

> Usada para criar **estruturas comuns** para classes derivadas.

---

### Classe Abstrata na Prática

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

### Construtor por Herança

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

### Introdução: Classe Selada

Uma **classe selada (sealed)** **não pode ser herdada**. Ela garante que nenhuma outra classe estenda sua implementação, sendo usada por **motivos de segurança, performance ou integridade da lógica**.

---

### Classe Selada na Prática

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

### Método Selado na Prática

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

### Introdução: Classe Object

Toda classe em C# herda **implícita ou explicitamente da classe `object`**, a **base de todos os tipos no .NET**.

Ela fornece métodos como:

* `ToString()`
* `Equals()`
* `GetHashCode()`
* `GetType()`

---

### Classe Object na Prática

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

### Introdução: Interfaces

Uma **interface** é um **contrato** que define **quais membros uma classe deve implementar**, sem fornecer lógica.

Diferente de uma classe abstrata:

* **Não possui campos**
* **Não contém implementação obrigatória (até o C# 8)**
* Pode ser **implementada por múltiplas classes** (C# não tem herança múltipla, mas aceita várias interfaces)

---

### Interface na Prática

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

### Método Padrão na Interface (C# 8+)

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

### Links Complementares de Estudo

Estudar a fundo o uso de **classes abstratas** e **interfaces** é essencial para aplicar corretamente os conceitos de **POO (Programação Orientada a Objetos)** em C#. Abaixo estão materiais para reforçar o conteúdo:

🔗[Classes Abstratas](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/abstract)     
🔗[Interfaces](https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/interfaces/)      
🔗[Classe Object](https://learn.microsoft.com/pt-br/dotnet/api/system.object)      

---

### Finalização

| Conceito        | Pode ter implementação? | Pode ser herdada? | Pode ser instanciada? |
| --------------- | ----------------------- | ----------------- | --------------------- |
| Classe Abstrata | Sim                     | Sim               | Não                   |
| Classe Selada   | Sim                     | Não               | Sim                   |
| Interface       | Apenas a partir do C# 8 | Sim (múltiplas)   | Não                   |

- Use **classes abstratas** quando quiser **compartilhar código entre classes relacionadas**.
- Use **interfaces** quando quiser **forçar um contrato** de implementação, com ou sem herança entre classes.

> Dominar esses conceitos é essencial para aplicar princípios de design como SOLID, Clean Code e Injeção de Dependência no .NET.

---

### Desafio do Módulo 4 - SmartPhone

[![Repo Card](https://github-readme-stats.vercel.app/api/pin/?username=fzanneti&repo=DIO-and-wex-cell-phone-challenge&bg_color=261d31&border_color=7a49c6&show_icons=true&icon_color=7a49c6&title_color=37ccab&text_color=FFF)](https://github.com/fzanneti/DIO-and-wex-cell-phone-challenge)

---

### Certificado

<img src="https://github.com/fzanneti/DIO-wex-e2e-csharp/blob/dd1e47a38400eb9fc8d893e2e5996f31cb4777a6/Assets/images/certificados/20-classes-abstratas-e-interfaces-com-CSharp.jpg" alt="Certificado" width="600px">

---

##### ✍️ Seção criada por: *Fabio Zanneti* - 🎯 Bootcamp: **WEX - End to End Engineering**
[![GitHub](https://img.shields.io/badge/GitHub-fzanneti-181717?style=flat&logo=github)](https://github.com/fzanneti)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-fzanneti-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/fzanneti)