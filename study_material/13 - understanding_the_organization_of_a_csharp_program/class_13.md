# 📁 Conhecendo a Organização de um Programa em C#

Este guia faz parte do repositório educativo do curso **WEX - End to End Engineering** e tem como objetivo apresentar a estrutura básica de um programa em C#, além de demonstrar como criar, organizar e navegar por projetos utilizando o terminal e o SDK .NET.

---

#### 🧱 Estrutura de um Programa C#

Todo projeto em C# é composto por **arquivos e pastas padrão** que organizam o código e os recursos necessários. A estrutura típica de um projeto `.NET` é:

```

/MeuProjeto
│
├── Program.cs         --> Ponto de entrada da aplicação
├── MeuProjeto.csproj  --> Arquivo de definição do projeto
├── appsettings.json   --> Configurações da aplicação
├── bin/               --> Arquivos compilados (Build)
├── obj/               --> Arquivos intermediários da compilação
└── Controllers/       --> (Para Web API) Controladores da aplicação

````

> **Nota:** Em projetos Web API ou MVC, também teremos `Startup.cs` (em .NET 5) ou as configurações no próprio `Program.cs` (em .NET 6+).

---

#### ⚙️ Criando Nosso Novo Projeto

Antes de tudo, certifique-se de que o SDK .NET está instalado com:

```bash
dotnet --version
````

#### 🔹 Para criar um projeto de console:

```bash
dotnet new console -n MeuProjeto
cd MeuProjeto
code .
```

#### 🔹 Para criar um projeto de API:

```bash
dotnet new webapi -n MeuApiProjeto
cd MeuApiProjeto
code .
```

---

#### 🗂️ Organizando e Referenciando Projetos

No desenvolvimento real, usamos **soluções (solution)** para agrupar vários projetos:

#### 1. Criar uma solução:

```bash
dotnet new sln -n MinhaSolucao
```

#### 2. Criar dois projetos distintos:

```bash
dotnet new classlib -n MinhaBiblioteca
dotnet new console -n MeuApp
```

#### 3. Adicionar os projetos à solução:

```bash
dotnet sln MinhaSolucao.sln add MinhaBiblioteca/MinhaBiblioteca.csproj
dotnet sln MinhaSolucao.sln add MeuApp/MeuApp.csproj
```

#### 4. Referenciar um projeto no outro (ex: biblioteca no console):

```bash
cd MeuApp
dotnet add reference ../MinhaBiblioteca/MinhaBiblioteca.csproj
```

---

#### 🆚 Criando Projetos com .NET 5 e .NET 6

Ambos são versões modernas do .NET, mas com diferenças significativas na **estrutura de inicialização**.

#### 🔹 Projeto com .NET 5

```bash
dotnet new console -n ProjetoNet5 --framework net5.0
```

> Esse projeto vai gerar uma estrutura com `static void Main(string[] args)` visível no `Program.cs`.

#### 🔹 Projeto com .NET 6 (ou superior)

```bash
dotnet new console -n ProjetoNet6 --framework net6.0
```

> Aqui o código usa a nova **top-level statement**, com `Program.cs` sem o método `Main` explícito.

#### ✅ Exemplo .NET 6:

```csharp
Console.WriteLine("Olá, mundo!");
```

---

#### 🧭 Entendendo o Caminho no Terminal

Ao trabalhar com projetos múltiplos ou soluções, é essencial entender como navegar com comandos no terminal:

* `cd nomeDaPasta` → entra em uma pasta
* `cd ..` → volta uma pasta
* `dir` (Windows) ou `ls` (Linux/Mac) → lista arquivos e pastas

#### Comandos úteis no terminal:

| Comando                | Ação                                |
| ---------------------- | ----------------------------------- |
| `dotnet new`           | Cria novo projeto                   |
| `dotnet run`           | Executa o projeto atual             |
| `dotnet build`         | Compila o projeto                   |
| `dotnet restore`       | Restaura pacotes e dependências     |
| `dotnet clean`         | Limpa os binários da build anterior |
| `dotnet sln add`       | Adiciona projeto à solução          |
| `dotnet add reference` | Referencia outro projeto .csproj    |

---

#### 📌 Dicas Finais

* Sempre mantenha os projetos organizados em pastas separadas.
* Nomeie os projetos com clareza (`MinhaApp.Console`, `MinhaApp.Data`, `MinhaApp.Domain`, etc).
* Utilize o VS Code ou Visual Studio para facilitar a navegação.
* Pratique a criação de soluções com múltiplos projetos para fixar bem a estrutura.

---

📂 **Repositório oficial do SDK .NET:**
[https://github.com/dotnet](https://github.com/dotnet)  
📚 **Documentação oficial da Microsoft:**
[https://learn.microsoft.com/dotnet](https://learn.microsoft.com/dotnet)

---

##### Seção criada por: *Fabio Zanneti - Projeto: WEX - End to End Engineering* - Guia de estudos.
