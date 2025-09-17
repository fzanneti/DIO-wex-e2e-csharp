# WEX - End to End Engineering

## 6.1 - Introdução ao Mercado de Qualidade de Software

![GitHub repo size](https://img.shields.io/github/repo-size/fzanneti/wex-e2e-csharp)
![GitHub forks](https://img.shields.io/github/forks/fzanneti/wex-e2e-csharp?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/fzanneti/wex-e2e-csharp?style=social)
![Bootcamp](https://img.shields.io/badge/WEX-End--to--End%20Engineering-blueviolet?logo=vercel&logoColor=white)
![Plataforma](https://img.shields.io/badge/Powered%20by-DIO.io-red?logo=data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjZmZmIiB2aWV3Qm94PSIwIDAgMzIgMzIiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PHBhdGggZD0iTTYuNzEgMy4yNWMtMi44OCAxLjQxLTUuMDcgNC4yMy01LjA3IDcuNzYgMCAzLjU4IDIuMjggNi43IDUuMzMgOC4xNSAxLjgzLS42MiAyLjQtMi4yNiAyLjQtMy44MSAwLS4yMy0uMDItLjQ1LS4wNS0uNjZBLjQ0LjQ0IDAgMDExMC4xIDExYy4yNC0uNzUuMTEtMS41My0uMy0yLjIyQzguOTIgNy45NiA3LjMzIDcuNSA1Ljc0IDcuNjZhNS41NSA1LjU1IDAgM)
![Autor](https://img.shields.io/badge/Autor-fzanneti-blue?style=flat-square&logo=github)

---

No Bootcamp WEX, você está aprendendo a construir aplicações robustas com C#, .NET, Git, GitHub, SQL Server, e MongoDB. Qualidade de Software (QA) é essencial para garantir que essas aplicações atendam aos requisitos, sejam confiáveis e ofereçam uma boa experiência ao usuário. Este módulo explora o mercado de QA, suas tendências, habilidades técnicas e soft skills necessárias, além de práticas de automação com ferramentas integradas ao ecossistema .NET, preparando você para se destacar em uma carreira estratégica e de alta demanda.

Qualidade de Software (QA) é a área responsável por garantir que uma aplicação funcione como esperado, seja confiável, segura e ofereça uma boa experiência ao usuário. No contexto do Bootcamp WEX, onde você tá aprendendo C#, .NET, Git, GitHub, SQL Server e MongoDB, o QA é o que une todas essas tecnologias para entregar um produto final que atenda aos requisitos do cliente e do negócio. Pense no QA como o "fiscal" que valida se o software que você tá construindo é top, sem bugs críticos e com desempenho sólido.

**Por que é importante?** 

Sem QA, você pode ter um código lindo em C# ou um banco de dados bem estruturado no SQL Server, mas se o sistema trava, tem brechas de segurança ou não faz o que o cliente espera, o projeto vai pro brejo. O QA ajuda a prevenir isso, garantindo que cada parte do desenvolvimento — desde o código até a integração com bancos como MongoDB — esteja alinhada com os objetivos.

Usamos Git/GitHub para versionar código, SQL Server/MongoDB para gerenciar dados e .NET para construir aplicações. O QA entra pra garantir que tudo isso funcione em harmonia, com testes que verificam desde a lógica do backend até a experiência do usuário final.

---

### Mercado e Tendências

O mercado de tecnologia tá bombando, e o QA é uma peça-chave nesse crescimento. A transformação digital tá fazendo empresas de todos os setores (bancos, varejo, saúde) dependerem de software, e isso aumenta a demanda por profissionais de QA. 

O **World Quality Report 2023-24** citado no material destaca que 72% das empresas tão investindo mais em QA porque sabem que um software mal testado pode custar caro — tanto em dinheiro quanto em reputação.

Imagine que você desenvolveu um e-commerce com .NET e MongoDB. Se o sistema deixa o cliente finalizar uma compra, mas o pedido não é registrado por um bug, a empresa perde vendas e o cliente fica frustrado. O QA evita isso com testes que simulam cenários reais.

**Tendências:**

- **Transformação digital:** Empresas tão migrando tudo pra nuvem (AWS, Azure) e precisam de QA pra garantir que essas transições sejam seguras.
- **IA e automação:** Ferramentas de teste com inteligência artificial, como o Testim, aprendem padrões e otimizam testes.
- **E-commerce:** Com o crescimento das compras online, o QA garante que plataformas sejam rápidas e seguras (ex.: validar pagamentos com PCI-DSS).

> As habilidades em C# e .NET te preparam pra criar sistemas robustos, mas o QA te ensina a testar essas aplicações em cenários reais, como os de e-commerce ou sistemas em nuvem.

---

### Contextualização do Mercado de TI e de QA

O mercado de TI tá mudando rápido, e o QA tá acompanhando essa evolução. Antes, o QA era visto como a última etapa do desenvolvimento, onde alguém testava o software pronto pra encontrar erros. Hoje, com metodologias ágeis (como Scrum) e DevOps, o QA tá presente desde o começo, trabalhando junto com desenvolvedores, analistas de negócio e até designers. Isso é chamado de **Shift-Left Testing**, que significa trazer a mentalidade de qualidade pro início do projeto.

- No Scrum, você participa de sprints onde o time define requisitos. Como QA, você já pode sugerir testes pra validar esses requisitos antes mesmo do código em C# ser escrito, garantindo que o sistema seja testável desde o design.
- Em metodologias ágeis, o software é entregue em pedaços pequenos e frequentes (iterações). O QA precisa ser rápido e integrado ao pipeline de CI/CD (integração e entrega contínua), usando ferramentas como GitHub Actions pra rodar testes automaticamente a cada commit.

---

### Principais Fatores de Crescimento:

O crescimento da área de QA é impulsionado por três fatores principais:

1. **Metodologias ágeis (Scrum, Kanban):** Essas abordagens exigem entregas rápidas e contínuas, o que aumenta a necessidade de testes constantes. No Scrum, por exemplo, cada sprint (2-4 semanas) gera uma versão do software que precisa ser testada.
2. **DevOps:** Essa cultura une desenvolvimento (Dev) e operações (Ops), com o QA no meio garantindo que o código entregue (via pipelines CI/CD) seja confiável. Ferramentas como Jenkins ou GitHub Actions automatizam esses testes.
3. **Demanda por qualidade:** Clientes esperam apps rápidos, seguros e sem bugs. Um aplicativo lento ou com falhas pode ser abandonado em segundos.

> Um app de banco desenvolvido com .NET precisa ser testado pra garantir que transações no SQL Server sejam seguras e rápidas. O QA usa automação pra simular milhares de transações e validar a performance.

---

### Importância da Qualidade de Software

A qualidade de software é um pilar estratégico pra qualquer empresa que depende de tecnologia. Ela impacta:

- **Custos:** Corrigir um bug depois que o software tá em produção pode custar até 100 vezes mais do que corrigir durante o desenvolvimento. O QA ajuda a identificar problemas cedo.
- **Reputação da marca:** Um app com falhas, como um sistema de e-commerce que trava, pode afastar clientes. Um bom QA garante que o software seja confiável.
- **Conformidade:** Leis como a LGPD (Lei Geral de Proteção de Dados) no Brasil exigem que dados dos usuários sejam protegidos. O QA valida que o software atende a essas regras.
- **Competitividade:** Empresas com software de qualidade (rápido, seguro, intuitivo) se destacam no mercado.

---

### O Presente e Futuro da Área de Qualidade

O QA tá evoluindo de uma área operacional pra uma área estratégica. As principais tendências são:

- **Automação de testes:** Ferramentas como Selenium (pra testes web), Cypress (pra interfaces modernas) e Playwright (pra testes multiplataforma) permitem rodar testes repetitivos de forma rápida. Isso é essencial em pipelines CI/CD.
- **Testes com IA:** Ferramentas como Mabl usam inteligência artificial pra aprender como o software funciona e sugerir testes mais inteligentes.
- **Observabilidade:** Monitorar o comportamento do software em produção (ex.: usando ferramentas como New Relic) ajuda a identificar problemas antes que os usuários percebam.
- **Shift-Left Testing:** Como já mencionado, o QA agora participa desde a definição dos requisitos, garantindo que o software seja projetado com qualidade em mente.

> **Visão de Futuro:** O QA vai deixar de ser apenas um testador pra se tornar um estrategista, influenciando decisões de produto e negócio. Por exemplo, um QA pode sugerir mudanças no design de uma aplicação pra torná-la mais testável ou performática.

---

### Afinal, o que faz um QA?

**Engenharia de Software e Suas Vertentes**

A Engenharia de Software é a disciplina que organiza o desenvolvimento de software com processos estruturados. O QA se encaixa em várias etapas:

- **Análise de Requisitos:** O QA ajuda a validar se os requisitos do cliente são claros e testáveis. Ex.: "O sistema deve processar 1.000 pedidos por segundo" — o QA cria testes pra garantir isso.
- **Design:** O QA sugere como tornar o sistema mais fácil de testar, como modularizar o código em C#.
- **Codificação:** O QA pode revisar o código pra garantir que segue boas práticas, como testes unitários.
- **Validação e Verificação:** O QA executa testes pra confirmar que o software atende aos requisitos (validação) e foi construído corretamente (verificação).

---

### Perfis e Responsabilidades de um QA

O QA não é um papel único — existem diferentes perfis, cada um com responsabilidades específicas:

- **QA Analyst:** Foca em testes manuais, escrevendo casos de teste e verificando o software com base em requisitos. Ex.: testar se um formulário web aceita entradas válidas.
- **QA Engineer:** Escreve scripts de teste automatizados (ex.: usando Selenium com C#) e integra testes ao pipeline de CI/CD.
- **SDET (Software Development Engineer in Test):** É um desenvolvedor especializado em testes, criando frameworks personalizados. Ex.: construir um sistema de testes que simula milhares de usuários acessando uma API.
- **Quality Coach:** Atua como mentor, ensinando o time a adotar práticas de qualidade, como escrever testes unitários no código .NET.

> **Nota:** Cada perfil exige níveis diferentes de conhecimento técnico e visão estratégica.

---

### O Papel das Certificações na Carreira de Qualidade de Software

As certificações em QA aumentam a empregabilidade e validam competências técnicas. As principais são:

- **ISTQB (International Software Testing Qualifications Board):** padrão global que oferece certificações desde o nível fundamental até o avançado.
- **CTFL:** foco em fundamentos.
- **CTAL:** especializações em testes técnicos, de gestão e automação.
- **Certificações Agile:** como **ICP-TST** e **Certified Agile Tester**, que validam habilidades em contextos ágeis.

> **Dica:** As certificações podem ser um diferencial competitivo em processos seletivos e progressão na carreira.

---

### Roadmap de Aprendizagem para Qualidade de Software

**Conhecimentos Técnicos e Conceitos para Ser um Bom QA**

Pra ser um QA completo, você precisa de um mix de habilidades técnicas e conceituais:

- **Linguagens de Programação:** C# (que você tá aprendendo) é ótimo pra automação com Selenium ou Playwright. Python e JavaScript também são comuns.
- **Frameworks de Testes:** Selenium testa aplicações web, Cypress é ideal pra apps modernos com React, e Playwright suporta múltiplas plataformas (web, mobile).
- **Versionamento de Código:** Git/GitHub é essencial pra gerenciar scripts de teste e colaborar com o time.
- **Banco de Dados:** Conhecimento em SQL te ajuda a validar dados no SQL Server ou MongoDB. Ex.: verificar se uma transação foi salva corretamente.
- **CI/CD:** Entender pipelines (ex.: GitHub Actions) pra rodar testes automaticamente.
- **Metodologias Ágeis:** Scrum e Kanban organizam o trabalho em sprints, e o QA participa de reuniões como planning e retrospectivas.

---

### Refletindo Sobre o Mindset de um QA e Seus Soft Skills

Além das habilidades técnicas, o QA precisa de um mindset e soft skills específicas:

- **Mentalidade de Prevenção:** Antecipar problemas, como testar cenários extremos (ex.: o que acontece se o usuário enviar um formulário vazio?).
- **Curiosidade e Investigação:** Explorar o sistema pra encontrar bugs que ninguém previu.
- **Comunicação:** Explicar bugs de forma clara pros desenvolvedores, usando ferramentas como Jira.
- **Trabalho em Equipe:** Colaborar com devs, POs e designers em sprints ágeis.
- **Pensamento Crítico:** Questionar requisitos e sugerir melhorias. Ex.: "Esse botão tá confuso pro usuário, podemos melhorar?"
- **Empatia:** Pensar como o usuário final pra garantir uma boa experiência.

---

### Encerramento do Curso

O material te dá uma visão geral do QA, desde o mercado até as habilidades práticas e soft skills. 

O próximo passo é aplicar o que você aprendeu no Bootcamp WEX em projetos reais, como:
- Criar testes automatizados com Selenium ou Playwright em C#.
- Integrar testes ao pipeline de CI/CD no GitHub.
- Estudar certificações como ISTQB pra se destacar no mercado.

---

### Referências e Leitura Complementar

🔗[World Quality Report 2023-24](https://www.capgemini.com/news/world-quality-report-2023-24/)     
🔗[ISTQB](https://www.istqb.org/)     
🔗[Selenium](https://www.selenium.dev/)     
🔗[Cypress](https://www.cypress.io/)    
🔗[Scrum Guide](https://scrumguides.org/)    
🔗[Playwright](https://playwright.dev/)    

---

### Certificado

<img src="https://github.com/fzanneti/DIO-wex-e2e-csharp/blob/main/Assets/images/certificados/28-introducao-ao-mercado-de-qualidade-de-software.jpg" alt="Certificado" width="600px">

---

##### ✍️ Seção criada por: *Fabio Zanneti* - 🎯 Bootcamp: **WEX - End to End Engineering**
[![GitHub](https://img.shields.io/badge/GitHub-fzanneti-181717?style=flat&logo=github)](https://github.com/fzanneti)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-fzanneti-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/fzanneti)