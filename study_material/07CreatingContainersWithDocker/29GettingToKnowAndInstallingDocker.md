# 🧩 Conhecendo e Instalando o Docker

### 📘 Introdução ao Docker e Containers

O Docker é uma plataforma que permite criar, executar e gerenciar **contêineres** — ambientes isolados que empacotam aplicações com todas as suas dependências, garantindo que rodem de forma consistente em qualquer ambiente.

**Por que usar Docker?**

* Consistência entre ambientes de desenvolvimento e produção
* Facilidade de empacotar e distribuir aplicações
* Melhor utilização de recursos do sistema

---

### 💡 Pré-requisitos e Laboratório Virtual

Antes de começar, o curso utiliza um **laboratório virtual** para simular a instalação e o uso do Docker, o que é ideal para quem:

* Está começando e não quer configurar o ambiente local
* Usa máquinas com sistema Windows ou que não suportam Linux nativamente

**Pré-requisitos básicos:**

* Noções de terminal Linux (caso precise revisar, veja o material abaixo)
* Acesso ao ambiente virtual fornecido pela plataforma

📎 **Material complementar – Repositório de Linux Fundamentals**
Você pode revisar comandos e conceitos do terminal Linux acessando meu repositório:
👉 [fzanneti/linux-fundamentals-training](https://github.com/fzanneti/linux-fundamentals-training)

---

### 🐳 Instalando o Docker

A instalação do Docker depende do seu sistema operacional. Abaixo, os passos básicos para **sistemas baseados em Linux (como Ubuntu/Debian)**:

```bash

# Atualizando pacotes
sudo apt update

# Instalando pacotes necessários
sudo apt install apt-transport-https ca-certificates curl software-properties-common -y

# Adicionando a chave oficial do Docker
curl -fsSL https://download.docker.com/linux/ubuntu/gpg | sudo gpg --dearmor -o /usr/share/keyrings/docker-archive-keyring.gpg

# Adicionando repositório do Docker
echo "deb [arch=amd64 signed-by=/usr/share/keyrings/docker-archive-keyring.gpg] https://download.docker.com/linux/ubuntu $(lsb_release -cs) stable" \
| sudo tee /etc/apt/sources.list.d/docker.list > /dev/null

# Atualizando pacotes novamente
sudo apt update

# Instalando o Docker
sudo apt install docker-ce -y

# Verificando se o Docker foi instalado
docker --version

```

**Dica:** Após a instalação, pode ser necessário adicionar seu usuário ao grupo `docker` para executar os comandos sem `sudo`:

```bash

sudo usermod -aG docker $USER

```

Depois disso, reinicie a sessão do terminal ou a máquina.

---

### 📚 **Links úteis sobre instalação:**

* [Documentação oficial – Instalando Docker no Ubuntu](https://docs.docker.com/engine/install/ubuntu/)
* [Instalando Docker no Windows com WSL2 (YouTube)](https://www.youtube.com/watch?v=_JpT8H_GnbE)
* [Docker Playground (laboratório online gratuito)](https://www.docker.com/play-with-docker/)
* [O que é Docker? (DigitalOcean - português)](https://www.digitalocean.com/community/tutorials/o-que-e-docker-e-para-que-serve)
* [Entendendo Containers vs Máquinas Virtuais (Red Hat - português)](https://www.redhat.com/pt-br/topics/containers/containers-vs-virtual-machines)
* [Guia de comandos básicos no Linux (DIO)](https://web.dio.me/articles/comandos-basicos-no-terminal-linux)
* [Tabela de comandos Linux em PDF (Guia Linux)](https://www.guiadeti.com.br/wp-content/uploads/2019/11/comandos_linux_guia.pdf)

---

#### ✅ O que você aprendeu nessa parte:

* O que é o Docker e para que serve
* Diferença entre contêiner e máquina virtual
* Como usar o laboratório virtual
* Como instalar o Docker em sistemas Linux

---

##### ✍️ **Seção criada por:** *Fabio Zanneti* 🎯 Projeto: **WEX - End to End Engineering**