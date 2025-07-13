# ⚙️ Operações e Atribuições em C#

Entenda como funcionam os operadores de atribuição, conversão de tipos e boas práticas para lidar com diferentes tipos de dados em C#.

![GitHub repo size](https://img.shields.io/github/repo-size/fzanneti/wex-e2e-csharp)
![GitHub forks](https://img.shields.io/github/forks/fzanneti/wex-e2e-csharp?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/fzanneti/wex-e2e-csharp?style=social)
![Linguagem](https://img.shields.io/badge/Linguagem-CSharp-blue)
![Bootcamp](https://img.shields.io/badge/WEX-End--to--End%20Engineering-blueviolet?logo=vercel&logoColor=white)
![Plataforma](https://img.shields.io/badge/Powered%20by-DIO.io-red?logo=data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjZmZmIiB2aWV3Qm94PSIwIDAgMzIgMzIiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PHBhdGggZD0iTTYuNzEgMy4yNWMtMi44OCAxLjQxLTUuMDcgNC4yMy01LjA3IDcuNzYgMCAzLjU4IDIuMjggNi43IDUuMzMgOC4xNSAxLjgzLS42MiAyLjQtMi4yNiAyLjQtMy44MSAwLS4yMy0uMDItLjQ1LS4wNS0uNjZBLjQ0LjQ0IDAgMDExMC4xIDExYy4yNC0uNzUuMTEtMS41My0uMy0yLjIyQzguOTIgNy45NiA3LjMzIDcuNSA1Ljc0IDcuNjZhNS41NSA1LjU1IDAgM)
![Autor](https://img.shields.io/badge/Autor-fzanneti-blue?style=flat-square&logo=github)

---

### ✅ Introdução - Operador de Atribuição

No Bootcamp WEX, você está construindo aplicações com C#, .NET, Git e GitHub. **Operadores** são ferramentas essenciais para manipular dados, tomar decisões e implementar lógicas complexas. Este módulo explora operadores de atribuição, condicionais, lógicos e conversões de tipos, preparando você para projetos robustos.

```csharp

int idade = 30;

```

Isso significa: “A variável `idade` recebe o valor `30`”. Atenção: isso não é uma **igualdade**, mas sim uma **atribuição de valor**.

---

### ➕ Combinando Operadores

É possível combinar operadores aritméticos com o de atribuição. Esses são chamados de **operadores de atribuição compostos**:

| Operador | Descrição                  | Exemplo                 |
| -------- | -------------------------- | ----------------------- |
| `+=`     | Soma e atribuição          | `x += 10;` (x = x + 10) |
| `-=`     | Subtração e atribuição     | `x -= 5;`               |
| `*=`     | Multiplicação e atribuição | `x *= 3;`               |
| `/=`     | Divisão e atribuição       | `x /= 2;`               |
| `%=`     | Módulo e atribuição        | `x %= 2;`               |
| `&=`     | AND bit a bit e atribuição | `x &= 2;`               |

---

### 🔄 Convertendo Tipos de Variáveis em C#

Em C#, é comum precisar **converter valores entre tipos diferentes**, como:

* de `string` para `int` (ao ler dados do teclado);
* de `double` para `int` (ao calcular e querer um número inteiro);
* de `int` para `float`, e por aí vai.

Existem **três formas principais** de fazer essa conversão:

---

### ⚠️ Cast Implícito e Explícito

* **Cast Implícito:** Quando não há perda de informação:

```csharp

int x = 10;
double y = x; // cast implícito

```

* **Cast Explícito:** Quando pode haver perda de dados. Exige sintaxe com `(tipo)`:

```csharp

double a = 9.8;
int b = (int)a; // b = 9 (trunca a parte decimal)

```

---

### 🔹 1. Conversão Implícita

A conversão **implícita** ocorre automaticamente **quando não há risco de perda de dados**. Isso geralmente acontece de um tipo **menor** para um tipo **maior**.

```csharp

int numero = 42;
double valor = numero;  // Conversão implícita (int para double)

Console.WriteLine(valor);  // Saída: 42.0

```

✅ **Seguro e direto.**
❌ Não funciona se houver risco de perda de precisão.

---

### 🔹 2. Conversão Explícita (Cast)

Já a conversão **explícita** (também chamada de *casting*) **precisa ser indicada pelo programador**. É usada quando **pode haver perda de dados**, como de `double` para `int`.

```csharp

double valor = 10.75;
int inteiro = (int)valor;  // Cast explícito: perde a parte decimal

Console.WriteLine(inteiro);  // Saída: 10

```

✅ Controlada e direta.
❌ Pode gerar truncamento de valores.

---

### 🔹 3. Métodos de Conversão (`Convert`, `Parse`, `TryParse`)

Esses métodos são usados principalmente para converter **strings em tipos numéricos** ou de datas.

---

### ✅ `Convert`

Converte com validação de tipo. É seguro contra `null`, mas lança exceções se o conteúdo da string for inválido.

```csharp

string texto = "123";
int numero = Convert.ToInt32(texto);

Console.WriteLine(numero);  // Saída: 123

```

* Aceita `null` (retorna 0).
* Lança erro se for texto inválido: `Convert.ToInt32("abc")` → erro!

---

### ✅ `Parse`

Converte a string **se o conteúdo for válido**. Mais direto, porém **não aceita `null` e lança exceção se inválido.**

```csharp

string texto = "456";
int numero = int.Parse(texto);

Console.WriteLine(numero);  // Saída: 456

```

* Mais rápido que `Convert`.
* Mais perigoso: não aceita erro ou valor nulo.

---

### ✅ `TryParse`

Forma **segura** de tentar converter sem lançar exceções. Ideal para validar entrada do usuário.

```csharp

string texto = "abc";
int numero;

bool sucesso = int.TryParse(texto, out numero);

if (sucesso)
    Console.WriteLine(numero);
else
    Console.WriteLine("Conversão falhou");

```

* **Não quebra o programa.**
* Retorna `true` se der certo, `false` se não.
* `numero` recebe 0 se falhar.

---

### 📌 Tabela Comparativa

| Método   | Aceita null | Lança exceção | Recomendado para            |
| -------- | ----------- | ------------- | --------------------------- |
| Cast     | Não         | Não           | Tipos numéricos compatíveis |
| Convert  | Sim         | Sim           | Entrada de fontes diversas  |
| Parse    | Não         | Sim           | Strings bem formatadas      |
| TryParse | Sim         | Não           | Entrada do usuário          |

---

#### 🎯 Conclusão

Saber **quando e como converter tipos de variáveis** evita erros comuns e deixa seu código mais robusto. Use:

* `cast` para tipos numéricos simples;
* `Convert` quando for lidar com diferentes origens;
* `Parse` quando tiver certeza do valor;
* `TryParse` para **qualquer entrada insegura**, como usuário digitando no console.

---

### ⚖️ Diferença entre `Convert` e `Parse`

| Característica      | `Convert`                    | `Parse`                               |
| ------------------- | ---------------------------- | ------------------------------------- |
| Aceita valor `null` | Sim (retorna valor padrão)   | Não (gera exceção)                    |
| Suporta mais tipos  | Sim (ex: `bool`, `DateTime`) | Não (mais restrito a string numérica) |
| Exemplo             | `Convert.ToInt32("10")`      | `int.Parse("10")`                     |

Use `Convert` quando não tiver certeza se o valor pode ser `null`. Use `Parse` quando souber que a string é válida.

---

### 🧾 Conversão para String

Qualquer tipo pode ser convertido para `string` usando o método `.ToString()`:

```csharp

int idade = 30;
string texto = idade.ToString(); // "30"

```

É muito útil para exibir valores em telas, logs ou mensagens.

---

### ⏱️ Ordem dos Operadores

A ordem das operações em C# segue as mesmas regras da matemática:

1. Parênteses `()`
2. Multiplicação `*`, Divisão `/`, Módulo `%`
3. Soma `+` e Subtração `-`
4. Atribuição `=`

Exemplo:

```csharp

int resultado = 10 + 2 * 5; // resultado = 20

```

Se quiser somar antes, use parênteses:

```csharp

int resultado = (10 + 2) * 5; // resultado = 60

```

---

### 🛡️ Convertendo de Maneira Segura

Use `TryParse` para evitar erros quando uma conversão pode falhar:

```csharp

string entrada = "abc";
int numero;

bool sucesso = int.TryParse(entrada, out numero);

if (sucesso)
    Console.WriteLine($"Valor convertido: {numero}");
else
    Console.WriteLine("Conversão falhou.");
    
```

Esse padrão é muito usado em validações de entrada.

---

#### ✅ Conclusão

Compreender operações, atribuições e conversões é fundamental para escrever códigos eficientes e seguros. Saber quando e como converter variáveis evita muitos erros comuns, especialmente ao lidar com entrada de dados do usuário, APIs e banco de dados.

**Recomendado:**

* [Documentação oficial sobre conversões](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/)
* [Operadores em C#](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/)

---

### ⚙️ Operadores Condicionais em C#

Neste material, você aprenderá a utilizar operadores condicionais em C# para controlar o fluxo do seu programa com base em decisões. Também exploraremos estruturas como `if`, `else`, `switch` e práticas para entender e debugar seu código.

---

### ✅ Introdução - Operadores Condicionais

Operadores condicionais permitem que o código **tome decisões** com base em uma condição. São fundamentais em qualquer linguagem de programação.

Em C#, usamos:

| Operador | Nome                   | Exemplo        |
|----------|------------------------|----------------|
| `==`     | Igual a                | `a == b`       |
| `!=`     | Diferente de           | `a != b`       |
| `>`      | Maior que              | `a > b`        |
| `<`      | Menor que              | `a < b`        |
| `>=`     | Maior ou igual         | `a >= b`       |
| `<=`     | Menor ou igual         | `a <= b`       |
| `&&`     | E (and) lógico         | `a > 5 && b < 10` |
| `||`     | OU (or) lógico         | `a > 5 || b < 10` |
| `!`      | Negação (not)          | `!verdadeiro`  |

Esses operadores são usados dentro de estruturas de controle como `if`, `else` e `switch`.

---

### 🧪 Operador Condicional na Prática

Exemplo simples com `if`:

```csharp

int idade = 18;

if (idade >= 18)
{
    Console.WriteLine("Maior de idade");
}
else
{
    Console.WriteLine("Menor de idade");
}

```

Exemplo com operador lógico:

```csharp

bool temCarteira = true;
int idade = 19;

if (idade >= 18 && temCarteira)
{
    Console.WriteLine("Pode dirigir");
}

```

---

### 🔍 Debugando Operador Condicional

Debugar é **observar passo a passo o que o programa está fazendo**. No Visual Studio:

1. Coloque um *breakpoint* (F9) na linha do `if`.
2. Rode o programa em modo de depuração (F5).
3. Passe o mouse sobre as variáveis ou use a janela "Autos/Locals" para ver os valores.
4. Verifique qual condição foi satisfeita e qual bloco foi executado.

Isso ajuda a identificar por que uma lógica não está funcionando como o esperado.

---

### 🧱 If Aninhado

Um **if aninhado** é um `if` dentro de outro `if`, usado quando temos **decisões mais complexas**:

```csharp

int nota = 85;

if (nota >= 70)
{
    if (nota >= 90)
    {
        Console.WriteLine("Aprovado com excelência!");
    }
    else
    {
        Console.WriteLine("Aprovado!");
    }
}
else
{
    Console.WriteLine("Reprovado");
}

```

**Dica:** se houver muitos `ifs` aninhados, considere usar `else if` ou `switch`.

---

### 🎚️ Aprendendo o Switch Case

O `switch` é uma estrutura usada quando temos **várias opções de comparação para a mesma variável**. Exemplo:

```csharp

string dia = "quarta";

switch (dia)
{
    case "segunda":
        Console.WriteLine("Início da semana");
        break;
    case "quarta":
        Console.WriteLine("Meio da semana");
        break;
    case "sexta":
        Console.WriteLine("Fim da semana");
        break;
    default:
        Console.WriteLine("Dia inválido");
        break;
}

```

### Quando usar `switch`:

* Quando há **múltiplas comparações iguais** com uma única variável.
* Quando deseja **melhor organização** do que muitos `else if`.

---

#### ✅ Conclusão

Operadores condicionais são essenciais para implementar **lógica de decisão** nos programas. Aprender a usá-los corretamente e depurá-los com atenção te permite escrever códigos **mais inteligentes, dinâmicos e confiáveis**.

**Recomendado para aprofundar:**

* [Documentação oficial do if](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/statements/selection-statements)
* [Switch Case - Microsoft Docs](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/switch)

---

### ⚙️ Operadores Lógicos em C#

> Neste material, você aprenderá como usar operadores lógicos (`&&`, `||`, `!`) no C# para construir condições compostas e tornar a lógica dos seus programas mais poderosa e inteligente.

---

### ✅ Introdução - Operadores Lógicos

Operadores lógicos são usados para **combinar ou modificar expressões booleanas** (que retornam verdadeiro ou falso). Eles são essenciais para realizar **comparações múltiplas** dentro de uma mesma estrutura condicional (`if`, `while`, etc.).

| Operador | Nome           | Significado                      |
|----------|----------------|----------------------------------|
| `&&`     | AND lógico     | Verdadeiro se **ambos** forem verdadeiros |
| `||`     | OR lógico      | Verdadeiro se **um ou ambos** forem verdadeiros |
| `!`      | NOT lógico     | Inverte o valor lógico (negação) |

---

### 🔸 Operador OR (`||`) na prática

O operador `||` (OU) retorna **true se pelo menos uma condição for verdadeira**.

```csharp

int idade = 16;
bool acompanhado = true;

if (idade >= 18 || acompanhado)
{
    Console.WriteLine("Entrada permitida");
}
else
{
    Console.WriteLine("Entrada negada");
}

```

Neste exemplo, mesmo que `idade` seja menor que 18, o fato de estar **acompanhado** permite a entrada.

**Resumo prático**:

* `true || true` → `true`
* `true || false` → `true`
* `false || false` → `false`

---

#### ✅ Introdução - Operador AND

O operador `&&` (E lógico) é usado quando **todas as condições precisam ser verdadeiras**.

---

#### 🔸 Operador AND (`&&`) na prática

Exemplo prático:

```csharp

int idade = 20;
bool temIngresso = true;

if (idade >= 18 && temIngresso)
{
    Console.WriteLine("Pode entrar no evento");
}
else
{
    Console.WriteLine("Não pode entrar");
}

```

Se qualquer uma das duas condições for falsa, a mensagem de negação será exibida.

**Resumo prático**:

* `true && true` → `true`
* `true && false` → `false`
* `false && false` → `false`

---

### ✅ Introdução - Operador NOT

O operador `!` (NOT) **inverte o valor lógico** de uma expressão. É útil quando você quer verificar se algo **não** é verdadeiro.

---

### 🔸 Operador NOT (`!`) na prática

Exemplo:

```csharp

bool conectado = false;

if (!conectado)
{
    Console.WriteLine("Você está offline");
}

```

Nesse caso, `!conectado` será `true`, já que `conectado` é `false`.

Outro exemplo comum:

```csharp

bool temPermissao = false;

if (!temPermissao)
{
    Console.WriteLine("Acesso negado");
}

```

---

#### ✅ Conclusão

Os operadores lógicos permitem escrever **decisões mais completas e inteligentes**. São indispensáveis no controle de fluxo e na construção de **regras de negócio complexas**.

**Dica:** combine `&&`, `||` e `!` com parênteses para deixar a leitura clara e evitar erros de precedência.

**Links úteis para aprofundar:**

* [Documentação oficial - Operadores lógicos (C#)](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/boolean-logical-operators)

---

##### ✍️ Seção criada por: *Fabio Zanneti* - 🎯 Bootcamp: **WEX - End to End Engineering**
[![GitHub](https://img.shields.io/badge/GitHub-fzanneti-181717?style=flat&logo=github)](https://github.com/fzanneti)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-fzanneti-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/fzanneti)