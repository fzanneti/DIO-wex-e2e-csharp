# 🧬 Herança e Polimorfismo com C#

Este documento apresenta, de forma clara e objetiva, dois dos pilares fundamentais da Programação Orientada a Objetos (POO): **Herança** e **Polimorfismo**, utilizando a linguagem **C#**.

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

#### 📘 Conclusão

A combinação de **herança** e **polimorfismo** proporciona um código mais **modular, reutilizável e fácil de manter**.
Esses conceitos são amplamente usados em frameworks, bibliotecas e aplicações reais.

---

##### ✍️ **Seção criada por:** *Fabio Zanneti*
##### 🎯 Projeto: **WEX - End to End Engineering**