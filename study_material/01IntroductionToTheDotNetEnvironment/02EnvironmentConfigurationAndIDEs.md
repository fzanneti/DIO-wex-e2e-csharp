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

> Configurar um ambiente de desenvolvimento .NET eficiente é o primeiro passo para criar aplicações robustas e escaláveis. Escolher a IDE certa e instalar as ferramentas corretas (como o .NET SDK) permite que você foque no aprendizado de C# e no desenvolvimento de projetos, sem preocupações com problemas de configuração. Este guia vai te orientar passo a passo para começar com confiança.

Antes de escrever seu primeiro código em **C#**, você precisa configurar seu ambiente de desenvolvimento.

Isso inclui:

- 📥 Instalar ferramentas e SDKs
- 🧠 Escolher a IDE ideal
- 🔍 Entender a diferença entre **.NET SDK** e **.NET Runtime**

---

## 🧠 Conceitos Principais

### 💻 O que é uma IDE?

**IDE (Integrated Development Environment)** é um ambiente completo que combina:

- ✏️ Editor de código
- 🧪 Depurador
- ⚙️ Compilador
- 💻 Terminal embutido

Tudo para aumentar sua produtividade como desenvolvedor.

---

### 📌 O papel do OmniSharp no suporte ao C# no VS Code

O **OmniSharp** é uma ferramenta de código aberto fundamental que transforma o **VS Code** (Visual Studio Code) em um ambiente de desenvolvimento robusto e completo para C#. Ele atua como um servidor de linguagem, fornecendo recursos avançados que tornam a codificação em C# muito mais eficiente e produtiva.

Pense no OmniSharp como o "cérebro" por trás das funcionalidades inteligentes do VS Code para C#. Sem ele, o VS Code seria apenas um editor de texto básico para seus arquivos C#. Com o OmniSharp, você obtém:

* **Preenchimento de código (IntelliSense):** À medida que você digita, o OmniSharp sugere nomes de classes, métodos, propriedades e variáveis, acelerando o desenvolvimento e reduzindo erros.
* **Análise de código e diagnóstico:** Ele identifica erros de sintaxe, problemas de lógica e sugere melhorias em tempo real, ajudando a manter a qualidade do código.
* **Navegação e refatoração:** Permite navegar rapidamente entre definições de código, encontrar referências, renomear símbolos de forma segura e aplicar outras refatorações úteis.
* **Depuração:** Embora o depurador em si seja uma extensão separada do VS Code, o OmniSharp fornece as informações de contexto necessárias para que o depurador funcione de forma eficaz com seu código C#.
* **Gerenciamento de projetos:** Ele entende a estrutura dos seus projetos C# (arquivos `.csproj` e `.sln`), permitindo que o VS Code trabalhe com soluções complexas.

Em essência, o OmniSharp integra as capacidades de um IDE (Ambiente de Desenvolvimento Integrado) completo dentro da leveza e flexibilidade do VS Code, tornando-o uma escolha popular para desenvolvedores C#.

---

### ⚠️ A importância de um ambiente configurado para CI/CD e colaboração em equipe

Além da ferramenta de desenvolvimento individual, a eficiência de uma equipe de software depende criticamente de um **ambiente bem configurado para CI/CD (Integração Contínua/Entrega Contínua) e colaboração**. Isso vai muito além do editor de código e impacta diretamente a velocidade, qualidade e comunicação do desenvolvimento.

### 🔄 Integração Contínua (CI)

A **Integração Contínua** é a prática de integrar o código de todos os desenvolvedores em um repositório compartilhado várias vezes ao dia. Cada integração é verificada por um build automatizado, incluindo testes. A importância de um ambiente configurado para CI reside em:

* **Detecção precoce de erros:** Problemas de integração e bugs são identificados rapidamente, tornando-os mais fáceis e baratos de corrigir.
* **Redução de conflitos:** Integrar com frequência minimiza a chance de grandes conflitos de código entre as contribuições dos desenvolvedores.
* **Garantia de qualidade:** Testes automatizados (unitários, de integração, etc.) são executados a cada commit, garantindo que novas alterações não quebrem funcionalidades existentes.
* **Feedback rápido:** Desenvolvedores recebem feedback instantâneo sobre a integridade do seu código.

### 📦 Entrega Contínua (CD)

A **Entrega Contínua** estende a CI, garantindo que o software possa ser liberado de forma confiável a qualquer momento. Isso significa que, após a CI, o código está pronto para ser implantado em ambientes de teste ou produção. Um ambiente de CD bem configurado oferece:

* **Implantações automatizadas:** O processo de lançamento é automatizado, reduzindo erros manuais e acelerando a entrega.
* **Maior confiança nas liberações:** Como o processo é automatizado e testado, há mais confiança de que as novas versões funcionarão conforme o esperado.
* **Ciclos de feedback mais curtos:** Novas funcionalidades chegam aos usuários mais rapidamente, permitindo coletar feedback e iterar com agilidade.

### 🤝 Colaboração em Equipe

Um ambiente que suporta CI/CD é, por natureza, propício à **colaboração em equipe**. Além disso, outros aspectos são cruciais:

* **Sistema de controle de versão (Git):** Um VCS centralizado e bem utilizado é o alicerce da colaboração, permitindo que múltiplos desenvolvedores trabalhem no mesmo código sem sobrescrever o trabalho uns dos outros.
* **Padronização:** Ferramentas, configurações de linter e formatadores de código padronizados garantem que todos os membros da equipe sigam as mesmas convenções, tornando o código mais legível e fácil de manter.
* **Revisão de código (Code Review):** Plataformas como GitHub ou GitLab facilitam a revisão de código, onde os colegas podem fornecer feedback, identificar problemas e compartilhar conhecimento.
* **Automação de tarefas:** Scripts e ferramentas automatizadas para builds, testes e implantações liberam os desenvolvedores de tarefas repetitivas, permitindo que se concentrem em desenvolver novas funcionalidades.
* **Documentação acessível:** Ter documentação clara e fácil de encontrar (arquitetura, APIs, processos) é vital para a integração de novos membros da equipe e para garantir que todos estejam alinhados.

> 📝 Em resumo, enquanto o OmniSharp aprimora a experiência de desenvolvimento C# individual no VS Code, um ambiente robusto de CI/CD e colaboração em equipe eleva a produtividade e a qualidade do software em escala, garantindo que o código seja integrado, testado e entregue de forma eficiente e confiável.

---

### 🧰 Principais IDEs para .NET

| 🧩 IDE                | 💼 Indicado para...                | 🖥️ Plataforma       | 💸 Gratuito?        |
|----------------------|------------------------------------|---------------------|---------------------|
| **Visual Studio**     | Profissionais e grandes projetos   | Windows / macOS     | ✅ Sim (Community)  |
| **Visual Studio Code**| Projetos leves e multiplataforma  | Win / macOS / Linux | ✅ Sim              |
| **Rider (JetBrains)** | Alternativa robusta e avançada     | Win / macOS / Linux | ⚠️ Não (trial)      |

---

### 🧪 Visual Studio (VS)

- Ferramenta oficial da **Microsoft**.
- Suporte completo a C#, ASP.NET, Windows Forms, etc.
- Recursos como:
  - IntelliSense
  - Designer
  - Live Debugging
- Recomendado para **grandes soluções corporativas**.

---

### 📝 Visual Studio Code (VS Code)

- Editor leve e altamente extensível.
- Requer **extensões** para suporte completo ao .NET.
- Ideal para quem prefere terminal, controle fino e velocidade.

#### 🔌 Extensões úteis para VS Code

- `C# for Visual Studio Code` (by Microsoft)
- `.NET Install Tool`
- `Debugger for C#`
- `Code Spell Checker` (qualidade de código)
- `GitLens` (versões e histórico Git)

📘 [Documentação oficial do VS Code + .NET](https://learn.microsoft.com/pt-br/dotnet/core/tutorials/with-visual-studio-code)

---

### 💼 Rider (JetBrains)

- IDE paga e avançada.
- Ideal para quem já usa ferramentas JetBrains (como IntelliJ).
- Recursos nativos:
  - Testes
  - Docker
  - Git
  - Debugger avançado

🌐 [Site oficial do Rider](https://www.jetbrains.com/rider/)

---

## ⚙️ Instalando o .NET SDK

### 📦 O que vem no SDK?

- Compiladores
- CLI `dotnet`
- Bibliotecas padrão para desenvolvimento

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

📥 [Download oficial do SDK](https://dotnet.microsoft.com/en-us/download)

---

## 💡 Instalando o VS Code + Extensões

### 🧭 Passo a passo

1. 🔽 Baixe o VS Code: [https://code.visualstudio.com](https://code.visualstudio.com)
2. 🧩 Instale a extensão `C# for VS Code (powered by OmniSharp)`
3. 📦 Instale o .NET SDK separadamente
4. 🧪 Verifique instalação:

```bash

dotnet --version

```

5. 🚀 Crie seu primeiro projeto:

```bash

dotnet new console -n MeuApp
cd MeuApp
dotnet run

```

> 📝 Esse comando gera uma aplicação console simples em C#.

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

---

#### ✅ Conclusão

Agora você:

* Entende o papel de uma **IDE**
* Sabe a diferença entre **SDK e Runtime**
* Consegue instalar e configurar o ambiente para programar em .NET

🎯 Escolha a IDE que **melhor combina com seu estilo**, e **comece a praticar**.

---

##### ✍️ Seção criada por: *Fabio Zanneti* - 🎯 Bootcamp: **WEX - End to End Engineering**
[![GitHub](https://img.shields.io/badge/GitHub-fzanneti-181717?style=flat&logo=github)](https://github.com/fzanneti)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-fzanneti-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/fzanneti)
