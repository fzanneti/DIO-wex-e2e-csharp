# 🍃 MongoDB com C# e Bancos de Dados NoSQL  

### 📘 Introdução ao NoSQL

O termo **NoSQL (Not Only SQL)** refere-se a bancos de dados que **não utilizam modelo relacional tradicional**. São ideais para aplicações modernas que exigem **alta performance, flexibilidade e escalabilidade horizontal**.

> ✅ São perfeitos para trabalhar com dados semi-estruturados, como documentos JSON.

---

## 🧩 Tipos de Bancos de Dados NoSQL

| Tipo             | Descrição                                | Exemplos                |
|------------------|-------------------------------------------|-------------------------|
| Chave-Valor      | Armazenamento simples em pares            | Redis, DynamoDB         |
| Colunar          | Focado em colunas, ideal para analytics   | Cassandra, HBase        |
| Documentos       | Armazena documentos (JSON/BSON)           | MongoDB, CouchDB        |
| Grafos           | Foco em relacionamentos complexos         | Neo4j, ArangoDB         |

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