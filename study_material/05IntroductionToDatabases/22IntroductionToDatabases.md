# 📦 Introdução a Banco de Dados

### 📘 Introdução ao Módulo

Neste módulo vamos aprender os conceitos fundamentais sobre **bancos de dados**, desde sua definição, passando pelos principais tipos existentes, até a instalação prática do **SQL Server**, um dos SGBDs mais usados no ecossistema .NET.

---

### 🧠 O que é um Banco de Dados?

Um **banco de dados** é um conjunto organizado de dados que podem ser acessados, gerenciados e atualizados de forma eficiente. Ele serve para **armazenar informações** estruturadas, como registros de clientes, produtos, pedidos etc.

No desenvolvimento com .NET, é comum utilizarmos **SGBDs relacionais**, como o **SQL Server**, integrados via **Entity Framework** ou comandos SQL puros.

---

## 🗂️ Tipos de Banco de Dados

### 1. Relacional (RDBMS)
- Estruturado em **tabelas com colunas e linhas**.
- Utiliza a linguagem **SQL (Structured Query Language)**.
- Exemplo: SQL Server, MySQL, PostgreSQL.

### 2. Não Relacional (NoSQL)
- Ideal para dados sem estrutura rígida.
- Pode ser baseado em **documentos, grafos, chave-valor ou colunas**.
- Exemplo: MongoDB, Redis, Cassandra.

---

### 📊 Entendendo uma Tabela

Uma **tabela** em um banco relacional é composta por:
- **Colunas**: Definem os **tipos de dados** (ex: `Nome`, `Idade`, `Email`).
- **Linhas (ou registros)**: Cada linha é um **dado completo** de uma entidade.

Exemplo:

| Id | Nome         | Email               |
|----|--------------|---------------------|
| 1  | Ana Oliveira | ana@email.com       |
| 2  | João Silva   | joao@email.com      |

---

### 🌐 Bancos Não Relacionais

Em vez de tabelas, os bancos NoSQL armazenam dados em:
- **Documentos (ex: JSON)** → MongoDB
- **Chave-valor** → Redis
- **Grafos** → Neo4j
- **Colunas** → Cassandra

📌 Úteis quando lidamos com **grandes volumes de dados não estruturados**, como logs, redes sociais, etc.

---

### 🔠 Tipos de Dados Comuns

| Tipo         | Exemplo               | Uso                                  |
|--------------|------------------------|---------------------------------------|
| `INT`        | 1, 200, -10            | Números inteiros                      |
| `VARCHAR(50)`| "Fabio"                | Texto com tamanho variável            |
| `DATE`       | '2025-06-15'           | Datas                                 |
| `DECIMAL`    | 10.99                  | Valores numéricos com casas decimais |
| `BIT`        | 0, 1                   | Valores booleanos (true/false)       |

---

### ⚙️ O que é um DBMS (ou SGBD)?

DBMS (Database Management System) ou em português **SGBD (Sistema Gerenciador de Banco de Dados)** é o software que gerencia o banco.

### Funções principais:
- Armazenar dados de forma eficiente.
- Permitir acesso concorrente.
- Gerenciar transações e segurança.

🎯 Exemplo: **Microsoft SQL Server**, **PostgreSQL**, **MySQL**, **MongoDB**.

---

### 🧪 Instalando o SQL Server

Para projetos em C# e .NET, o **SQL Server** é altamente recomendado.

### 👉 Passo a Passo:

1. Baixe o instalador do **SQL Server Developer Edition**:  
   [https://www.microsoft.com/pt-br/sql-server/sql-server-downloads](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)

2. Instale o **SQL Server Management Studio (SSMS)** para gerenciar o banco via interface gráfica:  
   [https://learn.microsoft.com/pt-br/sql/ssms/download-sql-server-management-studio-ssms](https://learn.microsoft.com/pt-br/sql/ssms/download-sql-server-management-studio-ssms)

3. Durante a instalação:
   - Escolha a opção "Basic" ou "Custom"
   - Mantenha o modo de autenticação padrão (Windows Authentication)

4. Após instalar:
   - Abra o **SSMS**, conecte ao servidor local (`localhost`) e comece a criar seu banco!

---

## 🗃️ Links Complementares de Estudo – Introdução a Banco de Dados

Bancos de dados são fundamentais em qualquer aplicação moderna. Entender bem os conceitos de tabelas, relacionamentos, SQL e NoSQL é o primeiro passo para trabalhar com persistência de dados. Abaixo estão materiais para te ajudar a entender desde os fundamentos até os primeiros comandos práticos.

---

### 🎓 Aulas e Cursos Gratuitos

- [Curso de Banco de Dados para Iniciantes (Curso em Vídeo)](https://www.youtube.com/playlist?list=PLHz_AreHm4dmDP_VgNa8YG_5bhOUIpEMd)
  > Explicação passo a passo de SQL, tabelas, comandos básicos e teoria relacional.
- [Introdução a Banco de Dados – DevMedia](https://www.devmedia.com.br/introducao-a-banco-de-dados/38352)
  > Um guia inicial com fundamentos teóricos sobre modelagem, tipos de dados, normalização e relacionamentos.
- [Fundamentos de Banco de Dados – Microsoft Learn](https://learn.microsoft.com/pt-br/training/modules/introduction-to-data/)
  > Módulo gratuito com explicações claras sobre dados estruturados, armazenamento e linguagens de consulta.

---

### 📚 Documentação e Ferramentas

- [Documentação Oficial SQL (W3Schools)](https://www.w3schools.com/sql/)
  > Um dos melhores guias interativos para aprender comandos SQL (`SELECT`, `INSERT`, `JOIN`, etc.).
- [MySQL Documentation (pt-br)](https://dev.mysql.com/doc/)
  > Documentação oficial para quem está usando MySQL (muito usado em cursos e projetos iniciais).
- [PostgreSQL - Guia Rápido](https://www.postgresql.org/docs/current/tutorial-start.html)
  > Comece a brincar com um banco de dados robusto e open source.
- [DB Fiddle](https://www.db-fiddle.com/)
  > Ambiente online para testar SQL sem instalar nada. Excelente para praticar.

---

### 📁 Conceitos Fundamentais

- [Modelo Relacional de Dados – Alura Artigo](https://www.alura.com.br/artigos/modelo-relacional-dados)
  > Explicação clara sobre como funciona o modelo de tabelas e relacionamentos.
- [O que é SQL? E para que serve? (HostGator)](https://www.hostgator.com.br/blog/o-que-e-sql/)
  > Visão geral bem simples sobre a linguagem SQL, ideal para iniciantes.
- [Normalização de Dados – DevMedia](https://www.devmedia.com.br/normalizacao-de-dados/24310)
  > Entenda como evitar redundância e garantir consistência nos seus bancos.

---

### 💡 Extras Interessantes

- [SQLZoo – Exercícios interativos de SQL](https://sqlzoo.net/)
  > Plataforma prática para treinar comandos SQL direto no navegador.
- [DrawSQL – Ferramenta de Diagrama ER online](https://drawsql.app/)
  > Para criar seus próprios esquemas de banco de dados com visual profissional.
- [DBeaver – Cliente gráfico de Banco de Dados](https://dbeaver.io/)
  > Ferramenta gratuita para conectar, visualizar e manipular dados em bancos locais ou remotos.

---

#### ✅ Conclusão

Este módulo oferece a base essencial para quem está começando a trabalhar com **banco de dados no .NET**, preparando o terreno para usar **ORMs como Entity Framework** ou executar **comandos SQL diretamente**.

---

##### ✍️ **Criado por:** *Fabio Zanneti* 🎯 Projeto: **WEX - End to End Engineering**