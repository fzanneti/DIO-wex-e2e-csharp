# WEX - End to End Engineering

## 7.6 - Trabalhando com o Docker Compose

![GitHub repo size](https://img.shields.io/github/repo-size/fzanneti/wex-e2e-csharp)
![GitHub forks](https://img.shields.io/github/forks/fzanneti/wex-e2e-csharp?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/fzanneti/wex-e2e-csharp?style=social)
![Linguagem](https://img.shields.io/badge/Linguagem-CSharp-blue)
![Bootcamp](https://img.shields.io/badge/WEX-End--to--End%20Engineering-blueviolet?logo=vercel&logoColor=white)
![Plataforma](https://img.shields.io/badge/Powered%20by-DIO.io-red?logo=data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjZmZmIiB2aWV3Qm94PSIwIDAgMzIgMzIiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PHBhdGggZD0iTTYuNzEgMy4yNWMtMi44OCAxLjQxLTUuMDcgNC4yMy01LjA3IDcuNzYgMCAzLjU4IDIuMjggNi43IDUuMzMgOC4xNSAxLjgzLS42MiAyLjQtMi4yNiAyLjQtMy44MSAwLS4yMy0uMDItLjQ1LS4wNS0uNjZBLjQ0LjQ0IDAgMDExMC4xIDExYy4yNC0uNzUuMTEtMS41My0uMy0yLjIyQzguOTIgNy45NiA3LjMzIDcuNSA1Ljc0IDcuNjZhNS41NSA1LjU1IDAgM)
![Autor](https://img.shields.io/badge/Autor-fzanneti-blue?style=flat-square&logo=github)

---

### Introdução ao Docker Compose

O **Docker Compose** é uma ferramenta que permite **definir e gerenciar múltiplos contêineres** como uma única aplicação. Usamos um arquivo `docker-compose.yml` para configurar os serviços (como banco de dados, backend, frontend, etc).

---

### Instalação do Docker Compose

Em sistemas Linux modernos com Docker instalado via Docker Desktop ou CLI atualizada, o Compose já vem embutido e pode ser usado assim:

```bash

docker compose version

```

**Caso seu sistema seja mais antigo, você pode seguir a instalação oficial:**

🔗[Guia oficial – Instalação do Docker Compose](https://docs.docker.com/compose/install/)

---

### Docker Compose – Exemplo prático

Crie um arquivo chamado `docker-compose.yml`:

```yaml

version: '3.8'

services:
  web:
    image: nginx
    ports:
      - "8080:80"

```

**Execute com:**

```bash

docker compose up -d

```

**Verifique com:**

```bash

docker ps

```

---

### Parando e removendo tudo: `docker compose down`

**Para encerrar e limpar tudo (contêineres, redes, volumes e imagens criadas):**

```bash

docker compose down

```

**Você pode limpar volumes juntos:**

```bash

docker compose down -v

```

---

### Exemplo prático: PHP + Apache + MySQL

**Estrutura de diretórios:**

```

php-mysql/
├── docker-compose.yml
└── site/
    └── index.php

```

`site/index.php`

```php

<?php
  $conn = new mysqli("db", "root", "senha123", "meubanco");
  if ($conn->connect_error) {
    die("Conexão falhou: " . $conn->connect_error);
  }
  echo "<h1>Conectado com sucesso ao MySQL!</h1>";
?>

```

`docker-compose.yml`

```yaml

version: '3.8'

services:
  web:
    image: php:7.4-apache
    container_name: php-apache
    ports:
      - "8080:80"
    volumes:
      - ./site:/var/www/html

  db:
    image: mysql:5.7
    container_name: mysql-db
    environment:
      MYSQL_ROOT_PASSWORD: senha123
      MYSQL_DATABASE: meubanco
    ports:
      - "3306:3306"

```

**Executar:**

```bash

docker compose up -d

```

Acesse: 🔗[localhost:8080](http://localhost:8080)

O PHP se conecta ao MySQL através do nome do serviço `db`.

---

### Utilizando exemplos do GitHub oficial do Docker

O repositório oficial do Docker tem vários exemplos prontos com Docker Compose:

🔗[Docker Samples no GitHub](https://github.com/docker/awesome-compose)

Exemplos úteis:

- **React + Node + Mongo**
- **Laravel + MySQL**
- **WordPress + MariaDB**
- **Nginx como proxy reverso**

Você pode clonar e adaptar conforme sua necessidade.

```bash

git clone https://github.com/docker/awesome-compose.git
cd awesome-compose/react-express-mongodb
docker compose up -d

```

---

### Links de estudo complementar

🔗[Documentação oficial do Docker Compose](https://docs.docker.com/compose/)\
🔗[Curso Docker Compose básico (YouTube – Fellyph Cintra)](https://www.youtube.com/watch?v=GH0x0qkZf5k)\
🔗[Awesome Compose – Exemplos no GitHub](https://github.com/docker/awesome-compose)\
🔗[Tutorial Compose com PHP e MySQL (Blog do Programador)](https://blog.programador.cs/docker-compose-aplicacao-php-mysql/)

---

### O que você aprendeu nessa parte:

- O que é e para que serve o Docker Compose
- Como montar múltiplos serviços com um único arquivo
- Exemplo real com PHP, Apache e MySQL
- Como parar e limpar ambientes com `docker compose down`
- Onde encontrar exemplos prontos no GitHub

---

### Certificado

<img src="https://github.com/fzanneti/DIO-wex-e2e-csharp/blob/main/Assets/images/certificados/37-trabalhando-com-Docker-Compose.jpg" alt="Certificado" width="600px">

---

##### ✍️ Seção criada por: *Fabio Zanneti* - 🎯 Bootcamp: **WEX - End to End Engineering**
[![GitHub](https://img.shields.io/badge/GitHub-fzanneti-181717?style=flat&logo=github)](https://github.com/fzanneti)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-fzanneti-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/fzanneti)