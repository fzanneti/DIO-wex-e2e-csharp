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

* **Jira** (Atlassian)
* **Bugzilla**
* **Azure DevOps**
* **TestLink**
* **MantisBT**
* **GitHub Issues**

---

## 🧪 3. Introdução aos Testes de Software

### 🎯 Conceitos e Objetivos

Testes de software visam verificar e validar se um sistema atende aos requisitos esperados. Eles são essenciais para garantir qualidade, segurança, performance e usabilidade.

### 🧭 Processo de Teste

1. Planejamento de Testes
2. Projeto dos Casos de Teste
3. Execução
4. Registro de Resultados
5. Avaliação de Saída
6. Fechamento e relatório

### 🧱 Níveis de Teste

* **Teste de Unidade:** verifica componentes isolados (funções, classes)
* **Teste de Integração:** verifica a interação entre módulos
* **Teste de Sistema:** valida o sistema como um todo
* **Teste de Aceitação:** valida se o sistema atende os requisitos do usuário final

### 🧪 Tipos de Teste

* **Funcionais:** validam funcionalidades específicas
* **Não funcionais:** desempenho, carga, segurança, etc.
* **Exploratórios:** sem script, feitos com base na experiência do tester
* **Regressão:** garante que alterações não quebraram funcionalidades existentes

### 🧠 Técnicas de Teste

* **Teste Caixa Preta:** foca nas entradas e saídas, sem ver o código
* **Teste Caixa Branca:** foca no código-fonte, estruturas e caminhos
* **Partição de Equivalência**
* **Análise de Valor Limite**
* **Técnica de tabela de decisão**

#### ✅ Conclusão

Testes não são apenas uma etapa, mas parte essencial do ciclo de desenvolvimento moderno. Eles previnem problemas, reduzem custos e aumentam a confiança nos sistemas.

---

### 🔗 Materiais de Apoio e Links Úteis

* [Guia de Qualidade de Software - Alura](https://www.alura.com.br/artigos/qualidade-software)
* [ISTQB - International Software Testing Qualifications Board](https://www.istqb.org/)
* [ISO/IEC 25010 - Modelo de Qualidade](https://iso25000.com/index.php/en/iso-25000-standards/iso-25010)
* [Documentação de Testes - IEEE 829](https://en.wikipedia.org/wiki/IEEE_829)
* [Blog QA Ninja - Testes, Qualidade e Automação](https://qaninja.com.br/blog/)
* [Livro: Teste de Software (Autor: Delamaro e Jino)](https://www.amazon.com.br/Teste-Software-Jose-Carlos-Machado/dp/8573936233)
* [Canal do YouTube - Taqe Tecnologia: Testes e Qualidade](https://www.youtube.com/@taqetecnologia)

---

##### ✍️ **Seção criada por:** *Fabio Zanneti* 🎯 Projeto: **WEX - End to End Engineering**