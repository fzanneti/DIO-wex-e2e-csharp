# 🛠️ IDEs e Configuração do Ambiente .NET

### 🎯 Introdução

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

#### ✅ Conclusão

Agora você:

* Entende o papel de uma **IDE**
* Sabe a diferença entre **SDK e Runtime**
* Consegue instalar e configurar o ambiente para programar em .NET

🎯 Escolha a IDE que **melhor combina com seu estilo**, e **comece a praticar**.

---

> ##### ✍️ **Seção criada por:** *Fabio Zanneti*
> ##### 🎯 Projeto: **WEX - End to End Engineering**
> ##### 📁 *Guia de estudos estruturado para GitHub*