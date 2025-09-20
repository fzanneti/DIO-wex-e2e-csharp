# WEX - End to End Engineering

## 7.7 - Introdução ao Kubernetes e Orquestração de Contêineres

![GitHub repo size](https://img.shields.io/github/repo-size/fzanneti/wex-e2e-csharp)
![GitHub forks](https://img.shields.io/github/forks/fzanneti/wex-e2e-csharp?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/fzanneti/wex-e2e-csharp?style=social)
![Linguagem](https://img.shields.io/badge/Linguagem-CSharp-blue)
![Bootcamp](https://img.shields.io/badge/WEX-End--to--End%20Engineering-blueviolet?logo=vercel&logoColor=white)
![Plataforma](https://img.shields.io/badge/Powered%20by-DIO.io-red?logo=data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjZmZmIiB2aWV3Qm94PSIwIDAgMzIgMzIiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PHBhdGggZD0iTTYuNzEgMy4yNWMtMi44OCAxLjQxLTUuMDcgNC4yMy01LjA3IDcuNzYgMCAzLjU4IDIuMjggNi43IDUuMzMgOC4xNSAxLjgzLS42MiAyLjQtMi4yNiAyLjQtMy44MSAwLS4yMy0uMDItLjQ1LS4wNS0uNjZBLjQ0LjQ0IDAgMDExMC4xIDExYy4yNC0uNzUuMTEtMS41My0uMy0yLjIyQzguOTIgNy45NiA3LjMzIDcuNSA1Ljc0IDcuNjZhNS41NSA1LjU1IDAgM)
![Autor](https://img.shields.io/badge/Autor-fzanneti-blue?style=flat-square&logo=github)

---

<img src="https://github.com/fzanneti/DIO-wex-e2e-csharp/blob/main/Assets/images/kubernetes.jpg" alt="Docker Compose" width="600px">

### Kubernetes Overview

O **Kubernetes (K8s)** é uma **plataforma de orquestração de contêineres** open-source que automatiza **deploy**, **escalabilidade**, **monitoramento** e **gerenciamento** de aplicações em contêineres.

**O que ele resolve:**

- Executar múltiplos contêineres distribuídos em vários servidores
- Escalar automaticamente serviços conforme necessidade
- Substituir contêineres que falharam
- Controlar atualizações sem downtime

Com o Docker, você **empacota** e executa contêineres.
Com o Kubernetes, você **gerencia** milhares deles de forma automatizada.

---

### Introdução ao Kubernetes

O nome "Kubernetes" vem do grego e significa "piloto" ou "timoneiro", ou seja, aquele que **guia os contêineres** em produção.

**Principais recursos do K8s:**

- **Pods:** Unidade mínima de execução (pode conter um ou mais contêineres)
- **Nodes:** Máquinas (físicas ou virtuais) que rodam os pods
- **Cluster:** Conjunto de nodes controlados por um master
- **Service:** Define como os pods são acessados (por outros pods ou externamente)
- **Deployment:** Automatiza o gerenciamento de múltiplos pods (escalabilidade, rollback, etc)

---

### Arquitetura Básica do Kubernetes

A arquitetura do Kubernetes é dividida em **dois grandes blocos**:

1. **Plano de Controle (Control Plane)**

Responsável por **gerenciar** o estado do cluster.

- `kube-apiserver`: Interface de comunicação principal
- `etcd`: Banco de dados chave/valor para armazenar o estado do cluster
- `controller-manager`: Garante que o estado atual siga o desejado
- `scheduler`: Aloca os pods nos nodes disponíveis

2. **Nó de Trabalho (Worker Node)**

Onde os contêineres realmente rodam.

- `kubelet`: Agente que recebe ordens do master
- `container runtime` (Docker, containerd, etc.): Executa os contêineres
- `kube-proxy`: Cuida da rede e do acesso aos serviços/pods

---

### Exemplo visual simplificado:

```

[ Cluster Kubernetes ]
     ┌────────────────────────────────────┐
     │         Control Plane              │
     │ ┌──────────────┐                   │
     │ │ kube-apiserver│  <== interface   │
     │ │ controller    │  <== controle     │
     │ │ scheduler      │  <== orquestra   │
     │ │ etcd           │  <== armazena    │
     │ └──────────────┘                   │
     └────────────────────────────────────┘

     ┌──────────────┐     ┌──────────────┐
     │  Worker Node │     │  Worker Node │
     │ ┌──────────┐ │     │ ┌──────────┐ │
     │ │ kubelet  │ │     │ │ kubelet  │ │
     │ │ pods     │ │     │ │ pods     │ │
     │ │ runtime  │ │     │ │ runtime  │ │
     │ └──────────┘ │     │ └──────────┘ │
     └──────────────┘     └──────────────┘

```

---

### Comparação: Docker x Kubernetes

| Recurso             | Docker               | Kubernetes                     |
| ------------------- | -------------------- | ------------------------------ |
| Execução            | Contêiner individual | Orquestração de múltiplos      |
| Escalabilidade      | Manual               | Automática                     |
| Tolerância a falhas | Limitada             | Alta, com substituição de pods |
| Rede interna        | Simples (bridge)     | Complexa e robusta             |
| Exposição de apps   | Porta direta do host | Serviços configuráveis         |

---

### Links de estudo complementar

🔗[Documentação oficial do Kubernetes (pt-BR)](https://kubernetes.io/pt/docs/home/)\
🔗[O que é Kubernetes? (Fellyph Cintra – YouTube)](https://www.youtube.com/watch?v=RA1ZV7U-bDo)\
🔗[Kubernetes na prática com minikube (Dev.to)](https://dev.to/danielme/kubernetes-na-pratica-com-minikube-4e06)\
🔗[Livro gratuito: Kubernetes para Desenvolvedores](https://developer.okta.com/resources/ebooks/kubernetes-for-developers/pt/)

---

### Projeto Interligado da DIO

[![Repo Card](https://github-readme-stats.vercel.app/api/pin/?username=fzanneti&repo=DIO-wex-dockercompose-challenge&bg_color=261d31&border_color=7a49c6&show_icons=true&icon_color=7a49c6&title_color=37ccab&text_color=FFF)](https://github.com/fzanneti/DIO-wex-dockercompose-challenge)

---

#### ✅ O que você aprendeu nessa parte:

* Conceito e propósito do **Kubernetes**
* Diferença entre Docker e Kubernetes
* Arquitetura básica (Control Plane + Nodes)
* Terminologia essencial: Pod, Node, Cluster, Service, Deployment
* Primeiros passos para estudar orquestração de contêineres

---

##### ✍️ Seção criada por: *Fabio Zanneti* - 🎯 Bootcamp: **WEX - End to End Engineering**
[![GitHub](https://img.shields.io/badge/GitHub-fzanneti-181717?style=flat&logo=github)](https://github.com/fzanneti)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-fzanneti-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/fzanneti)