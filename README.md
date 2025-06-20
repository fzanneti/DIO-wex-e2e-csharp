# 🧠 WEX End-to-End Engineering | Guia de Estudos em .NET com C#

**Repositório educacional criado para apoiar estudantes e novos profissionais que estão aprendendo sobre a plataforma .NET com foco em C#, com base no curso _WEX - End to End Engineering_ da [Digital Innovation One (DIO)](https://www.dio.me).**

---

#### 📚 Conteúdo

Este repositório contém resumos, exemplos e materiais complementares organizados por módulos de estudo e prática com C#:

#### ✅ Fundamentos do .NET e da linguagem C#

- 🕰️ Linha do tempo da plataforma .NET
- 🔍 Diferença entre .NET Framework e .NET moderno (.NET 5, 6, 7, etc.)
- ⚙️ Compiladores, CLR, transpiladores e arquitetura .NET
- 💻 Exemplos de código comentados
- 📊 Tabelas e diagramas explicativos
- 🔗 Links para materiais complementares e artigos

---

#### 🧪 Sintaxe e lógica de programação

- Variáveis, tipos primitivos e estruturas básicas
- Operadores aritméticos, relacionais e lógicos
- Condicionais (`if`, `else`, `switch`)
- Laços de repetição (`for`, `while`, `do while`)
- Métodos e parâmetros
- Funções com retorno e sem retorno
- Escopo de variáveis

---

#### 🏗️ Programação Orientada a Objetos

- Conceitos de classe, objeto, herança e encapsulamento
- Métodos e propriedades
- Construtores
- Modificadores de acesso
- Boas práticas com POO

---

### 🧬 Herança e Polimorfismo com C#

Dois pilares essenciais da Programação Orientada a Objetos (POO), **Herança** e **Polimorfismo**, são amplamente utilizados no desenvolvimento com C# e .NET.

#### 👣 Introdução à Herança

A **herança** permite que uma classe herde atributos e métodos de outra, promovendo **reutilização de código** e **organização hierárquica**.

- A classe base é a "mãe".
- A classe derivada (ou filha) herda seus membros e pode ter funcionalidades próprias.

#### Exemplo prático:

```csharp

public class Pessoa
{
    public string Nome { get; set; }

    public void Apresentar()
    {
        Console.WriteLine($"Olá, eu sou {Nome}");
    }
}

public class Aluno : Pessoa
{
    public string Curso { get; set; }

    public void Estudar()
    {
        Console.WriteLine($"{Nome} está estudando {Curso}");
    }
}

```

---

### 🔄 Polimorfismo em C\#

**Polimorfismo** significa "muitas formas". Ele permite que classes derivadas se comportem de maneira diferente, mesmo quando referenciadas por um tipo base.

#### ✅ Polimorfismo em tempo de execução (via override):

```csharp

public class Animal
{
    public virtual void EmitirSom()
    {
        Console.WriteLine("Som genérico de animal");
    }
}

public class Cachorro : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("Au au!");
    }
}

```

#### Uso:

```csharp

Animal meuAnimal = new Cachorro();
meuAnimal.EmitirSom(); // Saída: Au au!

```

#### 📌 Considerações

* Herança deve ser usada quando há uma clara relação "é um(a)".
* Polimorfismo facilita **substituição de implementações**, principalmente em listas genéricas e métodos polimórficos.
* Evite heranças profundas. Prefira composição quando possível.

---

#### 📌 Manipulando valores com C#

- 🔠 Concatenando strings e interpolação
- 🔢 Ajustando numeração e casas decimais
- 💰 Formatando valores monetários
- 🌍 Alterando localização e cultura do sistema
- 🧮 Representando porcentagens
- 📅 Trabalhando com DateTime
  - Formatando datas e horas
  - Validando com `TryParse`
  - Formatação personalizada com culturas diferentes

---

#### ❗ Tratamento de Exceções

- Introdução a exceções
- Bloco `try`, `catch` e `finally`
- Exceções específicas e genéricas
- Disparando erros com `throw`
- Lendo arquivos com tratamento de erro
- Boas práticas com validações

---

#### 📦 Coleções em C#

- **Queue (Fila)**: primeiro a entrar, primeiro a sair (FIFO)
- **Stack (Pilha)**: último a entrar, primeiro a sair (LIFO)
- **Dictionary**: estrutura chave/valor
- Adicionando, removendo e atualizando elementos
- Acessando elementos com segurança
- Casos de uso práticos

---

#### 🧾 Versionamento de Código

- Git e GitHub para controle de versões
- Criação e navegação por branches
- Clonagem e commit de projetos
- Pull requests e colaboração em equipe

---

#### 🛠️ Projetos Práticos e Desafios Técnicos

- Simulador de estacionamento com C#
- Manipulação de arquivos com tratamento de exceções
- Console Apps com entrada e saída de dados
- Aplicações com collections (pilha, fila, dicionário)

---

#### ✨ Objetivo

Este guia foi criado para facilitar o aprendizado técnico com explicações simples e diretas, oferecendo:

✔️ Estudo com foco em fundamentos e prática real  
✔️ Consulta rápida para revisão de conteúdos  
✔️ Base sólida para evoluir com confiança no .NET e C#  
✔️ Preparação para resolver desafios técnicos com clareza  

---

#### 🚀 Para quem é este projeto?

Este material é ideal para:

🧑‍💻 Iniciantes em .NET e C#  
🎓 Alunos do curso WEX - End to End Engineering  
🔁 Profissionais em transição de carreira  
📚 Estudantes que desejam reforçar fundamentos e prática  
🧠 Autodidatas em busca de material organizado e didático   

---

#### 👨‍💻 Criado por

**Fabio Zanneti**  
Profissional com mais de 10 anos de experiência nas áreas de Compras e Fiscal. Atualmente em transição de carreira para a tecnologia, focado em **.NET, C#, Inteligência Artificial e projetos criativos**.

🔗 GitHub: [fzanneti](https://github.com/fzanneti)  
🎯 LinkedIn: [fzanneti](https://www.linkedin.com/in/fzanneti)

---

#### 🔗 Links úteis

- [Documentação Oficial do .NET (Microsoft)](https://learn.microsoft.com/dotnet)
- [Canal da DIO no YouTube](https://www.youtube.com/@dio)
- [Artigo: Evolução do .NET](https://learn.microsoft.com/dotnet/fundamentals/history)

---

📁 **Repositório:**  
Se este conteúdo foi útil, ⭐ marque este repositório e compartilhe!

##### 📌 Este repositório faz parte da jornada de aprendizado e transição profissional do autor. É mantido com muito estudo, dedicação e amor pela tecnologia.  

##### ✍️ **Criado por:** *Fabio Zanneti* 🎯 Projeto: **WEX - End to End Engineering**