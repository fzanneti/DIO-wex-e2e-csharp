# WEX - End to End Engineering

## 7.2 - Primeiros Passos com o Docker

![GitHub repo size](https://img.shields.io/github/repo-size/fzanneti/wex-e2e-csharp)
![GitHub forks](https://img.shields.io/github/forks/fzanneti/wex-e2e-csharp?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/fzanneti/wex-e2e-csharp?style=social)
![Linguagem](https://img.shields.io/badge/Linguagem-CSharp-blue)
![Bootcamp](https://img.shields.io/badge/WEX-End--to--End%20Engineering-blueviolet?logo=vercel&logoColor=white)
![Plataforma](https://img.shields.io/badge/Powered%20by-DIO.io-red?logo=data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjZmZmIiB2aWV3Qm94PSIwIDAgMzIgMzIiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PHBhdGggZD0iTTYuNzEgMy4yNWMtMi44OCAxLjQxLTUuMDcgNC4yMy01LjA3IDcuNzYgMCAzLjU4IDIuMjggNi43IDUuMzMgOC4xNSAxLjgzLS42MiAyLjQtMi4yNiAyLjQtMy44MSAwLS4yMy0uMDItLjQ1LS4wNS0uNjZBLjQ0LjQ0IDAgMDExMC4xIDExYy4yNC0uNzUuMTEtMS41My0uMy0yLjIyQzguOTIgNy45NiA3LjMzIDcuNSA1Ljc0IDcuNjZhNS41NSA1LjU1IDAgM)
![Autor](https://img.shields.io/badge/Autor-fzanneti-blue?style=flat-square&logo=github)

---

### Realizando o download de imagens

As imagens são os "modelos prontos" que usamos para criar contêineres. O Docker Hub é o repositório oficial de imagens públicas.

```bash

docker pull ubuntu
docker pull nginx

```

**Você pode buscar imagens diretamente no terminal:**

```bash

docker search nome-da-imagem

```

🔗[Buscar imagens no Docker Hub](https://hub.docker.com/)

---

### Executando um contêiner

O comando `docker run` cria e executa um contêiner a partir de uma imagem:

```bash

docker run ubuntu

```

**Para rodar com terminal interativo:**

```bash

docker run -it ubuntu

```

**Para que o contêiner seja removido ao ser finalizado:**

```bash

docker run --rm -it ubuntu

```

---

### Velha sintaxe x Nova sintaxe

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

### Executando aplicações no contêiner

Você pode executar comandos diretamente:

```bash

docker run ubuntu echo "Olá, Docker!"

```

**Ou acessar o terminal do contêiner e executar o que quiser:**

```bash

docker run -it ubuntu
# dentro do container
apt update && apt install curl -y

```

---

### Excluindo e nomeando contêiner

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

### Copiando arquivos para o contêiner

```bash

docker cp meu_arquivo.txt nome_container:/tmp/

```

---

### Copiando arquivos do contêiner para sua máquina

```bash

docker cp nome_container:/tmp/arquivo.txt ./

```

---

### Trabalhando com TAGs

As tags definem versões da imagem. Exemplo com o MySQL:

```bash

docker pull mysql:8.0
docker pull mysql:5.7

```

**Sem tag = usa a `latest` por padrão:**

```bash

docker pull nginx
# equivale a
docker pull nginx:latest

```

---

### Criando um contêiner do MySQL

```bash

docker run --name mysql-container -e MYSQL_ROOT_PASSWORD=senha123 -d mysql:8.0

```

> `-e` define variáveis de ambiente
> `-d` roda em segundo plano

---

### Acessando o contêiner externamente

Para expor a porta do container ao host:

```bash

docker run -p 3306:3306 --name mysql-container -e MYSQL_ROOT_PASSWORD=senha123 -d mysql:8.0

```

Agora o MySQL está acessível via `localhost:3306`

---

### Parando e reiniciando contêiner

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

### Dicas rápidas

- Sempre nomeie seus contêineres para facilitar a gestão.
- Use a flag `--rm` para evitar acúmulo de contêineres temporários.
- Explore o Docker Hub para entender quais imagens são oficiais.
- MySQL, Nginx, Redis, MongoDB e PostgreSQL são boas imagens para treinar.

---

### Links de estudo complementar

🔗[Documentação oficial do Docker (pt-BR)](https://docs.docker.com/get-started/)\
🔗[Curso básico de Docker (Filipe Deschamps – YouTube)](https://www.youtube.com/watch?v=ZVaRK10HBjo)\
🔗[DockerHub – Repositório oficial de imagens](https://hub.docker.com/)\
🔗[Guia prático de comandos Docker (DIO)](https://web.dio.me/articles/comandos-mais-utilizados-no-docker)

---

### Certificado

<img src="https://github.com/fzanneti/DIO-wex-e2e-csharp/blob/main/Assets/images/certificados/33-primeiros-passos-com-o-docker.jpg" alt="Certificado" width="600px">

---

##### ✍️ Seção criada por: *Fabio Zanneti* - 🎯 Bootcamp: **WEX - End to End Engineering**
[![GitHub](https://img.shields.io/badge/GitHub-fzanneti-181717?style=flat&logo=github)](https://github.com/fzanneti)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-fzanneti-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/fzanneti)