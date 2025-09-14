# WEX - End to End Engineering

## 2.5 - Conhecendo a Organização de um Programa C#

![GitHub repo size](https://img.shields.io/github/repo-size/fzanneti/wex-e2e-csharp)
![GitHub forks](https://img.shields.io/github/forks/fzanneti/wex-e2e-csharp?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/fzanneti/wex-e2e-csharp?style=social)
![Linguagem](https://img.shields.io/badge/Linguagem-CSharp-blue)
![Bootcamp](https://img.shields.io/badge/WEX-End--to--End%20Engineering-blueviolet?logo=vercel&logoColor=white)
![Plataforma](https://img.shields.io/badge/Powered%20by-DIO.io-red?logo=data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjZmZmIiB2aWV3Qm94PSIwIDAgMzIgMzIiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PHBhdGggZD0iTTYuNzEgMy4yNWMtMi44OCAxLjQxLTUuMDcgNC4yMy01LjA3IDcuNzYgMCAzLjU4IDIuMjggNi43IDUuMzMgOC4xNSAxLjgzLS42MiAyLjQtMi4yNiAyLjQtMy44MSAwLS4yMy0uMDItLjQ1LS4wNS0uNjZBLjQ0LjQ0IDAgMDExMC4xIDExYy4yNC0uNzUuMTEtMS41My0uMy0yLjIyQzguOTIgNy45NiA3LjMzIDcuNSA1Ljc0IDcuNjZhNS41NSA1LjU1IDAgM)
![Autor](https://img.shields.io/badge/Autor-fzanneti-blue?style=flat-square&logo=github)

Este material apresenta a **estrutura fundamental de um programa em C#**, além de guiar a criação e organização de projetos com diferentes versões do .NET. Aprender a estrutura e organização é essencial para quem deseja evoluir com clareza, produtividade e boas práticas na plataforma.

---

### Estrutura de um Programa C#

Um programa básico em C# possui os seguintes elementos:

```csharp

using System;

namespace MeuPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, Mundo!");
        }
    }
}

```

### Componentes:

* `using`: diretivas de namespace (bibliotecas).
* `namespace`: agrupador lógico para organização do código.
* `class`: define a estrutura de uma classe.
* `Main`: ponto de entrada da aplicação.
* `Console.WriteLine`: exibe informações no console.

---

### Criando Nosso Novo Projeto

Para criar um novo projeto via terminal, execute:

```bash

dotnet new console -n NomeDoProjeto

```

* `dotnet new console`: cria um projeto do tipo console.
* `-n NomeDoProjeto`: define o nome do projeto.

> Após criar, acesse a pasta:

```bash

cd NomeDoProjeto

```

---

### Organizando e Referenciando Projetos

Em soluções maiores, é comum dividir o projeto em **camadas** (ex: domínio, aplicação, UI). Para isso:

**Criar uma solução:**

```bash

dotnet new sln -n MinhaSolucao

```

**Adicionar projetos:**

```bash

dotnet new classlib -n Projeto.Dominio
dotnet new console -n Projeto.UI

```

**Adicionar à solução:**

```bash

dotnet sln MinhaSolucao.sln add Projeto.Dominio/Projeto.Dominio.csproj
dotnet sln MinhaSolucao.sln add Projeto.UI/Projeto.UI.csproj

```

**Fazer referência entre projetos:**

```bash

dotnet add Projeto.UI/Projeto.UI.csproj reference Projeto.Dominio/Projeto.Dominio.csproj

```

---

### Criando um Projeto .NET 5 / 6 / 8

5️⃣ **Projeto .NET 5:**

```bash

dotnet new console -n ProjetoNet5 --framework net5.0

```

6️⃣ **Projeto .NET 6:**

```bash

dotnet new console -n ProjetoNet6 --framework net6.0

```

8️⃣ **Projeto .NET 8:**

```bash

dotnet new console -n ProjetoNet6 --framework net8.0

```

> Você também pode editar manualmente o `.csproj` para alterar a versão do framework, se necessário.

---

### Comparando .NET 5 / 6 / 8

| Característica       | .NET 5              | .NET 6 (LTS)                    | .NET 7/8                     |
| -------------------- | ------------------- | ------------------------------- | ---------------------------- |
| Suporte              | Terminado           | Suporte de longo prazo (LTS)    | Suporte ativo (8 é LTS)      |
| Top-Level Statements | Não                 | Sim                             | Sim                          |
| Performance          | Boa                 | Excelente                       | Ainda mais otimizada         |


### Entendendo o Caminho no Terminal

É essencial estar na pasta correta ao rodar comandos com o `dotnet`.

- Navegue: `cd NomeDoProjeto`, `ls`/`dir`.
- Verifique SDK: `dotnet --info`.
- Execute: `dotnet run`.

---

### Dicas:

- Use `cd` para navegar entre pastas.
- Use `ls` (Linux/macOS) ou `dir` (Windows) para listar arquivos.
- Se estiver em dúvida, use:

```bash

dotnet --info

```

Para verificar a versão do SDK e caminhos instalados.

### Rodar projeto:

```bash

dotnet run

```

Certifique-se de estar dentro da pasta do projeto ou aponte o caminho correto com:

```bash

dotnet run --project ./NomeDoProjeto

```

---

### Links Complementares de Estudo – Conhecendo a Organização de um Programa C#

Um programa em C# é composto por uma estrutura clara: namespaces, classes, métodos e a famosa função `Main()`. Entender essa organização ajuda a escrever código limpo e escalável.

🔗[Estrutura de Programa em C# – Microsoft Docs](https://learn.microsoft.com/pt-br/dotnet/csharp/fundamentals/program-structure/program-structure)      
🔗[Método Main – ponto de entrada de um app C#](https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/main-and-command-args/)    
🔗[Namespaces em C#](https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/namespaces/)   

---

### Conclusão

Entender a organização de um programa em C# e como gerenciar múltiplos projetos numa solução é essencial para criar aplicações profissionais. Além disso, dominar os comandos no terminal e entender as diferenças entre versões do .NET ajuda a ganhar agilidade e fazer escolhas conscientes.

---

### Certificado

<img src="https://github.com/fzanneti/DIO-wex-e2e-csharp/blob/main/Assets/images/certificados/10-conhecendo-a-organizacao-de-um-programa-CSharp.jpg" alt="Certificado" width="600px">

---

##### ✍️ Seção criada por: *Fabio Zanneti* - 🎯 Bootcamp: **WEX - End to End Engineering**
[![GitHub](https://img.shields.io/badge/GitHub-fzanneti-181717?style=flat&logo=github)](https://github.com/fzanneti)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-fzanneti-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/fzanneti)