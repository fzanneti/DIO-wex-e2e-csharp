# Versionamento de Código com Git e GitHub

### 📌 Introdução

Neste módulo, você aprenderá:

- Como **criar, clonar e configurar** repositórios
- Como **salvar, desfazer e enviar alterações**
- A importância dos **branches**
- Como **resolver conflitos**
- E os comandos mais úteis do Git para o dia a dia

---

## 📁 Criando e Clonando Repositórios

### 🔹 Conceitos

- Um **repositório** é onde seu código é armazenado com controle de versão
- **Clonar**: copiar um repositório remoto
- **Criar**: iniciar um projeto do zero

### 🛠️ Comandos

```bash

# Criar um novo repositório local
git init

# Clonar um repositório remoto
git clone https://github.com/usuario/repositorio.git

```

⚠️ Use `git status` com frequência para acompanhar o que está acontecendo.

---

## 💾 Salvando Alterações no Repositório Local

### 🔹 Processo

1. Modifique seus arquivos
2. Use `git add` para prepará-los
3. Use `git commit` para registrar as alterações

### 🛠️ Comandos

```bash

git add arquivo.txt                 # Adiciona um arquivo
git commit -m "mensagem do commit" # Salva alterações com descrição

```

---

## 🔄 Desfazendo Alterações

### 🔹 Situações comuns

| Situação                             | Comando                    |
| ------------------------------------ | -------------------------- |
| Desfazer modificação em arquivo      | `git restore nome_arquivo` |
| Desfazer arquivos adicionados        | `git reset nome_arquivo`   |
| Desfazer último commit (não enviado) | `git reset --soft HEAD~1`  |

⚠️ Cuidado com `reset --hard`, ele apaga alterações sem retorno.

---

## 🌐 Enviando e Baixando do GitHub

### 🛠️ Comandos

```bash

git push origin main    # Envia alterações para o repositório remoto
git pull origin main    # Baixa alterações do repositório remoto

```

📌 `origin` = nome do repositório remoto
📌 `main` = branch principal (padrão atual)

---

## 🌳 Trabalhando com Branches

### 🔹 Diferença entre main e master no GitHub

- São nomes de branches
Tanto main quanto master são nomes dados ao branch principal de um repositório Git.
Ou seja, é como se fosse a "linha do tempo" principal onde o desenvolvimento do projeto acontece.

### Mas por que tem dois nomes?

- **Antes (padrão antigo):** ```master``` - 
Antigamente, o Git criava o primeiro branch com o nome master por padrão.   
Isso vem desde a criação do Git, lá em 2005.

- **Hoje (padrão novo):** ```main``` - 
A partir de 2020, o GitHub (e depois o Git) mudou o padrão para main.  
Motivo: tornar o Git mais inclusivo. O termo “master” pode ter conotações ruins, especialmente relacionadas à escravidão. A mudança foi parte de um movimento maior por linguagem mais neutra.

---

## Na prática, o que muda pra você?

### Pouca coisa, mas vale saber:

| Situação                        | Branch padrão |
| ------------------------------- | ------------- |
| Repositórios antigos (pré-2020) | `master`      |
| Repositórios novos (pós-2020)   | `main`        |

### Você pode mudar o nome?	  
- Sim! É só renomear o branch

🔍 Para ver o branch principal:

```bash

git branch -a
cat .git/HEAD

```

### 🛠️ Renomear `master` para `main`

```bash

git branch -m master main        # Renomeia localmente
git push origin -u main          # Atualiza no remoto

```

Depois, no GitHub:

* Vá em **Settings > Branches**
* Altere a branch padrão para `main`
* Delete a antiga `master` se quiser

---

### 🛠️ Comandos com Branches

```bash

git branch nome-branch         # Cria nova branch
git checkout nome-branch       # Muda para essa branch
git merge nome-branch          # Mescla branch com atual
git branch -d nome-branch      # Deleta branch

```

💡 Use branches para desenvolver funcionalidades separadamente.

---

## ⚔️ Resolvendo Conflitos

### 🔹 O que é um conflito?

Quando duas pessoas alteram a mesma parte de um arquivo em branches diferentes.

### ✅ Como resolver:

1. O Git marca o conflito com `<<<<<<<`, `=======`, `>>>>>>>`
2. Edite e resolva manualmente
3. Finalize com:

```bash

git add arquivo.txt
git commit -m "resolve conflito"

```

---

### 🧰 Comandos Úteis no Dia a Dia

| Comando      | Função                              |
| ------------ | ----------------------------------- |
| `git log`    | Histórico de commits                |
| `git status` | Situação atual do repositório       |
| `git diff`   | Diferença entre versões de arquivos |
| `git stash`  | Guarda alterações temporariamente   |
| `git rebase` | Reorganiza o histórico de commits   |

---

#### ✅ Conclusão

Você agora conhece o fluxo básico de versionamento:

1. Criar ou clonar repositórios
2. Fazer e registrar alterações
3. Trabalhar com branches e colaborar
4. Resolver conflitos com segurança

🧪 Continue praticando!
🛠️ Use o GitHub como vitrine do seu progresso.

---

### 📚 Recursos adicionais

* 📘 [Livro oficial do Git (pt-br)](https://git-scm.com/book/pt-br/v2)
* 🎥 [Guia de Git - DIO (YouTube)](https://www.youtube.com/watch?v=UBAX-13g8OM)
* 📖 [Documentação oficial do GitHub](https://docs.github.com/pt)

---

##### ✍️ **Seção criada por:** *Fabio Zanneti*
##### 🎯 Projeto: **WEX - End to End Engineering**