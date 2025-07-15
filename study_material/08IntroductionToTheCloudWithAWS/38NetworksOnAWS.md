# ☁️ Redes em AWS

![GitHub repo size](https://img.shields.io/github/repo-size/fzanneti/wex-e2e-csharp)
![GitHub forks](https://img.shields.io/github/forks/fzanneti/wex-e2e-csharp?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/fzanneti/wex-e2e-csharp?style=social)
![Bootcamp](https://img.shields.io/badge/WEX-End--to--End%20Engineering-blueviolet?logo=vercel&logoColor=white)
![Plataforma](https://img.shields.io/badge/Powered%20by-DIO.io-red?logo=data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjZmZmIiB2aWV3Qm94PSIwIDAgMzIgMzIiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PHBhdGggZD0iTTYuNzEgMy4yNWMtMi44OCAxLjQxLTUuMDcgNC4yMy01LjA3IDcuNzYgMCAzLjU4IDIuMjggNi43IDUuMzMgOC4xNSAxLjgzLS42MiAyLjQtMi4yNiAyLjQtMy44MSAwLS4yMy0uMDItLjQ1LS4wNS0uNjZBLjQ0LjQ0IDAgMDExMC4xIDExYy4yNC0uNzUuMTEtMS41My0uMy0yLjIyQzguOTIgNy45NiA3LjMzIDcuNSA1Ljc0IDcuNjZhNS41NSA1LjU1IDAgM)
![Autor](https://img.shields.io/badge/Autor-fzanneti-blue?style=flat-square&logo=github)

---

### 🔌 O que são Redes na AWS?

As redes na AWS são o alicerce para conectar recursos na nuvem, como servidores (EC2), bancos de dados (RDS), ou qualquer outro serviço, de maneira segura, escalável e eficiente. A AWS fornece ferramentas para criar ambientes de rede personalizados, permitindo que você configure desde redes privadas isoladas até conexões híbridas com sua infraestrutura local.

O principal serviço de rede da AWS é a **Amazon Virtual Private Cloud (VPC)**, que funciona como uma rede virtual exclusiva para sua conta. Pense na VPC como um "data center virtual" que você controla completamente, desde os endereços IP até as regras de segurança e roteamento.

**Por que isso é importante?**
- **Segurança**: Você define quem pode acessar seus recursos e como o tráfego flui.
- **Flexibilidade**: Permite arquiteturas híbridas, conectando a nuvem com ambientes locais.
- **Escalabilidade**: Adapta-se a aplicações de pequeno a grande porte.

---

### 🏗️ Amazon VPC (Virtual Private Cloud)

A **Amazon VPC** é o coração das redes na AWS. Ela permite criar uma rede virtual isolada, onde você define:

- **Intervalos de IPs privados (CIDR Block)**: Um intervalo de endereços IP (ex.: `10.0.0.0/16`) que define o espaço de endereçamento da sua VPC.
- **Sub-redes (Subnets)**: Divisões menores do intervalo de IPs, separando recursos em redes públicas (acessíveis pela internet) ou privadas (isoladas).
- **Roteadores virtuais (Route Tables)**: Controlam o fluxo de tráfego entre sub-redes e para fora da VPC (ex.: internet ou redes locais).
- **Firewalls**: Usando **Security Groups** (nível de instância) e **Network ACLs (NACLs)** (nível de sub-rede).
- **Conexões externas**: Como **VPN** ou **AWS Direct Connect** para integrar com redes locais.

### 📌 Exemplo prático de uma VPC

Imagine que você está criando uma aplicação web com um frontend (servidor web) e um backend (banco de dados). Aqui está como você configuraria uma VPC básica:

| **Componente**         | **Configuração**                              | **Exemplo**                                                                 |
|------------------------|----------------------------------------------|-----------------------------------------------------------------------------|
| **CIDR Block**         | Intervalo de IPs da VPC                      | `10.0.0.0/16` (65.536 IPs disponíveis)                                      |
| **Subnet Pública**     | Para servidores web acessíveis pela internet | `10.0.1.0/24` (256 IPs, ex.: EC2 com servidor web)                      |
| **Subnet Privada**     | Para bancos de dados isolados                | `10.0.2.0/24` (256 IPs, ex.: RDS para banco de dados)                   |
| **Internet Gateway**   | Conecta a VPC à internet                     | Permite que a subnet pública acesse a internet                           |
| **NAT Gateway**        | Permite que subnets privadas acessem a internet (apenas saída) | Instâncias privadas baixam atualizações sem serem acessadas diretamente |
| **Route Tables**       | Define rotas de tráfego                      | Ex.: Tráfego de `0.0.0.0/0` vai para o Internet Gateway na subnet pública |

> 🔒 Tudo isso garante que sua aplicação seja **segura, controlada e eficiente em rede**.

#### 🔒 Por que isso é seguro?

- **Isolamento lógico**: Sua VPC é completamente isolada de outras contas AWS.
- **Controle granular**: Você define regras de tráfego e segurança.
- **Escalabilidade**: Pode expandir a VPC criando mais sub-redes ou conectando a outras VPCs.

---

## 🌐 Conectividade com AWS

A AWS oferece várias opções para conectar sua VPC a outras redes, seja na própria AWS, em outras nuvens, ou no seu data center local. Esses serviços são cruciais para arquiteturas híbridas, onde parte da infraestrutura está na nuvem e parte localmente.

### 🔍 Serviços de Conectividade

| **Serviço**                | **Descrição**                                                                                     | **Caso de uso**                                                                 |
|----------------------------|--------------------------------------------------------------------------------------------------|---------------------------------------------------------------------------------|
| 🔒 **VPN AWS**                | Conexão segura via IPsec entre sua rede local e a VPC. Usa a internet pública, mas é criptografada. | Empresas com escritórios locais que precisam acessar recursos na AWS.            |
| ⚡**AWS Direct Connect**     | Conexão física dedicada, com baixa latência e alta largura de banda. Não usa internet pública.    | Grandes empresas com necessidade de transferências massivas de dados.           |
| 🔗 **VPC Peering**            | Conexão direta entre duas VPCs na mesma ou em diferentes contas/regiões AWS.                     | Projetos colaborativos entre times que usam VPCs separadas.                     |
| 🌎 **AWS Transit Gateway**    | Hub centralizado que conecta múltiplas VPCs e redes locais em uma única interface.                | Arquiteturas complexas com várias VPCs e conexões locais.                       |

🧩 Esses serviços garantem **conectividade híbrida**, essencial para empresas que ainda mantêm infra local.

---

## 🗺️ Sub-redes e Listas de Controle de Acesso (NACL)

### 🧩 Sub-redes (Subnets)

As subnets dividem o intervalo de IPs da VPC (CIDR Block) em segmentos menores. Elas são criadas em **Availability Zones (AZs)**, que são data centers isolados dentro de uma região AWS. Isso aumenta a resiliência da sua aplicação.

- 📤 **Subnet Pública**:
  - Contém recursos acessíveis pela internet (ex.: servidores web EC2).
  - Está associada a uma **Route Table** que inclui uma rota para um **Internet Gateway** (ex.: `0.0.0.0/0 -> igw-xxxx`).
  - Exemplo: Um servidor web na subnet `10.0.1.0/24` acessível via HTTP.

- 🔒 **Subnet Privada**:
  - Contém recursos isolados (ex.: bancos de dados, servidores de aplicação).
  - Não tem rota direta para a internet, mas pode usar um **NAT Gateway** para acessar a internet de forma controlada (somente tráfego de saída).
  - Exemplo: Um banco de dados RDS na subnet `10.0.2.0/24` que só é acessado por instâncias internas.

**Por que usar subnets?**

- **Organização**: Separa camadas da aplicação (ex.: frontend, backend, banco de dados).
- **Segurança**: Isola recursos sensíveis (como bancos de dados) da internet.
- **Alta disponibilidade**: Colocar subnets em diferentes AZs evita falhas em caso de indisponibilidade de um data center.

Isso facilita a criação de uma **arquitetura segura e escalável**, separando camadas da aplicação.

---

### 🛡️ Network ACLs (NACLs) vs. Security Groups

Tanto **NACLs** quanto **Security Groups** são mecanismos de segurança, mas operam em níveis diferentes e têm características distintas.

| **Característica**            | **NACLs**                                              | **Security Groups**                                   |
|-------------------------------|-------------------------------------------------------|-----------------------------------------------------|
| **Nível de atuação**          | Subnet (afeta todas as instâncias na subnet)          | Instância (afeta apenas a instância EC2 ou recurso) |
| **Tipo de firewall**          | **Stateless**: Não rastreia o estado das conexões.    | **Stateful**: Rastreia o estado (ex.: permite respostas automáticas). |
| **Regras**                    | Permite ou bloqueia tráfego por IP, porta e protocolo. | Regras baseadas em portas e origens/destinos.       |
| **Exemplo de uso**            | Bloquear um intervalo de IPs em uma subnet inteira.   | Permitir apenas HTTP (porta 80) em um servidor web. |
| **Prioridade**                | Regras numeradas (ex.: regra 100 é avaliada antes da 200). | Regras são avaliadas como um conjunto.              |

🛡️ Além disso, temos os **Security Groups**, que controlam o tráfego no nível da instância EC2 e são stateful (mantêm o estado da conexão).

---

### 📚 Links para estudo complementar

* 📘 [Documentação Oficial AWS VPC (pt-BR)](https://docs.aws.amazon.com/pt_br/vpc/latest/userguide/what-is-amazon-vpc.html)
* 🖥️ [AWS Direct Connect – Visão Geral](https://aws.amazon.com/directconnect/)
* 🎥 [VPC explicado – YouTube Branas](https://www.youtube.com/watch?v=YQ9p1VZJhjM)
* 🛡️ [Diferença entre NACL e Security Group – AWS Blog](https://aws.amazon.com/pt/premiumsupport/knowledge-center/compare-security-groups-acls/)

---

#### ✅ O que você aprendeu nessa parte

- **Amazon VPC**: Uma rede virtual isolada onde você controla IPs, sub-redes, roteamento e segurança.
- **Sub-redes**: Dividem a VPC em redes públicas (com acesso à internet) e privadas (isoladas).
- **Conectividade**: Serviços como VPN, Direct Connect, VPC Peering e Transit Gateway permitem integrar a AWS com redes locais ou outras VPCs.
- **Segurança**: **Security Groups** (stateful, nível de instância) e **NACLs** (stateless, nível de subnet) garantem controle granular do tráfego.

---

##### ✍️ Criado por: Fabio Zanneti - 🎯 Projeto: WEX - End to End Engineering
[![GitHub](https://img.shields.io/badge/GitHub-fzanneti-181717?style=flat&logo=github)](https://github.com/fzanneti)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-fzanneti-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/fzanneti)