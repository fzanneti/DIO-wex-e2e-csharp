# 📘 Fundamentos de Qualidade de Software

Material de estudo estruturado para apoiar alunos, iniciantes e profissionais em transição de carreira que desejam entender os fundamentos da Qualidade de Software (Software Quality).

---

## 🧩 1. O que é Qualidade de Software

### 📌 Apresentação do curso

O objetivo deste módulo é fornecer uma visão clara e objetiva sobre o que se entende por "qualidade" no contexto do desenvolvimento de software, e como ela é medida, gerenciada e aplicada ao ciclo de vida de sistemas.

### 🧠 Definindo Qualidade

Qualidade de software pode ser definida como o grau de conformidade de um software com os requisitos funcionais e não funcionais especificados, bem como com os padrões técnicos e de usabilidade.

### Características comuns de qualidade:

* Confiabilidade
* Manutenibilidade
* Eficiência
* Portabilidade
* Usabilidade

### 📏 Normas e Padrões de Qualidade

Normas ajudam a definir critérios objetivos para desenvolvimento e avaliação da qualidade.

* **ISO/IEC 25010** – Modelo de qualidade do produto
* **ISO/IEC 12207** – Ciclo de vida do software
* **IEEE 829** – Padrões para documentação de testes
* **CMMI** – Modelo de maturidade de processos
* **MPS.BR** – Modelo brasileiro de melhoria de processos

### 📐 Medindo Qualidade

A qualidade de um software pode ser medida com base em métricas como:

* Densidade de defeitos
* Cobertura de testes
* Tempo médio para reparo (MTTR)
* Performance e tempo de resposta

### ⚙️ Processos de Gerenciamento da Qualidade

Inclui atividades como:

* Planejamento da qualidade
* Garantia da qualidade (QA)
* Controle de qualidade (QC)
* Melhoria contínua (CICD + feedbacks + testes automatizados)

---

## 🐞 2. Gerenciamento de Defeitos

### 🧪 Controle de Qualidade

Controle de qualidade é uma etapa focada na identificação de defeitos por meio de testes e revisões. É uma atividade **reativa**, diferente da garantia de qualidade (QA), que é **preventiva**.

### 🔍 Caracterizando Defeitos

* **Bug (erro):** falha no código-fonte
* **Defeito:** comportamento diferente do esperado
* **Falha:** resultado visível de um defeito em execução

### 🔁 Ciclo de Vida do Bug

1. Detecção
2. Registro (issue tracker)
3. Triagem (prioridade/severidade)
4. Correção (desenvolvedor)
5. Reteste
6. Fechamento ou reabertura

### 🛠️ Ferramentas de Suporte

Ferramentas utilizadas para controle de defeitos:

- [**Jira** (Atlassian)](https://www.atlassian.com/br/software/jira)
- [**Bugzilla**](https://www.bugzilla.org/)
- [**Azure DevOps**](https://azure.microsoft.com/pt-br/products/devops)
- [**TestLink**](https://testlink.org/)
- [**MantisBT**](https://mantisbt.org/)
- [**GitHub Issues**](https://docs.github.com/pt/issues)
- [**Trac**](https://trac.edgewall.org/)

---

## 🧪 3. Introdução aos Testes de Software

### 🎯 Conceitos e Objetivos

Testes de software visam verificar e validar se um sistema atende aos requisitos esperados. Eles são essenciais para garantir qualidade, segurança, performance e usabilidade.

Claro, Fabio! Aqui está a versão expandida e profissional do tópico **🧭 Processo de Teste**, com explicações detalhadas de cada etapa. Isso pode ser incluído diretamente no seu material de estudo em Markdown para deixar mais completo e didático:

---

## 🧭 Processo de Teste

O processo de teste é uma sequência estruturada de atividades com o objetivo de garantir que o software funcione conforme o esperado, atenda aos requisitos definidos e esteja livre de falhas críticas. Esse processo é essencial para promover qualidade, reduzir riscos e aumentar a confiabilidade do produto.

A seguir, as principais etapas do processo de teste:

### 1. Planejamento de Testes

- **Objetivo**: Definir o escopo, a estratégia e os recursos para o processo de teste.
- **Atividades**:

  - Identificação dos objetivos dos testes.
  - Escolha do tipo de teste a ser executado (unitário, integração, sistema, aceitação etc.).
  - Definição de critérios de entrada e saída.
  - Alocação de recursos (tempo, ferramentas e equipe).
  - Identificação de riscos e plano de contingência.
- **Entregáveis**: Plano de Testes (Test Plan), estratégia de teste, cronograma.

---

### 2. Projeto dos Casos de Teste

- **Objetivo**: Criar casos de teste detalhados que cubram os requisitos e funcionalidades do sistema.
- **Atividades**:

  - Análise dos requisitos e documentação técnica.
  - Definição de entradas, ações e resultados esperados.
  - Aplicação de técnicas de teste (caixa branca, preta, partição de equivalência, etc.).
  - Criação de dados de teste.
- **Entregáveis**: Casos de Teste (Test Cases), scripts automatizados (quando aplicável), matriz de rastreabilidade.

---

### 3. Execução

- **Objetivo**: Colocar os casos de teste em prática.
- **Atividades**:

  - Execução manual ou automatizada dos testes.
  - Comparação dos resultados obtidos com os resultados esperados.
  - Registro de comportamentos inesperados.
- **Ferramentas**: TestRail, Azure DevOps, JUnit, Selenium, Cypress, Postman (para APIs), entre outros.

---

### 4. Registro de Resultados

- **Objetivo**: Documentar os resultados da execução dos testes.
- **Atividades**:

  - Registro de testes bem-sucedidos e falhas detectadas.
  - Evidências de execução (prints, logs, vídeos).
  - Classificação de falhas por gravidade e impacto.
- **Entregáveis**: Relatórios de Execução, evidências, logs.

---

### 5. Avaliação de Saída

- **Objetivo**: Verificar se os critérios de aceitação foram cumpridos.
- **Atividades**:

  - Avaliação dos resultados frente aos critérios estabelecidos no plano.
  - Análise de cobertura de testes.
  - Identificação de pendências ou riscos residuais.
- **Entregáveis**: Métricas de qualidade, análise de cobertura, recomendação de aprovação ou reprovação.

---

### 6. Fechamento e Relatório

- **Objetivo**: Finalizar formalmente o ciclo de testes e documentar os aprendizados.
- **Atividades**:

  - Reunião de encerramento com lições aprendidas.
  - Geração do relatório final de testes.
  - Armazenamento de artefatos para auditoria e histórico.
  - Atualização de documentação.
- **Entregáveis**: Relatório de Testes Final, apresentação executiva (opcional), base de conhecimento.

---

## 🧱 Níveis de Teste

Os **níveis de teste** organizam as atividades de verificação e validação em diferentes estágios do desenvolvimento. Cada nível tem um foco específico e contribui para identificar defeitos o mais cedo possível.

---

### 🧩 **Teste de Unidade**

- **Objetivo**: Validar o comportamento de **componentes individuais**, como métodos, funções ou classes.
- **Responsável**: Geralmente, o **desenvolvedor** realiza esses testes durante o desenvolvimento.
- **Ferramentas comuns**: xUnit, NUnit, MSTest, JUnit.
- **Exemplo**: Verificar se uma função de cálculo de desconto retorna o valor correto para diferentes entradas.
- **Benefícios**:

  - Detecção rápida de erros em blocos de código.
  - Facilita o debugging e a manutenção.

---

### 🔗 **Teste de Integração**

- **Objetivo**: Garantir que **módulos ou componentes interajam corretamente** entre si.
- **Responsável**: Pode ser realizado por desenvolvedores ou QA.
- **Tipos**:

  - Integração incremental (top-down ou bottom-up)
  - Big Bang (todos os módulos de uma vez)
- **Exemplo**: Validar se o módulo de login comunica corretamente com o banco de dados e com o sistema de autenticação.
- **Benefícios**:

  - Detecta falhas na comunicação entre módulos.
  - Valida contratos de APIs internas.

---

### 🖥️ **Teste de Sistema**

- **Objetivo**: Avaliar o **sistema completo** em um ambiente que simula o real.
- **Responsável**: Equipe de QA.
- **Abrangência**: Testes funcionais, não funcionais (como desempenho), de segurança, usabilidade, etc.
- **Exemplo**: Simular um fluxo completo de compra em um e-commerce, incluindo login, carrinho e pagamento.
- **Benefícios**:

  - Garante que o sistema atenda aos requisitos especificados.
  - Fornece uma visão completa da aplicação.

---

### ✅ **Teste de Aceitação**

- **Objetivo**: Verificar se o sistema atende às **necessidades e expectativas do usuário final**.
- **Responsável**: Cliente, Product Owner ou QA.
- **Tipos**:

  - Teste de Aceitação do Usuário (UAT)
  - Teste Alpha (interno) e Beta (externo)
- **Exemplo**: Validar se um app mobile atende aos fluxos descritos em uma história de usuário.
- **Benefícios**:

  - Ajuda a garantir a satisfação do cliente.
  - Determina se o produto está pronto para produção.

---

## 🧪 Tipos de Teste

Os **tipos de teste** se referem à **intenção** ou **propósito** do teste dentro do processo de qualidade. Cada tipo atende a objetivos diferentes e pode ser aplicado em diferentes fases do ciclo de vida do software.

---

### ✅ **Funcionais**

- **Objetivo**: Validar se as **funcionalidades** do sistema estão funcionando conforme os requisitos especificados.
- **Base**: Casos de uso, histórias de usuário, requisitos funcionais.
- **Exemplos**:

  - Verificar se um botão "Cadastrar" realiza o cadastro corretamente.
  - Testar se o sistema permite login com credenciais válidas.
- **Técnicas comuns**: Caixa preta, testes baseados em fluxo.

---

### 🚀 **Não Funcionais**

- **Objetivo**: Avaliar **aspectos de qualidade** que não estão ligados diretamente ao que o sistema faz, mas **como ele se comporta**.
- **Subtipos**:

  - **Teste de desempenho**: tempo de resposta e throughput.
  - **Teste de carga**: capacidade sob aumento gradual de usuários.
  - **Teste de estresse**: resposta do sistema em condições extremas.
  - **Teste de segurança**: proteção contra ataques e vulnerabilidades.
  - **Teste de usabilidade**: facilidade de uso para o usuário final.
- **Exemplos**:

  - Verificar se o sistema suporta 1.000 acessos simultâneos.
  - Avaliar se a interface é intuitiva em dispositivos móveis.

---

### 🔍 **Exploratórios**

- **Objetivo**: Descobrir comportamentos inesperados explorando o sistema **sem um roteiro fixo**.
- **Base**: Conhecimento, curiosidade e experiência do tester.
- **Exemplos**:

  - Navegar livremente por uma aplicação tentando encontrar falhas.
  - Realizar ações que o usuário possa fazer por engano.
- **Quando usar**:

  - Em fases iniciais do projeto.
  - Para encontrar bugs que passaram despercebidos por testes automatizados ou roteirizados.

---

### 🔁 **Regressão**

- **Objetivo**: Garantir que **novas alterações no sistema não tenham impactado funcionalidades já existentes**.
- **Importância**: Essencial em ambientes com entregas contínuas (CI/CD).
- **Exemplos**:

  - Após alterar o módulo de cadastro, testar novamente os fluxos de login e logout.
  - Reexecutar os testes automatizados de uma suíte funcional após um deploy.
- **Automação**: É um dos tipos de teste mais automatizados, já que precisa ser executado repetidamente.

---

## 🧠 Técnicas de Teste

As técnicas de teste ajudam os analistas e desenvolvedores a definirem quais dados, cenários e caminhos devem ser testados, com base em estratégias estruturadas que aumentam a **cobertura** e a **eficácia** dos testes.

---

### 🔲 **Teste Caixa Preta (Black-box)**

- **Foco**: Funcionalidade do sistema sem considerar a estrutura interna do código.
- **Base**: Requisitos, histórias de usuário e casos de uso.
- **Objetivo**: Verificar se a **entrada** produz a **saída esperada**, independente de como o sistema processa internamente.
- **Exemplo**: Testar se uma calculadora retorna 10 ao somar 5 + 5, sem saber como o método de soma foi implementado.

---

### 🔳 **Teste Caixa Branca (White-box)**

- **Foco**: Lógica interna, fluxos de decisão e estruturas do código.
- **Base**: Código-fonte e estrutura lógica.
- **Objetivo**: Garantir que **todos os caminhos e condições lógicas** foram testados.
- **Exemplo**: Verificar se todos os blocos `if`, `else`, loops e condições de erro estão cobertos por testes.

---

### 🎯 **Partição de Equivalência**

- **Foco**: Dividir os dados de entrada em **grupos equivalentes** para reduzir a quantidade de testes sem perder cobertura.
- **Objetivo**: Se um valor de uma partição funcionar, os demais provavelmente também funcionarão.
- **Exemplo**: Um campo que aceita idades de 18 a 60. Você testa um valor representativo de cada partição:

  - Válido: 30
  - Inválido (abaixo): 17
  - Inválido (acima): 61

---

### 🔢 **Análise de Valor Limite (Boundary Value Analysis)**

- **Foco**: Testar os **limites extremos** das partições de equivalência, onde os erros ocorrem com mais frequência.
- **Objetivo**: Detectar falhas em valores mínimos e máximos.
- **Exemplo**: Para o campo idade (18 a 60), os testes ideais seriam:

  - 17 (abaixo do limite inferior)
  - 18 (no limite inferior)
  - 60 (no limite superior)
  - 61 (acima do limite superior)

---

### 📋 **Tabela de Decisão**

- **Foco**: Modelar **regras de negócio complexas** com múltiplas condições e suas ações/resultados esperados.
- **Objetivo**: Cobrir todas as combinações possíveis de entradas.
- **Exemplo**: Em um sistema bancário:

| Cliente VIP | Saldo > 5000 | Permitir Saque? |
| ----------- | ------------ | --------------- |
| Não         | Não          | Não             |
| Não         | Sim          | Sim             |
| Sim         | Não          | Sim             |
| Sim         | Sim          | Sim             |

- Cada linha representa um cenário de teste.

---

#### ✅ Conclusão

Testes não são apenas uma etapa, mas parte essencial do ciclo de desenvolvimento moderno. Eles previnem problemas, reduzem custos e aumentam a confiança nos sistemas.

---

### 🔗 Materiais de Apoio e Links Úteis

- [ISTQB - International Software Testing Qualifications Board](https://www.istqb.org/)
- [ISO/IEC 25010 - Modelo de Qualidade](https://iso25000.com/index.php/en/iso-25000-standards/iso-25010)
- [Documentação de Testes - IEEE 829](https://en.wikipedia.org/wiki/IEEE_829)
- [CTFL (bstqb.org.br)](https://bstqb.org.br/b9/doc/syllabus_ctfl_3.1br.pdf)
- [martinfowler.com](https://martinfowler.com/)
- [Cobertura de código explicada. Relatórios e métricas com Istanbul e o… | by Eduardo Rabelo | Medium](https://oieduardorabelo.medium.com/cobertura-de-c%C3%B3digo-explicada-ba1516db7dbd)

---

##### ✍️ **Seção criada por:** *Fabio Zanneti* 🎯 Projeto: **WEX - End to End Engineering**