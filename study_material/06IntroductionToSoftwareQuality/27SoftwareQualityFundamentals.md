# 📘 Fundamentos de Qualidade de Software

No **Bootcamp WEX**, você está aprendendo a construir aplicações completas com **C#**, **.NET**, **Git**, **APIs e bancos de dados relacionais** e **NoSQL**. A **Qualidade de Software** é um pilar fundamental para garantir que essas aplicações sejam confiáveis, escaláveis e atendam às expectativas dos usuários. Este módulo explora os fundamentos de QA, incluindo processos, técnicas e ferramentas de teste, com exemplos práticos em C# que se integram aos projetos full-stack, preparando você para atuar em equipes ágeis e pipelines DevOps.

![GitHub repo size](https://img.shields.io/github/repo-size/fzanneti/wex-e2e-csharp)
![GitHub forks](https://img.shields.io/github/forks/fzanneti/wex-e2e-csharp?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/fzanneti/wex-e2e-csharp?style=social)
![Bootcamp](https://img.shields.io/badge/WEX-End--to--End%20Engineering-blueviolet?logo=vercel&logoColor=white)
![Plataforma](https://img.shields.io/badge/Powered%20by-DIO.io-red?logo=data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjZmZmIiB2aWV3Qm94PSIwIDAgMzIgMzIiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PHBhdGggZD0iTTYuNzEgMy4yNWMtMi44OCAxLjQxLTUuMDcgNC4yMy01LjA3IDcuNzYgMCAzLjU4IDIuMjggNi43IDUuMzMgOC4xNSAxLjgzLS42MiAyLjQtMi4yNiAyLjQtMy44MSAwLS4yMy0uMDItLjQ1LS4wNS0uNjZBLjQ0LjQ0IDAgMDExMC4xIDExYy4yNC0uNzUuMTEtMS41My0uMy0yLjIyQzguOTIgNy45NiA3LjMzIDcuNSA1Ljc0IDcuNjZhNS41NSA1LjU1IDAgM)
![Autor](https://img.shields.io/badge/Autor-fzanneti-blue?style=flat-square&logo=github)

---

### ✅ O que é Qualidade de Software

A qualidade de software é o coração de qualquer aplicação robusta. É um conjunto de atributos que determinam a capacidade de um produto em satisfazer as necessidades explícitas e implícitas dos usuários, garantindo desempenho, segurança, usabilidade e confiabilidade. É como garantir que um carro não só ande, mas seja seguro, confortável e econômico.

Pense no QA como o "controle de qualidade" de uma fábrica: sem ele, você pode entregar um produto com defeitos. O QA é essencial para criar aplicações que impressionem em equipes ágeis e pipelines DevOps, onde testes automatizados e entregas contínuas são padrão. 

Você cria APIs e sistemas com C# e .NET. Imagine que sua API de e-commerce precisa processar pedidos rapidamente (desempenho), proteger dados sensíveis (segurança) e ser fácil para o cliente navegar (usabilidade). A qualidade de software é o que faz sua aplicação "entregar valor" de verdade. Sem QA, você pode entregar um sistema que funciona, mas falha em cenários reais, como picos de tráfego ou ataques maliciosos.

Vamos detalhar cada seção para reforçar seu aprendizado!

---

### 🧩 Definindo Qualidade

Segundo a **ISO 25010**, qualidade de software é medida por características como:

- **Funcionalidade:** Seu sistema de login em C# valida credenciais corretamente?
- **Confiabilidade:** Ele aguenta um usuário digitando senhas erradas várias vezes?
- **Usabilidade:** O front-end da sua aplicação (integrada com .NET) é intuitivo para o usuário final?
- **Eficiência:** O sistema utiliza bem os recursos?
- **Manutenibilidade:** É fácil de corrigir e evoluir?
- **Portabilidade:** O sistema pode ser executado em diferentes ambientes?

---

### 🏅 Normas e Padrões de Qualidade

Essas normas são como "manuais" que equipes profissionais seguem para garantir consistência. No bootcamp, você usa **Git** para controle de versão e pipelines DevOps para entregas. Normas como o CMMI ajudam a estruturar esses processos, garantindo que cada commit passe por revisões e testes. A **IEEE 829**, por exemplo, ensina como documentar testes de forma clara, algo útil para relatórios no seu projeto.

- Exemplos:

    - **ISO/IEC 25010:** Modelo de qualidade de software.
    - **ISO 9001:** Sistema de gestão da qualidade.
    - **CMMI (Capability Maturity Model Integration):** Melhoria de processos.
    - **IEEE 829:** Padrão para documentação de testes.

---

### 📏 Medindo Qualidade

A qualidade pode ser medida por métricas como:

- **Taxa de Defeitos:** número de erros por funcionalidade.
- **Cobertura de Testes:** percentual do código testado.
- **MTTF (Mean Time To Failure):** tempo médio até uma falha.
- **Satisfação do Usuário:** pesquisas e feedback.

> Métricas são como "termômetros" que mostram a saúde do seu software. No bootcamp, você pode usar ferramentas como **SonarQube** (integrada ao pipeline DevOps) para medir a cobertura de testes do seu código C#. Por exemplo, uma cobertura de 80% significa que 80% do seu código foi testado, mas os 20% restantes podem esconder bugs.

---

### 📋 Processos de Gerenciamento de Qualidade

O processo inclui planejamento, garantia, controle e melhoria contínua.
Pense nisso como um ciclo de produção: você planeja como construir (planejamento), segue regras para evitar erros (garantia), verifica o produto final (controle) e melhora o processo com base em falhas (melhoria contínua). No bootcamp, isso se traduz em:

- **Planejamento da Qualidade:** Definir quais endpoints da sua API serão testados.
- **Garantia da Qualidade:** Usar revisões de código no Git para evitar bugs.
- **Controle de Qualidade:** Executar testes unitários e de integração.
- **Melhoria Contínua:** Ajustar o pipeline DevOps com base em falhas.

---

## 🐞 Gerenciamento de Defeitos

### 🛡️ Falando em Controle de Qualidade

Controle de qualidade visa identificar e corrigir defeitos antes que o software chegue ao cliente. Isso inclui testes, revisões e inspeções.

> O controle de qualidade é como um "detector de falhas" que impede que esses bugs cheguem ao usuário final. Por exemplo, uma revisão de código no Git pode identificar um erro antes do deploy, e testes automatizados garantem que ele não volte.

---

### 🔎 Caracterizando Defeitos

Um defeito pode ser:

- **Erro:** falha humana na codificação ou documentação.
- **Falha:** o software não cumpre uma função esperada.
- **Bug:** manifestação do erro durante a execução.

---

### 🔄 Ciclo de Vida do Bug

O ciclo inclui identificação, classificação, atribuição, correção, validação e encerramento.

Pense no ciclo de vida do bug como uma "tarefa" no JIRA. Cada etapa garante que o problema seja resolvido de forma organizada. No bootcamp, você pode usar ferramentas como **Azure DevOps** para gerenciar bugs, integrando com seu pipeline.

1. **Identificação:** o defeito é reportado.
2. **Classificação:** prioridade e severidade.
3. **Atribuição:** designação a um desenvolvedor.
4. **Correção:** desenvolvimento da solução.
5. **Validação:** o QA testa a correção.
6. **Encerramento:** se resolvido, o bug é fechado.

---

### 🛠️ Ferramentas de Suporte

- **JIRA:** gestão de bugs e tarefas.
- **Bugzilla:** rastreamento de defeitos.
- **MantisBT:** sistema de acompanhamento de falhas.
- **Azure DevOps:** integração completa com pipelines de desenvolvimento.

Essas ferramentas são como "organizadores" que centralizam o trabalho da equipe. Você pode usar **Azure DevOps** para criar tarefas, rastrear bugs e integrar com pipelines CI/CD, garantindo que cada commit passe por testes.

---

## 🧪 Introdução aos Testes de Software

### 🎯 Conceitos e Objetivos

Testes de software são processos que visam:

- **Verificar se o software atende aos requisitos.**
- **Identificar falhas antes que cheguem ao cliente.**
- **Garantir segurança, desempenho e usabilidade.**

### 🔄 Processos de Teste

Conforme a **ISTQB**, o processo de teste é como uma receita: cada etapa é essencial para o resultado final. Você pode aplicar isso ao testar uma API REST. Por exemplo:

1. **Planejamento:** definição do que será testado.
2. **Análise:** levantamento dos requisitos de teste.
3. **Design:** criação dos casos de teste.
4. **Implementação:** desenvolvimento dos testes.
5. **Execução:** aplicação dos testes no software.
6. **Encerramento:** análise de resultados e documentação.

---

### 🧱 Níveis de Teste

Cada nível testa uma "camada" do software. Você começa com testes unitários (métodos em C#), avança para integração (interação com o banco) e, no final, valida o sistema completo com o cliente.

- **Teste Unitário:** verifica pequenas partes do código (funções/métodos).
- **Teste de Integração:** verifica a interação entre módulos.
- **Teste de Sistema:** verifica o sistema como um todo.
- **Teste de Aceitação:** validação final com o cliente ou usuário.

---

### 🧩 Tipos de Teste

Cada tipo foca em um aspecto do sistema. Por exemplo, testes funcionais verificam se o botão de login funciona, enquanto testes não funcionais checam se ele aguenta 1.000 cliques por segundo.

- **Funcional:** Testar se o endpoint de cadastro cria um usuário.
- **Não funcional:** Testar se a API responde em menos de 2 segundos.
- **Exploratório:** Tentar inserir caracteres especiais no formulário.
- **Regressão:** Garantir que uma nova feature não quebrou o login.

---

### 🔍 Técnicas de Teste

Inclui caixa branca, caixa preta, baseadas em experiência e modelos.

- **Caixa branca:** Você vê o código, útil para testes unitários em C#.
- **Caixa preta:** Você testa como usuário, sem conhecer o código (ex.: Postman).
- **Exploratório:** Como um "detetive", você explora o sistema procurando falhas.
- **Modelos:** Usa diagramas para planejar testes.

---

#### ✅ Conclusão

Qualidade de software combina boas práticas, processos e testes. O QA é responsabilidade de todos.
 
Você está aprendendo a ser um engenheiro completo. QA não é só testar, mas garantir que seu código C# seja robusto, sua API escalável e seu sistema confiável. Isso é crucial em equipes ágeis e pipelines DevOps.
 
- Aprenda automação de testes com **Selenium** ou **SpecFlow** para C#.
- Integre testes no seu pipeline DevOps.
- Explore ferramentas como **SonarQube** para métricas de qualidade.

---

## 📚 Referências e Leitura Complementar
- [ISO 25010](https://iso25000.com/index.php/en/iso-25000-standards/iso-25010)
- [CMMI Institute](https://cmmiinstitute.com/)
- [ISTQB](https://www.istqb.org/)
- [IEEE 829](https://ieeexplore.ieee.org/document/7167405)
- [JIRA Software](https://www.atlassian.com/software/jira)

---

##### ✍️ Seção criada por: *Fabio Zanneti* - 🎯 Bootcamp: **WEX - End to End Engineering**
[![GitHub](https://img.shields.io/badge/GitHub-fzanneti-181717?style=flat&logo=github)](https://github.com/fzanneti)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-fzanneti-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/fzanneti)