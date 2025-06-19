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

## 📚 Material de Apoio

Ao criar um projeto em C#, especialmente com .NET, o Visual Studio ou o .NET CLI gera uma estrutura padrão de arquivos e pastas. Compreender o papel de cada parte facilita a organização, manutenção e escalabilidade do código.

---

### 🎓 Vídeos e Aulas Gratuitas

- [Estrutura de Projeto C# .NET – Balta.io](https://www.youtube.com/watch?v=wvG6I7e1wQg)
- [Organização de um Projeto C# – DevAprender](https://www.youtube.com/watch?v=ehFCjQe7mcg)
- [Criando Projeto C# com .NET CLI – Luiz Carlos Faria](https://www.youtube.com/watch?v=TC32f7A0ynE)

---

### 📚 Documentação Oficial Microsoft

- [Estrutura de Projetos C# – Microsoft Docs](https://learn.microsoft.com/pt-br/dotnet/core/project-sdk/overview)
- [`Program.cs`, `Main()` e top-level statements](https://learn.microsoft.com/pt-br/dotnet/csharp/fundamentals/program-structure/program-structure)
- [`csproj`: o arquivo de projeto](https://learn.microsoft.com/pt-br/dotnet/core/project-sdk/msbuild-props)

---

### 🧠 Artigos Técnicos e Blogs

- [Como funciona a estrutura de projeto no .NET – Medium](https://medium.com/@mariofs/estrutura-de-um-projeto-em-net-core-para-iniciantes-cf4f50a3f63b)
- [Entendendo o Program.cs, Startup.cs e Appsettings.json](https://balta.io/blog/estrutura-de-um-projeto-dotnet)
- [Organização de pastas em projetos C# – TreinaWeb](https://www.treinaweb.com.br/blog/organizacao-de-projetos-em-csharp)

---

### 🗂️ O que geralmente compõe um projeto C#:

| Arquivo/Pasta        | Função Principal                                                                 |
|----------------------|-----------------------------------------------------------------------------------|
| `Program.cs`         | Ponto de entrada do projeto (contém o método `Main()` ou top-level statements)    |
| `Startup.cs`         | (Em APIs) Configura serviços e pipeline de execução                              |
| `appsettings.json`   | Arquivo de configuração da aplicação (ex: connection string, chaves, etc)         |
| `*.csproj`           | Arquivo que define o projeto, dependências e build settings                       |
| `bin/` e `obj/`      | Pastas geradas automaticamente com os arquivos compilados                         |
| `Properties/launchSettings.json` | Define configurações de execução (usado em debug local)               |
| `Controllers/`, `Models/`, `Services/` | Organização comum em projetos MVC/API                            |

---

### 💻 Ferramentas para Testes

- [Visual Studio 2022 Community](https://visualstudio.microsoft.com/pt-br/vs/community/)
- [Visual Studio Code + C# Extension](https://code.visualstudio.com/docs/languages/dotnet)
- [DotNet CLI (`dotnet new console`)](https://learn.microsoft.com/pt-br/dotnet/core/tools/dotnet-new)

---

#### ✅ Conclusão

O C# possui uma estrutura clara e bem definida para organizar projetos. Aprender essas convenções desde o início te prepara para:

* Escrever código limpo e legível
* Trabalhar melhor em equipe
* Evoluir com confiança em projetos reais

📌 Dominar os fundamentos é o que te torna pronto para desafios mais complexos.

---

##### ✍️ **Seção criada por:** *Fabio Zanneti* 🎯 Projeto: **WEX - End to End Engineering**
