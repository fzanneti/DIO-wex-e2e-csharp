# 🗄️ Armazenamento de Dados com Docker

### 📂 Montando um local de armazenamento

Por padrão, os dados em um contêiner Docker são **voláteis**, ou seja, são perdidos ao parar ou remover o contêiner. Para evitar isso, usamos os **volumes**, que permitem persistência de dados no host.

**Tipos de volumes (mounts):**

1. **Bind Mounts**
2. **Named Volumes**
3. **Volumes definidos no Dockerfile**

---

## 🔧 Tipos de Mount: Bind, Named, Dockerfile Volume

### 🔹 1. Bind Mount

Mapeia um diretório do host (máquina real) para dentro do contêiner:

```bash

docker run -v /caminho/no/host:/caminho/no/container nginx

```

> Útil para desenvolvimento, pois reflete mudanças em tempo real.

---

### 🔹 2. Named Volume

Volume nomeado, gerenciado pelo Docker, útil para produção:

```bash

docker volume create meu_volume
docker run -v meu_volume:/var/lib/mysql mysql

```

---

### 🔹 3. Volume no Dockerfile

Pode ser definido dentro do próprio Dockerfile:

```dockerfile

VOLUME /app/dados

```

> Quando o contêiner for criado, o Docker automaticamente gera um volume persistente para essa pasta.

---

### 🧪 Exemplos práticos de Mount

**Bind Mount simples (local → container):**

```bash

docker run -d \
-p 8080:80 \
-v $(pwd)/meu_html:/usr/share/nginx/html \
--name site_nginx \
nginx

```

**Named Volume:**

```bash

docker volume create dados_aplicacao
docker run -d \
-v dados_aplicacao:/app/data \
--name app_com_volume \
ubuntu

```

**Listar volumes existentes:**

```bash

docker volume ls

```

**Remover volume:**

```bash

docker volume rm nome_volume

```

---

### ✅ Mount: Conclusão

* **Bind mounts** são ótimos para desenvolvimento e testes locais
* **Named volumes** são ideais para ambientes de produção
* Volume no **Dockerfile** ajuda a manter consistência entre builds
* Montar volumes evita perda de dados e melhora organização

---

### 🌐 Exemplo: Apache Contêiner

Crie um diretório com um `index.html` local:

```bash

mkdir apache-site
echo "<h1>Olá, Fabio com Apache no Docker!</h1>" > apache-site/index.html

```

Execute o contêiner Apache com bind mount:

```bash

docker run -d \
-p 8080:80 \
-v $(pwd)/apache-site:/usr/local/apache2/htdocs/ \
--name apache-container \
httpd

```

Abra no navegador:

👉 [http://localhost:8080](http://localhost:8080)

---

### 🐘 Exemplo: PHP + Apache

Crie os arquivos:

📄 `index.php`

```php

<?php
    echo "<h1>Olá, Fabio com PHP + Apache no Docker!</h1>";
?>

```

📁 Estrutura de diretórios:

```

php-apache-site/
└── index.php

```

📦 Execute:

```bash

docker run -d \
-p 8081:80 \
-v $(pwd)/php-apache-site:/var/www/html \
--name php-apache-container \
php:7.4-apache

```

Acesse:

👉 [http://localhost:8081](http://localhost:8081)

---

### 📚 Links de estudo complementar

* 📘 [Volumes no Docker – Documentação oficial](https://docs.docker.com/storage/volumes/)
* 🎥 [Explicação prática sobre volumes Docker (YouTube – LinuxTips)](https://www.youtube.com/watch?v=QxZtBB0_EoU)
* 📄 [Diferenças entre Bind Mount e Volume – Dev.to](https://dev.to/lucassha/diferenca-entre-docker-volume-e-bind-mount-3e3k)

---

#### ✅ O que você aprendeu nessa parte:

* Como montar volumes no Docker
* Diferença entre bind mount, named volume e volume via Dockerfile
* Criar contêineres com Apache e PHP com volumes
* Como garantir persistência de dados nos seus projetos

---

##### ✍️ **Seção criada por:** *Fabio Zanneti* 🎯 Projeto: **WEX - End to End Engineering**