# 🛠️ Definição e Criação de um Dockerfile

### 🧱 Primeiro Dockerfile

Um `Dockerfile` é um arquivo de texto que contém **instruções** para gerar uma **imagem personalizada** do Docker. Com ele, podemos automatizar todo o processo de criação de ambientes.

---

### 📝 Exemplo: Primeiro Dockerfile

Crie uma pasta chamada `meu-apache` e dentro dela um arquivo `Dockerfile`:

```dockerfile

# Base da imagem
FROM httpd:2.4

# Copiando arquivos do host para dentro do contêiner
COPY ./public-html/ /usr/local/apache2/htdocs/

```

Depois crie a pasta `public-html/` com um arquivo `index.html`.

### 📦 **Build da imagem:**

```bash

docker build -t apache-personalizado .

```

### ▶️ **Executando:**

```bash

docker run -d -p 8080:80 --name meu-apache apache-personalizado

```

---

### 🔧 Criando imagem personalizada do Apache

Você pode adicionar scripts, páginas HTML e configurações customizadas ao seu container:

```dockerfile

FROM httpd:2.4

COPY ./meus-sites/ /usr/local/apache2/htdocs/
RUN echo "Servidor Apache customizado!" > /usr/local/apache2/htdocs/info.txt

```

Com isso, você entrega seu ambiente web já configurado, pronto para produção ou testes.

---

## 👨‍💻 Criando imagens personalizadas de linguagens de programação

### Exemplo: Aplicação Node.js

Estrutura de diretório:

```

app-node/
├── Dockerfile
├── package.json
└── index.js

```

### 📄 Dockerfile:

```dockerfile

FROM node:18

WORKDIR /app

COPY package*.json ./
RUN npm install

COPY . .

EXPOSE 3000

CMD [ "node", "index.js" ]

```

📦 **Build + run:**

```bash

docker build -t meu-node-app .
docker run -d -p 3000:3000 meu-node-app

```

---

### 🧪 Gerando imagem MULTISTAGE

O build multistage é útil para **reduzir o tamanho** da imagem final, separando as fases de build e produção.

### Exemplo: App Node.js com multistage

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

### ☁️ Realizando upload de imagens para o Docker Hub

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

🖼️ Agora sua imagem está pública (ou privada) no Docker Hub!
🔗 [Acesse seu perfil no Docker Hub](https://hub.docker.com/)

---

### 🏢 Criando seu próprio Registry (servidor de imagens local)

Você pode rodar um **registry local** para armazenar imagens privadas dentro da sua empresa ou máquina:

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

### 📚 Links de estudo complementar

* 📘 [Dockerfile – Documentação Oficial](https://docs.docker.com/engine/reference/builder/)
* 🧱 [Build Multistage no Docker – Dev.to](https://dev.to/joaopedrofilho/build-multistage-com-docker-38e8)
* 📦 [Como publicar imagens no Docker Hub – YouTube (Carlos Azevedo)](https://www.youtube.com/watch?v=_3fN1GikFQg)
* 🏢 [Criar um Docker Registry privado – DigitalOcean](https://www.digitalocean.com/community/tutorials/how-to-set-up-a-private-docker-registry-on-ubuntu-20-04)

---

#### ✅ O que você aprendeu nessa parte:

* Criar imagens personalizadas com `Dockerfile`
* Customizar imagens de Apache, Node.js, etc
* Utilizar **builds multistage** para reduzir tamanho
* Fazer upload de imagens para o **Docker Hub**
* Criar e usar um **registry local privado**

---

##### ✍️ **Seção criada por:** *Fabio Zanneti* 🎯 Projeto: **WEX - End to End Engineering**