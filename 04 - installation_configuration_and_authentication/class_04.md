# **Instalando, Configurando e Autenticando o Git**

### **Introdução**

Antes de usar Git e GitHub com eficiência, você precisa instalar e configurar corretamente o ambiente local. Nesta aula, vamos aprender como instalar o Git, fazer sua configuração inicial e autenticar sua máquina com o GitHub de forma segura.

---

### **Instalação do Git**

**No Windows:**
- Acesse o site oficial: 👉 https://git-scm.com/download/win
- Baixe o instalador e execute.

**Durante a instalação:**
- Mantenha as opções padrão.
- Certifique-se de marcar “Git from the command line”.

**Após a instalação, abra o terminal (CMD ou Git Bash) e digite:**

```bash
git --version
```
**🐧 No Linux (Ubuntu):**  
- Abra o terminal e execute:

```bash
sudo apt update
sudo apt install git
git --version
```

> *Verifique se o Git foi instalado corretamente com o comando ```git --version.```*

---

### **Configurando o Git**

Depois de instalar, defina seu nome de usuário e e-mail e eles aparecerão em cada commit.

```bash
git config --global user.name "Seu Nome"
git config --global user.email "seuemail@exemplo.com"
```

Verifique as configurações com:

```bash
git config --list
```
> *Essa configuração é como "assinar" seus códigos com sua identidade.*

---

### **Autenticando via Token (HTTPS)**

GitHub **não permite mais login com senha** via HTTPS.  
Use um token de acesso pessoal (PAT).

#### **Como gerar um Token:**

1. Acesse: https://github.com/settings/tokens.
2. Clique em **"Generate new token (classic)".**
3. Selecione permissões básicas: ```repo```, ```workflow```, ```read:user```.
4. Copie o token (ele não será mostrado novamente).

#### **Como usar:**

Ao fazer um ````git push```` pela primeira vez, insira:
- Usuário: seu usuário do GitHub
- Senha: cole o token no lugar da senha

````bash
git push origin main
# Será solicitado usuário e token
````

---

### **Autenticando via Chave SSH (Recomendado)**

Mais segura e prática. Ideal para quem usa GitHub com frequência.

**Gerar uma chave SSH:**

````bash
ssh-keygen -t ed25519 -C "seuemail@exemplo.com"
````

- Pressione Enter para aceitar o local padrão.
- Não use senha (ou defina uma, se desejar).

**Adicionar a chave ao GitHub:**

1. Copie a chave pública:

````bash
cat ~/.ssh/id_ed25519.pub
````

2. Vá até https://github.com/settings/ssh/new
3. Cole a chave e salve.

**Testar conexão:**

````bash
ssh -T git@github.com
`````

Se tudo estiver certo, você verá:

````bash
Hi seu_usuario! You've successfully authenticated.
````

*A chave SSH funciona como um “cartão de acesso” entre sua máquina e o GitHub.*

---

### **Comparativo: Token vs SSH**

|Autenticação|Vantagem|Ideal para...|
|:---:|:---:|:---:|
|Token (HTTPS)|Fácil de gerar, mais intuitivo|Usuários ocasionais|
|SSH|Mais segura, evita repetição|Usuários frequentes/projetos|

**Exemplo prático (fluxo SSH)**

````bash
# Criação de repositório local e envio para GitHub usando SSH

git init
git add .
git commit -m "Primeiro commit"
git remote add origin git@github.com:seuusuario/repositorio.git
git push -u origin master
````

**Conclusão**

> Instalar e configurar o Git corretamente é o primeiro passo para um versionamento eficiente. Com a autenticação segura via Token ou SSH, você garante integridade e praticidade ao interagir com o GitHub. Na próxima aula, aprenderemos fluxos de trabalho com branch, merge, pull, e push.

---

### **Materiais Complementares**

- [Documentação Oficial do Git](https://git-scm.com/doc)
- [Autenticação via token no GitHub](https://docs.github.com/pt/authentication/keeping-your-account-and-data-secure/managing-your-personal-access-tokens)
- [Como usar chaves SSH com GitHub](https://docs.github.com/pt/authentication/connecting-to-github-with-ssh)

---

##### Seção criada por: *Fabio Zanneti - Projeto: WEX - End to End Engineering* - Guia de estudos.

---
