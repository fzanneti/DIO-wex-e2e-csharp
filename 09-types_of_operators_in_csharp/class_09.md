# ⚙️ Operações e Atribuições em C#

Entenda como funcionam os operadores de atribuição, conversão de tipos e boas práticas para lidar com diferentes tipos de dados em C#.

---

#### ✅ Introdução - Operador de Atribuição

Em C#, o **operador de atribuição** é usado para armazenar valores em variáveis. O símbolo `=` é utilizado para essa operação:

```csharp
int idade = 30;
```

Isso significa: “A variável ````idade```` recebe o valor ````30````”. Atenção: isso não é uma **igualdade**, mas sim uma **atribuição de valor**.

---

#### ➕ Combinando Operadores

É possível combinar operadores aritméticos com o de atribuição. Esses são chamados de **operadores de atribuição compostos**:

| Operador | Descrição                  | Exemplo                 |
| -------- | -------------------------- | ----------------------- |
| `+=`     | Soma e atribuição          | `x += 10;` (x = x + 10) |
| `-=`     | Subtração e atribuição     | `x -= 5;`               |
| `*=`     | Multiplicação e atribuição | `x *= 3;`               |
| `/=`     | Divisão e atribuição       | `x /= 2;`               |
| `%=`     | Módulo e atribuição        | `x %= 2;`               |

Esses atalhos deixam o código mais limpo e fácil de ler.

---

#### 🔁 Convertendo Tipos de Variáveis

Em C#, é comum precisar converter o valor de uma variável de um tipo para outro, como de `string` para `int`, ou de `double` para `int`. Isso pode ser feito de três formas principais:

* Conversão explícita (cast)
* Conversão implícita
* Métodos como `Convert`, `Parse` e `TryParse`

---

#### ⚖️ Diferença entre `Convert` e `Parse`

| Característica      | `Convert`                    | `Parse`                               |
| ------------------- | ---------------------------- | ------------------------------------- |
| Aceita valor `null` | Sim (retorna valor padrão)   | Não (gera exceção)                    |
| Suporta mais tipos  | Sim (ex: `bool`, `DateTime`) | Não (mais restrito a string numérica) |
| Exemplo             | `Convert.ToInt32("10")`      | `int.Parse("10")`                     |

Use `Convert` quando não tiver certeza se o valor pode ser `null`. Use `Parse` quando souber que a string é válida.

---

#### 🧾 Conversão para String

Qualquer tipo pode ser convertido para `string` usando o método `.ToString()`:

```csharp
int idade = 30;
string texto = idade.ToString(); // "30"
```

É muito útil para exibir valores em telas, logs ou mensagens.

---

#### ⚠️ Cast Implícito e Explícito

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

#### ⏱️ Ordem dos Operadores

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

#### 🛡️ Convertendo de Maneira Segura

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

> **Recomendado:**
>
> * [Documentação oficial sobre conversões](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/)
> * [Operadores em C#](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/)

---

