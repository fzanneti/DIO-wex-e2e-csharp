# 🧠 Processamento, Logs e Rede com Docker

### ⚙️ Processamento, Logs e Rede

Ao trabalhar com contêineres, é essencial entender como controlar o uso de **recursos**, acompanhar **logs** e configurar **redes** para integração entre serviços.

---

### 💾 Limitando memória e CPU

Você pode limitar o uso de recursos dos seus contêineres para evitar sobrecarga da máquina host.

**Limitar memória (ex: 512MB):**

```bash

docker run -m 512m ubuntu

```

**Limitar CPUs (ex: usar apenas 1 CPU):**

```bash

docker run --cpus="1.0" ubuntu

```

**Limitar memória + CPU:**

```bash

docker run -m 512m --cpus="0.5" ubuntu

```

### 📌 *Essas limitações são úteis principalmente em ambientes de produção, onde o consumo precisa ser controlado.*

---

### 📄 Informações, logs e processos

**Ver detalhes de uso do contêiner:**

```bash

docker stats

```

Exibe uso de CPU, memória e rede em tempo real de todos os contêineres.

**Inspecionar detalhes do contêiner:**

```bash

docker inspect nome_ou_id

```

**Acessar logs de um contêiner:**

```bash

docker logs nome_ou_id

```

Você pode usar filtros:

```bash

docker logs --tail 50 nome_container     # Últimas 50 linhas
docker logs -f nome_container            # Acompanhar em tempo real (follow)

```

**Ver processos ativos dentro do contêiner:**

```bash

docker top nome_container

```

---

### 🌐 Redes

O Docker trabalha com redes para permitir que contêineres se comuniquem entre si ou com o mundo externo.

### Tipos de redes:

| Tipo              | Descrição                                         |
| ----------------- | ------------------------------------------------- |
| `bridge` (padrão) | Rede interna para comunicação entre contêineres   |
| `host`            | Compartilha a rede do host (sem isolamento)       |
| `none`            | Desativa completamente a rede                     |
| `custom`          | Redes criadas manualmente para organizar serviços |

---

**Criar uma rede customizada:**

```bash

docker network create minha-rede

```

**Usar essa rede ao criar contêiner:**

```bash

docker run -d --name meu_app --network minha-rede nginx

```

**Listar redes existentes:**

```bash

docker network ls

```

**Inspecionar rede específica:**

```bash

docker network inspect minha-rede

```

---

### 🔗 Exemplo prático de rede entre dois contêineres

```bash

# Criar a rede
docker network create rede-teste

# Subir contêiner do MySQL
docker run -d --name meu_mysql --network rede-teste \
  -e MYSQL_ROOT_PASSWORD=senha123 \
  mysql:8.0

# Subir aplicação na mesma rede
docker run -it --network rede-teste --rm php bash

```

Agora o contêiner PHP pode acessar o MySQL usando o nome `meu_mysql` como hostname.

---

### 📚 Links de Estudo Complementar

* 📘 [Gerenciando recursos do Docker – Documentação Oficial](https://docs.docker.com/config/containers/resource_constraints/)
* 🎥 [Comando docker stats explicado – YouTube](https://www.youtube.com/watch?v=Qo3FHp2nAGc)
* 🔧 [Redes no Docker – Explicação prática (Dev.to)](https://dev.to/coderpadawans/docker-criando-e-gerenciando-redes-1jpp)
* 📦 [Documentação oficial sobre Docker Networks](https://docs.docker.com/network/)

---

#### ✅ O que você aprendeu nessa parte:

* Como limitar o uso de **CPU** e **memória** em contêineres
* Monitorar **logs**, **processos** e **uso de recursos**
* Criar e gerenciar **redes Docker**
* Fazer comunicação entre contêineres de forma isolada e organizada

---

##### ✍️ **Seção criada por:** *Fabio Zanneti* 🎯 Projeto: **WEX - End to End Engineering**