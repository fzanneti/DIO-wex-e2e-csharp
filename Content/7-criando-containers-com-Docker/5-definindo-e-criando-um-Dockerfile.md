# WEX - End to End Engineering

## 7.5 - Definição e Criação de um Dockerfile

![GitHub repo size](https://img.shields.io/github/repo-size/fzanneti/wex-e2e-csharp)
![GitHub forks](https://img.shields.io/github/forks/fzanneti/wex-e2e-csharp?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/fzanneti/wex-e2e-csharp?style=social)
![Linguagem](https://img.shields.io/badge/Linguagem-CSharp-blue)
![Bootcamp](https://img.shields.io/badge/WEX-End--to--End%20Engineering-blueviolet?logo=vercel&logoColor=white)
![Plataforma](https://img.shields.io/badge/Powered%20by-DIO.io-red?logo=data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjZmZmIiB2aWV3Qm94PSIwIDAgMzIgMzIiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PHBhdGggZD0iTTYuNzEgMy4yNWMtMi44OCAxLjQxLTUuMDcgNC4yMy01LjA3IDcuNzYgMCAzLjU4IDIuMjggNi43IDUuMzMgOC4xNSAxLjgzLS42MiAyLjQtMi4yNiAyLjQtMy44MSAwLS4yMy0uMDItLjQ1LS4wNS0uNjZBLjQ0LjQ0IDAgMDExMC4xIDExYy4yNC0uNzUuMTEtMS41My0uMy0yLjIyQzguOTIgNy45NiA3LjMzIDcuNSA1Ljc0IDcuNjZhNS41NSA1LjU1IDAgM)
![Autor](https://img.shields.io/badge/Autor-fzanneti-blue?style=flat-square&logo=github)

---

### Primeiro Dockerfile

Um `Dockerfile` é um arquivo de texto que contém **instruções** para gerar uma **imagem personalizada** do Docker. Com ele, podemos automatizar todo o processo de criação de ambientes.

---

### Exemplo: Primeiro Dockerfile

Crie uma pasta chamada `meu-apache` e dentro dela um arquivo `Dockerfile`:

```dockerfile

# Base da imagem
FROM httpd:2.4

# Copiando arquivos do host para dentro do contêiner
COPY ./public-html/ /usr/local/apache2/htdocs/

```

> Depois crie a pasta `public-html/` com um arquivo `index.html`.

**Build da imagem:**

```bash

docker build -t apache-personalizado .

```

**Executando:**

```bash

docker run -d -p 8080:80 --name meu-apache apache-personalizado

```

---

### Criando imagem personalizada do Apache

Você pode adicionar scripts, páginas HTML e configurações customizadas ao seu container:

```dockerfile

FROM httpd:2.4

COPY ./meus-sites/ /usr/local/apache2/htdocs/
RUN echo "Servidor Apache customizado!" > /usr/local/apache2/htdocs/info.txt

```

Com isso, você entrega seu ambiente web já configurado, pronto para produção ou testes.

---

### Criando imagens personalizadas de linguagens de programação

**Exemplo: Aplicação Node.js**

Estrutura de diretório:

```

app-node/
├── Dockerfile
├── package.json
└── index.js

```

**Dockerfile:**

```dockerfile

FROM node:18

WORKDIR /app

COPY package*.json ./
RUN npm install

COPY . .

EXPOSE 3000

CMD [ "node", "index.js" ]

```

**Build + run:**

```bash

docker build -t meu-node-app .
docker run -d -p 3000:3000 meu-node-app

```

---

### Gerando imagem MULTISTAGE

O build multistage é útil para **reduzir o tamanho** da imagem final, separando as fases de build e produção.

**Exemplo: App Node.js com multistage**

```dockerfile

# Etapa de build
FROM node:18 as build

WORKDIR /app
COPY . .
RUN npm install && npm run build

# Etapa final (produção)
FROM nginx:alpine

COPY --from=build /app/build /usr/share/nginx/html

```

> Assim, a imagem final contém apenas os arquivos finais da aplicação, sem dependências de desenvolvimento.

---

### Realizando upload de imagens para o Docker Hub

1. Faça login no Docker:

```bash

docker login

```

2. Nomeie sua imagem com seu usuário:

```bash

docker tag apache-personalizado fzanneti/apache-personalizado:v1

```

3. Envie a imagem:

```bash

docker push fzanneti/apache-personalizado:v1

```

Agora sua imagem está pública (ou privada) no Docker Hub!

🔗[Acesse seu perfil no Docker Hub](https://hub.docker.com/)

---

### Criando seu próprio Registry (servidor de imagens local)

**Você pode rodar um **registry local** para armazenar imagens privadas dentro da sua empresa ou máquina:**

```bash

docker run -d -p 5000:5000 --name registry registry:2

```

**Enviar uma imagem para ele:**

```bash

docker tag apache-personalizado localhost:5000/apache-custom:v1
docker push localhost:5000/apache-custom:v1

```

**Verificar imagens armazenadas:**

```bash

curl http://localhost:5000/v2/_catalog

```

---

### Links de estudo complementar

🔗[Dockerfile – Documentação Oficial](https://docs.docker.com/engine/reference/builder/)\
🔗[Build Multistage no Docker – Dev.to](https://dev.to/joaopedrofilho/build-multistage-com-docker-38e8)\
🔗[Como publicar imagens no Docker Hub – YouTube (Carlos Azevedo)](https://www.youtube.com/watch?v=_3fN1GikFQg)\
🔗[Criar um Docker Registry privado – DigitalOcean](https://www.digitalocean.com/community/tutorials/how-to-set-up-a-private-docker-registry-on-ubuntu-20-04)

---

### O que você aprendeu nessa parte:

- Criar imagens personalizadas com `Dockerfile`
- Customizar imagens de Apache, Node.js, etc
- Utilizar **builds multistage** para reduzir tamanho
- Fazer upload de imagens para o **Docker Hub**
- Criar e usar um **registry local privado**

---

### Certificado

<img src="https://github.com/fzanneti/DIO-wex-e2e-csharp/blob/main/Assets/images/certificados/36-definicao-e-criacao-de-um-Dockerfile.jpg" alt="Certificado" width="600px">

---

##### ✍️ Seção criada por: *Fabio Zanneti* - 🎯 Bootcamp: **WEX - End to End Engineering**
[![GitHub](https://img.shields.io/badge/GitHub-fzanneti-181717?style=flat&logo=github)](https://github.com/fzanneti)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-fzanneti-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/fzanneti)