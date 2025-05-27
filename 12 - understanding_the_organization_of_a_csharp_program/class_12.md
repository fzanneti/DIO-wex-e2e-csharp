# 🧱 Conhecendo a Organização de um Programa C#

Este material apresenta a **estrutura fundamental de um programa em C#**, além de guiar a criação e organização de projetos com diferentes versões do .NET. Aprender a estrutura e organização é essencial para quem deseja evoluir com clareza, produtividade e boas práticas na plataforma.

---

#### 📌 Índice

- Estrutura de um programa C#  
- Criando nosso novo projeto  
- Organizando e referenciando projetos  
- Criando um projeto .NET 5 e .NET 6  
- Comparando .NET 5 e .NET 6  
- Entendendo o caminho no terminal  

---

#### 🧠 Estrutura de um Programa C#

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
````

#### Componentes:

* `using`: diretivas de namespace (bibliotecas).
* `namespace`: agrupador lógico para organização do código.
* `class`: define a estrutura de uma classe.
* `Main`: ponto de entrada da aplicação.
* `Console.WriteLine`: exibe informações no console.

---

#### 🚀 Criando Nosso Novo Projeto

Para criar um novo projeto via terminal, execute:

```bash
dotnet new console -n NomeDoProjeto
```

* `dotnet new console`: cria um projeto do tipo console.
* `-n NomeDoProjeto`: define o nome do projeto.

👉 Após criar, acesse a pasta:

```bash
cd NomeDoProjeto
```

---

#### 🗂️ Organizando e Referenciando Projetos

Em soluções maiores, é comum dividir o projeto em **camadas** (ex: domínio, aplicação, UI). Para isso:

#### Criar uma solução:

```bash
dotnet new sln -n MinhaSolucao
```

#### Adicionar projetos:

```bash
dotnet new classlib -n Projeto.Dominio
dotnet new console -n Projeto.UI
```

#### Adicionar à solução:

```bash
dotnet sln MinhaSolucao.sln add Projeto.Dominio/Projeto.Dominio.csproj
dotnet sln MinhaSolucao.sln add Projeto.UI/Projeto.UI.csproj
```

#### Fazer referência entre projetos:

```bash
dotnet add Projeto.UI/Projeto.UI.csproj reference Projeto.Dominio/Projeto.Dominio.csproj
```

---

#### 🧱 Criando um Projeto .NET 5 e .NET 6

#### Projeto .NET 5:

```bash
dotnet new console -n ProjetoNet5 --framework net5.0
```

#### Projeto .NET 6:

```bash
dotnet new console -n ProjetoNet6 --framework net6.0
```

Você também pode editar manualmente o `.csproj` para alterar a versão do framework, se necessário.

---

#### 🔍 Comparando .NET 5 vs .NET 6

| Característica       | .NET 5              | .NET 6 (LTS)                    |
| -------------------- | ------------------- | ------------------------------- |
| Suporte              | Terminado           | Suporte de longo prazo (LTS)    |
| Sintaxe simplificada | Não                 | Sim (`top-level statements`)    |
| Performance          | Boa                 | Excelente (otimizações nativas) |
| Minimal API          | Não disponível      | Disponível                      |
| Estabilidade         | Versão de transição | Versão estável e recomendada    |

#### Exemplo com sintaxe minimalista no .NET 6:

```csharp
Console.WriteLine("Olá, mundo!");
```

---

#### 🖥️ Entendendo o Caminho no Terminal

É essencial estar na pasta correta ao rodar comandos com o `dotnet`.

#### Dicas:

* Use `cd` para navegar entre pastas.
* Use `ls` (Linux/macOS) ou `dir` (Windows) para listar arquivos.
* Se estiver em dúvida, use:

```bash
dotnet --info
```

Para verificar a versão do SDK e caminhos instalados.

#### Rodar projeto:

```bash
dotnet run
```

Certifique-se de estar dentro da pasta do projeto ou aponte o caminho correto com:

```bash
dotnet run --project ./NomeDoProjeto
```

---

#### ✅ Conclusão

Entender a organização de um programa em C# e como gerenciar múltiplos projetos numa solução é essencial para criar aplicações profissionais. Além disso, dominar os comandos no terminal e entender as diferenças entre versões do .NET ajuda a ganhar agilidade e fazer escolhas conscientes.

---

##### Seção criada por: *Fabio Zanneti - Projeto: WEX - End to End Engineering* - Guia de estudos.
