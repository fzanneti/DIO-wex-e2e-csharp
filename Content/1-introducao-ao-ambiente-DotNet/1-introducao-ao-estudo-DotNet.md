# WEX - End to End Engineering

## 1 - Introdução ao .NET

A plataforma **.NET**, desenvolvida pela **Microsoft**, é um ambiente robusto e versátil que permite criar aplicações para **Windows**, **Web**, **Cloud**, **Mobile**, e até **IoT**.
Seu foco principal é oferecer uma base unificada e moderna para desenvolvimento em diversas linguagens — com destaque para o **C#**.

![GitHub repo size](https://img.shields.io/github/repo-size/fzanneti/wex-e2e-csharp)
![GitHub forks](https://img.shields.io/github/forks/fzanneti/wex-e2e-csharp?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/fzanneti/wex-e2e-csharp?style=social)
![Linguagem](https://img.shields.io/badge/Linguagem-CSharp-blue)
![Bootcamp](https://img.shields.io/badge/WEX-End--to--End%20Engineering-blueviolet?logo=vercel&logoColor=white)
![Plataforma](https://img.shields.io/badge/Powered%20by-DIO.io-red?logo=data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjZmZmIiB2aWV3Qm94PSIwIDAgMzIgMzIiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PHBhdGggZD0iTTYuNzEgMy4yNWMtMi44OCAxLjQxLTUuMDcgNC4yMy01LjA3IDcuNzYgMCAzLjU4IDIuMjggNi43IDUuMzMgOC4xNSAxLjgzLS42MiAyLjQtMi4yNiAyLjQtMy44MSAwLS4yMy0uMDItLjQ1LS4wNS0uNjZBLjQ0LjQ0IDAgMDExMC4xIDExYy4yNC0uNzUuMTEtMS41My0uMy0yLjIyQzguOTIgNy45NiA3LjMzIDcuNSA1Ljc0IDcuNjZhNS41NSA1LjU1IDAgM)
![Autor](https://img.shields.io/badge/Autor-fzanneti-blue?style=flat-square&logo=github)

---

### Por que escolher o .NET?

O .NET é amplamente adotado por empresas globais devido à sua escalabilidade, segurança e suporte a arquiteturas modernas, como microsserviços e aplicações em nuvem (ex.: Azure). Comparado a outras plataformas, como Java ou Node.js, o .NET oferece uma integração nativa com ferramentas Microsoft, alta performance com o JIT Compiler, e uma comunidade ativa que impulsiona inovações constantes. É ideal para quem busca produtividade com C# e flexibilidade para diferentes tipos de projetos.

---

### Conceitos Principais

- **.NET** é um ecossistema completo: inclui ferramentas, bibliotecas e o tempo de execução (**runtime**).
- **Multiplataforma**: roda no Windows, Linux e macOS.
- Suporte a várias linguagens: **C#**, **F#**, **VB.NET**.
- **SDK (.NET Software Development Kit)**: Inclui ferramentas e bibliotecas para desenvolvimento, como compiladores e o .NET CLI.
- **.NET CLI**: Interface de linha de comando para criar, compilar e executar projetos .NET (ex.: dotnet new, dotnet run).

---

### Bibliotecas Populares:

- **ASP.NET Core**: Framework para aplicações web modernas e APIs REST.
- **Entity Framework Core**: ORM para acesso a bancos de dados de forma simplificada.
- **Blazor**: Framework para interfaces web interativas usando C#.

---

### Linha do Tempo do .NET

| Ano | Evento Importante |
|:------:|----------------------|
| 2002   | Lançamento do .NET Framework 1.0 |
| 2016   | Lançamento do .NET Core (cross-platform) |
| 2020   | Lançamento do .NET 5 (unificação) |
| 2021   | .NET 6 - Long Term Support (LTS) |
| 2022   | .NET 7 (melhorias de performance e APIs) |
| 2023   | .NET 8 (atualização contínua) |
| 2024   | .NET 9 - Foco em AOT, integração com IA e performance otimizada | 

> .NET 9: lançado oficialmente em novembro de 2024 durante a .NET Conf, após as versões de testes disponíveis desde setembro de 2024. Ele aprimora o desempenho, a segurança e introduz novas funcionalidades no ASP.NET Core, MAUI e Native AOT. Esta versão mais recente, disponível para Windows, macOS e Linux, otimiza o desenvolvimento de aplicações e sucede o .NET 8.

---

### Conclusão

O .NET passou de um framework limitado ao Windows para uma plataforma poderosa e multiplataforma, ideal para aplicações modernas.

---

### Comparando: .NET Framework vs .NET (Core/5+)

- .NET Framework
   - Lançado em **2002**.
   - Suporte apenas a sistemas **Windows**.
   - Muito usado em sistemas corporativos e aplicações **legadas**.

---

### .NET Core / .NET 5+

- **Multiplataforma**.
- **Open Source**.
- Alta performance.
- Suporte ativo da comunidade.

---

### Tabela Comparativa

| Recurso            | .NET Framework  |   .NET Core / .NET 5+    |
|--------------------|-----------------|--------------------------|
| Multiplataforma    | ❌ Não          | ✅ Sim                  |
| Código Aberto      | ⚠️ Parcial      | ✅ Sim                  |
| Performance        | 🟡 Regular      | 🟢 Alta                 |
| Suporte Moderno    | 🔴 Limitado     | ✅ Ativo                |
| Longevidade        | 🛠️ Manutenção   | 🌟 Futuro da Plataforma |

---

<img src="https://github.com/fzanneti/DIO-wex-e2e-csharp/blob/main/Content/assets/images/Code_Generated_Image.png" alt="Comparação de Perfomance" width="600px">

---

> **Resumo**: Use o **.NET 6 ou superior** para novos projetos. O .NET Framework continua sendo usado para sistemas legados, mas está em modo de manutenção.

---

### Conclusão

Se você está começando hoje, foque no **.NET 6** ou superior. O .NET Framework ainda é usado, mas não receberá mais evoluções significativas. Ele permanece em modo de manutenção, ou seja:

- Recebe atualizações de segurança e correções críticas.
- Não receberá novos recursos ou grandes melhorias de performance.
- Continua sendo suportado em sistemas Windows que dependem de aplicações legadas.

A Microsoft incentiva a migração para o .NET 6+ (ou superior), que é o futuro da plataforma. O .NET moderno é multiplataforma, open source, com melhor performance e mais recursos.

> **Resumo:** o .NET Framework ainda é necessário para sistemas antigos, mas novos projetos devem usar o .NET atual (.NET 6, 7, 8...).

---

### Compiladores e Transpiladores no .NET

#### Conceitos

- **Compilador**: transforma código C# em **CIL** (*Common Intermediate Language*).
- **CLR** (*Common Language Runtime*): executa o código CIL no sistema.
- **Transpilador**: converte código de uma linguagem para outra. (Menos comum no .NET, mas útil para interoperabilidade.)

---

### Como funciona o compilador .NET

1. Você escreve código em C#.
2. O compilador converte esse código em **CIL**.
3. O **CLR** interpreta e executa esse código CIL na máquina.

``` csharp

// Exemplo básico em C#
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Olá, mundo!");
    }
}

```

> Esse código é compilado para **CIL** e executado pelo **CLR** na plataforma destino.

---

### Exemplo prático: Criando e Compilando um Projeto .NET: JIT vs. AOT

Este guia prático mostrará como criar um projeto de console simples no .NET, executá-lo com compilação Just-In-Time (JIT) e, em seguida, publicá-lo como um executável nativo usando Ahead-of-Time (AOT) para entender as diferenças.

#### Pré-requisitos

Certifique-se de ter o **SDK do .NET** instalado em sua máquina. Você pode baixá-lo em [dotnet.microsoft.com/download](https://dotnet.microsoft.com/download).

- Verifique a instalação:

```bash

dotnet --version

```

---

### 1. Criando um Novo Projeto de Console

Primeiro, vamos criar um novo projeto de console chamado "MeuAppExemplo".

```bash

dotnet new console -o MeuAppExemplo
cd MeuAppExemplo

```

---

### Entendendo o Código (Program.cs)

Por padrão, o arquivo `Program.cs` dentro da pasta `MeuAppExemplo` terá um código simples como este:

```csharp

// Program.cs
Console.WriteLine("Olá, mundo! Este é o meu app .NET.");

```

Você pode abrir este arquivo com seu editor de texto preferido para visualizá-lo ou modificá-lo.

---

### Executando com Compilação JIT (Just-In-Time)

Quando você executa seu aplicativo .NET dessa forma, o Common Intermediate Language (CIL) é compilado para código de máquina **durante a execução** (JIT). Isso é ideal para desenvolvimento, pois permite um ciclo rápido de feedback.

```bash

dotnet run

```

---

Você verá a saída: `"Olá, mundo! Este é o meu app .NET."`

### Publicando com Compilação AOT (Ahead-of-Time)

Agora, vamos publicar nosso aplicativo usando a compilação AOT. Isso criará um **executável nativo** que não requer o runtime .NET instalado na máquina de destino. Ele é compilado **antes da execução**, resultando em inicialização mais rápida e um binário independente.

Para este exemplo, vamos gerar um executável para Windows x64. Você pode mudar `-r win-x64` para outras runtimes, como `linux-x64` ou `osx-x64`, dependendo do seu ambiente.

```bash

dotnet publish -c Release -r win-x64 --self-contained true /p:PublishAot=true

```

---

### Verificando o Executável AOT

Após o comando `dotnet publish` ser concluído, você encontrará o executável nativo na seguinte pasta (o caminho exato pode variar um pouco dependendo da versão do .NET e do sistema operacional):

`MeuAppExemplo\bin\Release\net8.0\win-x64\publish\`

Dentro desta pasta `publish`, você verá um arquivo executável chamado `MeuAppExemplo.exe` (no Windows) ou `MeuAppExemplo` (no Linux/macOS).

Você pode executar este arquivo diretamente sem a necessidade do SDK do .NET ou do runtime .NET instalado, comprovando que ele é um binário nativo e independente.

---

### Resumo das Diferenças

| Característica | JIT (Just-In-Time)                        | AOT (Ahead-of-Time)                                     |
| :------------- | :---------------------------------------- | :------------------------------------------------------ |
| **Quando compila?** | Durante a execução                       | Antes da execução                                       |
| **Dependências** | Requer o runtime .NET instalado          | Não requer o runtime .NET (binário autocontido)         |
| **Tamanho do binário** | Menor (depende do runtime)               | Maior (inclui componentes do runtime necessários)       |
| **Inicialização** | Pode ser ligeiramente mais lenta         | Mais rápida (sem compilação em tempo de execução)      |
| **Otimização** | Otimiza para o hardware local no runtime | Otimiza no momento da publicação para a plataforma alvo |
| **Uso Ideal** | Desenvolvimento, aplicações web, APIs    | Contêineres, IoT, microserviços, aplicativos CLI nativos |

---

### Primeiros Passos com .NET

**Crie seu primeiro projeto**

- *Crie um projeto console*:

```bash

dotnet new console -n MinhaPrimeiraApp
cd MinhaPrimeiraApp

```

- Edite o arquivo `Program.cs`:

```csharp

using System;

namespace MinhaPrimeiraApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao .NET!");
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine($"Olá, {nome}! Vamos programar em C#!");
        }
    }
}

```

- *Execute*:

```bash

dotnet run

```

> Experimente criar projetos web com `dotnet new webapi` (API REST) ou `dotnet new blazor` (UI interativa).

---

### Boas Práticas no .NET

**Desenvolvimento no .NET:**

- *Organize seu projeto*:

Use pastas como `Controllers`, `Services`, `Models` para separar responsabilidades.

- Exemplo:

```

/MinhaApp
├── Controllers/
├── Services/
├── Models/
├── wwwroot/
└── Program.cs

```

---

### Conclusão

O sistema de compilação do .NET fornece:

- **Segurança**
- **Portabilidade**
- **Performance**

Com isso, você pode escrever em C# e rodar sua aplicação em diversos sistemas com eficiência.

---

### Materiais Complementares:

🔗[Documentação oficial da Microsoft](https://learn.microsoft.com/pt-br/dotnet/)
🔗[Livro gratuito da Microsoft](https://docs.microsoft.com/dotnet/standard/)

---

##### ✍️ Seção criada por: *Fabio Zanneti* - 🎯 Bootcamp: **WEX - End to End Engineering**
[![GitHub](https://img.shields.io/badge/GitHub-fzanneti-181717?style=flat&logo=github)](https://github.com/fzanneti)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-fzanneti-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/fzanneti)