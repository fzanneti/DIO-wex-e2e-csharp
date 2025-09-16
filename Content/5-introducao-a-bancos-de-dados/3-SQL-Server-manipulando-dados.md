# WEX - End to End Engineering

## 5.3 - SQL Server – Manipulando Dados

![GitHub repo size](https://img.shields.io/github/repo-size/fzanneti/wex-e2e-csharp)
![GitHub forks](https://img.shields.io/github/forks/fzanneti/wex-e2e-csharp?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/fzanneti/wex-e2e-csharp?style=social)
![Linguagem](https://img.shields.io/badge/Linguagem-CSharp-blue)
![Bootcamp](https://img.shields.io/badge/WEX-End--to--End%20Engineering-blueviolet?logo=vercel&logoColor=white)
![Plataforma](https://img.shields.io/badge/Powered%20by-DIO.io-red?logo=data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjZmZmIiB2aWV3Qm94PSIwIDAgMzIgMzIiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PHBhdGggZD0iTTYuNzEgMy4yNWMtMi44OCAxLjQxLTUuMDcgNC4yMy01LjA3IDcuNzYgMCAzLjU4IDIuMjggNi43IDUuMzMgOC4xNSAxLjgzLS42MiAyLjQtMi4yNiAyLjQtMy44MSAwLS4yMy0uMDItLjQ1LS4wNS0uNjZBLjQ0LjQ0IDAgMDExMC4xIDExYy4yNC0uNzUuMTEtMS41My0uMy0yLjIyQzguOTIgNy45NiA3LjMzIDcuNSA1Ljc0IDcuNjZhNS41NSA1LjU1IDAgM)
![Autor](https://img.shields.io/badge/Autor-fzanneti-blue?style=flat-square&logo=github)

---

### Introdução

No Bootcamp WEX, você está aprendendo C#, .NET, Git e GitHub. **Manipular dados no SQL Server** é essencial para consultas avançadas e relacionamentos. Este módulo explora comandos T-SQL e integração com **EF Core**.

---

### Usando o COUNT

O `COUNT` retorna a **quantidade de registros**.

```sql

SELECT COUNT(*) FROM Clientes;

```

* Também pode contar valores específicos:

```sql

SELECT COUNT(Email) FROM Clientes;

```

---

### Usando o SUM

O `SUM` retorna a **soma total de uma coluna numérica**.

```sql

SELECT SUM(Estoque) FROM Produtos;

```

---

### MÍN, MÁX e MÉDIA

`MIN` – valor mínimo

```sql

SELECT MIN(Preco) FROM Produtos;

```

`MAX` – valor máximo

```sql

SELECT MAX(Preco) FROM Produtos;
```


`AVG` – média dos valores

```sql

SELECT AVG(Preco) FROM Produtos;

```

---

### Concatenando Colunas

Você pode juntar colunas de texto com `+` ou `CONCAT`.

```sql

SELECT Nome + ' - ' + Email AS Informacao FROM Clientes;

```

Ou:

```sql

SELECT CONCAT(Nome, ' | ', Email) AS Info FROM Clientes;

```

---

### Funções UPPER e LOWER

* `UPPER()` → transforma o texto em **maiúsculas**
* `LOWER()` → transforma o texto em **minúsculas**

```sql

SELECT UPPER(Nome) AS NomeMaiusculo FROM Clientes;
SELECT LOWER(Email) AS EmailMinusculo FROM Clientes;

```

---

### Adicionando Nova Coluna

```sql

ALTER TABLE Clientes
ADD Telefone VARCHAR(15);

```

---

### Formatando uma Data

Usando `FORMAT()` para customizar exibição:

```sql

SELECT FORMAT(DataCadastro, 'dd/MM/yyyy') AS DataFormatada FROM Clientes;

```

---

### Entendendo o GROUP BY

Permite **agrupar registros** com base em um ou mais campos, geralmente usado com funções de agregação.

```sql

SELECT Preco, COUNT(*) AS Quantidade
FROM Produtos
GROUP BY Preco;

```

---

### Primary Key (PK) e Foreign Key (FK)

* **Primary Key**: identificador único da tabela.
* **Foreign Key**: cria **relação entre tabelas**.

Exemplo prático: Clientes e seus Endereços.

---

### Criando Tabela de Endereços com Foreign Key

```sql

CREATE TABLE Enderecos (
    EnderecoId INT PRIMARY KEY IDENTITY(1,1),
    ClienteId INT,
    Rua VARCHAR(100),
    Cidade VARCHAR(50),
    Estado VARCHAR(50),
    FOREIGN KEY (ClienteId) REFERENCES Clientes(Id)
);

```

* Cada endereço pertence a um cliente.
* A **chave estrangeira** (`ClienteId`) aponta para a PK da tabela `Clientes`.

---

### Realizando um JOIN

O `JOIN` é utilizado para **combinar registros de duas ou mais tabelas** com base em uma condição de relacionamento (normalmente uma **chave primária** e uma **chave estrangeira**).

```sql

SELECT c.Nome, e.Rua
FROM Clientes c
INNER JOIN Enderecos e ON c.Id = e.ClienteId;

```

> *Exibe apenas os clientes que possuem endereço cadastrado.*

---

### LEFT JOIN (ou LEFT OUTER JOIN)

Retorna **todos os registros da tabela da esquerda** (`Clientes`) e os correspondentes da direita (`Enderecos`).
Se não houver correspondência, os campos da tabela da direita virão como `NULL`.

```sql

SELECT c.Nome, e.Rua
FROM Clientes c
LEFT JOIN Enderecos e ON c.Id = e.ClienteId;

```

> *Exibe todos os clientes, mesmo os que **não têm endereço**.*

---

### RIGHT JOIN (ou RIGHT OUTER JOIN)

Retorna **todos os registros da tabela da direita** e os correspondentes da esquerda.
Se não houver correspondência, os campos da tabela da esquerda virão como `NULL`.

```sql

SELECT c.Nome, e.Rua
FROM Clientes c
RIGHT JOIN Enderecos e ON c.Id = e.ClienteId;

```

> *Exibe todos os endereços, mesmo os que **não estão ligados a clientes**.*

---

### FULL JOIN (ou FULL OUTER JOIN)

Retorna **todos os registros de ambas as tabelas**, combinando os dados quando há correspondência.
Se não houver, preenche com `NULL` nas colunas da tabela que não tiver valor correspondente.

```sql

SELECT c.Nome, e.Rua
FROM Clientes c
FULL JOIN Enderecos e ON c.Id = e.ClienteId;

```

> *Exibe todos os clientes e todos os endereços, inclusive os que **não têm relação** entre si.*

---

### Dica Visual (Resumão)

| JOIN       | O que retorna?                                      |
| ---------- | --------------------------------------------------- |
| INNER JOIN | Só os que têm correspondência nas duas tabelas      |
| LEFT JOIN  | Todos da esquerda + os que casam da direita         |
| RIGHT JOIN | Todos da direita + os que casam da esquerda         |
| FULL JOIN  | Todos de ambos os lados, com ou sem correspondência |

---

### Exemplo com Dados

Imaginando a tabela `Clientes` e `Enderecos`:

**Clientes**

| Id | Nome  |
| -- | ----- |
| 1  | Fabio |
| 2  | Maria |
| 3  | João  |

**Enderecos**

| EnderecoId | ClienteId | Rua   |
| ---------- | --------- | ----- |
| 1          | 1         | Rua A |
| 2          | 2         | Rua B |

* `INNER JOIN` → retorna Fabio e Maria com seus endereços.
* `LEFT JOIN` → retorna Fabio, Maria e João (João com `NULL` no endereço).
* `RIGHT JOIN` → retorna Fabio e Maria com endereço, e qualquer endereço sem cliente (se existisse).
* `FULL JOIN` → retorna todos os dados, mesmo sem correspondência (ex: João e um endereço sem dono).

---

### Links Complementares de Estudo – SQL Server: Manipulando Dados

Manipular dados é uma das habilidades mais fundamentais ao trabalhar com banco de dados. Isso inclui inserir, consultar, atualizar e excluir registros de forma segura e eficiente. Abaixo estão materiais gratuitos para dominar os principais comandos DML (Data Manipulation Language) no SQL Server.

🔗[SELECT (Transact-SQL)](https://learn.microsoft.com/pt-br/sql/t-sql/queries/select-transact-sql)     
Guia completo do comando `SELECT`, com cláusulas como `WHERE`, `ORDER BY`, `TOP`, `JOIN`     
🔗[INSERT (Transact-SQL)](https://learn.microsoft.com/pt-br/sql/t-sql/statements/insert-transact-sql)    
Sintaxe e exemplos para inserir dados em tabelas     
🔗[UPDATE (Transact-SQL)](https://learn.microsoft.com/pt-br/sql/t-sql/statements/update-transact-sql)     
Modificando dados existentes com `UPDATE`    
🔗[DELETE (Transact-SQL)](https://learn.microsoft.com/pt-br/sql/t-sql/statements/delete-transact-sql)     
Remoção de registros com segurança, incluindo uso de `WHERE`    
🔗[INNER JOIN e OUTER JOIN – Explicação](https://learn.microsoft.com/pt-br/sql/t-sql/queries/from-transact-sql?view=sql-server-ver16)    
Como unir tabelas com `JOIN` e suas variações    
🔗[SQL Server Management Studio (SSMS)](https://learn.microsoft.com/pt-br/sql/ssms/download-sql-server-management-studio-ssms)    
Ferramenta oficial para executar comandos SQL Server localmente    
🔗[DB Fiddle (com suporte a SQL Server)](https://www.db-fiddle.com/)     
Teste seus comandos online sem precisar instalar nada    
🔗[SQLPad – Executando SQL no Navegador](https://sqlpad.io/)     
Ótima opção para ensinar e praticar comandos SQL interativamente    

---

### Conclusão

Com esses comandos, você já consegue:

* **Analisar e resumir dados**
* **Formatar e transformar colunas**
* **Criar relações entre tabelas**
* **Trabalhar com múltiplas tabelas ao mesmo tempo**

Essa base é essencial para qualquer aplicação que manipule dados no back-end com C# e .NET.

---

### Certificado

<img src="https://github.com/fzanneti/DIO-wex-e2e-csharp/blob/main/Assets/images/certificados/25-SQL-Server-manipulando-dados.jpg" alt="Certificado" width="600px">

---

##### ✍️ Seção criada por: *Fabio Zanneti* - 🎯 Bootcamp: **WEX - End to End Engineering**
[![GitHub](https://img.shields.io/badge/GitHub-fzanneti-181717?style=flat&logo=github)](https://github.com/fzanneti)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-fzanneti-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/fzanneti)