# WEX - End to End Engineering

## Instalando, Configurando e Autenticando o Git

![GitHub repo size](https://img.shields.io/github/repo-size/fzanneti/wex-e2e-csharp)
![GitHub forks](https://img.shields.io/github/forks/fzanneti/wex-e2e-csharp?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/fzanneti/wex-e2e-csharp?style=social)
![Linguagem](https://img.shields.io/badge/Linguagem-CSharp-blue)
![Bootcamp](https://img.shields.io/badge/WEX-End--to--End%20Engineering-blueviolet?logo=vercel&logoColor=white)
![Plataforma](https://img.shields.io/badge/Powered%20by-DIO.io-red?logo=data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjZmZmIiB2aWV3Qm94PSIwIDAgMzIgMzIiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PHBhdGggZD0iTTYuNzEgMy4yNWMtMi44OCAxLjQxLTUuMDcgNC4yMy01LjA3IDcuNzYgMCAzLjU4IDIuMjggNi43IDUuMzMgOC4xNSAxLjgzLS42MiAyLjQtMi4yNiAyLjQtMy44MSAwLS4yMy0uMDItLjQ1LS4wNS0uNjZBLjQ0LjQ0IDAgMDExMC4xIDExYy4yNC0uNzUuMTEtMS41My0uMy0yLjIyQzguOTIgNy45NiA3LjMzIDcuNSA1Ljc0IDcuNjZhNS41NSA1LjU1IDAgM)
![Autor](https://img.shields.io/badge/Autor-fzanneti-blue?style=flat-square&logo=github)

---

### Introdução

Configurar o Git corretamente é essencial para gerenciar projetos .NET com eficiência, garantindo colaboração fluida e versionamento seguro. No Bootcamp WEX, você usará Git e GitHub para controlar suas aplicações. Este módulo guia você na instalação, configuração e autenticação, preparando o terreno para fluxos colaborativos.

Você aprenderá a:

- Instalar o Git.
- Configurar nome e e-mail.
- Autenticar com GitHub via **Token** ou **SSH**.

---

### Instalação do Git

⊞ Windows

1. Acesse: 🔗[https://git-scm.com/download/win](https://git-scm.com/download/win)  
2. Baixe o instalador, execute mantendo as opções padrão
3. Certifique-se de deixar marcada a opção **“Git from the command line”**

**Verifique a instalação:**

```bash

git --version

```

---

🐧 Linux (Ubuntu)

Abra o terminal e execute:

```bash

sudo apt update
sudo apt install git
git --version

```

---

🍎 macOS

```bash

brew install git

```

- Verifique:

```bash

git --version

```

> "**Nota**: Use Git 2.28+ para compatibilidade com GitHub Actions."

---

### Configurando o Git

Após a instalação, defina seu nome e e-mail (eles ficarão gravados em cada commit que você fizer):

```bash

git config --global user.name "Seu Nome"
git config --global user.email "seuemail@exemplo.com"

```

---

### Configurações adicionais:

- Editor padrão (VS Code):

```bash

git config --global core.editor "code --wait"

```

---

- Cores no terminal:

```bash

git config --global color.ui auto

```

---

- Branch padrão (`main`):

```bash

git config --global init.defaultBranch main

```

---

### Verifique a configuração:

```bash

git config --list

```

> *Essa configuração é como “assinar” seus códigos com sua identidade.*

---

### Configurando Git para Projetos .NET

1. Crie um projeto .NET:

```bash

dotnet new console -n MeuProjeto
cd MeuProjeto

```

2. Inicialize o Git e adicione .gitignore:

```bash

git init
echo -e "bin/\nobj/\n*.csproj.user\n.vscode/" > .gitignore
git add .
git commit -m "feat: initialize .NET console project"

```

---

### Autenticação via Token (HTTPS)

O GitHub **não permite mais login com senha**.
A autenticação por Token é simples e segura para quem usa Git ocasionalmente.

---

### Como gerar seu Token:

1. Acesse: 🔗[https://github.com/settings/tokens](https://github.com/settings/tokens)
2. Clique em **"Generate new token (classic)"**
3. Marque permissões como:

   * `repo`
   * `workflow`
   * `read:user`
4. Copie o token (⚠️ ele não será exibido novamente)

---

### Como usar:

Na hora de fazer `git push`, use:

* **Usuário:** seu login do GitHub
* **Senha:** o token gerado

```bash

git push origin main

```

---

### Armazenar token:

```bash

git config --global credential.helper store

```

---

### Autenticação via Chave SSH (Recomendado)

Mais segura e prática. Ideal para quem usa GitHub com frequência.

- Gerar uma chave SSH:

```bash

ssh-keygen -t ed25519 -C "seuemail@exemplo.com"

```

* Pressione **Enter** para aceitar o local padrão
* Pode usar senha (ou deixar em branco)

---

### Adicionar ao GitHub:

1. Copie a chave pública:

```bash

cat ~/.ssh/id_ed25519.pub

```

2. Vá até: [https://github.com/settings/ssh/new](https://github.com/settings/ssh/new)
3. Cole a chave e clique em **Add SSH Key**

---

### Testar conexão:

```bash

ssh -T git@github.com

```

Se estiver tudo certo:

```bash

Hi seu_usuario! You've successfully authenticated.

```

> *A chave SSH funciona como um “cartão de acesso” entre sua máquina e o GitHub.*

---

### Múltiplas máquinas:

```bash

ssh-keygen -t ed25519 -C "seuemail@exemplo.com" -f ~/.ssh/id_ed25519_trabalho

```

---

### Comparativo: Token vs SSH

| Autenticação | Vantagem                | Ideal para...           |
| --------------- | ------------------------- | -------------------------- |
| **Token**       | Fácil de gerar e usar     | Usuários ocasionais        |
| **SSH**         | Mais segura e persistente | Usuários frequentes e devs |

---

### Exemplo prático: Git com SSH

1. Crie um projeto .NET:

```bash

dotnet new console -n MeuProjeto
cd MeuProjeto

```

2. Configure o Git:

```bash

git init
echo -e "bin/\nobj/\n*.csproj.user\n.vscode/" > .gitignore
git add .
git commit -m "feat: initialize .NET console project"

```

3. Conecte ao GitHub:

```bash

git remote add origin git@github.com:fzanneti/MeuProjeto.git
git push -u origin main

```

---

### Código (Program.cs):

```csharp

using System;

namespace MeuProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto .NET configurado com Git e GitHub!");
        }
    }
}

```

---

### Solução de Problemas

- "git não reconhecido": Reinstale o Git e verifique o PATH.
- "Permission denied (publickey)": Adicione a chave SSH ao GitHub.
- "Invalid username or password": Gere um novo token.

---

### Materiais Complementares

🔗[Documentação Oficial do Git](https://git-scm.com/doc)  
🔗[Pro Git Book (pt-BR)](https://git-scm.com/book/pt-br/v2)  
🔗[GitHub Docs: Autenticação](https://docs.github.com/pt/authentication)  
🔗[Como gerar e usar tokens no GitHub](https://docs.github.com/pt/authentication/keeping-your-account-and-data-secure/managing-your-personal-access-tokens)  
🔗[Conectar-se ao GitHub com SSH](https://docs.github.com/pt/authentication/connecting-to-github-with-ssh)

---

### Conclusão

Configurar corretamente o Git e autenticar com segurança é o primeiro passo para usar versionamento com eficiência.
Com **Token ou SSH**, você garante segurança e praticidade ao trabalhar com o GitHub.

---

##### ✍️ Seção criada por: *Fabio Zanneti* - 🎯 Bootcamp: **WEX - End to End Engineering**
[![GitHub](https://img.shields.io/badge/GitHub-fzanneti-181717?style=flat&logo=github)](https://github.com/fzanneti)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-fzanneti-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/fzanneti)