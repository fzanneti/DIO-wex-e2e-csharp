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

## 🧬 Links Complementares de Estudo – Herança e Polimorfismo em C#

Herança e polimorfismo são dois dos principais pilares da **Programação Orientada a Objetos (POO)**. São fundamentais para escrever código limpo, reutilizável e extensível em C#. Aqui estão materiais gratuitos e práticos para aprofundar nesse tema:

### 🎓 Vídeos e Aulas Gratuitas

- [Herança em C# - Curso POO Balta.io (YouTube)](https://www.youtube.com/watch?v=KTwE-cbdq5Y)
  > Explicação didática sobre herança em C#, com exemplos práticos.
- [Polimorfismo em C# - DevAprender](https://www.youtube.com/watch?v=mKCeu5ne7Xc)
  > Aula objetiva sobre polimorfismo, mostrando a diferença entre sobrescrita e sobrecarga.
- [POO em C# - Herança e Polimorfismo (CFBCursos)](https://www.youtube.com/watch?v=z-f7L_OZMEg)
  > Curso gratuito abordando herança e polimorfismo de forma prática e com código ao vivo.

### 📚 Documentação Oficial da Microsoft

- [Herança (C#) – Microsoft Learn](https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/inheritance)
  > Explicação técnica sobre como funciona a herança em C# e suas regras.
- [Polimorfismo – Microsoft Learn](https://learn.microsoft.com/pt-br/dotnet/fundamentals/code-analysis/quality-guidelines/ca2214)
  > Explicação do comportamento de métodos virtuais, override, e base.
- [Palavras-chave: `virtual`, `override`, `new` – Microsoft Docs](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/override)
  > Guia detalhado sobre como usar polimorfismo em métodos com `virtual` e `override`.

### 🧠 Artigos e Leitura Técnica

- [O que é Herança e Polimorfismo em C#? (DevMedia)](https://www.devmedia.com.br/entendendo-heranca-e-polimorfismo-em-c/25881)
  > Explicações com exemplos simples e exercícios.
- [Herança x Composição - Qual aplicar em C#? (TreinaWeb)](https://www.treinaweb.com.br/blog/heranca-ou-composicao-em-c)
  > Um comparativo entre herança e composição – importante para entender os limites do uso da herança.
- [Polimorfismo com exemplos simples - Medium](https://medium.com/@wilsonneto/polimorfismo-em-c-com-exemplos-1b5b18004f96)
  > Artigo com exemplos práticos que mostram o poder do polimorfismo na reutilização de código.

---

#### 📘 Conclusão

A combinação de **herança** e **polimorfismo** proporciona um código mais **modular, reutilizável e fácil de manter**.
Esses conceitos são amplamente usados em frameworks, bibliotecas e aplicações reais.

---

##### ✍️ **Seção criada por:** *Fabio Zanneti*
##### 🎯 Projeto: **WEX - End to End Engineering**