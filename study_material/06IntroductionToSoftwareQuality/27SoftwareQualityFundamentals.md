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

A qualidade de software é um conjunto de atributos que determinam a capacidade de um produto em satisfazer as necessidades explícitas e implícitas dos usuários, garantindo desempenho, segurança, usabilidade e confiabilidade.

---

### 🧩 Definindo Qualidade

Segundo a **ISO 25010**, qualidade de software é medida por características como:
- **Funcionalidade:** o sistema cumpre o que promete?
- **Confiabilidade:** o sistema funciona bem sob diferentes condições?
- **Usabilidade:** o sistema é fácil e agradável de usar?
- **Eficiência:** o sistema utiliza bem os recursos?
- **Manutenibilidade:** é fácil de corrigir e evoluir?
- **Portabilidade:** o sistema pode ser executado em diferentes ambientes?

---

### 🏅 Normas e Padrões de Qualidade

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

---

### 📋 Processos de Gerenciamento de Qualidade

- **Planejamento da Qualidade:** definição dos padrões e critérios.
- **Garantia da Qualidade:** implementação de processos para evitar defeitos.
- **Controle de Qualidade:** inspeção e testes para identificar falhas.
- **Melhoria Contínua:** ações sistemáticas para aprimorar o produto e o processo.

---

## 🐞 Gerenciamento de Defeitos

### 🛡️ Falando em Controle de Qualidade

Controle de qualidade visa identificar e corrigir defeitos antes que o software chegue ao cliente. Isso inclui testes, revisões e inspeções.

---

### 🔎 Caracterizando Defeitos

Um defeito pode ser:

- **Erro:** falha humana na codificação ou documentação.
- **Falha:** o software não cumpre uma função esperada.
- **Bug:** manifestação do erro durante a execução.

---

### 🔄 Ciclo de Vida do Bug

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

---

## 🧪 Introdução aos Testes de Software

### 🎯 Conceitos e Objetivos
Testes de software são processos que visam:
- **Verificar se o software atende aos requisitos.**
- **Identificar falhas antes que cheguem ao cliente.**
- **Garantir segurança, desempenho e usabilidade.**

### 🔄 Processos de Teste

Conforme a **ISTQB**, o processo de teste inclui:
1. **Planejamento:** definição do que será testado.
2. **Análise:** levantamento dos requisitos de teste.
3. **Design:** criação dos casos de teste.
4. **Implementação:** desenvolvimento dos testes.
5. **Execução:** aplicação dos testes no software.
6. **Encerramento:** análise de resultados e documentação.

---

### 🧱 Níveis de Teste

- **Teste Unitário:** verifica pequenas partes do código (funções/métodos).
- **Teste de Integração:** verifica a interação entre módulos.
- **Teste de Sistema:** verifica o sistema como um todo.
- **Teste de Aceitação:** validação final com o cliente ou usuário.

---

### 🧩 Tipos de Teste

- **Funcional:** verifica as funções do software.
- **Não Funcional:** verifica performance, segurança, usabilidade.
- **Exploratórios:** busca por defeitos de forma intuitiva.
- **Regressão:** garante que mudanças não afetaram funcionalidades antigas.

---

### 🔍 Técnicas de Teste

- **Caixa Branca:** o testador conhece o código.
- **Caixa Preta:** o testador não conhece o código.
- **Técnicas Baseadas em Experiência:** heurísticas e testes exploratórios.
- **Técnicas Baseadas em Modelos:** uso de fluxogramas e diagramas.

---

#### ✅ Conclusão

A qualidade de software é resultado da combinação de **boas práticas de engenharia**, **processos bem definidos**, e **testes sistemáticos**. O QA atua como guardião da qualidade, mas a responsabilidade é de toda a equipe.

> 🚀 **Próximos Passos:** aprofundar-se em automação de testes e estratégias avançadas de qualidade.

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