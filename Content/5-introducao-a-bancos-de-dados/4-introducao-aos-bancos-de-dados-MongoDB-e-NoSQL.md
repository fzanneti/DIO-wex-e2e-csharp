# WEX - End to End Engineering

## 4.4 - MongoDB com C# e Bancos de Dados NoSQL

![GitHub repo size](https://img.shields.io/github/repo-size/fzanneti/wex-e2e-csharp)
![GitHub forks](https://img.shields.io/github/forks/fzanneti/wex-e2e-csharp?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/fzanneti/wex-e2e-csharp?style=social)
![Linguagem](https://img.shields.io/badge/Linguagem-CSharp-blue)
![Bootcamp](https://img.shields.io/badge/WEX-End--to--End%20Engineering-blueviolet?logo=vercel&logoColor=white)
![Plataforma](https://img.shields.io/badge/Powered%20by-DIO.io-red?logo=data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjZmZmIiB2aWV3Qm94PSIwIDAgMzIgMzIiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PHBhdGggZD0iTTYuNzEgMy4yNWMtMi44OCAxLjQxLTUuMDcgNC4yMy01LjA3IDcuNzYgMCAzLjU4IDIuMjggNi43IDUuMzMgOC4xNSAxLjgzLS42MiAyLjQtMi4yNiAyLjQtMy44MSAwLS4yMy0uMDItLjQ1LS4wNS0uNjZBLjQ0LjQ0IDAgMDExMC4xIDExYy4yNC0uNzUuMTEtMS41My0uMy0yLjIyQzguOTIgNy45NiA3LjMzIDcuNSA1Ljc0IDcuNjZhNS41NSA1LjU1IDAgM)
![Autor](https://img.shields.io/badge/Autor-fzanneti-blue?style=flat-square&logo=github)

---

### Introdução ao NoSQL

No Bootcamp WEX, você está aprendendo C#, .NET, Git e GitHub. **Bancos NoSQL** (MongoDB, Redis, Neo4j). Este módulo explora integração com C# e operações CRUD.

O termo **NoSQL (Not Only SQL)** refere-se a bancos de dados que **não utilizam modelo relacional tradicional**. São ideais para aplicações modernas que exigem **alta performance, flexibilidade e escalabilidade horizontal**.

> São perfeitos para trabalhar com dados semi-estruturados, como documentos JSON.

---

### Tipos de Bancos de Dados NoSQL

| Tipo             | Descrição                                | Exemplos                |
|------------------|-------------------------------------------|-------------------------|
| Chave-Valor      | Armazenamento simples em pares            | Redis, DynamoDB         |
| Colunar          | Focado em colunas, ideal para analytics   | Cassandra, HBase        |
| Documentos       | Armazena documentos (JSON/BSON)           | MongoDB, CouchDB        |
| Grafos           | Foco em relacionamentos complexos         | Neo4j, ArangoDB         |

---

<img src="https://github.com/fzanneti/DIO-wex-e2e-csharp/blob/main/Assets/images/neo4j.jpg" alt="neo4j" width="600px">

### Neo4j e Bancos de Dados Orientados a Grafos

**O que são Bancos de Dados em Grafos?**

Um **banco de dados orientado a grafos** representa dados como **nós (nodes), arestas (relationships)** e **propriedades**, espelhando relações reais entre entidades.

> **Exemplo real**: Redes sociais (usuário → segue → outro usuário)

---

### Introdução ao Neo4j

O **Neo4j** é o banco de grafos mais popular do mercado. Ele permite:

- Representar entidades como **nós** (`nodes`)
- Conectar entidades com **relacionamentos** (`edges`)
- Atribuir **propriedades** aos nós e relações
- Executar **consultas poderosas com a linguagem Cypher**

---

### Teste comandos sem instalação 

**Testando sem instalar nada – Neo4j Sandbox**

Você pode começar a testar o **Neo4j diretamente no navegador** usando a ferramenta gratuita e oficial da plataforma:

Acesse: 🔗[Neo4j - Web](https://sandbox.neo4j.com)

**Passos para usar:**

1. Clique em **"Start Project"**
2. Selecione o modelo **"Blank Sandbox"**
3. Aguarde a criação do ambiente (leva poucos segundos)
4. Clique em **"Open"** para abrir o console Cypher
5. Use os comandos abaixo direto no editor:

**Exemplos práticos:**

```cypher

CREATE (:Pessoa {nome: 'Fabio', idade: 43})
CREATE (:Pessoa {nome: 'Miguel', idade: 6})

MATCH (p1:Pessoa {nome: 'Fabio'}), (p2:Pessoa {nome: 'Miguel'})
CREATE (p1)-[:PAI_DE]->(p2)

MATCH (pai:Pessoa)-[:PAI_DE]->(filho)
RETURN pai.nome, filho.nome

```

---

### Sobre o Sandbox

Validade: 3 dias (renovável)

Ambiente isolado: Cada sandbox é um banco exclusivo seu

Não precisa login em desktop: Tudo é web-based

Ideal para aprender e demonstrar

---

### Dica:

Use o botão "Code Snippets" no Sandbox para acessar exemplos prontos com modelagem de filmes, redes sociais, etc.

---

### Instalando o Neo4j

**Local**

1. Acesse: 🔗[Neo4j - Desktop](https://neo4j.com/download/)
2. Baixe e instale o Neo4j Desktop
3. Crie um novo banco e inicie o ambiente

**Cloud (Neo4j Aura Free)**

1. Acesse: 🔗[Neo4j - Cloud](https://neo4j.com/cloud/aura/)
2. Crie uma conta gratuita
3. Crie um banco e copie a `connection string` e credenciais

---

### Estrutura Conceitual

```text

(Nó) --[Relação]--> (Nó)

Exemplo:

(Fabio:Pessoa {idade:43}) -[:PAI_DE]-> (Miguel:Pessoa {idade:6})

```

---

### Linguagem Cypher - Consultas Básicas

**Criar Nós**

```cypher

CREATE (:Pessoa {nome: 'Fabio', idade: 43})
CREATE (:Pessoa {nome: 'Miguel', idade: 6})

```

**Criar Relacionamento**

```cypher

MATCH (p1:Pessoa {nome: 'Fabio'}), (p2:Pessoa {nome: 'Miguel'})
CREATE (p1)-[:PAI_DE]->(p2)

```

**Buscar Relações**

```cypher

MATCH (p:Pessoa)-[:PAI_DE]->(filho)
RETURN p.nome, filho.nome

```

---

### Vantagens dos Bancos em Grafos

|Vantagem	|Explicação|
|---|---|
|Modelagem natural	|Ideal para representar relações reais|
|Performance em relacionamentos	|Alta performance mesmo com muitos vínculos|
|Flexível e escalável|	Fácil de adaptar novos tipos de relações e entidades|
|Linguagem declarativa (Cypher)	|Sintaxe próxima de linguagem humana, fácil de aprender|

---

### Integração com C# (.NET)

**Instalar o Driver .NET**

```bash

dotnet add package Neo4j.Driver

```

**Exemplo de Conexão**

```csharp

using Neo4j.Driver;

var uri = "bolt://localhost:7687"; // ou URI da Aura Cloud
var user = "neo4j";
var password = "sua_senha";

using var driver = GraphDatabase.Driver(uri, AuthTokens.Basic(user, password));
using var session = driver.AsyncSession();

// Inserindo um nó
await session.RunAsync("CREATE (:Pessoa {nome: 'Fabio', idade: 43})");

// Fechando sessão
await session.CloseAsync();

```

---

### Buscar Dados com C#

```csharp

var result = await session.RunAsync("MATCH (p:Pessoa) RETURN p.nome, p.idade");

await result.ForEachAsync(record =>
{
    Console.WriteLine($"{record["p.nome"]} - {record["p.idade"]}");
});

```

---

### Casos de Uso Comuns

- Redes Sociais: seguidores, amigos, curtidas
- Recomendação: filmes, produtos, perfis
- Logística: rotas, conexões, hubs
- Detecção de fraudes: transações suspeitas em redes bancárias

---

### Conclusão

O Neo4j é uma excelente ferramenta para aplicações .NET que demandam modelagem de relações complexas. Com integração simples via C# e consultas com Cypher, ele oferece:

- Alta expressividade
- Performance para dados conectados
- Uma nova abordagem para modelar o mundo real

---

<img src="https://github.com/fzanneti/DIO-wex-e2e-csharp/blob/main/Assets/images/apache_cassandra.png" alt="Apache Cassandra" width="600px">

### Apache Cassandra – Banco de Dados Colunar  

**O que é o Cassandra?**

O **Apache Cassandra** é um **banco de dados NoSQL distribuído baseado em colunas**, projetado para lidar com grandes volumes de dados em ambientes distribuídos com alta disponibilidade e performance.

> Ideal para **grandes aplicações que exigem escalabilidade horizontal**, como IoT, redes sociais e serviços de streaming.

---

### Modelo Colunar vs Relacional

| Relacional (SQL)          | Colunar (Cassandra)             |
|---------------------------|---------------------------------|
| Linhas com colunas fixas  | Colunas agrupadas por família   |
| Escalabilidade vertical   | Escalabilidade horizontal       |
| Rígido e estruturado      | Flexível e tolerante a falhas   |
| JOINs e relações fortes   | Sem JOIN, foco em consultas rápidas por chave |

---

### Estrutura de Dados do Cassandra

- **Keyspace**: Equivalente ao “banco de dados” em SQL
- **Table**: Armazena os dados, organizada por **famílias de colunas**
- **Partition Key**: Define onde os dados serão armazenados no cluster
- **Clustering Columns**: Organiza os dados dentro da partição

**Exemplo:**

```text

Keyspace: usuarios_app

Tabela: usuarios
    - id (partition key)
    - nome
    - email
    - data_criacao

```

---

### Vantagens do Cassandra

|Recurso|	Benefício|
|---|---|
|Alta escalabilidade	|Distribui os dados horizontalmente em múltiplos nós|
|Tolerância a falhas	|Dados replicados automaticamente (sem ponto único de falha)|
|Esquema flexível	|Adição de colunas sem necessidade de alterar toda a tabela|
Escritas rápidas|	Projetado para grandes volumes de escrita|

---

### Instalando o Cassandra (Ambiente Local)

**🐳 Usando Docker (opcional)**

```bash

docker run --name cassandra -p 9042:9042 -d cassandra

```

Ou:

1. Baixe em: 🔗[Cassandra - Download](https://cassandra.apache.org/_/download.html)
2. Extraia e execute os scripts (bin/cassandra)

---

### Testando com CQL (Cassandra Query Language)

**Criando um Keyspace**

```Sql

CREATE KEYSPACE usuarios_app WITH replication = {
  'class': 'SimpleStrategy',
  'replication_factor': 1
};

```

**Criando uma Tabela**

```Sql

USE usuarios_app;

CREATE TABLE usuarios (
  id UUID PRIMARY KEY,
  nome TEXT,
  email TEXT,
  data_criacao TIMESTAMP
);

```

**Inserindo Dados**

```Sql

INSERT INTO usuarios (id, nome, email, data_criacao)
VALUES (uuid(), 'Fabio', 'fabio@email.com', toTimestamp(now()));

```

**Consultando Dados**


```Sql

SELECT * FROM usuarios;

```

---

### Testar sem instalar nada – Cassandra Playground

**Você pode testar o CQL direto no navegador em plataformas como:**

🔗[Cassandra - Teste](https://www.killercoda.com/cassandra)
🔗[DataStax Astra - Teste](https://www.datastax.com/astra)

**Dica:**

Use o DataStax Astra (versão cloud gratuita do Cassandra), ideal para praticar sem setup local.

---

### Integração com .NET (C#)

**Instalar o Driver**

```bash

dotnet add package CassandraCSharpDriver

```

**Exemplo de Conexão**

```csharp

using Cassandra;

var cluster = Cluster.Builder()
    .AddContactPoint("127.0.0.1") // ou IP da Astra Cloud
    .Build();

var session = cluster.Connect("usuarios_app");

var rs = session.Execute("SELECT * FROM usuarios");

foreach (var row in rs)
{
    Console.WriteLine($"{row["nome"]} - {row["email"]}");
}

```

---

### Considerações Finais

O Cassandra é ideal para aplicações que precisam:

- Armazenar muito volume de dados
- Suportar escritas frequentes
- Alta disponibilidade e resiliência
- Trabalhar com consulta rápida por chave primária

---

<img src="https://github.com/fzanneti/DIO-wex-e2e-csharp/blob/main/Assets/images/redis.png" alt="Redis" width="600px">

### Redis – Banco de Dados Chave-Valor  

**O que é o Redis?**

O **Redis** (Remote Dictionary Server) é um banco de dados NoSQL do tipo **chave-valor** e armazenado em memória. Ele é extremamente rápido e amplamente usado para:

- Cache de dados
- Armazenar sessões de usuários
- Filas e publicações/assinaturas (pub/sub)
- Contadores, listas, conjuntos e mais

> Redis é mais que um cache — é uma **estrutura de dados em memória**, simples e poderosa.

---

### Como funciona o modelo chave-valor?

- **Chave (key)**: identificador único
- **Valor (value)**: qualquer tipo de dado (string, lista, hash, set, etc.)

```text

chave: "usuario:101"
valor: "{ nome: 'Fabio', idade: 43 }"

```

---

### Vantagens do Redis

|Recurso|	Benefício|
|---|---|
|In-memory (na RAM)	|Acesso ultra-rápido aos dados|
|Tipos de dados avançados	| Listas, hashes, sets, sorted sets|
|Persistência opcional	|Pode salvar dados em disco mesmo sendo memória|
|Escalável e leve	|Ideal para sistemas de alto desempenho|
|Suporte a Pub/Sub	|Comunicação entre serviços em tempo real|

---

### Instalação do Redis

**Local (via Docker)**

```bash

docker run --name redis -p 6379:6379 -d redis

```

**Cloud (Redis Cloud Gratuito)**

1. Acesse: 🔗[Redis - Cloud](https://redis.com/try-free)
2. Crie um cluster gratuito
3. Copie a string de conexão

---

### Comandos Básicos no Redis CLI

```bash

redis-cli

```

- Armazenar valor

```Redis

SET usuario:101 "Fabio"

```

- Buscar valor

```Redis

GET usuario:101

```

- Expiração de chave

```Redis

SET codigo:123456 "validado"
EXPIRE codigo:123456 60

```

---

### Integração com C# (.NET)

**Instalar pacote NuGet**

```bash

dotnet add package StackExchange.Redis

```

**Conectar e usar o Redis**

```csharp

using StackExchange.Redis;

var redis = ConnectionMultiplexer.Connect("localhost"); // ou Redis Cloud URI
var db = redis.GetDatabase();

// SET
db.StringSet("usuario:101", "Fabio");

// GET
string nome = db.StringGet("usuario:101");
Console.WriteLine($"Nome: {nome}");

```

---

### Outros tipos de dados suportados

|Tipo|	Exemplo de Uso|
|---|---|
|String|	Valores simples e JSONs|
|Hash	|Objetos (ex: usuario:102 => nome, idade)|
|List	|Filas e histórico|
|Set	|Conjuntos sem repetição|
|Sorted Set|	Rankings com pontuação|
|Pub/Sub	|Comunicação em tempo real entre serviços|

---

### Testando Online – Redis Playground

Você pode testar comandos Redis no navegador:

🔗[Redis - Web](https://try.redis.io/)

---

### Exemplo com Expiração e Sessão

```csharp

db.StringSet("sessao:fabio", "ativo", TimeSpan.FromMinutes(30));

```

> Ideal para sessões expiráveis sem precisar de banco tradicional.

---

### Quando usar Redis?

- Armazenar sessões de login
- Cache de resultados de queries
- Fila de tarefas assíncronas
- Contadores e notificações
- Controle de acesso e rate-limit

---

### Conclusão

O Redis é essencial em sistemas de alta performance, sendo leve, rápido e extremamente útil para aplicações .NET. Mesmo com estrutura simples, permite resolver problemas complexos de cache, tempo real e persistência temporária.

---

### MongoDB com C# – Introdução e Instalação

**Instalando o MongoDB Driver**

No seu projeto .NET:

```bash

dotnet add package MongoDB.Driver

```

---

<img src="https://github.com/fzanneti/DIO-wex-e2e-csharp/blob/main/Assets/images/mongodb.jpg" alt="Redis" width="600px">

### Criando o Cluster (MongoDB Atlas)

1. Acesse: 🔗[MongoDB](https://www.mongodb.com/cloud/atlas)
2. Crie um cluster gratuito.
3. Configure um usuário e libere IP (pode usar 0.0.0.0 para testes).
4. Copie a **connection string** (ex: `mongodb+srv://usuario:senha@cluster.mongodb.net`)

---

### Schema Design e Boas Práticas

**Exemplo de Classe com Atributos**

```csharp

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class Usuario
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement("nome")]
    public string Nome { get; set; }

    [BsonElement("idade")]
    public int Idade { get; set; }
}

```

> **Use atributos do namespace `MongoDB.Bson.Serialization.Attributes`** para mapear corretamente os campos.

---

### Conexão com o MongoDB

```csharp

using MongoDB.Driver;

var client = new MongoClient("sua_connection_string");
var database = client.GetDatabase("MinhaBase");
var collection = database.GetCollection<Usuario>("usuarios");

```

---

### Operações com MongoDB no C\#

**Inserir um Documento**

```csharp

var novoUsuario = new Usuario { Nome = "Fabio", Idade = 43 };
await collection.InsertOneAsync(novoUsuario);

```

---

**Buscar Documentos**

```csharp

var usuarios = await collection.Find(u => u.Idade > 40).ToListAsync();

```

---

**Atualizar Documento**

```csharp

var filtro = Builders<Usuario>.Filter.Eq(u => u.Nome, "Fabio");
var atualizacao = Builders<Usuario>.Update.Set(u => u.Idade, 44);

await collection.UpdateOneAsync(filtro, atualizacao);

```

---

**Remover Documento**

```csharp

await collection.DeleteOneAsync(u => u.Nome == "Fabio");

```

---

### Índices e Performance

Você pode criar índices programaticamente:

```csharp

var indexKeys = Builders<Usuario>.IndexKeys.Ascending(u => u.Idade);
await collection.Indexes.CreateOneAsync(new CreateIndexModel<Usuario>(indexKeys));

```

> Use com moderação — muitos índices impactam o desempenho de inserções.

---

### Agregações com C\#

Exemplo: Contar quantos usuários existem por idade:

```csharp

var resultado = await collection.Aggregate()
    .Group(u => u.Idade, g => new { Idade = g.Key, Total = g.Count() })
    .ToListAsync();

```

### Outros operadores úteis:

* `.Match()` → filtro
* `.Project()` → projeção de campos
* `.Sort()` → ordenação
* `.Limit()` → limite de resultados

---

### JSON vs BSON

| Formato | Descrição                   | Vantagens                       |
| ------- | --------------------------- | ------------------------------- |
| JSON    | Texto leve, legível         | Ideal para APIs                 |
| BSON    | Binário, suporta mais tipos | Rápido e eficiente para leitura |

---

### Conclusão

Neste módulo aprendemos:

* Fundamentos NoSQL e tipos de banco
* Instalar e usar MongoDB com .NET
* Criar schema em C# com boas práticas
* Manipular dados (CRUD)
* Agregar e trabalhar com índices

MongoDB é altamente integrado com C# e uma excelente escolha para aplicações modernas que precisam de performance e flexibilidade.

---

### Neo4j – Banco de Dados de Grafos - Documentação e Guias

🔗[Documentação Oficial (em inglês)](https://neo4j.com/docs/)      
🔗[Neo4j Cypher Manual (linguagem de consulta)](https://neo4j.com/docs/cypher-refcard/current/)     
🔗[Guia de introdução rápida](https://neo4j.com/developer/get-started/)      
🔗[Guia prático em português - Data Hackers](https://www.linkedin.com/pulse/introdu%C3%A7%C3%A3o-ao-neo4j-com-cypher-n%C3%A3o-%C3%A9-magia-%C3%A9-grafo-leonardo-cavalcante)         
🔗[Neo4j Sandbox](https://sandbox.neo4j.com) *(não precisa instalar nada)*        
🔗[Playground com queries de filmes](https://neo4j.com/developer/example-project/)       
🔗[Neo4jClient (biblioteca C#)](https://github.com/Readify/Neo4jClient)        
🔗[Exemplo de uso com .NET](https://neo4j.com/developer/dotnet/)       

---

### Apache Cassandra – Banco de Dados Colunar - Documentação e Guias

🔗[Documentação Oficial](https://cassandra.apache.org/doc/latest/)        
🔗[CQL (Cassandra Query Language)](https://cassandra.apache.org/doc/latest/cql/)       
🔗[Curso Gratuito: Cassandra Essentials – DataStax](https://academy.datastax.com/courses/cassandra-essentials)      
🔗[Visão geral simplificada em português – Medium](https://medium.com/@souzamagno/introdu%C3%A7%C3%A3o-ao-banco-de-dados-cassandra-d0d63f632a98)       
🔗[KillerCoda – Terminal interativo com Cassandra](https://www.killercoda.com/cassandra)       
🔗[DataStax Astra – Cassandra Cloud Gratuito](https://www.datastax.com/astra)      
🔗[DataStax C# Driver](https://docs.datastax.com/en/developer/csharp-driver/)      
🔗[Repositório GitHub - Cassandra C# Driver](https://github.com/datastax/csharp-driver)       

---

### Redis – Banco de Dados Chave-Valor em Memória - Documentação e Guias

🔗[Documentação Oficial Redis](https://redis.io/docs/)      
🔗[Comandos Redis com exemplos](https://redis.io/commands/)      
🔗[Guia Redis para desenvolvedores .NET](https://stackexchange.github.io/StackExchange.Redis/)     
🔗[Artigo introdutório em português – Dev.to](https://dev.to/melgaco/introducao-ao-redis-pt-br-1o5d)      
🔗[Redis Playground Oficial](https://try.redis.io/)       
🔗[RedisInsight (ferramenta visual)](https://redis.com/redis-enterprise/redis-insight/)     
🔗[StackExchange.Redis (biblioteca oficial para .NET)](https://github.com/StackExchange/StackExchange.Redis)       
🔗[Exemplos de uso no .NET Docs](https://learn.microsoft.com/en-us/azure/azure-cache-for-redis/cache-dotnet-core-quickstart)     

---

### MongoDB – Banco de Dados Orientado a Documentos - Documentação e Guias

🔗[MongoDB Docs Oficial](https://www.mongodb.com/docs/)      
🔗[MongoDB University (cursos gratuitos)](https://learn.mongodb.com/)      
🔗[Introdução ao MongoDB – Digital Innovation One](https://web.digitalinnovation.one/course/introducao-ao-mongodb/learning/8e316210-232b-4ab3-9ac7-eac0bc7c5b8b)      
🔗[Cheat Sheet MongoDB (inglês)](https://www.mongodb.com/developer/products/mongodb/cheat-sheet/)     
🔗[MongoDB Atlas (Cloud gratuito)](https://www.mongodb.com/cloud/atlas/register)       
🔗[Playground no Compass](https://www.mongodb.com/products/compass)      
🔗[MongoDB.Driver (NuGet oficial)](https://www.nuget.org/packages/MongoDB.Driver/)      
🔗[Documentação oficial MongoDB com C#](https://mongodb.github.io/mongo-csharp-driver/2.19/)      
🔗[Exemplo CRUD com MongoDB e C#](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mongo-app)      

---

### Certificado

<img src="https://github.com/fzanneti/DIO-wex-e2e-csharp/blob/main/Assets/images/certificados/26-introducao-ao-MongoDB-e-bancos-de-dados-NoSQL.jpg" alt="Certificado" width="300px">

---

##### ✍️ Seção criada por: *Fabio Zanneti* - 🎯 Bootcamp: **WEX - End to End Engineering**
[![GitHub](https://img.shields.io/badge/GitHub-fzanneti-181717?style=flat&logo=github)](https://github.com/fzanneti)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-fzanneti-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/fzanneti)