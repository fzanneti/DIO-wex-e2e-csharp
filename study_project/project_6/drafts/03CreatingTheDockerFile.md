# 🧱 Criar o `Dockerfile` do JarbasBot

![GitHub repo size](https://img.shields.io/github/repo-size/fzanneti/wex-e2e-csharp)
![GitHub forks](https://img.shields.io/github/forks/fzanneti/wex-e2e-csharp?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/fzanneti/wex-e2e-csharp?style=social)
![Bootcamp](https://img.shields.io/badge/WEX-End--to--End%20Engineering-blueviolet?logo=vercel&logoColor=white)
![Plataforma](https://img.shields.io/badge/Powered%20by-DIO.io-red?logo=data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjZmZmIiB2aWV3Qm94PSIwIDAgMzIgMzIiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PHBhdGggZD0iTTYuNzEgMy4yNWMtMi44OCAxLjQxLTUuMDcgNC4yMy01LjA3IDcuNzYgMCAzLjU4IDIuMjggNi43IDUuMzMgOC4xNSAxLjgzLS42MiAyLjQtMi4yNiAyLjQtMy44MSAwLS4yMy0uMDItLjQ1LS4wNS0uNjZBLjQ0LjQ0IDAgMDExMC4xIDExYy4yNC0uNzUuMTEtMS41My0uMy0yLjIyQzguOTIgNy45NiA3LjMzIDcuNSA1Ljc0IDcuNjZhNS41NSA1LjU1IDAgM)
![Autor](https://img.shields.io/badge/Autor-fzanneti-blue?style=flat-square&logo=github)

---

> O `Dockerfile` define como o projeto em C# será **compilado e empacotado** como container.

---

### 📁 Navegue até a pasta do projeto JarbasBot

```bash

cd /DesafioWEXDockerCompose/JarbasBot

```

---

### 📝 Crie o arquivo `Dockerfile`

```bash

nano Dockerfile

```

Cole o conteúdo abaixo:

```dockerfile

# Etapa 1: build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copia tudo
COPY . ./

# Restaura as dependências
RUN dotnet restore

# Compila o projeto
RUN dotnet publish -c Release -o out

# Etapa 2: runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Copia os arquivos compilados da etapa anterior
COPY --from=build /app/out .

# Expõe a porta padrão da API
ENV ASPNETCORE_URLS=http://+:80

# Executa o JarbasBot
ENTRYPOINT ["dotnet", "JarbasBot.dll"]

```

---

### 💡 O que esse Dockerfile faz?

| Etapa        | O que faz                                  |
| ------------ | ------------------------------------------ |
| `build`      | Compila seu projeto com o SDK              |
| `runtime`    | Usa imagem mais leve só com ASP.NET        |
| `COPY`       | Move o build final pra dentro do container |
| `ENTRYPOINT` | Define o comando pra iniciar sua API       |

---

### 📂 Confirma: Estrutura atual do projeto

```

DesafioWEXDockerCompose/
├── html/
│   └── index.html
├── JarbasBot/
│   ├── Controllers/
│   ├── Program.cs
│   ├── Dockerfile ✅
│   └── ...

```

---

# ✅ Criar o `docker-compose.yml` com os dois serviços

Agora vamos orquestrar tudo.

---

### 📁 Volte para a raiz do projeto

```bash

cd /DesafioWEXDockerCompose

```

---

### 📝 Crie o arquivo `docker-compose.yml`

```bash

nano docker-compose.yml

```

Cole o conteúdo:

```yaml

services:
  apache:
    image: httpd:latest
    container_name: apache-server
    ports:
      - "8080:80"
    volumes:
      - ./html:/usr/local/apache2/htdocs/

  jarbasbot:
    build:
      context: ./JarbasBot
      dockerfile: Dockerfile
    container_name: jarbasbot-api
    ports:
      - "5000:80"
    environment:
      - ASPNETCORE_ENVIRONMENT=Development
      # API KEY pode ser usada aqui futuramente:
      # - OPENAI_API_KEY=xxxxxx

```

---

# 🚀 Rodar tudo com Docker Compose

Na raiz do projeto:

```bash

docker-compose up --build

```

Se tudo der certo, você verá logs assim:

```

container apache-server - Running
jarbasbot-api - Running

```

---

### 🌐 Agora acesse:

* `http://localhost:8080` → Página HTML do desafio
* `http://localhost:5000/swagger` → API do JarbasBot pronta para interagir

---

#### ✅ Concluído!

| Serviço     | Porta | Status    |
| ----------- | ----- | --------- |
| Apache HTML | 8080  | ✅ Rodando |
| JarbasBot   | 5000  | ✅ Rodando |

---


##### ✍️ Criado por: Fabio Zanneti - 🎯 Projeto: WEX - End to End Engineering
[![GitHub](https://img.shields.io/badge/GitHub-fzanneti-181717?style=flat&logo=github)](https://github.com/fzanneti)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-fzanneti-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/fzanneti)