# WEX - End to End Engineering

## 3 - Introdução ao Versionamento de Código com Git e GitHub

![GitHub repo size](https://img.shields.io/github/repo-size/fzanneti/wex-e2e-csharp)
![GitHub forks](https://img.shields.io/github/forks/fzanneti/wex-e2e-csharp?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/fzanneti/wex-e2e-csharp?style=social)
![Linguagem](https://img.shields.io/badge/Linguagem-CSharp-blue)
![Bootcamp](https://img.shields.io/badge/WEX-End--to--End%20Engineering-blueviolet?logo=vercel&logoColor=white)
![Plataforma](https://img.shields.io/badge/Powered%20by-DIO.io-red?logo=data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjZmZmIiB2aWV3Qm94PSIwIDAgMzIgMzIiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PHBhdGggZD0iTTYuNzEgMy4yNWMtMi44OCAxLjQxLTUuMDcgNC4yMy01LjA3IDcuNzYgMCAzLjU4IDIuMjggNi43IDUuMzMgOC4xNSAxLjgzLS42MiAyLjQtMi4yNiAyLjQtMy44MSAwLS4yMy0uMDItLjQ1LS4wNS0uNjZBLjQ0LjQ0IDAgMDExMC4xIDExYy4yNC0uNzUuMTEtMS41My0uMy0yLjIyQzguOTIgNy45NiA3LjMzIDcuNSA1Ljc0IDcuNjZhNS41NSA1LjU1IDAgM)
![Autor](https://img.shields.io/badge/Autor-fzanneti-blue?style=flat-square&logo=github)

---

### Visão Geral

O versionamento com **Git** e **GitHub** é essencial para desenvolvedores, especialmente em projetos .NET. Essas ferramentas permitem gerenciar alterações, testar ideias e colaborar em equipe, garantindo organização e qualidade. Neste módulo, você dominará o Git para controle local e o GitHub para colaboração remota, alinhado ao Bootcamp WEX.

---

### Objetivos do Módulo

- Entender o conceito de **versionamento de código**
- Aprender os **fundamentos do Git**
- Compreender como o **GitHub** complementa o Git
- Praticar os comandos básicos com segurança

---

### Ferramentas Utilizadas

| Ferramenta | Função Principal           | Link para Download                       |
|---------------|-------------------------------|--------------------------------------------|
| **Git**      | Controle de versão local      | 🔗[git-scm.com](https://git-scm.com/)        |
| **GitHub**   | Repositório remoto e colaboração | 🔗[github.com](https://github.com/)       |
| **VS Code**  | Editor de código              | 🔗[code.visualstudio.com](https://code.visualstudio.com/) |

> **Dica:** Instale o Git antes de tudo. Ele é a base de toda a trilha.

---

### O que é Versionamento de Código?

**Definição**: Processo de registrar, rastrear e gerenciar alterações no código-fonte.
*Por que usar?*

- Voltar a versões anteriores.
- Colaborar em equipe.
- Testar ideias sem riscos.
- Manter histórico detalhado.

---

**Analogia**: Como salvar um documento com "v1", "v2", mas com mais controle e eficiência.

---

<img src="https://github.com/fzanneti/DIO-wex-e2e-csharp/blob/main/Assets/images/git.png" alt="Git" width="300px">

### O que é Git?

**Definição**: Sistema de controle de versão distribuído, criado por Linus Torvalds em 2005. Salva "fotografias" do código (commits) para rastreamento.

---

### Conceitos Principais

| Termo | O que significa |
| --- | --- |
| Repositório | Pasta monitorada pelo Git |
| Commit | Registro de uma alteração |
| Branch | Ramificação para testar ideias |
| Merge | Unir mudanças de uma branch |
| Clone | Cópia local de um repositório remoto |
| Stage | Área temporária para preparar commits |
| Pull | Baixar e integrar mudanças remotas |
| Pull Request | Solicitação para revisar e mesclar mudanças |

---

### Comandos Básicos do Git

```bash

# Inicialização
git init                  # Inicia um repositório Git
git clone <url>           # Clona um repositório Gir

# Controle de alterações
git status                # Mostra o estado atual dos arquivos
git add <arquivo>         # Adiciona um arquivo específico
git add .                 # Adiciona todos os arquivos ao stage
git commit -m "mensagem"  # Cria um commit com mensagem
git log                   # Exibe o histórico de commits de um repositório Git

# Colaboração
git push origin <branch>  # Envia suas alterações locais (commits) para o repositório remoto
git pull origin <branch>  # Baixa as alterações do repositório remoto e as mescla no seu repositório local
git branch <nome>         # Cria uma nova branch com o nome especificado
git checkout <nome>       # Muda para a branch ou commit especificado, atualizando seu diretório de trabalho
git merge <branch>        # Integra as alterações de uma branch para a branch atual

```
---

<img src="https://github.com/fzanneti/DIO-wex-e2e-csharp/blob/main/Assets/images/github.png" alt="GitHub" width="300px">

### O que é GitHub?

**Definição**: GitHub é uma **plataforma online** que hospeda repositórios Git, permitindo:

* Colaboração em equipe
* Controle de versão remoto
* Revisões de código
* Deploy de projetos

---

### Git vs GitHub

| Característica | Git             | GitHub                |
| ----------------- | ------------------ | ------------------------ |
| Tipo              | CLI (local)        | Plataforma web (remota)  |
| Função principal  | Controle de versão | Hospedagem e colaboração |
| Requer internet?  | ❌ Não (até o push) | ✅ Sim                    |

---

### Fluxo de Trabalho com Branches

1. Crie uma branch:

```bash

git branch feature/nova-funcionalidade
git checkout feature/nova-funcionalidade

```

2. Faça alterações e commit:

```bash

git add .
git commit -m "feat: add nova funcionalidade"

```

3. Envie ao GitHub:

```bash

git push origin feature/nova-funcionalidade

```
4. Crie um Pull Request no GitHub.

5. Mesclar na `main`:

```bash

git checkout main
git merge feature/nova-funcionalidade
git push origin main
   
```

---

### Resumo:

> Git é o motor.
> GitHub é a garagem onde você armazena e compartilha seu projeto.

---

### Exemplo Prático de Fluxo com Git e GitHub

1. Crie um projeto .NET:

```bash

dotnet new console -n MeuProjeto
cd MeuProjeto

```
2. Inicialize o Git:

```bash

git init
git add .
git commit -m "feat: create initial .NET console project"
   
```

3. Crie um repositório no GitHub e conecte:

```bash

git remote add origin https://github.com/fzanneti/MeuProjeto.git
git push -u origin main

```

**Código** (`Program.cs`):

```csharp

using System;

namespace MeuProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao meu projeto .NET no GitHub!");
        }
    }
}

```
---

### Solução de Problemas

- **"fatal: not a git repository"**: Execute `git init`.
- **"failed to push some refs"**: Use `git pull --rebase` antes de `git push`.
- **"permission denied (publickey)"**: Gere uma chave SSH (`ssh-keygen`) e adicione ao GitHub.

---

### Documentação Oficial

🔗[Git - Documentação Oficial](https://git-scm.com/doc)    
🔗[GitHub Docs (pt-BR)](https://docs.github.com/pt)     
🔗[Guia interativo do Git (em português)](https://learngitbranching.js.org/?locale=pt_BR)

---

### Materiais Complementares

🔗[Curso rápido de Git e GitHub - DIO](https://www.youtube.com/watch?v=UBAX-13g8OM)     
🔗[Livro gratuito “Pro Git” (pt-BR)](https://git-scm.com/book/pt-br/v2)     
🔗[GitHub Learning Lab (exercícios práticos)](https://github-com.translate.goog/apps/github-learning-lab?_x_tr_sl=en&_x_tr_tl=pt&_x_tr_hl=pt&_x_tr_pto=tc)

---

### Projeto Interligado da DIO

[![Repo Card](https://github-readme-stats.vercel.app/api/pin/?username=digitalinnovationone&repo=dio-lab-open-source&bg_color=261d31&border_color=7a49c6&show_icons=true&icon_color=7a49c6&title_color=37ccab&text_color=FFF)](https://github.com/digitalinnovationone/dio-lab-open-source)

---

### Conclusão

Agora você:

* Compreende o que é **versionamento de código**
* Entende a diferença entre **Git e GitHub**
* Conhece os **comandos iniciais** para começar a trabalhar com repositórios

Nas próximas aulas, você vai **explorar comandos mais avançados** e simulações de cenários reais de colaboração.

---

### Certificado

<img src="https://github.com/fzanneti/DIO-wex-e2e-csharp/blob/main/Assets/images/certificados/3-versionamento-de-codigo-com-Git-e-GitHub.jpg" alt="Certificado" width="600px">

---

##### ✍️ Seção criada por: *Fabio Zanneti* - 🎯 Bootcamp: **WEX - End to End Engineering**
[![GitHub](https://img.shields.io/badge/GitHub-fzanneti-181717?style=flat&logo=github)](https://github.com/fzanneti)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-fzanneti-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/fzanneti)
