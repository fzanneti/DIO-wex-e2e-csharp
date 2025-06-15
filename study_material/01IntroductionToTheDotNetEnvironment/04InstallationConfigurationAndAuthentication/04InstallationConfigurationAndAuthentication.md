# 🔧 Instalando, Configurando e Autenticando o Git

### 🧭 Introdução

Antes de usar Git e GitHub com eficiência, é essencial configurar corretamente seu ambiente local.

Nesta aula, você vai:

- Instalar o Git
- Configurar seu nome e e-mail
- Aprender duas formas de autenticação com o GitHub: **via Token** e **via Chave SSH**

---

## 💾 Instalação do Git

### 🪟 Windows

1. Acesse: [https://git-scm.com/download/win](https://git-scm.com/download/win)  
2. Baixe o instalador e execute
3. Mantenha as opções padrão  
✅ Certifique-se de deixar marcada a opção **“Git from the command line”**

**Verifique a instalação:**

```bash

git --version

```

---

### 🐧 Linux (Ubuntu)

Abra o terminal e execute:

```bash

sudo apt update
sudo apt install git
git --version

```

---

### ⚙️ Configurando o Git

Após a instalação, defina seu nome e e-mail (eles ficarão gravados em cada commit que você fizer):

```bash
git config --global user.name "Seu Nome"
git config --global user.email "seuemail@exemplo.com"
```

✅ **Verifique a configuração:**

```bash

git config --list

```

💡 *Essa configuração é como “assinar” seus códigos com sua identidade.*

---

## 🔐 Autenticação via Token (HTTPS)

O GitHub **não permite mais login com senha**.
A autenticação por Token é simples e segura para quem usa Git ocasionalmente.

### 👣 Como gerar seu Token:

1. Acesse: [https://github.com/settings/tokens](https://github.com/settings/tokens)
2. Clique em **"Generate new token (classic)"**
3. Marque permissões como:

   * `repo`
   * `workflow`
   * `read:user`
4. Copie o token (⚠️ ele não será exibido novamente)

### 🛠️ Como usar:

Na hora de fazer `git push`, use:

* **Usuário:** seu login do GitHub
* **Senha:** o token gerado

```bash

git push origin main

```

---

## 🛡️ Autenticação via Chave SSH (Recomendado)

Mais segura e prática. Ideal para quem usa GitHub com frequência.

### 🔐 Gerar uma chave SSH:

```bash

ssh-keygen -t ed25519 -C "seuemail@exemplo.com"

```

* Pressione **Enter** para aceitar o local padrão
* Pode usar senha (ou deixar em branco)

### 📋 Adicionar ao GitHub:

1. Copie a chave pública:

```bash

cat ~/.ssh/id_ed25519.pub

```

2. Vá até: [https://github.com/settings/ssh/new](https://github.com/settings/ssh/new)
3. Cole a chave e clique em **Add SSH Key**

### ✅ Testar conexão:

```bash

ssh -T git@github.com

```

Se estiver tudo certo:

```bash

Hi seu_usuario! You've successfully authenticated.

```

💡 *A chave SSH funciona como um “cartão de acesso” entre sua máquina e o GitHub.*

---

### ⚖️ Comparativo: Token vs SSH

| 🔐 Autenticação | ✅ Vantagem                | 👤 Ideal para...           |
| --------------- | ------------------------- | -------------------------- |
| **Token**       | Fácil de gerar e usar     | Usuários ocasionais        |
| **SSH**         | Mais segura e persistente | Usuários frequentes e devs |

---

### 🚀 Exemplo prático: Git com SSH

```bash

# Criação do repositório local e envio para o GitHub via SSH

git init
git add .
git commit -m "Primeiro commit"
git remote add origin git@github.com:seuusuario/repositorio.git
git push -u origin master

```

---

#### ✅ Conclusão

Configurar corretamente o Git e autenticar com segurança é o primeiro passo para usar versionamento com eficiência.

Com **Token ou SSH**, você garante segurança e praticidade ao trabalhar com o GitHub.

👉 No próximo módulo: Fluxos de trabalho com `branch`, `merge`, `pull` e `push`.

---

### 📚 Materiais Complementares

* 📘 [Documentação Oficial do Git](https://git-scm.com/doc)
* 🔐 [Como gerar e usar tokens no GitHub](https://docs.github.com/pt/authentication/keeping-your-account-and-data-secure/managing-your-personal-access-tokens)
* 🛡️ [Conectar-se ao GitHub com SSH](https://docs.github.com/pt/authentication/connecting-to-github-with-ssh)

---

> ##### ✍️ **Seção criada por:** *Fabio Zanneti*
> ##### 🎯 Projeto: **WEX - End to End Engineering**
> ##### 📁 *Guia de estudos estruturado para GitHub*