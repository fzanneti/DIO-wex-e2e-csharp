# 🛠️ IDEs e Configuração do Ambiente .NET

![GitHub repo size](https://img.shields.io/github/repo-size/fzanneti/wex-e2e-csharp)
![GitHub forks](https://img.shields.io/github/forks/fzanneti/wex-e2e-csharp?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/fzanneti/wex-e2e-csharp?style=social)
![Linguagem](https://img.shields.io/badge/Linguagem-CSharp-blue)
![Bootcamp](https://img.shields.io/badge/WEX-End--to--End%20Engineering-blueviolet?logo=vercel&logoColor=white)
![Plataforma](https://img.shields.io/badge/Powered%20by-DIO.io-red?logo=data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjZmZmIiB2aWV3Qm94PSIwIDAgMzIgMzIiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PHBhdGggZD0iTTYuNzEgMy4yNWMtMi44OCAxLjQxLTUuMDcgNC4yMy01LjA3IDcuNzYgMCAzLjU4IDIuMjggNi43IDUuMzMgOC4xNSAxLjgzLS42MiAyLjQtMi4yNiAyLjQtMy44MSAwLS4yMy0uMDItLjQ1LS4wNS0uNjZBLjQ0LjQ0IDAgMDExMC4xIDExYy4yNC0uNzUuMTEtMS41My0uMy0yLjIyQzguOTIgNy45NiA3LjMzIDcuNSA1Ljc0IDcuNjZhNS41NSA1LjU1IDAgM)
![Autor](https://img.shields.io/badge/Autor-fzanneti-blue?style=flat-square&logo=github)

---

### 🎯 Introdução

> Configurar um ambiente .NET eficiente é o primeiro passo para criar aplicações robustas e escaláveis. Escolher a IDE certa e instalar as ferramentas corretas (como o .NET SDK) permite focar no aprendizado de C# e no desenvolvimento, sem preocupações com problemas técnicos. Este guia orienta você passo a passo para começar com confiança.

Você aprenderá a:

- 📥 Instalar ferramentas e SDKs
- 🧠 Escolher a IDE ideal
- 🔍 Diferenciar **.NET SDK** e **.NET Runtime**

---

## 🧠 Conceitos Principais

### 💻 O que é uma IDE?

Uma **IDE (Integrated Development Environment)** é um ambiente completo que combina:

- ✏️ Editor de código
- 🧪 Depurador
- ⚙️ Compilador
- 💻 Terminal embutido

Esses recursos aumentam a produtividade do desenvolvedor.

---

### 📌 Papel do OmniSharp no VS Code

O **OmniSharp** é uma ferramenta de código aberto fundamental que transforma o **VS Code** (Visual Studio Code) em um ambiente de desenvolvimento robusto e completo para C#. Ele atua como um servidor de linguagem, fornecendo recursos avançados que tornam a codificação em C# muito mais eficiente e produtiva.

Pense no OmniSharp como o "cérebro" por trás das funcionalidades inteligentes do VS Code para C#. Sem ele, o VS Code seria apenas um editor de texto básico para seus arquivos C#. Com o OmniSharp, você obtém:

- **IntelliSense**: Sugestões automáticas de código.
- **Análise de código**: Identifica erros em tempo real.
- **Navegação**: Permite ir a definições e referências.
- **Depuração**: Integra com o depurador do VS Code.
- **Gerenciamento de projetos**: Suporta arquivos `.csproj` e `.sln`.

---

### ⚠️ A importância de um ambiente configurado para CI/CD e colaboração em equipe

Além da ferramenta de desenvolvimento individual, a eficiência de uma equipe de software depende criticamente de um **ambiente bem configurado para CI/CD (Integração Contínua/Entrega Contínua) e colaboração**. Isso vai muito além do editor de código e impacta diretamente a velocidade, qualidade e comunicação do desenvolvimento.

Um ambiente configurado para Integração Contínua (CI) e Entrega Contínua (CD) garante:

- **CI**: Builds e testes automatizados para detectar erros cedo.
- **CD**: Implantações confiáveis e rápidas.
- **Colaboração**: Git, revisões de código e padrões unificados melhoram o trabalho em equipe.

> 📝 Em resumo, enquanto o OmniSharp aprimora a experiência de desenvolvimento C# individual no VS Code, um ambiente robusto de CI/CD e colaboração em equipe eleva a produtividade e a qualidade do software em escala, garantindo que o código seja integrado, testado e entregue de forma eficiente e confiável.

---

### 🧰 Principais IDEs para .NET

|🧩 IDE|💼 Indicado para...|🖥️ Plataforma|💸 Gratuito?| ✅ Prós|❌ Contras|
|---|---|---|---|---|---|
|**Visual Studio**|Profissionais e grandes projetos|Windows / macOS|✅ Sim (Community)|✅ Recursos completos, integração com Azure|❌ Pesado, apenas Windows/macOS|
|**Visual Studio Code**|Projetos leves e multiplataforma|Win / macOS / Linux|✅ Sim|✅ Leve, extensível|❌ Requer configuração manual|
|**Rider (JetBrains)**|Alternativa robusta e avançada|Win / macOS / Linux|⚠️ Não (trial)|✅ Debugger avançado, suporte a Docker|❌ Pago|

- **Visual Studio**: Ferramenta oficial da Microsoft, ideal para soluções corporativas, com IntelliSense, designer e depuração avançada.
- **VS Code**: Leve e extensível, perfeito para projetos multiplataforma, mas requer extensões.
- **Rider**: IDE paga com recursos avançados, como suporte a Docker e testes nativos.

🌐 [Rider](https://www.jetbrains.com/rider/) | 📘 [VS Code + .NET](https://learn.microsoft.com/pt-br/dotnet/core/tutorials/with-visual-studio-code)

---

## ⚙️ Instalando o .NET SDK

### 📦 O que vem no SDK?

- Compiladores, CLI `dotnet`, bibliotecas padrão para desenvolvimento.

### 🧩 E o Runtime?

- Permite **executar** aplicações já compiladas.
- **Não permite desenvolvimento**.

---

### 🔍 Comparativo: SDK vs Runtime

| 🔍 Característica     | ✅ .NET SDK      | 🚫 .NET Runtime     |
|----------------------|------------------|---------------------|
| Desenvolver apps     | ✅ Sim           | ❌ Não              |
| Executar apps        | ✅ Sim           | ✅ Sim              |
| Usar CLI `dotnet`    | ✅ Completo      | ⚠️ Limitado         |

📥 [Download oficial do SDK](https://dotnet.microsoft.com/pt-br/download)

### ⚙️ Instalação por Plataforma

- 🗔 **Windows**: Baixe em dotnet.microsoft.com.
- 🍎 **macOS**: `brew install dotnet-sdk`.
- 🐧 **Linux (Ubuntu)**: `sudo apt-get update && sudo apt-get install -y dotnet-sdk-8.0`.
- Verifique: `dotnet --list-sdks` (ex.: `8.0.100 [/usr/share/dotnet/sdk]`).

---

### 💡 Instalando o VS Code + Extensões

Com o SDK instalado, configure o VS Code para desenvolvimento .NET:

1. 🔽 Baixe o VS Code: [📥](https://code.visualstudio.com)
2. 🧩 Instale a extensão `C# for VS Code (powered by OmniSharp)`
3. 📦 [Instale o .NET SDK separadamente](https://github.com/fzanneti/wex-e2e-csharp/blob/main/study_material/01IntroductionToTheDotNetEnvironment/02EnvironmentConfigurationAndIDEs.md#L107) 
4. 🧪 Verifique instalação: `dotnet --version`.
5. 🚀 Crie seu primeiro projeto:

```bash

dotnet new console -n MeuApp
cd MeuApp
dotnet run

```

### 🔌 Extensões recomendadas:

- `C# for Visual Studio Code (Microsoft)`.
- `.NET Install Tool`.
- `Debugger for C#`.
- `Code Spell Checker`.
- `GitLens`.

---

## ⚙️ Configuração Avançada do Ambiente

### 🧩 Personalizando o VS Code

- **Configurações recomendadas** (adicione ao `settings.json` do VS Code):

```json
  
{
  "editor.formatOnSave": true,
  "csharp.suppressDotnetInstallWarning": true,
  "omnisharp.useGlobalMono": "always"
}
  
```

- **Atalhos úteis**:

  - `Ctrl + .`: Sugestões rápidas (Quick Fix).
  - `F5`: Iniciar depuração.
  - `Ctrl + Shift + B`: Compilar projeto.

---

### 🔒 Certificados HTTPS

- Para projetos ASP.NET Core:

```bash

dotnet dev-certs https --trust

```

---

### 📦 Integração com Git

- Inicialize um repositório Git:

```bash
  
git init
git add .
git commit -m "feat: initialize .NET console project"

```

- Configure `.gitignore` para .NET:

```
bin/
obj/
*.csproj.user
.vscode/
  
```

---

### 🛠️ Ferramentas Complementares

- **Postman**: Teste APIs criadas com ASP.NET Core.
- **Docker Desktop**: Para rodar aplicações .NET em contêineres.
- **SQL Server Management Studio**: Para projetos com bancos de dados.

---

### 📅 Exemplo prático de Calculadora:

```csharp

using System;

namespace MinhaCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo à Calculadora .NET!");
            Console.WriteLine("Digite o primeiro número:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escolha a operação (+, -, *, /):");
            char operacao = Console.ReadKey().KeyChar;
            Console.WriteLine();

            double resultado = 0;
            switch (operacao)
            {
                case '+': resultado = num1 + num2; break;
                case '-': resultado = num1 - num2; break;
                case '*': resultado = num1 * num2; break;
                case '/': resultado = num2 != 0 ? num1 / num2 : throw new DivideByZeroException("Divisão por zero!"); break;
                default: throw new InvalidOperationException("Operação inválida!");
            }

            Console.WriteLine($"Resultado: {num1} {operacao} {num2} = {resultado}");
        }
    }
}

```

### Como rodar o projeto:

1. Crie o projeto:

```bash

dotnet new console -n MinhaCalculadora
cd MinhaCalculadora

```
2. Substitua o conteúdo de `Program.cs` pelo código acima.
3. Execute:

```bash

dotnet run
   
```

---

## 🛠️ Solução de Problemas

- **Erro: "dotnet não é reconhecido"**
  - **Causa**: .NET SDK não está no PATH.
  - **Solução**: Reinstale o SDK ou adicione ao PATH:
```bash

export PATH=$PATH:/usr/share/dotnet
    
```
- **Erro: "OmniSharp não inicia no VS Code"**
  - **Causa**: Extensão C# ou SDK mal configurados.
  - **Solução**: Reinstale a extensão C# e verifique o SDK com `dotnet --info`.
- **Erro: "Projeto não compila por falta de dependências"**
  - **Solução**: Restaure pacotes:
```bash

dotnet restore

```

---

#### 📚 Recursos Complementares

- [Microsoft Learn: .NET](https://learn.microsoft.com/pt-br/dotnet/core/tutorials/)
- [DIO: Bootcamp WEX](https://dio.me)
- [Discord .NET Community](https://discord.com/invite/dotnet)
- [VS Code + .NET Tutorial](https://www.youtube.com/watch?v=YEtisxQugew)

---

#### 🎓 Vídeos e Tutoriais Gratuitos

- [Instalando Visual Studio](https://www.youtube.com/watch?v=s5bi_8y6bLQ)
- [IDE p/ C#](https://www.youtube.com/watch?v=LwGXtxDSmeg)
- [Configurando VS Code com C# .Net SDK](https://www.youtube.com/watch?v=YEtisxQugew)
- [Domine o .NET CLI com Esses 5 Comandos Essenciais!](https://www.youtube.com/watch?v=0H-K_-E6hRM)

---

#### 📌 Extras úteis

- [Terminal integrado do VS Code](https://code.visualstudio.com/docs/editor/integrated-terminal)
- [Extensões úteis no VS Code](https://marketplace.visualstudio.com/)
- [Tutorial de VS Code com .NET](https://www.youtube.com/watch?v=YEtisxQugew).
- [Microsoft Learn: Configurar o Ambiente .NET](https://learn.microsoft.com/pt-br/dotnet/core/tutorials/).

---

#### ✅ Conclusão

Você agora:

* Entende o papel de uma **IDE**
* Sabe a diferença entre **SDK e Runtime**
* Consegue instalar e configurar o ambiente para programar em .NET

🎯 Escolha a IDE que **melhor combina com seu estilo**, e **comece a praticar**.

---

##### ✍️ Seção criada por: *Fabio Zanneti* - 🎯 Bootcamp: **WEX - End to End Engineering**
[![GitHub](https://img.shields.io/badge/GitHub-fzanneti-181717?style=flat&logo=github)](https://github.com/fzanneti)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-fzanneti-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/fzanneti)