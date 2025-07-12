# Versionamento de Código com Git e GitHub

![GitHub repo size](https://img.shields.io/github/repo-size/fzanneti/wex-e2e-csharp)
![GitHub forks](https://img.shields.io/github/forks/fzanneti/wex-e2e-csharp?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/fzanneti/wex-e2e-csharp?style=social)
![Linguagem](https://img.shields.io/badge/Linguagem-CSharp-blue)
![Bootcamp](https://img.shields.io/badge/WEX-End--to--End%20Engineering-blueviolet?logo=vercel&logoColor=white)
![Plataforma](https://img.shields.io/badge/Powered%20by-DIO.io-red?logo=data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjZmZmIiB2aWV3Qm94PSIwIDAgMzIgMzIiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PHBhdGggZD0iTTYuNzEgMy4yNWMtMi44OCAxLjQxLTUuMDcgNC4yMy01LjA3IDcuNzYgMCAzLjU4IDIuMjggNi43IDUuMzMgOC4xNSAxLjgzLS42MiAyLjQtMi4yNiAyLjQtMy44MSAwLS4yMy0uMDItLjQ1LS4wNS0uNjZBLjQ0LjQ0IDAgMDExMC4xIDExYy4yNC0uNzUuMTEtMS41My0uMy0yLjIyQzguOTIgNy45NiA3LjMzIDcuNSA1Ljc0IDcuNjZhNS41NSA1LjU1IDAgM)
![Autor](https://img.shields.io/badge/Autor-fzanneti-blue?style=flat-square&logo=github)

---

### 📌 Introdução

O versionamento com Git e GitHub é essencial para projetos .NET, permitindo colaboração eficiente e controle de alterações. No Bootcamp WEX, você usará essas ferramentas para versionar seu código e colaborar em equipe. Este módulo aborda repositórios, branches, commits, conflitos e automação.

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

# Acessa o diretório o projeto
cd repositorio

# Cria um novo projeto de aplicativo de console C# básico
dotnet new console

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
git commit -m "mensagem do commit"  # Salva alterações com descrição - exemplo: "feat: add .NET console project structure"

```

### 🔏.gitignore para .NET**:

```bash

echo -e "bin/\nobj/\n*.csproj.user\n.vscode/" > .gitignore


```

#### Propósito do .gitignore

> O arquivo .gitignore é crucial em sistemas de controle de versão (mais comumente o Git) para especificar arquivos e diretórios intencionalmente não rastreados que o Git deve ignorar. Isso ajuda a manter seu repositório limpo e focado no código-fonte relevante, impedindo que arquivos desnecessários (como arquivos temporários, artefatos de build ou configurações específicas de IDE) sejam commitados.

---

## 🔄 Desfazendo Alterações

### 🔹 Situações comuns

| Situação                             | Comando                    |
| ------------------------------------ | -------------------------- |
| Desfazer modificação em arquivo      | `git restore nome_arquivo` |
| Desfazer arquivos adicionados        | `git reset nome_arquivo`   |
| Desfazer último commit (não enviado) | `git reset --soft HEAD~1`  |

⚠️ Cuidado com `reset --hard`, ele apaga alterações sem retorno.

### 🔹Usando `git stash`

```bash

# Salva suas mudanças locais não commitadas em uma área de armazenamento temporário (stash), associando a mensagem "alterações temporárias" para identificação.
git stash push -m "alterações temporárias"

# Aplica as mudanças salvas mais recentemente do seu stash e, em seguida, as remove do stash.
git stash pop

```

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

### 📝 Exemplo de CI para .NET:

```yaml

name: CI .NET
on: [push]
jobs:
  build:
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v3
      - uses: actions/setup-dotnet@v3
        with:
          dotnet-version: '8.0.x'
      - run: dotnet build
      - run: dotnet test

```

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

###  📝 Exemplo:

1. Conflito em `Program.cs`:

```csharp

<<<<<<< HEAD
Console.WriteLine("Olá do desenvolvedor 1!");
=======
Console.WriteLine("Olá do desenvolvedor 2!");
>>>>>>> feature/2

```
2. Resolva:

```csharp

Console.WriteLine("Olá dos desenvolvedores 1 e 2!");

```

3. Finalize:

```bash

git add Program.cs
git commit -m "resolve: merge conflict in Program.cs"

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
* 🎥 [Como usar Git e GitHub na prática (YouTube)](https://www.youtube.com/watch?v=UBAX-13g8OM)
* 📖 [Documentação oficial do GitHub](https://docs.github.com/pt)

---

##### ✍️ Seção criada por: *Fabio Zanneti* - 🎯 Bootcamp: **WEX - End to End Engineering**
[![GitHub](https://img.shields.io/badge/GitHub-fzanneti-181717?style=flat&logo=github)](https://github.com/fzanneti)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-fzanneti-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/fzanneti)