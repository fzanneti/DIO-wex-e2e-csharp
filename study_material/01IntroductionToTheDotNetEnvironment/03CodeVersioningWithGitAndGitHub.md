# 🔄 Introdução ao Versionamento de Código com Git e GitHub

### 🧭 Visão Geral

Nesta trilha, você vai aprender a controlar versões do seu código usando **Git** e **GitHub** — ferramentas essenciais para qualquer desenvolvedor moderno.

---

### 🎯 Objetivos do Módulo

- Entender o conceito de **versionamento de código**
- Aprender os **fundamentos do Git**
- Compreender como o **GitHub** complementa o Git
- Praticar os comandos básicos com segurança

---

### 🧰 Ferramentas Utilizadas

| 🧩 Ferramenta | 🛠️ Função Principal           | 🔗 Link para Download                       |
|---------------|-------------------------------|--------------------------------------------|
| **Git**      | Controle de versão local      | [git-scm.com](https://git-scm.com/)        |
| **GitHub**   | Repositório remoto e colaboração | [github.com](https://github.com/)       |
| **VS Code**  | Editor de código              | [code.visualstudio.com](https://code.visualstudio.com/) |

💡 **Dica:** Instale o Git antes de tudo. Ele é a base de toda a trilha.

---

## 📦 O que é Versionamento de Código?

### 🔍 Definição: 

Versionamento de código é o processo de registrar, rastrear e gerenciar alterações feitas no código-fonte de um projeto ao longo do tempo.

---

### 🧠 Por que usar?

- 🔙 Voltar no tempo (rollback)
- 👥 Trabalhar em equipe com segurança
- 💡 Testar novas ideias sem afetar o projeto principal
- 📜 Ter histórico detalhado de cada mudança


---

### 📝 Analogia Simples

> Imagine salvar um documento Word com "v1", "v2", "v3"... O Git faz isso automaticamente, com muito mais controle e eficiência.

---

## ⚙️ O que é Git?

### 🧠 Definição:

Git é um **sistema de controle de versão distribuído**, criado por **Linus Torvalds** (o criador do Linux) em 2005.
Permite salvar "fotografias" do seu código (os **commits**) e voltar para versões anteriores a qualquer momento.

---

### 📚 Conceitos principais

| 🧩 Termo      | 🔍 O que significa              |
|--------------|-------------------------------|
| Repositório  | Pasta monitorada pelo Git     |
| Commit       | Registro de uma alteração     |
| Branch       | Ramificação para testar ideias|
| Merge        | Unir mudanças de uma branch   |
| Clone        | Cópia local de um repositório remoto |


---

### 🔧 Comandos Básicos do Git

```bash

git init                  # Inicia um repositório Git
git status                # Mostra o estado atual dos arquivos
git add .                 # Adiciona todos os arquivos ao stage
git commit -m "mensagem"  # Cria um commit com mensagem

```
---

## ☁️ O que é GitHub?

### 🧠 Definição:

GitHub é uma **plataforma online** que hospeda repositórios Git, permitindo:

* 🧑‍🤝‍🧑 Colaboração em equipe
* 🔁 Controle de versão remoto
* ✅ Revisões de código
* 🚀 Deploy de projetos

---

### ⚖️ Git vs GitHub

| ⚙️ Característica | 🧠 Git             | ☁️ GitHub                |
| ----------------- | ------------------ | ------------------------ |
| Tipo              | CLI (local)        | Plataforma web (remota)  |
| Função principal  | Controle de versão | Hospedagem e colaboração |
| Requer internet?  | ❌ Não (até o push) | ✅ Sim                    |

🎯 **Resumo:**

> Git é o motor.
> GitHub é a garagem onde você armazena e compartilha seu projeto.

---

### 🚀 Exemplo Prático de Fluxo com Git e GitHub

```bash

# Criação e envio do projeto local para GitHub

git init                          # Cria repositório local
git add .                         # Adiciona todos os arquivos
git commit -m "Primeiro commit"   # Salva alterações localmente
git remote add origin https://github.com/seu_usuario/repositorio.git
git push -u origin master         # Envia para o GitHub

```
### 📚 Documentação Oficial

* 📘 [Git - Documentação Oficial](https://git-scm.com/doc)
* 📘 [GitHub Docs (pt-BR)](https://docs.github.com/pt)
* 🧪 [Guia interativo do Git (em português)](https://learngitbranching.js.org/?locale=pt_BR)

---

#### ✅ Conclusão

Agora você:

* Compreende o que é **versionamento de código**
* Entende a diferença entre **Git e GitHub**
* Conhece os **comandos iniciais** para começar a trabalhar com repositórios

🔧 Nas próximas aulas, você vai **explorar comandos mais avançados** e simulações de cenários reais de colaboração.

---

### 📚 Materiais Complementares

* 🎓 [Curso rápido de Git e GitHub - DIO](https://www.youtube.com/watch?v=UBAX-13g8OM)
* 📘 [Livro gratuito “Pro Git” (pt-BR)](https://git-scm.com/book/pt-br/v2)
* 🔁 [GitHub Learning Lab (exercícios práticos)](https://github-com.translate.goog/apps/github-learning-lab?_x_tr_sl=en&_x_tr_tl=pt&_x_tr_hl=pt&_x_tr_pto=tc)


---

##### ✍️ **Seção criada por:** *Fabio Zanneti*
##### 🎯 Projeto: **WEX - End to End Engineering**