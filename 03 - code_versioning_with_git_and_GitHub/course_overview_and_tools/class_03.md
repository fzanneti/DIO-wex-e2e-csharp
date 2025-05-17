# **Introdução ao Versionamento de Código com Git e GitHub**

### **Visão geral do curso e ferramentas**

Nesta trilha, você vai aprender a controlar versões do seu código utilizando Git e GitHub — ferramentas essenciais no mundo do desenvolvimento de software moderno.

Objetivos do módulo:
Compreender o que é versionamento de código.

Aprender os conceitos fundamentais do Git.
   
Entender como o GitHub complementa o Git.

Praticar comandos básicos com confiança.

Ferramentas utilizadas:
Ferramenta	Função Principal	Link para Download
Git	Controle de versão local	git-scm.com
GitHub	Repositório remoto e colaboração	github.com
VS Code	Editor de código	code.visualstudio.com

💡 Dica: Instale o Git antes de tudo. Ele é a base de toda a trilha.

🗂️ O que é Versionamento de Código?
Definição:
Versionamento de código é o processo de registrar, rastrear e gerenciar alterações feitas no código-fonte de um projeto ao longo do tempo.

Por que usar?
Voltar no tempo (rollback).

Trabalhar em equipe com segurança.

Testar novas ideias sem bagunçar o projeto principal.

Registrar o histórico de cada mudança.

Analogia simples:
Imagine um arquivo do Word com "Salvar como v1, v2, v3...". O Git faz isso automaticamente, só que de forma muito mais eficiente e organizada.

🔧 O que é Git?
Definição:
Git é um sistema de controle de versão distribuído, criado por Linus Torvalds (criador do Linux) em 2005. Ele permite salvar “fotografias” do seu código (chamadas commits) e voltar a versões anteriores a qualquer momento.

Conceitos principais:
Termo	O que significa
Repositório	Pasta monitorada pelo Git
Commit	Registro de uma alteração
Branch	Ramificação para testar ideias
Merge	Unir mudanças de uma branch para outra
Clone	Cópia local de um repositório remoto

Comandos básicos:
bash
Copiar
Editar
git init       # Inicia um repositório Git
git status     # Mostra o estado atual
git add .      # Adiciona arquivos para commit
git commit -m "mensagem"  # Salva a alteração
🌐 O que é GitHub?
Definição:
GitHub é uma plataforma online que armazena repositórios Git na nuvem, permitindo colaboração, versionamento remoto, revisão de código, e deploy de projetos.

Git vs GitHub
Característica	Git	GitHub
Tipo	Ferramenta local (CLI)	Plataforma web remota
Função principal	Controle de versão	Hospedagem e colaboração
Requer internet?	Não (até o push)	Sim

🎯 Importante: Git é o motor. GitHub é a garagem onde você guarda e compartilha seu projeto.

🧪 Exemplo prático de fluxo básico
bash
Copiar
Editar
# Criação e envio de projeto local para GitHub

git init                          # Cria repositório local
git add .                         # Adiciona todos os arquivos
git commit -m "Primeiro commit"   # Salva alterações
git remote add origin https://github.com/seuusuario/repositorio.git
git push -u origin master         # Envia para GitHub
📎 Documentação oficial do Git
📎 Documentação oficial do GitHub
📎 Guia interativo do Git (em português)

✅ Conclusão
Compreender o funcionamento básico do Git e do GitHub é essencial para qualquer desenvolvedor. Você agora conhece os fundamentos do versionamento de código, a diferença entre Git e GitHub, e os primeiros comandos para começar a praticar. Nas próximas aulas, exploraremos os comandos com mais profundidade e simulações de cenários reais.

📚 Materiais Complementares
🎥 Curso rápido de Git e GitHub - Dio

📘 Livro gratuito “Pro Git” (em português)

🌐 GitHub Learning Lab (exercícios práticos)