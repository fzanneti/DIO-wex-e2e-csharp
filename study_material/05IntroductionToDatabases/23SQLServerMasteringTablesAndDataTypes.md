# 🧩 SQL Server - Dominando Tabelas e Tipos de Dados

![GitHub repo size](https://img.shields.io/github/repo-size/fzanneti/wex-e2e-csharp)
![GitHub forks](https://img.shields.io/github/forks/fzanneti/wex-e2e-csharp?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/fzanneti/wex-e2e-csharp?style=social)
![Linguagem](https://img.shields.io/badge/Linguagem-CSharp-blue)
![Bootcamp](https://img.shields.io/badge/WEX-End--to--End%20Engineering-blueviolet?logo=vercel&logoColor=white)
![Plataforma](https://img.shields.io/badge/Powered%20by-DIO.io-red?logo=data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjZmZmIiB2aWV3Qm94PSIwIDAgMzIgMzIiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PHBhdGggZD0iTTYuNzEgMy4yNWMtMi44OCAxLjQxLTUuMDcgNC4yMy01LjA3IDcuNzYgMCAzLjU4IDIuMjggNi43IDUuMzMgOC4xNSAxLjgzLS42MiAyLjQtMi4yNiAyLjQtMy44MSAwLS4yMy0uMDItLjQ1LS4wNS0uNjZBLjQ0LjQ0IDAgMDExMC4xIDExYy4yNC0uNzUuMTEtMS41My0uMy0yLjIyQzguOTIgNy45NiA3LjMzIDcuNSA1Ljc0IDcuNjZhNS41NSA1LjU1IDAgM)
![Autor](https://img.shields.io/badge/Autor-fzanneti-blue?style=flat-square&logo=github)

---

### 📘 Introdução

No Bootcamp WEX, você está aprendendo C#, .NET, Git e GitHub. **Tabelas e tipos de dados no SQL Server** são essenciais para persistência de dados. Este módulo explora como criar e manipular tabelas com **SQL Server** e **EF Core**.

---

### 🗃️ Entendendo um Database

Um **database** (ou banco de dados) é o **repositório central** onde todas as tabelas, relacionamentos e dados da aplicação são armazenados.

No SQL Server, um database pode conter:
- Tabelas
- Procedures (procedimentos)
- Views (visões)
- Triggers (gatilhos)
- Funções

🎯 Comando para criar um database:

```sql

CREATE DATABASE NomeDoBanco;

```

---

### 🔐 Acessando o Banco de Dados

Após criar o banco ou abrir o SQL Server, usamos o comando:

```sql

USE NomeDoBanco;

```

Isso define qual banco estamos utilizando para as próximas instruções SQL.

---

### 🏗️ Criando Nossa Tabela

```sql

CREATE TABLE Clientes (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nome VARCHAR(100),
    Email VARCHAR(100),
    DataCadastro DATE
);

```

* `Id` é a chave primária e auto-incrementável
* `IDENTITY(1,1)` indica que começa no 1 e incrementa de 1 em 1

---

### 🔍 O Comando SELECT

Serve para consultar os dados de uma tabela.

```sql

SELECT * FROM Clientes;

```

* O `*` significa **"todas as colunas"**
* Para buscar colunas específicas:

```sql

SELECT Nome, Email FROM Clientes;

```

---

### 📑 Ordenando os Resultados

```sql

SELECT * FROM Clientes ORDER BY Nome ASC;

```

* `ASC`: crescente
* `DESC`: decrescente

---

### 🎯 Usando WHERE (Filtrando Dados)

```sql

SELECT * FROM Clientes WHERE Email LIKE '%@gmail.com';

```

* Permite filtrar dados com condições
* Pode usar `=`, `<`, `>`, `LIKE`, `IN`, `BETWEEN` etc.

---

### ➕ Realizando um INSERT

```sql

INSERT INTO Clientes (Nome, Email, DataCadastro)
VALUES ('Fabio Zanneti', 'fabio@email.com', '2025-06-15');

```

---

### ✂️ INSERT Omitindo Colunas

Se a tabela permite valores `NULL`, é possível omitir colunas:

```sql

INSERT INTO Clientes (Nome)
VALUES ('Maria');

```

---

### 🆔 Entendendo o ID

O `ID` é uma coluna chave primária (`PRIMARY KEY`), que **identifica unicamente cada registro**.

* Quando usamos `IDENTITY`, o valor é **gerado automaticamente**.
* Evita duplicidade e permite localizar registros com facilidade.

---

### 📌 Apontamento de Query

Você pode especificar qual tabela e quais campos está manipulando:

```sql

SELECT Nome FROM dbo.Clientes;

```

* `dbo` é o schema padrão do SQL Server.

---

### ✏️ Realizando um UPDATE

```sql

UPDATE Clientes
SET Email = 'novoemail@email.com'
WHERE Id = 1;

```

⚠️ **Sempre use WHERE para evitar atualizar todos os registros!**

---

### ⚠️ Cuidados com UPDATE

```sql

-- ERRADO: altera todos os registros!
UPDATE Clientes SET Email = 'teste@email.com';

-- CERTO: com filtro
UPDATE Clientes SET Email = 'teste@email.com' WHERE Id = 1;

```

---

## 🗑️ Deletando um Registro

```sql

DELETE FROM Clientes WHERE Id = 2;

```

⚠️ Assim como o UPDATE, **NUNCA use DELETE sem WHERE**.

---

### 🧠 Estudando Tipos de Dados

## 📚 Tabela de Tipos de Dados no SQL Server

| Tipo SQL            | Descrição                                                                 | Exemplos                     | Observações                                 |
|---------------------|---------------------------------------------------------------------------|------------------------------|---------------------------------------------|
| `INT`               | Número inteiro com sinal (positivo/negativo)                             | 0, 10, -200                  | Ocupa 4 bytes                               |
| `BIGINT`            | Número inteiro muito grande                                               | 9223372036854775807          | Ocupa 8 bytes                               |
| `SMALLINT`          | Número inteiro menor                                                      | -32.768 a 32.767             | Ocupa 2 bytes                               |
| `TINYINT`           | Apenas números positivos de 0 a 255                                       | 0, 255                       | Ocupa 1 byte                                |
| `DECIMAL(p,s)`      | Número decimal com precisão e escala (p = total de dígitos, s = casas decimais) | 12345.67 (`DECIMAL(7,2)`)    | Usado para valores monetários               |
| `FLOAT`             | Números com ponto flutuante (alta precisão)                              | 3.14159265359                | Aproximado, menos preciso que `DECIMAL`     |
| `REAL`              | Versão mais leve do `FLOAT`                                               | 3.14                         | Ocupa menos espaço                          |
| `BIT`               | Valor booleano (0 ou 1)                                                   | 1 (verdadeiro), 0 (falso)    | Ideal para flags e ativa/inativa            |
| `CHAR(n)`           | Texto de comprimento fixo                                                 | 'FABIO     '                 | Preenche com espaços até o tamanho `n`      |
| `VARCHAR(n)`        | Texto de comprimento variável                                             | 'Fabio'                      | Mais eficiente em espaço                    |
| `TEXT`              | Texto longo (descontinuado em versões recentes)                          | -                            | Substituído por `VARCHAR(MAX)`              |
| `VARCHAR(MAX)`      | Texto muito longo (até 2GB)                                               | -                            | Usado para textos extensos, ex: artigos     |
| `DATE`              | Armazena somente a data (YYYY-MM-DD)                                     | '2025-06-15'                 | Sem hora                                    |
| `DATETIME`          | Armazena data e hora (precisão de 3 milissegundos)                       | '2025-06-15 14:30:00'        | Usado amplamente                            |
| `DATETIME2`         | Versão aprimorada do `DATETIME` (maior precisão)                         | '2025-06-15 14:30:00.1234567'| Melhor desempenho e uso recomendado         |
| `TIME`              | Apenas o horário (sem a data)                                             | '14:30:00'                   | Ideal para agendamentos                     |
| `UNIQUEIDENTIFIER`  | Identificador único global (UUID)                                        | '6F9619FF-8B86-D011-B42D-00C04FC964FF' | Muito usado como chave primária alternativa |

---

📌 **Dicas**:
- Prefira `VARCHAR` ao invés de `CHAR` para textos que variam de tamanho.
- Use `DECIMAL` para valores financeiros (evita erros de arredondamento).
- `BIT` é perfeito para representar verdadeiro/falso ou ligado/desligado.
- `DATETIME2` é recomendado para novos projetos em vez de `DATETIME`.

---

### 🧱 Criando Outra Tabela de Exemplo

```sql

CREATE TABLE Produtos (
    ProdutoId INT PRIMARY KEY IDENTITY(1,1),
    Nome VARCHAR(100),
    Preco DECIMAL(10,2),
    Estoque INT
);

```

---

## 🗄️ Links Complementares de Estudo – SQL Server: Dominando Tabelas e Tipos de Dados

Compreender os **tipos de dados**, **estruturas de tabelas** e boas práticas de modelagem é essencial para desenvolver soluções eficientes com SQL Server. Aqui estão links e materiais de apoio para aprofundar no tema:

---

### 📚 Documentação Oficial Microsoft

- [Tipos de Dados (Transact-SQL)](https://learn.microsoft.com/pt-br/sql/t-sql/data-types/data-types-transact-sql)
  > Lista completa dos tipos de dados suportados no SQL Server, com descrição e exemplos.
- [CREATE TABLE (Transact-SQL)](https://learn.microsoft.com/pt-br/sql/t-sql/statements/create-table-transact-sql)
  > Guia oficial sobre a sintaxe para criar tabelas, constraints e propriedades avançadas.
- [CAST e CONVERT – Tratamento de Tipos](https://learn.microsoft.com/pt-br/sql/t-sql/functions/cast-and-convert-transact-sql)
  > Como converter tipos de dados corretamente no SQL Server.

- [Entity Framework Core](https://learn.microsoft.com/pt-br/ef/core/)

---

### 🧪 Ferramentas e Ambientes para Testes

- [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/pt-br/sql/ssms/download-sql-server-management-studio-ssms)
  > Ferramenta oficial da Microsoft para gerenciar bancos SQL Server localmente ou em rede.
- [Azure SQL (Gratuito por tempo limitado)](https://learn.microsoft.com/pt-br/azure/azure-sql/)
  > Ideal para testar soluções em nuvem com SQL Server.
- [DB Fiddle (com suporte parcial a SQL Server)](https://www.db-fiddle.com/)
  > Plataforma online para testar estruturas e comandos SQL sem precisar instalar nada.

---

#### ✅ Conclusão

Este módulo fornece o essencial para **manipular tabelas e dados no SQL Server**, base para qualquer aplicação .NET que dependa de persistência de dados.
Com isso, você já pode **criar, consultar, atualizar e deletar registros**, além de entender melhor como o banco se estrutura.

---

##### ✍️ Seção criada por: *Fabio Zanneti* - 🎯 Bootcamp: **WEX - End to End Engineering**
[![GitHub](https://img.shields.io/badge/GitHub-fzanneti-181717?style=flat&logo=github)](https://github.com/fzanneti)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-fzanneti-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/fzanneti)