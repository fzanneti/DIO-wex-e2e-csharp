# WEX - End to End Engineering

## 7 - Introdução — Entendendo a Estrutura do Projeto em C#

![GitHub repo size](https://img.shields.io/github/repo-size/fzanneti/wex-e2e-csharp)
![GitHub forks](https://img.shields.io/github/forks/fzanneti/wex-e2e-csharp?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/fzanneti/wex-e2e-csharp?style=social)
![Linguagem](https://img.shields.io/badge/Linguagem-CSharp-blue)
![Bootcamp](https://img.shields.io/badge/WEX-End--to--End%20Engineering-blueviolet?logo=vercel&logoColor=white)
![Plataforma](https://img.shields.io/badge/Powered%20by-DIO.io-red?logo=data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjZmZmIiB2aWV3Qm94PSIwIDAgMzIgMzIiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PHBhdGggZD0iTTYuNzEgMy4yNWMtMi44OCAxLjQxLTUuMDcgNC4yMy01LjA3IDcuNzYgMCAzLjU4IDIuMjggNi43IDUuMzMgOC4xNSAxLjgzLS42MiAyLjQtMi4yNiAyLjQtMy44MSAwLS4yMy0uMDItLjQ1LS4wNS0uNjZBLjQ0LjQ0IDAgMDExMC4xIDExYy4yNC0uNzUuMTEtMS41My0uMy0yLjIyQzguOTIgNy45NiA3LjMzIDcuNSA1Ljc0IDcuNjZhNS41NSA1LjU1IDAgM)
![Autor](https://img.shields.io/badge/Autor-fzanneti-blue?style=flat-square&logo=github)

---

### Estrutura básica de um projeto .NET

Antes de escrever código, é importante entender o que vem por padrão ao criar um projeto .NET:

```bash

dotnet new console

```

Isso gera uma estrutura como:

* `Program.cs`: Ponto de entrada da aplicação
* `*.csproj`: Arquivo de configuração do projeto (.NET version, pacotes, etc.)
* `bin/` e `obj/`: Diretórios de build (compilação)

> Essa estrutura facilita a **manutenção, modularização e organização** do código.

---

### Conceito de Classe

No C#, **classes são moldes** que descrevem:

* Características / Dados → **Propriedades**
* Comportamentos → **Métodos**

---

### Exemplo Prático:

1. **Produto.cs**:

```csharp

namespace MeuProjeto
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public void ExibirInfo()
        {
            Console.WriteLine($"{Nome} custa {Preco:C}");
        }
    }
}

```

2. **GerenciadorProdutos.cs**:
  
```csharp

using System.Collections.Generic;

namespace MeuProjeto
{
    public class GerenciadorProdutos
    {
        private readonly List<Produto> _produtos = new List<Produto>();

        public void AdicionarProduto(Produto produto)
        {
            _produtos.Add(produto);
        }

        public void ListarProdutos()
        {
            foreach (var produto in _produtos)
            {
                produto.ExibirInfo();
            }
        }
    }
}
   
```

3. **Program.cs**:

```csharp

using System;

namespace MeuProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            var gerenciador = new GerenciadorProdutos();
            gerenciador.AdicionarProduto(new Produto { Nome = "Notebook", Preco = 3500.00 });
            gerenciador.AdicionarProduto(new Produto { Nome = "Mouse", Preco = 50.00 });
            gerenciador.ListarProdutos();
        }
    }
}

```

---

### Criando uma Classe no Projeto

Dentro do seu projeto, você pode criar arquivos `.cs` separados para cada classe.

```csharp

public class Produto
{
    public string Nome;
    public double Preco;
}

```

> **Dica:** sempre use nomes claros e com inicial maiúscula (PascalCase).

---

### Estrutura Básica de um Código C\#

**Elementos:**

- **`using`** (importações)
- **namespace** (opcional)
- **classe**
- **método `Main()`** (ponto de entrada)

---

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

### Explicando o Projeto C# "MeuProjeto"

Este manual explica de forma concisa as classes do seu projeto C# e como elas trabalham juntas para gerenciar produtos.

---

### Visão Geral

O "MeuProjeto" é um sistema básico de gerenciamento de produtos. Ele demonstra como organizar o código em C# usando classes específicas para diferentes tarefas: definir produtos, gerenciar uma lista de produtos e executar a aplicação.

---

### 1. Classe `Produto`

* **Arquivo**: `Produto.cs`
* **Função**: É o **modelo** para cada produto.
* **Conteúdo**:
    * **`Nome`** (texto) e **`Preco`** (número decimal): Propriedades para as características do produto.
    * **`ExibirInfo()`**: Método que mostra o nome e o preço do produto no console.

---

### 2. Classe `GerenciadorProdutos`

* **Arquivo**: `GerenciadorProdutos.cs`
* **Função**: É o **organizador** dos produtos.
* **Conteúdo**:
    * **`private readonly List<Produto> _produtos`**: Uma lista interna e privada para guardar os objetos `Produto`. É `readonly` para que a lista em si não possa ser substituída, mas produtos podem ser adicionados ou removidos dela.
    * **`AdicionarProduto(Produto produto)`**: Adiciona um produto à lista.
    * **`ListarProdutos()`**: Percorre a lista e pede a cada produto que exiba suas informações usando `ExibirInfo()`.

---

### 3. Classe `Program`

* **Arquivo**: `Program.cs`
* **Função**: É o **ponto de partida** da aplicação.
* **Conteúdo**:
    * **`static void Main(string[] args)`**: O método que inicia a execução do programa.
    * Cria uma instância de `GerenciadorProdutos`.
    * Cria novos objetos `Produto` (Notebook, Mouse) e os adiciona ao `GerenciadorProdutos`.
    * Chama o método `ListarProdutos()` do `GerenciadorProdutos` para mostrar todos os produtos cadastrados.

---

### Como Interagem

O `Program` **cria** um `GerenciadorProdutos`. Ele então **cria** produtos e os **entrega** ao `GerenciadorProdutos` para que este os **armazene**. Por fim, o `Program` pede ao `GerenciadorProdutos` para **listar** tudo, e o `GerenciadorProdutos`, por sua vez, pede a cada `Produto` para **se exibir**.

---

### Namespaces

Namespaces agrupam classes relacionadas para evitar conflitos de nomes e manter a organização.

```csharp

namespace MeuProjeto.Compras
{
    public class Pedido { }
}
namespace MeuProjeto.Usuarios
{
    public class Cliente { }
}

```

---

### Usando a Classe Pessoa

```csharp

Pessoa p = new Pessoa();
p.Nome = "Fabio";
p.Idade = 43;
p.Apresentar();

```

No C#, **instanciamos objetos** com `new`, acessamos **propriedades** e executamos **métodos**.

---

### Sintaxe do C\#

* Linhas terminam com `;`
* Blocos delimitados com `{}` (não por identação como em Python)
* Tipagem forte e explícita `int idade = 30;`
* Linguagem orientada a objetos

### Exemplo:

```csharp

int idade = 30;
string nome = "Fabio";

```

---

### Convenções de Escrita

- **CamelCase**: `nomeCliente`, `precoTotal`.
- **PascalCase**: `Produto`, `ExibirInfo()`.

**Exemplo**:

```csharp

public class Cliente
{
    public string NomeCompleto { get; set; }
    public int IdadeCliente { get; set; }
}

```

---

### Boas Práticas para Estruturação

1. **Separação de Responsabilidades**: Use `Controllers/`, `Models/`, `Services/`.
2. **Nomenclatura Clara**: `ProdutoService`, `listaProdutos`.
3. **Modularização**: Camadas (ex.: Dados, Negócios).
4. **Documentação**: Use comentários XML.
5. **Testes**: Crie pasta `Tests/` com xUnit.

---

### O que geralmente compõe um projeto C#:

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

### Material de Apoio

Ao criar um projeto em C#, especialmente com .NET, o Visual Studio ou o .NET CLI gera uma estrutura padrão de arquivos e pastas. Compreender o papel de cada parte facilita a organização, manutenção e escalabilidade do código.

---

🔗[Estrutura de Projetos C# – Microsoft Docs](https://learn.microsoft.com/pt-br/dotnet/core/project-sdk/overview)   
🔗[`Program.cs`, `Main()` e top-level statements](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/top-level-statements)    
🔗[`csproj`: o arquivo de projeto](https://learn.microsoft.com/pt-br/dotnet/core/project-sdk/msbuild-props)   
🔗[Organize seu projeto no .NET](https://learn.microsoft.com/pt-br/dotnet/core/porting/project-structure)   
🔗[Visual Studio 2022 Community](https://visualstudio.microsoft.com/pt-br/vs/community/)    
🔗[Visual Studio Code + C# Extension](https://code.visualstudio.com/docs/languages/dotnet)    
🔗[DotNet CLI (`dotnet new console`)](https://learn.microsoft.com/pt-br/dotnet/core/tools/dotnet-new)    

---

### Conclusão

O C# possui uma estrutura clara e bem definida para organizar projetos. Aprender essas convenções desde o início te prepara para:

* Escrever código limpo e legível
* Trabalhar melhor em equipe
* Evoluir com confiança em projetos reais

> Dominar a estrutura de um projeto .NET te prepara para escrever código organizado, colaborar em equipe e enfrentar desafios reais no Bootcamp WEX. Crie projetos práticos, siga convenções e use Git para versionar seu progresso. Seu código está pronto para crescer!

---

##### ✍️ Seção criada por: *Fabio Zanneti* - 🎯 Bootcamp: **WEX - End to End Engineering**
[![GitHub](https://img.shields.io/badge/GitHub-fzanneti-181717?style=flat&logo=github)](https://github.com/fzanneti)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-fzanneti-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/fzanneti)