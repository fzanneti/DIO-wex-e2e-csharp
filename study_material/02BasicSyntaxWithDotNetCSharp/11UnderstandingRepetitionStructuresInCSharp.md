# 🔁 Conhecendo as Estruturas de Repetição em C#

Este material é parte da trilha de estudos em C#, abordando as principais **estruturas de repetição (loops)** da linguagem. Loops são fundamentais para executar blocos de código de forma repetitiva até que uma condição seja atendida — algo essencial em qualquer aplicação real.

---

### 📌 Índice

- Introdução às Estruturas de Repetição  
- Estrutura `for`  
- Estrutura `while`  
- Estrutura `do while`  
- Interrupção de fluxo com `break` e `continue`  
- Criando e refatorando menus interativos  

---

### 🧠 Introdução - Estrutura de Repetição

Uma **estrutura de repetição** permite executar um trecho de código diversas vezes, controlando esse processo com **condições lógicas**.

Principais estruturas em C#:
- `for`
- `while`
- `do while`

Essas estruturas são muito usadas em laços, contagens, buscas, validações, leitura de listas, e muito mais.

---

### 🔂 Introdução ao `for`

O `for` é ideal quando você sabe **exatamente o número de vezes que o loop deve rodar**.

### Exemplo:

```csharp

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Valor de i: {i}");
}

```

### Estrutura:

```csharp

for (inicialização; condição; incremento)

```

* `inicialização`: define o valor inicial do contador.
* `condição`: enquanto for verdadeira, o loop continua.
* `incremento`: altera o valor do contador a cada iteração.

---

### 🐞 Debugando o `for`

Durante o debug, você pode observar:

* O valor inicial da variável.
* A condição sendo testada.
* O incremento ao final de cada laço.

Ideal para ver como o fluxo se comporta passo a passo.

---

### 🔁 Introdução ao `while`

O `while` executa um bloco de código **enquanto a condição for verdadeira**. Ideal para situações onde **não sabemos quantas vezes a repetição será feita**.

### Exemplo:

```csharp

int contador = 0;

while (contador < 5)
{
    Console.WriteLine($"Contador: {contador}");
    contador++;
}

```

---

### 🐞 Debugando o `while`

No modo de depuração (debug), você consegue observar:

* Se a condição é avaliada corretamente.
* Como a variável é alterada dentro do laço.
* Onde o loop é interrompido.

---

### 🚫 Interrompendo o Fluxo de Execução

Duas instruções muito úteis:

* `break`: encerra o loop imediatamente.
* `continue`: pula para a próxima iteração.

### Exemplo com `break`:

```csharp

for (int i = 0; i < 10; i++)
{
    if (i == 5) break;
    Console.WriteLine(i);
}

```

### Exemplo com `continue`:

```csharp

for (int i = 0; i < 10; i++)
{
    if (i % 2 == 0) continue;
    Console.WriteLine(i);
}

```

---

### 🔄 Introdução ao `do while`

A estrutura `do while` é similar ao `while`, mas garante que o bloco será **executado pelo menos uma vez**, pois a condição é verificada **depois da execução**.

### Exemplo:

```csharp

int i = 0;
do
{
    Console.WriteLine($"i: {i}");
    i++;
} while (i < 5);

```

---

### 🐞 Debugando o `do while`

Ao debugar, note que:

* O bloco será executado ao menos uma vez, mesmo se a condição inicial for falsa.
* A condição só será checada após o código rodar.

---

### 🧮 Construindo um Menu Interativo

Menus interativos utilizam loops para **repetir a exibição de opções até que o usuário deseje sair**.

### Exemplo:

```csharp

int opcao;
do
{
    Console.WriteLine("1 - Exibir data");
    Console.WriteLine("2 - Exibir hora");
    Console.WriteLine("0 - Sair");
    opcao = int.Parse(Console.ReadLine());

    switch(opcao)
    {
        case 1: Console.WriteLine(DateTime.Now.ToShortDateString()); break;
        case 2: Console.WriteLine(DateTime.Now.ToShortTimeString()); break;
        case 0: Console.WriteLine("Encerrando..."); break;
        default: Console.WriteLine("Opção inválida!"); break;
    }

} while(opcao != 0);

```

---

### ♻️ Refatorando o Menu

Com o tempo, esse menu pode ser **refatorado em métodos**, tornando o código mais limpo, modular e reutilizável.

### Dica:

```csharp

static void ExibirData() => Console.WriteLine(DateTime.Now.ToShortDateString());
static void ExibirHora() => Console.WriteLine(DateTime.Now.ToShortTimeString());

```

---

## 🔁 Links Complementares de Estudo – Estruturas de Repetição em C#

As estruturas de repetição permitem executar blocos de código várias vezes, seja de forma controlada ou baseada em condições. Em C#, os principais laços são: `for`, `while`, `do-while` e `foreach`.

---

### 🎓 Vídeos e Aulas Gratuitas

- [Estruturas de Repetição em C# – Curso Completo (CFBCursos)](https://www.youtube.com/watch?v=5vHThwFGeYs)
- [Laços em C# – Balta.io](https://www.youtube.com/watch?v=PE5rxK7Yp5g)
- [foreach no C# – DevAprender](https://www.youtube.com/watch?v=8mrYu4CZ41U)

---

### 📚 Documentação Oficial Microsoft

- [`for` Loop – Microsoft Docs](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/for)
- [`while` Loop – Microsoft Docs](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/while)
- [`do-while` Loop – Microsoft Docs](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/do)
- [`foreach` – Microsoft Docs](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/foreach-in)

---

### 🧠 Artigos e Explicações Técnicas

- [Estruturas de Repetição em C# – DevMedia](https://www.devmedia.com.br/estruturas-de-repeticao-em-c/27995)
- [Diferença entre `for`, `foreach` e `while` – Alura](https://www.alura.com.br/artigos/csharp-for-foreach-while)
- [Boas práticas ao usar laços – Medium](https://medium.com/@luizeduardohs/boas-pr%C3%A1ticas-em-la%C3%A7os-de-repeti%C3%A7%C3%A3o-no-c-e0a6bc8fdc7)

---

### 💻 Ferramentas para Testes

- [DotNetFiddle](https://dotnetfiddle.net/)
- [LINQPad](https://www.linqpad.net/)

---

#### 📘 Conclusão

Dominar estruturas de repetição é essencial para programar de forma eficiente e escalável. Entender como cada uma funciona e quando utilizar é um passo importante na sua evolução como desenvolvedor C#.

---

##### ✍️ **Seção criada por:** *Fabio Zanneti* 🎯 Projeto: **WEX - End to End Engineering**
