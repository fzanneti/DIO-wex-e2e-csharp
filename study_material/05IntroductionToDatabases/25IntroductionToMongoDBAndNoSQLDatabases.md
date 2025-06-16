# 🍃 MongoDB com C# e Bancos de Dados NoSQL  

### 📘 Introdução ao NoSQL

O termo **NoSQL (Not Only SQL)** refere-se a bancos de dados que **não utilizam modelo relacional tradicional**. São ideais para aplicações modernas que exigem **alta performance, flexibilidade e escalabilidade horizontal**.

> ✅ São perfeitos para trabalhar com dados semi-estruturados, como documentos JSON.

---

### 🧩 Tipos de Bancos de Dados NoSQL

| Tipo             | Descrição                                | Exemplos                |
|------------------|-------------------------------------------|-------------------------|
| Chave-Valor      | Armazenamento simples em pares            | Redis, DynamoDB         |
| Colunar          | Focado em colunas, ideal para analytics   | Cassandra, HBase        |
| Documentos       | Armazena documentos (JSON/BSON)           | MongoDB, CouchDB        |
| Grafos           | Foco em relacionamentos complexos         | Neo4j, ArangoDB         |

---

## 🔗 Neo4j e Bancos de Dados Orientados a Grafos

### 🧠 O que são Bancos de Dados em Grafos?

Um **banco de dados orientado a grafos** representa dados como **nós (nodes), arestas (relationships)** e **propriedades**, espelhando relações reais entre entidades.

> 📌 **Exemplo real**: Redes sociais (usuário → segue → outro usuário)

---

### 🌐 Introdução ao Neo4j

O **Neo4j** é o banco de grafos mais popular do mercado. Ele permite:

- Representar entidades como **nós** (`nodes`)
- Conectar entidades com **relacionamentos** (`edges`)
- Atribuir **propriedades** aos nós e relações
- Executar **consultas poderosas com a linguagem Cypher**

---

## 🌐 Teste comandos sem instalação 

### 🧪 Testando sem instalar nada – Neo4j Sandbox

Você pode começar a testar o **Neo4j diretamente no navegador** usando a ferramenta gratuita e oficial da plataforma:

1. 🔗 Acesse: [https://sandbox.neo4j.com](https://sandbox.neo4j.com)

### ▶️ Passos para usar:

1. Clique em **"Start Project"**
2. Selecione o modelo **"Blank Sandbox"**
3. Aguarde a criação do ambiente (leva poucos segundos)
4. Clique em **"Open"** para abrir o console Cypher
5. Use os comandos abaixo direto no editor:

### 💡 Exemplos práticos:

```cypher

CREATE (:Pessoa {nome: 'Fabio', idade: 43})
CREATE (:Pessoa {nome: 'Miguel', idade: 6})

MATCH (p1:Pessoa {nome: 'Fabio'}), (p2:Pessoa {nome: 'Miguel'})
CREATE (p1)-[:PAI_DE]->(p2)

MATCH (pai:Pessoa)-[:PAI_DE]->(filho)
RETURN pai.nome, filho.nome

```

---

### 📦 Sobre o Sandbox

Validade: 3 dias (renovável)

Ambiente isolado: Cada sandbox é um banco exclusivo seu

Não precisa login em desktop: Tudo é web-based

Ideal para aprender e demonstrar

---

### 📌 Dica:

Use o botão "Code Snippets" no Sandbox para acessar exemplos prontos com modelagem de filmes, redes sociais, etc.

---

## 🛠️ Instalando o Neo4j

### 🔹 Local

1. Acesse: https://neo4j.com/download/
2. Baixe e instale o Neo4j Desktop
3. Crie um novo banco e inicie o ambiente

### ☁️ Cloud (Neo4j Aura Free)

1. Acesse: https://neo4j.com/cloud/aura/
2. Crie uma conta gratuita
3. Crie um banco e copie a `connection string` e credenciais

---

### 🔍 Estrutura Conceitual

```text

(Nó) --[Relação]--> (Nó)

Exemplo:

(Fabio:Pessoa {idade:43}) -[:PAI_DE]-> (Miguel:Pessoa {idade:6})

```

---

## 🔤 Linguagem Cypher - Consultas Básicas

### 🔸 Criar Nós

```cypher

CREATE (:Pessoa {nome: 'Fabio', idade: 43})
CREATE (:Pessoa {nome: 'Miguel', idade: 6})

```

### 🔸 Criar Relacionamento

```cypher

MATCH (p1:Pessoa {nome: 'Fabio'}), (p2:Pessoa {nome: 'Miguel'})
CREATE (p1)-[:PAI_DE]->(p2)

```

### 🔸 Buscar Relações

```cypher

MATCH (p:Pessoa)-[:PAI_DE]->(filho)
RETURN p.nome, filho.nome

```

---

### 📊 Vantagens dos Bancos em Grafos

|Vantagem	|Explicação|
|---|---|
|Modelagem natural	|Ideal para representar relações reais|
|Performance em relacionamentos	|Alta performance mesmo com muitos vínculos|
|Flexível e escalável|	Fácil de adaptar novos tipos de relações e entidades|
|Linguagem declarativa (Cypher)	|Sintaxe próxima de linguagem humana, fácil de aprender|

---

## 💻 Integração com C# (.NET)

### 🔹 Instalar o Driver .NET

```bash

dotnet add package Neo4j.Driver

```

### 🔹 Exemplo de Conexão

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

### 🔹 Buscar Dados com C#

```csharp

var result = await session.RunAsync("MATCH (p:Pessoa) RETURN p.nome, p.idade");

await result.ForEachAsync(record =>
{
    Console.WriteLine($"{record["p.nome"]} - {record["p.idade"]}");
});

```

---

### 🧠 Casos de Uso Comuns

- Redes Sociais: seguidores, amigos, curtidas
- Recomendação: filmes, produtos, perfis
- Logística: rotas, conexões, hubs
- Detecção de fraudes: transações suspeitas em redes bancárias

---

#### ✅ Conclusão

O Neo4j é uma excelente ferramenta para aplicações .NET que demandam modelagem de relações complexas. Com integração simples via C# e consultas com Cypher, ele oferece:

- Alta expressividade
- Performance para dados conectados
- Uma nova abordagem para modelar o mundo real

---

## 📊 Apache Cassandra – Banco de Dados Colunar  

### 📘 O que é o Cassandra?

O **Apache Cassandra** é um **banco de dados NoSQL distribuído baseado em colunas**, projetado para lidar com grandes volumes de dados em ambientes distribuídos com alta disponibilidade e performance.

> 🔧 Ideal para **grandes aplicações que exigem escalabilidade horizontal**, como IoT, redes sociais e serviços de streaming.

---

### 🧩 Modelo Colunar vs Relacional

| Relacional (SQL)          | Colunar (Cassandra)             |
|---------------------------|---------------------------------|
| Linhas com colunas fixas  | Colunas agrupadas por família   |
| Escalabilidade vertical   | Escalabilidade horizontal       |
| Rígido e estruturado      | Flexível e tolerante a falhas   |
| JOINs e relações fortes   | Sem JOIN, foco em consultas rápidas por chave |

---

### 🧱 Estrutura de Dados do Cassandra

- **Keyspace**: Equivalente ao “banco de dados” em SQL
- **Table**: Armazena os dados, organizada por **famílias de colunas**
- **Partition Key**: Define onde os dados serão armazenados no cluster
- **Clustering Columns**: Organiza os dados dentro da partição

### Exemplo:

```text

Keyspace: usuarios_app

Tabela: usuarios
    - id (partition key)
    - nome
    - email
    - data_criacao

```

---

### 🚀 Vantagens do Cassandra

|Recurso|	Benefício|
|---|---|
|Alta escalabilidade	|Distribui os dados horizontalmente em múltiplos nós|
|Tolerância a falhas	|Dados replicados automaticamente (sem ponto único de falha)|
|Esquema flexível	|Adição de colunas sem necessidade de alterar toda a tabela|
Escritas rápidas|	Projetado para grandes volumes de escrita|

---

## 🛠️ Instalando o Cassandra (Ambiente Local)

### 🐳 Usando Docker (opcional)

```bash

docker run --name cassandra -p 9042:9042 -d cassandra

```

Ou:

1. Baixe em: https://cassandra.apache.org/_/download.html
2. Extraia e execute os scripts (bin/cassandra)

---

### 🧪 Testando com CQL (Cassandra Query Language)

🔹 Criando um Keyspace

```Sql

CREATE KEYSPACE usuarios_app WITH replication = {
  'class': 'SimpleStrategy',
  'replication_factor': 1
};

```

🔹 Criando uma Tabela

```Sql

USE usuarios_app;

CREATE TABLE usuarios (
  id UUID PRIMARY KEY,
  nome TEXT,
  email TEXT,
  data_criacao TIMESTAMP
);

```

🔹 Inserindo Dados

```Sql

INSERT INTO usuarios (id, nome, email, data_criacao)
VALUES (uuid(), 'Fabio', 'fabio@email.com', toTimestamp(now()));

```

🔹 Consultando Dados


```Sql

SELECT * FROM usuarios;

```

---

### 🧪 Testar sem instalar nada – Cassandra Playground

Você pode testar o CQL direto no navegador em plataformas como:

🔗 https://www.killercoda.com/cassandra
🔗 https://www.datastax.com/astra

### 💡 Dica:

Use o DataStax Astra (versão cloud gratuita do Cassandra), ideal para praticar sem setup local.

---

### 💻 Integração com .NET (C#)

🔹 Instalar o Driver

```bash

dotnet add package CassandraCSharpDriver

```

🔹 Exemplo de Conexão

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

### 🧠 Considerações Finais

O Cassandra é ideal para aplicações que precisam:

- Armazenar muito volume de dados
- Suportar escritas frequentes
- Alta disponibilidade e resiliência
- Trabalhar com consulta rápida por chave primária

---

## 🧰 Redis – Banco de Dados Chave-Valor  

### 🧠 O que é o Redis?

O **Redis** (Remote Dictionary Server) é um banco de dados NoSQL do tipo **chave-valor** e armazenado em memória. Ele é extremamente rápido e amplamente usado para:

- Cache de dados
- Armazenar sessões de usuários
- Filas e publicações/assinaturas (pub/sub)
- Contadores, listas, conjuntos e mais

> 🔧 Redis é mais que um cache — é uma **estrutura de dados em memória**, simples e poderosa.

---

### 🧩 Como funciona o modelo chave-valor?

- **Chave (key)**: identificador único
- **Valor (value)**: qualquer tipo de dado (string, lista, hash, set, etc.)

```text

chave: "usuario:101"
valor: "{ nome: 'Fabio', idade: 43 }"

```

---

### 🚀 Vantagens do Redis

|Recurso|	Benefício|
|---|---|
|In-memory (na RAM)	|Acesso ultra-rápido aos dados|
|Tipos de dados avançados	Listas, hashes, sets, sorted sets|Persistência opcional	|Pode salvar dados em disco mesmo sendo memória|
Escalável e leve	Ideal para sistemas de alto desempenho|Suporte a Pub/Sub	|Comunicação entre serviços em tempo real|



---

🔌 Instalação do Redis

🔹 Local (via Docker)

docker run --name redis -p 6379:6379 -d redis

🔹 Cloud (Redis Cloud Gratuito)

1. Acesse: https://redis.com/try-free


2. Crie um cluster gratuito


3. Copie a string de conexão




---

🔍 Comandos Básicos no Redis CLI

redis-cli

🔹 Armazenar valor

SET usuario:101 "Fabio"

🔹 Buscar valor

GET usuario:101

🔹 Expiração de chave

SET codigo:123456 "validado"
EXPIRE codigo:123456 60


---

💻 Integração com C# (.NET)

🔹 Instalar pacote NuGet

dotnet add package StackExchange.Redis

🔹 Conectar e usar o Redis

using StackExchange.Redis;

var redis = ConnectionMultiplexer.Connect("localhost"); // ou Redis Cloud URI
var db = redis.GetDatabase();

// SET
db.StringSet("usuario:101", "Fabio");

// GET
string nome = db.StringGet("usuario:101");
Console.WriteLine($"Nome: {nome}");


---

📦 Outros tipos de dados suportados

Tipo	Exemplo de Uso

String	Valores simples e JSONs
Hash	Objetos (ex: usuario:102 => nome, idade)
List	Filas e histórico
Set	Conjuntos sem repetição
Sorted Set	Rankings com pontuação
Pub/Sub	Comunicação em tempo real entre serviços



---

🧪 Testando Online – Redis Playground

Você pode testar comandos Redis no navegador:

🔗 https://try.redis.io/


---

🔐 Exemplo com Expiração e Sessão

db.StringSet("sessao:fabio", "ativo", TimeSpan.FromMinutes(30));

> 🔁 Ideal para sessões expiráveis sem precisar de banco tradicional.




---

🧠 Quando usar Redis?

Armazenar sessões de login

Cache de resultados de queries

Fila de tarefas assíncronas

Contadores e notificações

Controle de acesso e rate-limit



---

✅ Conclusão

O Redis é essencial em sistemas de alta performance, sendo leve, rápido e extremamente útil para aplicações .NET. Mesmo com estrutura simples, permite resolver problemas complexos de cache, tempo real e persistência temporária.


---

📁 Repositório:
Se este conteúdo te ajudou, ⭐ deixe sua estrela no repositório e compartilhe com a comunidade!

---

Se quiser, Fabio, posso te montar um mini projeto ASP.NET com Redis para armazenar sessões ou cache de dados em C#. Posso seguir com isso?



---

## 🍃 MongoDB com C# – Introdução e Instalação

### 🛠️ Instalando o MongoDB Driver

No seu projeto .NET:

```bash

dotnet add package MongoDB.Driver

```

---

### ☁️ Criando o Cluster (MongoDB Atlas)

1. Acesse: [https://www.mongodb.com/cloud/atlas](https://www.mongodb.com/cloud/atlas)
2. Crie um cluster gratuito.
3. Configure um usuário e libere IP (pode usar 0.0.0.0 para testes).
4. Copie a **connection string** (ex: `mongodb+srv://usuario:senha@cluster.mongodb.net`)

---

## 🧱 Schema Design e Boas Práticas

### Exemplo de Classe com Atributos

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

> ✅ **Use atributos do namespace `MongoDB.Bson.Serialization.Attributes`** para mapear corretamente os campos.

---

### ⚙️ Conexão com o MongoDB

```csharp

using MongoDB.Driver;

var client = new MongoClient("sua_connection_string");
var database = client.GetDatabase("MinhaBase");
var collection = database.GetCollection<Usuario>("usuarios");

```

---

## 🧾 Operações com MongoDB no C\#

### 🔹 Inserir um Documento

```csharp

var novoUsuario = new Usuario { Nome = "Fabio", Idade = 43 };
await collection.InsertOneAsync(novoUsuario);

```

---

### 🔍 Buscar Documentos

```csharp

var usuarios = await collection.Find(u => u.Idade > 40).ToListAsync();

```

---

### ✏️ Atualizar Documento

```csharp

var filtro = Builders<Usuario>.Filter.Eq(u => u.Nome, "Fabio");
var atualizacao = Builders<Usuario>.Update.Set(u => u.Idade, 44);

await collection.UpdateOneAsync(filtro, atualizacao);

```

---

### ❌ Remover Documento

```csharp

await collection.DeleteOneAsync(u => u.Nome == "Fabio");

```

---

### 🚀 Índices e Performance

Você pode criar índices programaticamente:

```csharp

var indexKeys = Builders<Usuario>.IndexKeys.Ascending(u => u.Idade);
await collection.Indexes.CreateOneAsync(new CreateIndexModel<Usuario>(indexKeys));

```

> ⚠️ Use com moderação — muitos índices impactam o desempenho de inserções.

---

### 📊 Agregações com C\#

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

### 🔄 JSON vs BSON

| Formato | Descrição                   | Vantagens                       |
| ------- | --------------------------- | ------------------------------- |
| JSON    | Texto leve, legível         | Ideal para APIs                 |
| BSON    | Binário, suporta mais tipos | Rápido e eficiente para leitura |

---

#### ✅ Conclusão

Neste módulo aprendemos:

* Fundamentos NoSQL e tipos de banco
* Instalar e usar MongoDB com .NET
* Criar schema em C# com boas práticas
* Manipular dados (CRUD)
* Agregar e trabalhar com índices

MongoDB é altamente integrado com C# e uma excelente escolha para aplicações modernas que precisam de performance e flexibilidade.

---

##### ✍️ **Seção criada por:** *Fabio Zanneti*
##### 🎯 Projeto: **WEX - End to End Engineering**