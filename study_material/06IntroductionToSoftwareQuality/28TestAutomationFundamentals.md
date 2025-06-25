# 🧪 Fundamentos de Automação de Testes

## 📌 1. Introdução

A automação de testes é um dos pilares para garantir qualidade de software de forma escalável e ágil. Com a evolução das metodologias ágeis e da entrega contínua (CI/CD), a automação deixou de ser um diferencial e se tornou uma necessidade.

### 🔍 Por que automatizar testes?

- **Agilidade nas entregas**: reduz o tempo de execução dos testes manuais.
- **Redução de erros humanos**: testes automatizados executam sempre da mesma forma.
- **Cobertura de testes**: permite verificar mais cenários em menos tempo.
- **Feedback rápido**: detecta falhas logo após alterações no código.
- **Suporte à integração contínua**: testes automatizados são parte essencial do pipeline.

---

## 🧱 2. Fundamentos para projetos de automação

Antes de iniciar a automação, é importante entender os princípios e etapas que guiam um projeto eficiente:

### 🔸 Planejamento

- **Objetivo dos testes**: o que será validado?
- **Ambiente de testes**: onde os testes serão executados?
- **Escopo da automação**: quais testes são candidatos à automação (ex: testes repetitivos, de regressão, etc.)?

### 🔸 Pirâmide de Testes

A pirâmide de testes ajuda a entender onde aplicar a automação:

```

       UI (Testes de Interface)  👆
         ↑    Mais lentos
         |    Menor quantidade
       API (Testes de Integração)
         |
       Unitários (Testes de Unidade) 👇
         ↓    Mais rápidos
         ↓    Maior quantidade

```

- **Base (Testes Unitários)**: valem cada função isoladamente.
- **Meio (Testes de Integração/API)**: validam a comunicação entre módulos.
- **Topo (Testes de UI)**: simulam interações do usuário com o sistema.

### 🔸 Boas práticas

- ❌ **Não automatizar tudo**: nem todo teste precisa ou deve ser automatizado.
- ✅ **Testes devem ser reexecutáveis**: sempre que rodados, devem dar o mesmo resultado.
- ✅ **Isolamento de dados**: cada teste deve ter seus próprios dados ou resetar o estado antes de começar.
- ✅ **Feedback rápido**: testes devem ser rápidos e rodar em pipelines de CI/CD.

---

## 🛠️ 3. Ferramentas de Suporte e Testes

Aqui estão algumas das principais ferramentas utilizadas em automação de testes, divididas por categoria:

### 📦 Frameworks de Testes

| Tipo de Teste       | Linguagem       | Ferramentas Populares                 |
|---------------------|------------------|----------------------------------------|
| Testes Unitários    | Java, C#, Python | JUnit, NUnit, xUnit, PyTest            |
| Testes de API       | Multi            | RestAssured, Postman, SoapUI           |
| Testes de UI        | JavaScript, Java, Python | Selenium, Cypress, Playwright       |

### ⚙️ Suporte à automação

- **Build e CI/CD**: Jenkins, GitHub Actions, GitLab CI, Azure DevOps
- **Gerenciamento de dependências**: Maven, Gradle, NPM
- **Geradores de dados**: Faker, Mockaroo
- **Ambientes isolados**: Docker, TestContainers

### 🧪 Ferramentas modernas de testes

| Finalidade             | Ferramentas                |
|------------------------|----------------------------|
| Testes end-to-end      | Cypress, Playwright        |
| Testes mobile          | Appium, Detox              |
| Testes de carga        | JMeter, k6, Gatling        |
| Mock de serviços       | WireMock, MockServer       |

---

#### 🧠 Conclusão

A automação de testes é essencial para aumentar a qualidade e a confiança nas entregas. Mais do que saber usar ferramentas, é importante entender **quando**, **como** e **por que** automatizar.

Comece pequeno, com testes unitários bem definidos, e vá evoluindo para testes de integração e UI, respeitando a pirâmide de testes. Um projeto de automação bem planejado pode economizar tempo, dinheiro e dores de cabeça.

---

### 📚 Referências

- [Test Automation University - by Applitools](https://testautomationu.applitools.com/)
- [Guia oficial do Selenium](https://www.selenium.dev/documentation/)
- [Documentação do Cypress](https://docs.cypress.io/)
- [Padrões de automação de testes (Martin Fowler)](https://martinfowler.com/)

---

# 🏗️ Arquitetura Genérica e Design para Automação

## 🧠 1. Revisitando Conceitos de Arquitetura de Software

Antes de mergulharmos na arquitetura de automação de testes, vale relembrar alguns conceitos fundamentais de arquitetura de software:

### 🧱 O que é Arquitetura de Software?

> Conjunto de decisões estruturais sobre o sistema, que define sua organização, componentes, relacionamentos e princípios de design.

### 🧩 Princípios importantes:

- **Modularidade**: separar responsabilidades em módulos ou camadas.
- **Reutilização**: componentes reutilizáveis evitam retrabalho.
- **Manutenibilidade**: código organizado e padronizado facilita mudanças.
- **Escalabilidade**: deve comportar crescimento da aplicação/testes.
- **Separação de responsabilidades (SoC)**: cada classe/componente com uma função clara.

---

## 🏗️ 2. Arquitetura do Projeto de Automação

Projetos de automação também precisam seguir uma **arquitetura bem definida**, tanto para facilitar a escalabilidade quanto para garantir qualidade nos testes automatizados.

### 🔧 Componentes básicos de uma arquitetura de automação:

```

/tests   
\|- unit/   
\|- integration/   
\|- e2e/   
\|- fixtures/   
\|- data/    
\|- utils/   
\|- drivers/   
\|- reports/   
\|- config/   

```

### 💡 Design orientado para testes

- **Page Object Model (POM)**  
  Separa o código de navegação/interação (páginas) da lógica dos testes.  
  Exemplo:

```csharp

  // LoginPage.cs
  public class LoginPage {
      public void EnterUsername(string username) { ... }
      public void ClickLogin() { ... }
  }

```

* **Factory Pattern**
  Criação de objetos reutilizáveis para testes.

* **Camadas de abstração**
  Evita acoplamento direto com frameworks (ex: WebDriver ou Requests).

---

## ⚠️ 3. O que devemos considerar antes de iniciar um projeto

A arquitetura deve ser pensada **antes de escrever o primeiro teste**. Veja o que avaliar:

### ✅ Check-list inicial:

* **Quais tipos de testes?** (unitários, API, UI, performance, etc.)
* **Qual linguagem e frameworks serão usados?**
* **Qual ferramenta de CI/CD integrará os testes?**
* **Qual será a estratégia de execução?** (em paralelo, ambiente dedicado, containers, etc.)
* **Precisaremos de mocks, stubs ou dados gerados?**
* **Qual será o padrão de nomenclatura e organização de pastas?**
* **Os testes terão dados dinâmicos ou dados fixos?**
* **Os testes irão rodar em múltiplos ambientes (QA, dev, staging)?**

---

## 🧭 4. Abordagens para Automação

Existem diferentes **abordagens arquiteturais** para implementar automação. A escolha depende do contexto, escopo e maturidade da equipe.

### 🔹 Abordagem Modular

* Código dividido por funcionalidades (login, cadastro, pedidos, etc.)
* Boa organização e fácil manutenção
* Facilita a reutilização de componentes

### 🔹 Abordagem Camadas (Layered Testing Architecture)

Separação clara por camadas:

```

- Testes (specs)
- Serviços (requisições, APIs)
- Pages (UI e componentes)
- Helpers (utilitários)
- Data (fixtures, dados mockados)

```

### 🔹 Abordagem de Domínio (DDD + Testes)

* Organiza o código com base em **conceitos de negócio**
* Mais utilizada em empresas com testes altamente integrados ao código de produção

### 🧪 Frameworks que suportam essas arquiteturas:

| Linguagem  | Framework           | Suporte a Design Patterns |
| ---------- | ------------------- | ------------------------- |
| Java       | JUnit, TestNG       | Sim                       |
| JavaScript | Cypress, Playwright | Sim                       |
| Python     | PyTest              | Sim                       |
| C#         | NUnit, SpecFlow     | Sim                       |

---

#### 🎯 Conclusão

A arquitetura de um projeto de automação é **tão importante quanto o código dos testes**. Uma estrutura bem pensada:

* Evita retrabalho
* Permite reuso
* Facilita manutenção e evolução
* Suporta crescimento da base de testes
* Garante maior qualidade e agilidade

> ⚠️ **Automatizar sem planejamento é como construir um prédio sem fundação.**

---

### 📚 Referências

* [Page Object Model - Selenium Docs](https://www.selenium.dev/documentation/test_practices/encouraged/page_object_models/)
* [Arquitetura de Testes Automatizados - ThoughtWorks](https://www.thoughtworks.com)
* [Clean Architecture for Test Automation – Medium](https://medium.com/testvagrant/clean-architecture-for-test-automation-7a3f7cdecf3c)

---

# 🧩 Padrões de Projeto para Testes E2E

Este módulo apresenta os principais padrões utilizados em projetos de testes **End-to-End (E2E)**. Esses padrões facilitam a **organização**, **manutenção** e **reutilização** de código de testes, permitindo criar soluções escaláveis e profissionais.

---

## 🧱 1. Padrões de Projeto para Automação E2E

Automação E2E foca em **simular o comportamento do usuário** final no sistema, testando a aplicação do início ao fim (login, compras, fluxo completo...).

### 🎯 Desafios da automação E2E:

- Alta complexidade de cenários
- Mudanças constantes na interface
- Riscos de flakiness (testes intermitentes)
- Dificuldade de manutenção

Para enfrentar esses desafios, usamos **padrões de design** consolidados na engenharia de software.

---

## 🧭 2. Conhecendo o Business Layer + Page Object Pattern

O **Page Object Pattern (POM)** é um dos mais usados para testes E2E. Ele isola os elementos da interface em **objetos de página**, facilitando a manutenção.

### 🧱 Page Object

```csharp

public class LoginPage {
    private IWebDriver driver;

    public LoginPage(IWebDriver driver) {
        this.driver = driver;
    }

    public void EnterUsername(string username) =>
        driver.FindElement(By.Id("username")).SendKeys(username);

    public void ClickLogin() =>
        driver.FindElement(By.Id("loginBtn")).Click();
}

````

### 🧠 Business Layer (Camada de Negócio)

Aqui entramos com uma **camada intermediária** entre os testes e os page objects, encapsulando as regras de negócio.

```csharp

public class LoginFlow {
    private LoginPage loginPage;

    public LoginFlow(IWebDriver driver) {
        this.loginPage = new LoginPage(driver);
    }

    public void LoginAsAdmin() {
        loginPage.EnterUsername("admin");
        loginPage.ClickLogin();
    }
}

```

📌 **Vantagens**:

* Baixo acoplamento
* Alta reutilização
* Facilidade de leitura dos testes

---

## 🎭 3. Conhecendo o Screenplay Pattern

O **Screenplay Pattern** é uma evolução do Page Object, baseado na **programação orientada a atores**. Foi criado para tornar os testes mais legíveis, reutilizáveis e modulares.

### 👤 Conceitos principais:

* **Atores (Actors)**: representam usuários reais ou virtuais.
* **Tarefas (Tasks)**: ações que o ator realiza.
* **Perguntas (Questions)**: verificações que o ator faz.
* **Interações (Interactions)**: comandos como clicar, digitar, etc.

### 🔧 Exemplo (pseudo-código):

```csharp

Actor gabriel = Actor.named("Gabriel");
gabriel.can(BrowseTheWeb.with(driver));

gabriel.attemptsTo(
    Login.withCredentials("user", "pass"),
    Click.on(SubmitButton)
);

gabriel.should(seeThat(WelcomeMessage.isVisible()));

```

📌 **Vantagens**:

* Alto nível de abstração
* Modularização de tarefas
* Fácil manutenção e leitura
* Escalável para projetos grandes

🧪 Ferramentas que suportam:

* Serenity BDD (Java)
* Boa prática também com SpecFlow, RestAssured, etc.

---

## 🎮 4. Conhecendo o App Actions

O padrão **App Actions** organiza as ações do app em **componentes reutilizáveis de alto nível**, aproximando o código de teste à experiência real do usuário.

### 📦 Estrutura comum:

```

/Pages
  |- LoginPage.cs
  |- ProductPage.cs

/Actions
  |- LoginActions.cs
  |- ProductActions.cs

/Tests
  |- LoginTest.cs

/Utils
  |- WebDriverFactory.cs

```  

Em C#, a abordagem seria baseada em:

- Classes de Ações (Actions) → encapsulam comportamentos do usuário
- Classes de Páginas (Page Objects) → encapsulam a interface e elementos
- Testes → usam as Actions para compor cenários

### 🔧 Exemplo (C# + Cypress):

```csharp

// Pages/LoginPage.cs
public class LoginPage
{
    private IWebDriver driver;

    public LoginPage(IWebDriver driver) => this.driver = driver;

    public void FillUsername(string username) =>
        driver.FindElement(By.Id("username")).SendKeys(username);

    public void FillPassword(string password) =>
        driver.FindElement(By.Id("password")).SendKeys(password);

    public void Submit() =>
        driver.FindElement(By.Id("loginBtn")).Click();
}

// Actions/LoginActions.cs
public class LoginActions
{
    private readonly IWebDriver driver;
    private readonly LoginPage loginPage;

    public LoginActions(IWebDriver driver)
    {
        this.driver = driver;
        loginPage = new LoginPage(driver);
    }

    public void LoginAs(string username, string password)
    {
        loginPage.FillUsername(username);
        loginPage.FillPassword(password);
        loginPage.Submit();
    }
}

// Tests/LoginTest.cs
[TestClass]
public class LoginTest
{
    private IWebDriver driver;

    [TestInitialize]
    public void SetUp()
    {
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://app.com/login");
    }

    [TestMethod]
    public void LoginAsStandardUser()
    {
        var login = new LoginActions(driver);
        login.LoginAs("standard_user", "secret_sauce");

        Assert.IsTrue(driver.FindElement(By.Id("welcomeMessage")).Displayed);
    }

    [TestCleanup]
    public void TearDown()
    {
        driver.Quit();
    }
}


```

📌 **Vantagens**:

* Isolamento das responsabilidades
* Facilita testes reutilizáveis
* Aproxima o código da linguagem do negócio

---

#### ✅ 5. Conclusão

> ✅ O padrão App Actions é aplicável em **qualquer linguagem**, inclusive **C#**, desde que siga a ideia de **organizar ações de alto nível separadas das páginas**. Ele funciona como uma camada intermediária entre os testes e os objetos de página, facilitando a leitura e a manutenção dos testes E2E.

Cada padrão tem sua **finalidade específica** e pode ser usado **em conjunto** para melhorar a qualidade dos testes E2E.

| Padrão             | Quando usar                                 | Pontos fortes                         |
| ------------------ | ------------------------------------------- | ------------------------------------- |
| Page Object        | Projetos pequenos a médios                  | Fácil implementação e leitura         |
| Business Layer     | Quando há lógica de negócio no fluxo        | Encapsula regras e melhora manutenção |
| Screenplay Pattern | Projetos grandes e complexos                | Altamente modular, escalável          |
| App Actions        | Projetos JS modernos com Cypress/Playwright | Reuso, clareza, flexível              |

> 🎯 **Recomenda-se sempre começar simples (POM) e evoluir conforme o projeto crescer.**

---

### 📚 Referências

* [Screenplay Pattern - Serenity Docs](https://serenity-bdd.info/docs/screenplay/)
* [Page Object Model - Selenium](https://www.selenium.dev/documentation/test_practices/encouraged/page_object_models/)
* [Design Patterns for Test Automation - Medium](https://medium.com/testautomation)
* [Cypress Best Practices](https://docs.cypress.io/guides/references/best-practices)

---

##### ✍️ **Seção criada por:** *Fabio Zanneti* 🎯 Projeto: **WEX - End to End Engineering**