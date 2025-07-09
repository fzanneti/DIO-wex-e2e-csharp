# 💻 Computação em AWS

![GitHub repo size](https://img.shields.io/github/repo-size/fzanneti/wex-e2e-csharp)
![GitHub forks](https://img.shields.io/github/forks/fzanneti/wex-e2e-csharp?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/fzanneti/wex-e2e-csharp?style=social)
![Linguagem](https://img.shields.io/badge/Linguagem-CSharp-blue)
![Bootcamp](https://img.shields.io/badge/WEX-End--to--End%20Engineering-blueviolet?logo=vercel&logoColor=white)
![Plataforma](https://img.shields.io/badge/Powered%20by-DIO.io-red?logo=data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjZmZmIiB2aWV3Qm94PSIwIDAgMzIgMzIiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PHBhdGggZD0iTTYuNzEgMy4yNWMtMi44OCAxLjQxLTUuMDcgNC4yMy01LjA3IDcuNzYgMCAzLjU4IDIuMjggNi43IDUuMzMgOC4xNSAxLjgzLS42MiAyLjQtMi4yNiAyLjQtMy44MSAwLS4yMy0uMDItLjQ1LS4wNS0uNjZBLjQ0LjQ0IDAgMDExMC4xIDExYy4yNC0uNzUuMTEtMS41My0uMy0yLjIyQzguOTIgNy45NiA3LjMzIDcuNSA1Ljc0IDcuNjZhNS41NSA1LjU1IDAgM)
![Autor](https://img.shields.io/badge/Autor-fzanneti-blue?style=flat-square&logo=github)

---

### ⚙️ Elastic Compute Cloud (EC2)

O **Amazon EC2** é o serviço de **computação escalável** da AWS.
Com ele, você pode **criar máquinas virtuais (instâncias)** em minutos, personalizando:

* Tipo de sistema operacional (Linux, Windows)
* Tamanho e performance (CPU, RAM, Storage)
* Segurança e acesso remoto (chaves SSH)
* Scripts de inicialização (User Data)

🛠️ Exemplo de criação com AWS CLI:

```bash

aws ec2 run-instances \
  --image-id ami-0c55b159cbfafe1f0 \
  --count 1 \
  --instance-type t2.micro \
  --key-name MinhaChaveSSH \
  --security-groups default

```

📎 É o serviço ideal quando você precisa de **controle total do servidor**, como em aplicações web, bancos de dados, jogos, etc.

---

### 📈 Amazon EC2 Auto Scaling

O **EC2 Auto Scaling** permite **aumentar ou reduzir** automaticamente a quantidade de instâncias com base em:

* Tráfego de usuários
* Uso de CPU
* Horários de pico

🔁 Exemplo de uso:

* Horário comercial: 5 instâncias
* Madrugada: 1 instância

📌 Benefícios:

* Economia de custos 💰
* Alta disponibilidade ⚙️
* Escalabilidade automática 🚀

---

### ⚖️ Elastic Load Balancing (ELB)

O **ELB** é o serviço de **balanceamento de carga da AWS**.

Ele distribui o tráfego entre múltiplas instâncias EC2 ou serviços, garantindo:

* ⚖️ **Equilíbrio de carga**
* 🛡️ **Alta disponibilidade**
* 🔁 **Tolerância a falhas**

Tipos de ELB:

| Tipo           | Uso principal                  |
| -------------- | ------------------------------ |
| Application LB | Apps HTTP/HTTPS (nível 7)      |
| Network LB     | Baixa latência/TCP (nível 4)   |
| Gateway LB     | Tráfego de terceiros/firewalls |

---

### ✉️ Serviços de Mensageria

A AWS oferece serviços para **comunicação assíncrona** entre aplicações:

### 📮 Amazon SQS (Simple Queue Service)

* Fila de mensagens distribuída
* Garante entrega mesmo se o serviço receptor estiver fora do ar

### 📢 Amazon SNS (Simple Notification Service)

* Publicação e notificação
* Envia alertas por email, SMS ou HTTP

🔄 Muito usados em arquiteturas desacopladas, microserviços e pipelines de eventos.

---

### ⚡ Computação sem servidor (Serverless)

No modelo **Serverless**, você **executa código sem se preocupar com servidores**.
Você só paga quando seu código é executado.

### 🧠 Principal serviço: **AWS Lambda**

* Executa funções sob demanda
* Integra com S3, DynamoDB, API Gateway etc.
* Escala automaticamente

📝 Exemplo de uso:

* Ao fazer upload em um bucket S3, uma função Lambda é acionada para processar a imagem.

📎 Ideal para:

* APIs rápidas
* Processos em background
* Automatizações simples

---

### 📦 Containers na AWS

A AWS suporta **contêineres Docker** com serviços próprios:

| Serviço            | Descrição                                             |
| ------------------ | ----------------------------------------------------- |
| 🐳 **Amazon ECS**  | Gerenciamento de containers (similar ao Docker Swarm) |
| ☸️ **Amazon EKS**  | Kubernetes gerenciado                                 |
| 📦 **AWS Fargate** | Executa containers **sem provisionar servidores**     |

📌 ECS + Fargate é uma das formas mais simples de subir containers na AWS, inclusive com Docker Compose adaptado.

---

### 📚 Links para estudo complementar

* 📘 [Amazon EC2 – Documentação Oficial](https://docs.aws.amazon.com/pt_br/ec2/)
* 🎥 [Auto Scaling na prática – YouTube (AWS Brasil)](https://www.youtube.com/watch?v=glbBK2zQW2o)
* 📘 [O que é ELB – DigitalOcean](https://www.digitalocean.com/community/tutorials/what-is-load-balancing)
* 📢 [SQS vs SNS – Explicação simples (Dev.to)](https://dev.to/aws-builders/what-is-the-difference-between-sqs-and-sns-2l3g)
* 🧠 [AWS Lambda – Documentação](https://docs.aws.amazon.com/lambda/latest/dg/welcome.html)
* 🐳 [Amazon ECS vs EKS vs Fargate – Comparativo](https://aws.amazon.com/ecs/faqs/)

---

#### ✅ O que você aprendeu nessa parte:

* O que é o EC2 e como criar instâncias
* Como funciona o Auto Scaling e o ELB
* Diferença entre **mensageria (SNS/SQS)** e uso prático
* Conceito de **Serverless com Lambda**
* Gerenciamento de containers via ECS, EKS e Fargate

---

##### ✍️ Criado por: Fabio Zanneti - 🎯 Projeto: WEX - End to End Engineering
[![GitHub](https://img.shields.io/badge/GitHub-fzanneti-181717?style=flat&logo=github)](https://github.com/fzanneti)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-fzanneti-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/fzanneti)