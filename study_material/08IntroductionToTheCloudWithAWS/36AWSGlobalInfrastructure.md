# 🌐 Infraestrutura Global AWS

![GitHub repo size](https://img.shields.io/github/repo-size/fzanneti/wex-e2e-csharp)
![GitHub forks](https://img.shields.io/github/forks/fzanneti/wex-e2e-csharp?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/fzanneti/wex-e2e-csharp?style=social)
![Bootcamp](https://img.shields.io/badge/WEX-End--to--End%20Engineering-blueviolet?logo=vercel&logoColor=white)
![Plataforma](https://img.shields.io/badge/Powered%20by-DIO.io-red?logo=data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjZmZmIiB2aWV3Qm94PSIwIDAgMzIgMzIiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PHBhdGggZD0iTTYuNzEgMy4yNWMtMi44OCAxLjQxLTUuMDcgNC4yMy01LjA3IDcuNzYgMCAzLjU4IDIuMjggNi43IDUuMzMgOC4xNSAxLjgzLS42MiAyLjQtMi4yNiAyLjQtMy44MSAwLS4yMy0uMDItLjQ1LS4wNS0uNjZBLjQ0LjQ0IDAgMDExMC4xIDExYy4yNC0uNzUuMTEtMS41My0uMy0yLjIyQzguOTIgNy45NiA3LjMzIDcuNSA1Ljc0IDcuNjZhNS41NSA1LjU1IDAgM)
![Autor](https://img.shields.io/badge/Autor-fzanneti-blue?style=flat-square&logo=github)

---

* 📘 [Material introdutório de estudo: Introdução à Nuvem](https://github.com/fzanneti/resumo-do-lab/blob/5d5264aba3857749e3889a5f00d05002bf4f4fcf/01%20-%20cloud_computing/01IntroductionToTheCloud.md)

---

### 🌍 O que é a Infraestrutura Global da AWS?

A **AWS (Amazon Web Services)** opera a maior e mais confiável infraestrutura de computação em nuvem do mundo.

A **Infraestrutura Global da AWS** é formada por:

* **Regiões** 🌎
* **Zonas de Disponibilidade (AZs)** 🏢
* **Pontos de Presença (PoPs)** 📍
* **Edge Locations (CDN)** ⚡

Essa estrutura garante que seus serviços rodem com alta **disponibilidade**, **resiliência**, **baixa latência** e **redundância global**.

---

## 🌍 Regiões e Zonas de Disponibilidade (AZs)

### 📍 Região (Region)

Uma **Região** é um conjunto de datacenters localizados em uma área geográfica específica.
Exemplos:

* `us-east-1` (Virgínia, EUA)
* `sa-east-1` (São Paulo, Brasil)
* `eu-central-1` (Frankfurt, Alemanha)

Cada região é isolada das outras — ou seja, você **escolhe onde seus dados e recursos vão ficar hospedados**.

---

### 🏢 Zona de Disponibilidade (Availability Zone – AZ)

Uma **Zona de Disponibilidade** é um ou mais datacenters dentro de uma região, com energia, rede e refrigeração próprias.

Cada região da AWS contém pelo menos **duas AZs** (algumas têm até 6).
As AZs permitem criar **infraestruturas tolerantes a falhas**, com **replicação de dados automática** entre zonas.

---

### ⚡ Pontos de Presença (Points of Presence – PoPs)

Os **Pontos de Presença** são locais espalhados globalmente para oferecer **serviços de entrega rápida e segura de conteúdo**, como:

* **CloudFront (CDN)**: distribui conteúdo para usuários finais com baixa latência
* **Route 53 (DNS)**: resolve domínios com alta performance
* **AWS Global Accelerator**: melhora a performance global de aplicações

📌 São essenciais para sites e apps com usuários em diferentes regiões do mundo.

---

### ⚙️ Provisionamento de Recursos na AWS

Na AWS, você provisiona (ou seja, **cria**) recursos como:

* Instâncias EC2 (servidores)
* Bancos de dados RDS
* Storage (S3, EBS)
* Serviços de segurança, monitoramento, IA etc.

Esse provisionamento pode ser feito de várias formas:

| Método                 | Descrição                                                                                          |
| ---------------------- | -------------------------------------------------------------------------------------------------- |
| 🖱️ Console Web        | Interface gráfica via navegador ([https://aws.amazon.com/console](https://aws.amazon.com/console)) |
| 🧑‍💻 AWS CLI          | Linha de comando (via terminal)                                                                    |
| 📦 AWS SDKs            | Programação via linguagens (Python, JS, C# etc.)                                                   |
| 🏗️ AWS CloudFormation | Provisionamento via código (IaC – Infrastructure as Code)                                          |

---

### 📐 Exemplo prático de escolha de região

```bash

aws configure

```

Durante a configuração da AWS CLI, você informa a região padrão (ex: `sa-east-1` para São Paulo).

Depois, você pode iniciar uma instância EC2:

```bash

aws ec2 run-instances \
  --image-id ami-12345678 \
  --instance-type t2.micro \
  --region sa-east-1

```

---

### 🧠 Por que essa estrutura importa?

* 🔄 **Alta disponibilidade**: se uma AZ falha, outra assume
* ⚡ **Menor latência**: seus dados viajam menos
* 🔐 **Conformidade legal**: controle de onde os dados estão
* 🧩 **Desempenho global**: entrega rápida via edge locations

---

### 📚 Links de estudo complementar

* 🌐 [Infraestrutura Global da AWS – Oficial](https://docs.aws.amazon.com/pt_br/whitepapers/latest/aws-overview/global-infrastructure.html)
* 🎥 [AWS Global Infra explicada (YouTube – AWS)](https://www.youtube.com/watch?v=UuRX2gK0IYw)
* 🗺️ [Mapa interativo das Regiões da AWS](https://infrastructure.aws/)
* 📘 [O que é Edge Location?](https://www-lastweekinaws-com.translate.goog/blog/what-is-an-edge-location-in-aws-a-simple-explanation/?_x_tr_sl=en&_x_tr_tl=pt&_x_tr_hl=pt&_x_tr_pto=tc)

---

#### ✅ O que você aprendeu nessa parte:

* O que é a **Infraestrutura Global da AWS**
* Diferença entre **Região**, **Zona de Disponibilidade** e **Ponto de Presença**
* Como a AWS garante **alta disponibilidade e baixa latência**
* Formas de **provisionar recursos** na nuvem
* Importância estratégica de escolher a região correta

---

##### ✍️ Criado por: Fabio Zanneti - 🎯 Projeto: WEX - End to End Engineering
[![GitHub](https://img.shields.io/badge/GitHub-fzanneti-181717?style=flat&logo=github)](https://github.com/fzanneti)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-fzanneti-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/fzanneti)