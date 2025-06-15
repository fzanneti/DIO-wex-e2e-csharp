# 🧱 Introdução — Entendendo a Estrutura do Projeto em C#

### 📁 Estrutura básica de um projeto .NET

Antes de escrever código, é importante entender o que vem por padrão ao criar um projeto .NET:

```bash

dotnet new console

```

Isso gera uma estrutura como:

* `Program.cs`: Ponto de entrada da aplicação
* `*.csproj`: Arquivo de configuração do projeto (.NET version, pacotes, etc.)
* `bin/` e `obj/`: Diretórios de build (compilação)

🎯 Essa estrutura facilita a **manutenção, modularização e organização** do código.

---

### 🧩 Conceito de Classe

No C#, **classes são moldes** que descrevem:

* Características → **Propriedades**
* Comportamentos → **Métodos**

### 💡 Exemplo:

```csharp

public class Pessoa
{
    public string Nome;
    public int Idade;

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
    }
}

```

---

### 🛠️ Criando uma Classe no Projeto

Dentro do seu projeto, você pode criar arquivos `.cs` separados para cada classe.

```csharp

public class Produto
{
    public string Nome;
    public double Preco;
}

```

🎯 **Dica:** sempre use nomes claros e com inicial maiúscula (PascalCase).

---

## 🏗️ Estrutura Básica de um Código C\#

### Elementos:

* **`using`** (importações)
* **namespace** (opcional)
* **classe**
* **método `Main()`** (ponto de entrada)

### Exemplo:

```csharp

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

```

---

### 📦 Namespaces

Namespaces agrupam classes relacionadas para evitar conflitos de nomes e manter a organização.

```csharp

namespace Projeto.Exemplo
{
    public class Cliente { }
    public class Pedido { }
}

```

---

### 🧪 Usando a Classe Pessoa

```csharp

Pessoa p = new Pessoa();
p.Nome = "Fabio";
p.Idade = 43;
p.Apresentar();

```

No C#, **instanciamos objetos** com `new`, acessamos **propriedades** e executamos **métodos**.

---

### 🧬 Sintaxe do C\#

* Linhas terminam com `;`
* Blocos delimitados com `{}` (não por identação como em Python)
* Tipagem forte e explícita
* Linguagem orientada a objetos

### Exemplo:

```csharp

int idade = 30;
string nome = "Fabio";

```

---

## ✍️ Convenções de Escrita (Case Style)

### CamelCase

* Usado para variáveis e parâmetros
* Ex: `nomeCliente`, `precoTotal`

### PascalCase

* Usado para classes, métodos e propriedades
* Ex: `Produto`, `CalcularTotal()`, `NomeCompleto`

### ❌ snake\_case

* Não é usado no C#
* Mais comum em Python

---

### ✔️ Convenções em Ação

```csharp

public class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }

    public void ExibirInfo()
    {
        Console.WriteLine($"{Nome} custa {Preco:C}");
    }
}

```

🎯 Nome de classe, propriedades e método em PascalCase.

---

### 🧹 Boas Práticas de Escrita

* 🟢 Use nomes significativos: `clienteAtivo` > `c1`
* 🟢 Evite abreviações sem sentido: `produto` > `prd`
* 🟢 Use linhas em branco para separar blocos
* 🟢 Escreva código legível para você e para os outros

### Comparativo:

```csharp

string nomeCompleto = "Maria Clara"; // Boa prática
int idadeCliente = 35;

public class Cliente { }             // PascalCase

// Ruim:
string nc = "Maria Clara";
int id = 35;

```

---

#### ✅ Conclusão

O C# possui uma estrutura clara e bem definida para organizar projetos. Aprender essas convenções desde o início te prepara para:

* Escrever código limpo e legível
* Trabalhar melhor em equipe
* Evoluir com confiança em projetos reais

📌 Dominar os fundamentos é o que te torna pronto para desafios mais complexos.

---

> ##### ✍️ **Seção criada por:** *Fabio Zanneti*
> ##### 🎯 Projeto: **WEX - End to End Engineering**
> ##### 📁 *Guia de estudos com foco em estrutura de código e boas práticas*