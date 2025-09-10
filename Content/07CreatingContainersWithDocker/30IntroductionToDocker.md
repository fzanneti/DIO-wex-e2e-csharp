# 🚀Primeiros Passos com o Docker

### 📥 Realizando o download de imagens

As imagens são os "modelos prontos" que usamos para criar contêineres. O Docker Hub é o repositório oficial de imagens públicas.

```bash

docker pull ubuntu
docker pull nginx

```

Você pode buscar imagens diretamente no terminal:

```bash

docker search nome-da-imagem

```

🔗 [Buscar imagens no Docker Hub](https://hub.docker.com/)

---

### ▶️ Executando um contêiner

O comando `docker run` cria e executa um contêiner a partir de uma imagem:

```bash

docker run ubuntu

```

Para rodar com terminal interativo:

```bash

docker run -it ubuntu

```

Para que o contêiner seja removido ao ser finalizado:

```bash

docker run --rm -it ubuntu

```

---

### 📜 Velha sintaxe x Nova sintaxe

A principal diferença está nas versões antigas versus a atual:

**Velha forma:**

```bash

docker run -i -t ubuntu bash

```

**Nova forma (mais clara e moderna):**

```bash

docker run -it ubuntu bash

```

---

### 📂 Executando aplicações no contêiner

Você pode executar comandos diretamente:

```bash

docker run ubuntu echo "Olá, Docker!"

```

Ou acessar o terminal do contêiner e executar o que quiser:

```bash

docker run -it ubuntu
# dentro do container
apt update && apt install curl -y

```

---

### 🧹 Excluindo e nomeando contêiner

**Nomeando contêiner:**

```bash

docker run --name meu_container -it ubuntu

```

**Removendo contêiner parado:**

```bash

docker rm nome_ou_id

```

**Forçando a remoção de contêiner ativo:**

```bash

docker rm -f nome_ou_id

```

---

### 📁 Copiando arquivos para o contêiner

```bash

docker cp meu_arquivo.txt nome_container:/tmp/

```

---

### 📤 Copiando arquivos do contêiner para sua máquina

```bash

docker cp nome_container:/tmp/arquivo.txt ./

```

---

#### 🏷️ Trabalhando com TAGs

As tags definem versões da imagem. Exemplo com o MySQL:

```bash

docker pull mysql:8.0
docker pull mysql:5.7

```

Sem tag = usa a `latest` por padrão:

```bash

docker pull nginx
# equivale a
docker pull nginx:latest

```

---

### 🐬 Criando um contêiner do MySQL

```bash

docker run --name mysql-container -e MYSQL_ROOT_PASSWORD=senha123 -d mysql:8.0

```

> `-e` define variáveis de ambiente
> `-d` roda em segundo plano

---

### 🌐 Acessando o contêiner externamente

Para expor a porta do container ao host:

```bash

docker run -p 3306:3306 --name mysql-container -e MYSQL_ROOT_PASSWORD=senha123 -d mysql:8.0

```

Agora o MySQL está acessível via `localhost:3306`

---

### ⏸️ Parando e reiniciando contêiner

**Parar:**

```bash

docker stop nome_container

```

**Reiniciar:**

```bash

docker restart nome_container

```

**Ver todos os containers ativos:**

```bash

docker ps

```

**Ver todos (inclusive parados):**

```bash

docker ps -a

```

---

### 🧠 Dicas rápidas

* Sempre nomeie seus contêineres para facilitar a gestão.
* Use a flag `--rm` para evitar acúmulo de contêineres temporários.
* Explore o Docker Hub para entender quais imagens são oficiais.
* MySQL, Nginx, Redis, MongoDB e PostgreSQL são boas imagens para treinar.

---

### 📚 Links de estudo complementar

* 📘 [Documentação oficial do Docker (pt-BR)](https://docs.docker.com/get-started/)
* 🎥 [Curso básico de Docker (Filipe Deschamps – YouTube)](https://www.youtube.com/watch?v=ZVaRK10HBjo)
* 📦 [DockerHub – Repositório oficial de imagens](https://hub.docker.com/)
* 💡 [Guia prático de comandos Docker (DIO)](https://web.dio.me/articles/comandos-mais-utilizados-no-docker)

---

##### ✍️ **Seção criada por:** *Fabio Zanneti* 🎯 Projeto: **WEX - End to End Engineering**