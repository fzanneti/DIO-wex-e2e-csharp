# 💾 Armazenamento e Banco de Dados

![GitHub repo size](https://img.shields.io/github/repo-size/fzanneti/wex-e2e-csharp)
![GitHub forks](https://img.shields.io/github/forks/fzanneti/wex-e2e-csharp?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/fzanneti/wex-e2e-csharp?style=social)
![Bootcamp](https://img.shields.io/badge/WEX-End--to--End%20Engineering-blueviolet?logo=vercel&logoColor=white)
![Plataforma](https://img.shields.io/badge/Powered%20by-DIO.io-red?logo=data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjZmZmIiB2aWV3Qm94PSIwIDAgMzIgMzIiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PHBhdGggZD0iTTYuNzEgMy4yNWMtMi44OCAxLjQxLTUuMDcgNC4yMy01LjA3IDcuNzYgMCAzLjU4IDIuMjggNi43IDUuMzMgOC4xNSAxLjgzLS42MiAyLjQtMi4yNiAyLjQtMy44MSAwLS4yMy0uMDItLjQ1LS4wNS0uNjZBLjQ0LjQ0IDAgMDExMC4xIDExYy4yNC0uNzUuMTEtMS41My0uMy0yLjIyQzguOTIgNy45NiA3LjMzIDcuNSA1Ljc0IDcuNjZhNS41NSA1LjU1IDAgM)
![Autor](https://img.shields.io/badge/Autor-fzanneti-blue?style=flat-square&logo=github)

---

### 📦 Armazenamento de Dados em Nuvem

A AWS oferece uma ampla gama de serviços de armazenamento, cada um projetado para atender a necessidades específicas, desde discos de alta performance para servidores até armazenamento de objetos escalável para grandes volumes de dados. Escolher o serviço certo depende do tipo de dado, caso de uso e requisitos de performance.

**Por que isso é importante?**

- **Flexibilidade**: Soluções para diferentes tipos de dados (bloco, objeto, arquivo).
- **Escalabilidade**: Cresce automaticamente com suas necessidades.
- **Durabilidade e disponibilidade**: Garante que seus dados estejam seguros e acessíveis.

A tabela fornecida resume bem os principais serviços:

| **Tipo** | **Serviço** | **Indicado para**                     |
|----------|-------------|---------------------------------------|
| 📄       | Amazon EBS  | Discos para servidores EC2            |
| ☁️       | Amazon S3   | Arquivos na nuvem (objetos)           |
| 📂       | Amazon EFS  | Sistema de arquivos compartilhado     |

Vamos detalhar cada um com explicações claras e exemplos práticos.

---

## 📄 Amazon EBS – Elastic Block Store

O **Amazon Elastic Block Store (EBS)** é um serviço de **armazenamento em bloco** que funciona como um disco rígido (HDD) ou SSD virtual conectado a instâncias **EC2**. Ele é ideal para aplicações que precisam de acesso rápido e persistente aos dados.

### 🔍 Características principais

- **Persistência**: Os dados permanecem mesmo após a instância EC2 ser desligada, ao contrário de discos efêmeros (instance store).
- **Tipos de discos**:
  - **SSD (gp3, gp2)**: Alta performance para aplicações como bancos de dados ou sistemas transacionais.
  - **HDD (st1, sc1)**: Alta capacidade para dados menos acessados, como logs ou backups.
- **Snapshots**: Backups pontuais armazenados no S3, permitindo restaurar ou replicar volumes.
- **Flexibilidade**: Pode ser redimensionado (aumentar tamanho ou alterar tipo) sem downtime.

### 📌 Ideal para:

- Bancos de dados relacionais (ex.: MySQL, PostgreSQL) que requerem baixa latência e alta taxa de IOPS.
- Sistemas operacionais ou aplicações que precisam de armazenamento persistente (ex.: servidores de aplicação).
- Ambientes que exigem snapshots frequentes para backup ou recuperação de desastres.

---

## ☁️ Amazon S3 – Simple Storage Service

O **Amazon Simple Storage Service (S3)** é o serviço de **armazenamento de objetos** da AWS, projetado para armazenar grandes quantidades de dados de forma escalável, durável e acessível.

### 🔍 Características principais

- **Durabilidade de 99.999999999% (11 9’s)**: Praticamente elimina o risco de perda de dados.
- **Escalabilidade ilimitada**: Cresce automaticamente sem necessidade de provisionamento manual.
- **Classes de armazenamento**:
  - **S3 Standard**: Para dados frequentemente acessados (ex.: sites, aplicativos).
  - **S3 Glacier**: Para arquivos raramente acessados, como backups ou arquivos históricos.
  - **S3 One Zone-IA**: Para dados menos críticos armazenados em uma única zona de disponibilidade.
- **Acesso flexível**: Via console web, CLI, SDKs ou APIs.
- **Segurança**: Controle de acesso via políticas IAM, bucket policies e ACLs.

### 📌 Casos de uso

- Hospedagem de arquivos estáticos para sites (imagens, CSS, JavaScript).
- Backups e arquivamento de dados.
- Armazenamento de logs de aplicações ou servidores.
- Big Data e Machine Learning (armazenar datasets para processamento).

---

### 📂 Amazon EFS – Elastic File System

O **Amazon Elastic File System (EFS)** é um sistema de arquivos compartilhado, compatível com o protocolo **NFS** (Network File System), que permite que várias instâncias EC2 acessem os mesmos arquivos simultaneamente.

### 🔍 Características principais

- **POSIX-compliant**: Suporta aplicações que requerem sistemas de arquivos tradicionais.
- **Escalabilidade automática**: Cresce e reduz conforme a demanda, sem necessidade de gerenciamento manual.
- **Alta disponibilidade**: Dados replicados em várias zonas de disponibilidade (AZs).
- **Acesso compartilhado**: Ideal para ambientes colaborativos ou distribuídos.

### 📌 Casos de uso

- Sistemas de gerenciamento de conteúdo (CMS) que precisam de arquivos acessíveis por múltiplos servidores.
- Ambientes de desenvolvimento/teste compartilhados entre equipes.
- Aplicações que requerem sistemas de arquivos escaláveis, como pipelines de CI/CD.

---

## 🗄️ Amazon RDS – Relational Database Service

O **Amazon Relational Database Service (RDS)** é um serviço gerenciado que simplifica a configuração, operação e escalabilidade de **bancos de dados relacionais**.

### 🔍 Características principais

- **Bancos suportados**: MySQL, PostgreSQL, MariaDB, Oracle, SQL Server, Amazon Aurora (versão otimizada da AWS).
- **Gerenciamento automatizado**:
  - Backups automáticos e snapshots.
  - Atualizações de software (patching).
  - Alta disponibilidade com **Multi-AZ** (réplicas em diferentes zonas de disponibilidade).
- **Escalabilidade**:
  - **Vertical**: Aumentar CPU, memória ou armazenamento.
  - **Horizontal**: Réplicas de leitura para distribuir carga.
- **Segurança**: Criptografia em repouso e em trânsito, integração com IAM.

### 📌 Casos de uso

- Aplicações web com bancos relacionais (ex.: e-commerce, blogs).
- Sistemas empresariais que usam Oracle ou SQL Server.
- Projetos que precisam de um banco de dados robusto sem gerenciamento manual.

---

## ⚡ Amazon DynamoDB

O **Amazon DynamoDB** é um banco de dados **NoSQL totalmente gerenciado**, otimizado para alta performance e escalabilidade automática.

### 🔍 Características principais

- **Latência de milissegundos**: Ideal para aplicações que exigem respostas rápidas.
- **Escalabilidade automática**: Ajusta capacidade de leitura/escrita conforme a demanda.
- **Modelos de dados**: Suporta **key-value** (ex.: chave = ID do usuário, valor = dados do perfil) e **documentos JSON**.
- **Alta disponibilidade**: Dados replicados em várias AZs.

### 📌 Casos de uso

- Aplicações móveis que precisam de baixa latência (ex.: chats, leaderboards de jogos).
- Sistemas IoT que processam grandes volumes de dados em tempo real.
- Arquiteturas serverless com **AWS Lambda**.

---

### 🗃️ Outros Serviços de Banco de Dados na AWS

A AWS oferece bancos especializados para casos de uso específicos:

| **Serviço**           | **Descrição**                                   | **Caso de uso**                             |
|-----------------------|------------------------------------------------|---------------------------------------------|
| **Amazon ElastiCache** | Cache em memória (Redis ou Memcached)          | Acelerar consultas repetitivas em aplicações |
| **Amazon Neptune**    | Banco de dados de grafos                      | Redes sociais, análise de fraudes           |
| **Amazon DocumentDB** | Banco compatível com MongoDB                   | Aplicações que usam documentos JSON         |
| **Amazon Timestream** | Banco para séries temporais                   | IoT, monitoramento de métricas              |

Cada serviço é otimizado para um tipo de necessidade específica, como caching, grafos sociais ou análise de tempo.

---

## 📊 Big Data com Amazon Redshift

O **Amazon Redshift** é um serviço de **data warehouse** otimizado para análises complexas em grandes volumes de dados.

### 🔍 Características principais

- **Processamento paralelo massivo (MPP)**: Distribui consultas em vários nós para alta performance.
- **Integração com AWS**: Conecta-se ao S3 (para carregar dados), AWS Glue (ETL) e QuickSight (visualizações).
- **Custo acessível**: Mais econômico que data warehouses tradicionais, como Oracle ou Teradata.
- **Colunar**: Armazena dados em colunas, otimizando consultas analíticas.

### 📌 Casos de uso

- Análise de dados para Business Intelligence (BI).
- Relatórios de vendas e comportamento do cliente.
- Processamento de logs para insights operacionais.

---

### 📝 Projeto Interligado da DIO

[![Repo Card](https://github-readme-stats.vercel.app/api/pin/?username=fzanneti&repo=wex-dockercompose-challenge&bg_color=261d31&border_color=7a49c6&show_icons=true&icon_color=7a49c6&title_color=37ccab&text_color=FFF)](https://github.com/fzanneti/wex-dockercompose-challenge)

---

### 📚 Links para Estudo Complementar

* 📘 [Amazon S3 – Documentação Oficial](https://docs.aws.amazon.com/pt_br/s3/)
* 📘 [Amazon EBS – Visão Geral](https://docs.aws.amazon.com/pt_br/AWSEC2/latest/UserGuide/AmazonEBS.html)
* 📘 [Amazon RDS – Documentação](https://docs.aws.amazon.com/pt_br/AmazonRDS/)
* 📘 [Amazon DynamoDB – Documentação](https://docs.aws.amazon.com/pt_br/dynamodb/)
* 📘 [Amazon Redshift – Introdução](https://docs.aws.amazon.com/pt_br/redshift/latest/mgmt/welcome.html)
* 🎥 [AWS Storage Services – YouTube AWS Brasil](https://www.youtube.com/watch?v=6q05tR3d1I0)

---

### ✅ O que você aprendeu nessa parte

- **Amazon EBS**: Armazenamento em bloco persistente para EC2, ideal para bancos de dados e aplicações que precisam de discos.
- **Amazon S3**: Armazenamento de objetos escalável para arquivos, backups e logs, com alta durabilidade.
- **Amazon EFS**: Sistema de arquivos compartilhado para múltiplas instâncias, ideal para aplicações distribuídas.
- **Amazon RDS**: Banco de dados relacional gerenciado, com suporte a MySQL, PostgreSQL, Aurora, etc.
- **Amazon DynamoDB**: Banco NoSQL para aplicações de alta performance e escalabilidade.
- **Outros bancos**: ElastiCache (cache), Neptune (grafos), DocumentDB (MongoDB), Timestream (séries temporais).
- **Amazon Redshift**: Data warehouse para análises de Big Data e Business Intelligence.

---

##### ✍️ Criado por: Fabio Zanneti - 🎯 Projeto: WEX - End to End Engineering
[![GitHub](https://img.shields.io/badge/GitHub-fzanneti-181717?style=flat&logo=github)](https://github.com/fzanneti)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-fzanneti-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/fzanneti)