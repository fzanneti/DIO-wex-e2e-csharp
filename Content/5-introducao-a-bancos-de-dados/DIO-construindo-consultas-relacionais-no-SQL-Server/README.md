# WEX - End to End Engineering

# Desafio DIO + WEX - SQL Server e Banco de Dados

![GitHub repo size](https://img.shields.io/github/repo-size/fzanneti/wex-e2e-csharp)
![GitHub forks](https://img.shields.io/github/forks/fzanneti/wex-e2e-csharp?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/fzanneti/wex-e2e-csharp?style=social)
![Linguagem](https://img.shields.io/badge/Linguagem-CSharp-blue)
![Bootcamp](https://img.shields.io/badge/WEX-End--to--End%20Engineering-blueviolet?logo=vercel&logoColor=white)
![Plataforma](https://img.shields.io/badge/Powered%20by-DIO.io-red?logo=data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjZmZmIiB2aWV3Qm94PSIwIDAgMzIgMzIiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PHBhdGggZD0iTTYuNzEgMy4yNWMtMi44OCAxLjQxLTUuMDcgNC4yMy01LjA3IDcuNzYgMCAzLjU4IDIuMjggNi43IDUuMzMgOC4xNSAxLjgzLS42MiAyLjQtMi4yNiAyLjQtMy44MSAwLS4yMy0uMDItLjQ1LS4wNS0uNjZBLjQ0LjQ0IDAgMDExMC4xIDExYy4yNC0uNzUuMTEtMS41My0uMy0yLjIyQzguOTIgNy45NiA3LjMzIDcuNSA1Ljc0IDcuNjZhNS41NSA1LjU1IDAgM)
![Autor](https://img.shields.io/badge/Autor-fzanneti-blue?style=flat-square&logo=github)

Projeto proposto no Bootcamp **.NET Developer - WEX - End to End Engineering**, da plataforma **Digital Innovation One (DIO)**, com foco em modelagem e manipulação de dados utilizando **SQL Server**.

---

### Objetivo

Executar consultas SQL em um banco de dados relacional com estrutura de filmes, gêneros e atores. As queries demonstram conceitos como:

- Filtragem de dados
- Ordenação
- Agregação (COUNT, MAX)
- Relacionamentos via **JOINs**
- Uso de **chaves primárias e estrangeiras**

---

### Script de Criação do Banco

O script `films.sql` contido neste repositório realiza:

- Criação do banco `Filmes`
- Tabelas:
  - `Atores`
  - `Filmes`
  - `ElencoFilme`
  - `Generos`
  - `FilmesGenero`
- Relacionamentos entre tabelas com **chaves estrangeiras**
- Popularização das tabelas com dados reais (inserções via `INSERT`)

---

### Consultas (Queries)

Todas as consultas estão no arquivo `challenge.sql`.

1. Selecionar título e ano de lançamento

```sql

SELECT Nome, Ano FROM Filmes;

```

<img src="https://github.com/fzanneti/DIO-wex-e2e-csharp/blob/main/Assets/images/bd/querie1.jpg" alt="Querie 1" style="width: 600px;">

---

2. Buscar o nome e ano dos filmes, ordenados por ordem crescente pelo ano

```sql

SELECT Nome, Ano FROM Filmes ORDER BY Ano ASC;

```

<img src="https://github.com/fzanneti/DIO-wex-e2e-csharp/blob/main/Assets/images/bd/querie2.jpg" alt="Querie 2" style="width: 600px;">

---

3. Buscar pelo filme de volta para o futuro, trazendo o nome, ano e a duração

```sql

SELECT Nome, Ano, Duracao FROM Filmes WHERE Nome = 'De Volta para o Futuro';

```

<img src="https://github.com/fzanneti/DIO-wex-e2e-csharp/blob/main/Assets/images/bd/querie3.jpg" alt="Querie 3" style="width: 600px;">

---

4. Buscar os filmes lançados em 1997

```sql

SELECT Nome, Ano, Duracao FROM Filmes WHERE Ano = 1997;

```

<img src="https://github.com/fzanneti/DIO-wex-e2e-csharp/blob/main/Assets/images/bd/querie4.jpg" alt="Querie 4" style="width: 600px;">

---

5. Buscar filmes lançados após 2000

```sql

SELECT Nome, Ano, Duracao FROM Filmes WHERE Ano > 2000;

```

<img src="https://github.com/fzanneti/DIO-wex-e2e-csharp/blob/main/Assets/images/bd/querie5.jpg" alt="Querie 5" style="width: 600px;">

---

6. Buscar os filmes com a duracao maior que 100 e menor que 150, ordenando pela duracao em ordem crescente

```sql

SELECT Nome, Ano, Duracao FROM Filmes WHERE Duracao > 100 AND Duracao < 150 ORDER BY Duracao ASC;

```

<img src="https://github.com/fzanneti/DIO-wex-e2e-csharp/blob/main/Assets/images/bd/querie6.jpg" alt="Querie 6" style="width: 600px;">

---

7. Contagem de filmes por ano, ordenando por maior duração

```sql

SELECT Ano, COUNT(*) AS ContagemDeFilmes, MAX(Duracao) AS MaiorDuracao FROM Filmes GROUP BY Ano ORDER BY MaiorDuracao DESC;

```

<img src="https://github.com/fzanneti/DIO-wex-e2e-csharp/blob/main/Assets/images/bd/querie7.jpg" alt="Querie 7" style="width: 600px;">

---

8. Buscar os Atores do gênero masculino, retornando o PrimeiroNome, UltimoNome

```sql

SELECT PrimeiroNome, UltimoNome, Genero FROM Atores WHERE Genero = 'M';

```

<img src="https://github.com/fzanneti/DIO-wex-e2e-csharp/blob/main/Assets/images/bd/querie8.jpg" alt="Querie 8" style="width: 600px;">

---

9. Buscar os Atores do gênero feminino, retornando o PrimeiroNome, UltimoNome, e ordenando pelo PrimeiroNome

```sql

SELECT PrimeiroNome, UltimoNome, Genero FROM Atores WHERE Genero = 'F' ORDER BY PrimeiroNome ASC;

```

<img src="https://github.com/fzanneti/DIO-wex-e2e-csharp/blob/main/Assets/images/bd/querie9.jpg" alt="Querie 9" style="width: 600px;">

---

10. Filme + Gênero

```sql

SELECT Filmes.Nome, Generos.Genero FROM Filmes 
JOIN FilmesGenero ON Filmes.Id = FilmesGenero.IdFilme 
JOIN Generos ON FilmesGenero.IdGenero = Generos.Id;

```

<img src="https://github.com/fzanneti/DIO-wex-e2e-csharp/blob/main/Assets/images/bd/querie10.jpg" alt="Querie 10" style="width: 600px;">

---

11. Buscar o nome do filme e o gênero do tipo "Mistério"

```sql

SELECT Filmes.Nome, Generos.Genero FROM Filmes
INNER JOIN FilmesGenero ON Filmes.Id = FilmesGenero.IdFilme
INNER JOIN Generos ON FilmesGenero.IdGenero = Generos.Id
WHERE Genero = 'Mistério';

```

<img src="https://github.com/fzanneti/DIO-wex-e2e-csharp/blob/main/Assets/images/bd/querie11.jpg" alt="Querie 11" style="width: 600px;">

---

12. Filme + Atores + Papel

```sql

SELECT Filmes.Nome, Atores.PrimeiroNome, Atores.UltimoNome, ElencoFilme.Papel FROM Filmes
JOIN ElencoFilme ON Filmes.Id = ElencoFilme.IdFilme
JOIN Atores ON ElencoFilme.IdAtor = Atores.Id;

```

<img src="https://github.com/fzanneti/DIO-wex-e2e-csharp/blob/main/Assets/images/bd/querie12.jpg" alt="Querie 12" style="width: 600px;">

---

### Relacionamento das Tabelas

* **Filmes** (Id)   
  └─ 1\:N com **FilmesGenero** (IdFilme)   
  └─ 1\:N com **ElencoFilme** (IdFilme)   

* **Generos** (Id)   
  └─ 1\:N com **FilmesGenero** (IdGenero)   

* **Atores** (Id)   
  └─ 1\:N com **ElencoFilme** (IdAtor)   

---

### Aprendizados

* Prática de consultas SQL fundamentais para backend com .NET
* Compreensão de **JOINs** e manipulação de dados entre tabelas
* Modelagem de banco de dados relacional
* Conceitos de chaves primárias e estrangeiras

---

### Certificado

<img src="https://github.com/fzanneti/DIO-wex-e2e-csharp/blob/main/Assets/images/certificados/27-montando-consultas-relacionais-no-SQL-Server.jpg" alt="Certificado" width="600px">

---

##### ✍️ Seção criada por: *Fabio Zanneti* - 🎯 Bootcamp: **WEX - End to End Engineering**
[![GitHub](https://img.shields.io/badge/GitHub-fzanneti-181717?style=flat&logo=github)](https://github.com/fzanneti)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-fzanneti-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/fzanneti)