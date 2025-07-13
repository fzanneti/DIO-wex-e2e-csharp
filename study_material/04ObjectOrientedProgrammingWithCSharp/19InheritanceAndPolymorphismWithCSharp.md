# 🧬 Herança e Polimorfismo com C#

No Bootcamp WEX, você está aprendendo C#, .NET, Git e GitHub. **Herança** e **polimorfismo** são pilares da POO que permitem reutilizar código e criar sistemas flexíveis. Este módulo explora como herdar comportamentos e implementar métodos dinâmicos.

![GitHub repo size](https://img.shields.io/github/repo-size/fzanneti/wex-e2e-csharp)
![GitHub forks](https://img.shields.io/github/forks/fzanneti/wex-e2e-csharp?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/fzanneti/wex-e2e-csharp?style=social)
![Linguagem](https://img.shields.io/badge/Linguagem-CSharp-blue)
![Bootcamp](https://img.shields.io/badge/WEX-End--to--End%20Engineering-blueviolet?logo=vercel&logoColor=white)
![Plataforma](https://img.shields.io/badge/Powered%20by-DIO.io-red?logo=data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjZmZmIiB2aWV3Qm94PSIwIDAgMzIgMzIiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PHBhdGggZD0iTTYuNzEgMy4yNWMtMi44OCAxLjQxLTUuMDcgNC4yMy01LjA3IDcuNzYgMCAzLjU4IDIuMjggNi43IDUuMzMgOC4xNSAxLjgzLS42MiAyLjQtMi4yNiAyLjQtMy44MSAwLS4yMy0uMDItLjQ1LS4wNS0uNjZBLjQ0LjQ0IDAgMDExMC4xIDExYy4yNC0uNzUuMTEtMS41My0uMy0yLjIyQzguOTIgNy45NiA3LjMzIDcuNSA1Ljc0IDcuNjZhNS41NSA1LjU1IDAgM)
![Autor](https://img.shields.io/badge/Autor-fzanneti-blue?style=flat-square&logo=github)

---

### 🧱 Introdução à Herança

Herança é o mecanismo que permite **reutilizar código**.  
Uma classe pode herdar **atributos e métodos** de outra, formando uma **relação hierárquica** entre elas.

- A classe que herda é chamada de **classe derivada** (ou filha).
- A classe base é chamada de **classe pai** (ou superclasse).

📌 **Objetivo:** Evitar repetição de código, criar estruturas organizadas e reutilizáveis.

---

### 🛠️ Herança na prática

```csharp

public class Pessoa
{
    public string Nome { get; set; }

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}");
    }
}

public class Aluno : Pessoa
{
    public string Curso { get; set; }

    public void Estudar()
    {
        Console.WriteLine($"{Nome} está estudando {Curso}.");
    }
}

```

### ✅ A classe `Aluno` herda o atributo `Nome` e o método `Apresentar` da classe `Pessoa`.

### 📝 Uso:

```csharp

Aluno aluno = new Aluno();
aluno.Nome = "Fabio";
aluno.Curso = "C# Avançado";
aluno.Apresentar(); // Olá, meu nome é Fabio
aluno.Estudar();    // Fabio está estudando C# Avançado

```

---

### ⚠️ Considerações finais sobre herança

* **Evite heranças profundas** (muitas camadas) — elas dificultam a manutenção.
* Prefira **herança apenas quando existe uma clara relação "é um(a)"**.
* Para reutilização sem hierarquia, considere **composição**.

---

### 🧠 Introdução ao Polimorfismo

Polimorfismo significa **"muitas formas"**.
Na prática, permite que objetos derivados de uma mesma classe base possam se comportar de formas diferentes ao sobrescrever métodos.

Existem dois tipos principais:

| Tipo                                | Explicação                                  |
| ----------------------------------- | ------------------------------------------- |
| Polimorfismo em tempo de compilação | Sobrecarga de métodos.                      |
| Polimorfismo em tempo de execução   | Sobrescrita de métodos via herança virtual. |

---

### 🔄 Polimorfismo em tempo de execução (via herança)

Usamos a palavra-chave `virtual` para permitir que um método seja sobrescrito com `override`:

```csharp
public class Animal
{
    public virtual void EmitirSom()
    {
        Console.WriteLine("Som genérico de animal");
    }
}

public class Cachorro : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("Au au!");
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

### 📝 Uso com polimorfismo:

```csharp

List<Animal> animais = new List<Animal>
{
    new Cachorro(),
    new Gato(),
    new Animal()
};

foreach (var animal in animais)
{
    animal.EmitirSom(); 
}

```

🔁 Saída:

```

Au au!
Miau!
Som genérico de animal

```

✅ Mesmo que o tipo seja `Animal`, o método correto é chamado de acordo com o objeto instanciado — isso é 
**polimorfismo em tempo de execução**.

---

### ✅ Considerações finais sobre polimorfismo

* Permite **flexibilidade** e **extensibilidade** do código.
* Ideal quando usamos **listas genéricas** ou **interfaces**.
* Reduz o uso de estruturas como `if/else` ou `switch`.

---

## 🧬 Links Complementares de Estudo – Herança e Polimorfismo em C#

Herança e polimorfismo são dois dos principais pilares da **Programação Orientada a Objetos (POO)**. São fundamentais para escrever código limpo, reutilizável e extensível em C#. Aqui estão materiais gratuitos e práticos para aprofundar nesse tema:

### 📚 Documentação Oficial da Microsoft

- [Herança](https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/inheritance)
- [Polimorfismo](https://learn.microsoft.com/pt-br/dotnet/csharp/fundamentals/object-oriented/polymorphism)
- [Interfaces](https://learn.microsoft.com/pt-br/dotnet/csharp/fundamentals/types/interfaces)
- [Palavras-chave: `virtual`, `override`, `new` – Microsoft Docs](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/override)

---

#### 📘 Conclusão

A combinação de **herança** e **polimorfismo** proporciona um código mais **modular, reutilizável e fácil de manter**.
Esses conceitos são amplamente usados em frameworks, bibliotecas e aplicações reais.

Herança e polimorfismo são fundamentais para projetos .NET no Bootcamp WEX. Use herança para reutilizar código e polimorfismo para flexibilidade. Continue praticando!

---

##### ✍️ Seção criada por: *Fabio Zanneti* - 🎯 Bootcamp: **WEX - End to End Engineering**
[![GitHub](https://img.shields.io/badge/GitHub-fzanneti-181717?style=flat&logo=github)](https://github.com/fzanneti)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-fzanneti-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/fzanneti)