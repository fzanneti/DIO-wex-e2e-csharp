# 🧩 SQL Server - Dominando Tabelas e Tipos de Dados

### 📘 Introdução

Neste módulo, vamos aprofundar os conhecimentos em **SQL Server**, dominando comandos essenciais para criar, consultar, modificar e excluir dados de tabelas. É a base prática para integrar **bancos relacionais** com aplicações em **C# e .NET**.

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

| Tipo SQL        | Descrição                      | Exemplo      |
| --------------- | ------------------------------ | ------------ |
| `INT`           | Número inteiro                 | 1, 100, -50  |
| `VARCHAR(100)`  | Texto variável                 | 'João'       |
| `DATE`          | Data                           | '2025-06-15' |
| `DECIMAL(10,2)` | Decimal com casas decimais     | 199.90       |
| `BIT`           | Booleano (0 = falso, 1 = true) | 1            |

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

#### ✅ Conclusão

Este módulo fornece o essencial para **manipular tabelas e dados no SQL Server**, base para qualquer aplicação .NET que dependa de persistência de dados.
Com isso, você já pode **criar, consultar, atualizar e deletar registros**, além de entender melhor como o banco se estrutura.

---

##### ✍️ **Seção criada por:** *Fabio Zanneti*
##### 🎯 Projeto: **WEX - End to End Engineering**