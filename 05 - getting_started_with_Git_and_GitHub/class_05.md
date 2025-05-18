# Versionamento de Código com Git e GitHub

## Introdução
Este módulo mostra como começar a trabalhar com Git e GitHub na prática. Aqui você aprenderá a criar, clonar, modificar e gerenciar repositórios locais e remotos. Também verá como usar branches para isolar funcionalidades, resolver conflitos e colaborar com eficiência.

---

## Criando e Clonando Repositórios

### Conceitos
- Um **repositório** é onde o código-fonte é armazenado.
- **Clonar** é copiar um repositório remoto para seu computador.
- **Criar** é iniciar um repositório do zero.

### Comandos principais
```bash
# Criar um novo repositório local
git init

# Clonar um repositório remoto
git clone https://github.com/usuario/repositorio.git
```

### Dica
Use `git status` com frequência para saber o que está acontecendo no seu repositório.

---

## Salvando Alterações no Repositório Local

### Conceitos
O Git funciona como um sistema de checkpoints:
1. Você modifica arquivos.
2. Usa `git add` para preparar.
3. Usa `git commit` para salvar.

### Comandos
```bash
git add arquivo.txt     # Adiciona um arquivo
git commit -m "mensagem do commit"  # Salva alterações com descrição
```

---

## Desfazendo Alterações

### Situações comuns e como resolver

| Situação                             | Comando                                       |
|-------------------------------------|-----------------------------------------------|
| Desfazer arquivo modificado         | `git restore nome_arquivo`                    |
| Desfazer arquivos adicionados com add | `git reset nome_arquivo`                   |
| Desfazer último commit (não enviado) | `git reset --soft HEAD~1`                    |

> ⚠️ Evite usar `reset --hard` sem entender, ele apaga dados.

---

## Enviando e Baixando do Repositório Remoto

### Comandos Essenciais
```bash
git push origin main    # Envia commits locais
git pull origin main    # Atualiza com o servidor remoto
```

> `origin` é o nome padrão do repositório remoto. `main` é o nome do branch principal.

---

## Trabalhando com Branches

### Conceitos
Branches permitem trabalhar em funcionalidades separadas sem mexer no código principal.

### Comandos Básicos
```bash
git branch nome-branch         # Cria uma nova branch
git checkout nome-branch       # Troca para a branch
git merge nome-branch          # Mescla branch atual com outra
git branch -d nome-branch      # Deleta branch
```

---

## Resolvendo Conflitos

### O que é um conflito?
Acontece quando duas pessoas alteram a mesma linha de um arquivo em branches diferentes.

### Como resolver?
1. O Git marca os conflitos no arquivo.
2. Edite o arquivo manualmente e remova os marcadores `<<<<<<<`, `=======`, `>>>>>>>`.
3. Salve e use:
```bash
git add arquivo.txt
git commit -m "resolve conflito"
```

---

## Comandos Úteis no Dia a Dia

| Comando                        | Função                                 |
|-------------------------------|----------------------------------------|
| `git log`                     | Mostra o histórico de commits          |
| `git status`                  | Mostra estado do repositório           |
| `git diff`                    | Mostra diferenças entre arquivos       |
| `git stash`                   | Salva mudanças temporariamente         |
| `git rebase`                  | Reorganiza histórico de commits        |

---

## Conclusão
Agora você tem as ferramentas básicas para trabalhar com versionamento de código em projetos reais. Continue praticando e utilize sempre o GitHub como vitrine e controle do seu trabalho.

### Recursos adicionais
- [Git - Livro oficial (em português)](https://git-scm.com/book/pt-br/v2)
- [Guia de Git da Digital Innovation One](https://www.youtube.com/watch?v=UBAX-13g8OM)
- [GitHub Docs](https://docs.github.com/pt)

---