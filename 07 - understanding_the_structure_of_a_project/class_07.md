# **Introdução — Entendendo a Estrutura do Projeto**

Antes de escrever qualquer linha de código em C#, é essencial entender como um projeto em .NET é organizado. Ao criar um novo projeto (por exemplo, com ````dotnet new console````), o .NET gera arquivos como:

- ````Program.cs````: ponto de entrada da aplicação.

- ````*.csproj````: arquivo de configuração do projeto.

- Diretórios como ````obj/```` e ````bin/````: onde ficam os arquivos compilados.

Essa estrutura permite manter o código organizado, modular e de fácil manutenção.

---

#### **O conceito da classe**

No C#, tudo gira em torno de **classes**. Uma classe é um "molde" que define o comportamento (métodos) e as características (propriedades) de um objeto.

Exemplo conceitual:

```` csharp
public class Pessoa
{
    public string Nome;
    public int Idade;

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
    }
}
````
---

**Criando nossa classe no código**

Dentro de um projeto C#, você cria classes dentro de arquivos ````.cs````. Cada classe deve ser pública ou interna, e seu nome deve ser descritivo e iniciar com letra maiúscula.

````csharp
public class Produto
{
    public string Nome;
    public double Preco;
}
````
---

**Entendendo a estrutura do código**

Cada código C# segue a seguinte estrutura básica:
- Namespace (opcional)
- Declaração da classe
- Atributos e métodos
- Ponto de entrada ````Main()````

````csharp
using System;

namespace Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
````
---

**Usando Namespaces**

Um namespace agrupa classes relacionadas para facilitar a organização e evitar conflitos de nome.

````csharp
namespace Projeto.Exemplo
{
    public class Cliente { }
    public class Pedido { }
}
````

---

**Usando a classe Pessoa**

````csharp
Pessoa p = new Pessoa();
p.Nome = "Fabio";
p.Idade = 43;
p.Apresentar();
````

O C# é orientado a objetos: criamos instâncias (new Pessoa()) e usamos métodos e propriedades definidas nas classes.

---

**Explorando a sintaxe**

Principais pontos da sintaxe C#:

- Toda linha de código termina com ;
- Blocos são delimitados por {} (e não por indentação)
- O método Main é o ponto de partida
- Tipagem forte e explícita
- Suporte a orientação a objetos

Exemplo:

````csharp
int idade = 30;
string nome = "Fabio";
````

---

**Convenções CASE**

- **CamelCase:** usado para nomes de variáveis e parâmetros.
Ex: ````minhaVariavel````, ````nomeCliente````
- **PascalCase:** usado para nomes de classes, métodos e propriedades.
Ex: ````MinhaClasse````, ````CalcularTotal()````, ````NomeCompleto````
- **snake_case:** NÃO é utilizado no C#. É mais comum em Python.

---

**Convenções CASE no código**

````csharp
public class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }

    public void ExibirInfo()
    {
        Console.WriteLine($"{Nome} custa {Preco:C}");
    }
}
````

Note o uso de PascalCase em ````Produto````, ````Nome````, ````Preco````, ````ExibirInfo````.

---

**Convenções na escrita do código**

Boas práticas:

- Use nomes significativos: ````clienteAtivo```` é melhor que ````c1````
- Evite abreviações: ````produto```` ao invés de ````prd````
- Use espaços e quebras de linha para legibilidade
- Separe blocos com linhas em branco

---

**Convenção de nome e variável**

Exemplos de boas práticas:

````csharp
string nomeCompleto = "Maria Clara"; // CamelCase
int idadeCliente = 35;

public class Cliente { }             // PascalCase
````

Evite:

````csharp
string nc = "Maria Clara"; // ruim
int id = 35;               // pouco claro
````
---

**Conclusão**

A sintaxe e identação no C# são estruturadas para promover clareza e organização. Usar corretamente as convenções ajuda a manter o código limpo, colaborativo e fácil de entender por qualquer desenvolvedor. Compreender esses fundamentos é essencial para evoluir na linguagem e trabalhar em projetos reais com confiança.

---

##### Seção criada por: *Fabio Zanneti - Projeto: WEX - End to End Engineering* - Guia de estudos.