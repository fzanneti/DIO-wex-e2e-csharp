# **IDEs e Configuração do Ambiente .NET**

#### **Introdução**

Antes de escrever seu primeiro código em C#, você precisa preparar seu ambiente de desenvolvimento. Isso envolve instalar as ferramentas certas, escolher a IDE ideal e entender a diferença entre o .NET SDK e o .NET Runtime. Nesta aula, vamos explorar os principais ambientes de desenvolvimento usados na plataforma .NET.

---

### **Conceitos Principais**

#### **O que é uma IDE?**

**IDE (Integrated Development Environment)** é um ambiente integrado que reúne ferramentas como editor de código, depurador, compilador e terminal. IDEs tornam o desenvolvimento mais produtivo.

---

#### **Principais IDEs para .NET**

|IDE|Indicado para...|Plataforma|Gratuito?|
|:---:|:---:|:---:|:---:|
|Visual Studio| Profissionais e grandes projetos|Windows/Mac|Sim (Community)|
|Visual Studio Code|Leve, multiplataforma, extensível|Win/Mac/Linux|Sim|
|Rider (JetBrains)|Alternativa robusta ao VS| Win/Mac/Linux|Não (trial)|

---

#### **Visual Studio (VS)**

- Ferramenta oficial da Microsoft para desenvolvimento em .NET.
- Interface amigável, integração completa com C#, ASP.NET, Windows Forms, etc.
- Possui recursos como IntelliSense, Designer, Live Debugging, etc.
- Recomendado para quem vai trabalhar com grandes aplicações ou soluções corporativas.

---

#### **Visual Studio Code (VS Code)**

- Editor de código leve e extensível.
- Precisa de **extensões** para funcionar com C# e .NET.
- Ideal para quem deseja controle total sobre o ambiente, usando o terminal.

---

#### **Extensões úteis para VS Code:**

- **C# for Visual Studio Code** (by Microsoft)
- **.NET Install Tool**
- **Debugger for C#**
- **Code Spell Checker** (qualidade do código)
- **GitLens** (controle de versão)

[Documentação oficial do VS Code + .NET](https://learn.microsoft.com/pt-br/dotnet/core/tutorials/with-visual-studio-code)

---

#### **Rider (JetBrains)**

- IDE paga com recursos avançados.
- Excelente para quem já trabalha com ferramentas JetBrains (como o IntelliJ).
- Integração nativa com ferramentas de teste, Docker, Git e outros.

---

#### **Instalando o .NET SDK**

**SDK** (Software Development Kit) é o pacote completo que inclui:

* Compiladores
* Ferramentas de linha de comando (`dotnet`)
* Bibliotecas base para desenvolvimento

**Runtime** é o pacote necessário apenas para executar aplicações, e **não permite desenvolvimento**.

---

#### **Comparativo:**

|Característica|.NET SDK|.NET Runtime|
|:---:|:---:|:---:|
|Desenvolver apps |✅|❌|
|Executar apps|✅|✅|
|CLI `dotnet`|✅|⚠️ Limitado|

[Download oficial do .NET SDK](https://dotnet.microsoft.com/en-us/download)

---

### **Instalando o Visual Studio Code + Extensões**

#### **Passo a passo:**

1. Baixe o VS Code em: [https://code.visualstudio.com](https://code.visualstudio.com)
2. Instale a extensão `C# for VS Code (powered by OmniSharp)`
3. Instale o .NET SDK separadamente
4. Verifique instalação com:

```bash
dotnet --version
```

5. Crie seu primeiro projeto:

```bash
dotnet new console -n MeuApp
cd MeuApp
dotnet run
```

---

## **Conclusão**

Você agora entende a importância das IDEs, a diferença entre SDK e Runtime, e como configurar o ambiente para começar com .NET. Escolha a ferramenta que mais se adapta ao seu perfil e siga em frente!

---

## **Materiais Complementares**

* [Documentação oficial do .NET](https://learn.microsoft.com/pt-br/dotnet/)
* [Curso gratuito de C# e .NET na DIO](https://web.digitalinnovation.one/)
* [JetBrains Rider](https://www.jetbrains.com/rider/)
* [Como configurar o VS Code para .NET](https://www.youtube.com/watch?v=oyJIGeEYb8Y)

---

##### Seção criada por: *Fabio Zanneti - Projeto: WEX - End to End Engineering* - Guia de estudos.
