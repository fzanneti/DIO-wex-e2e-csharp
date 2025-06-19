# 📘 Tipos de Dados em C\#

Guia completo para iniciantes que estão aprendendo C# e desejam entender os principais tipos de dados utilizados no desenvolvimento de aplicações na plataforma .NET.

---

### 🧠 Introdução

Em C#, **tipos de dados** são utilizados para definir que tipo de informação uma variável pode armazenar. A linguagem é **fortemente tipada**, ou seja, cada variável precisa ter um tipo declarado logo na criação.

Essa definição ajuda o compilador a garantir segurança e eficiência no código — além de melhorar a legibilidade e evitar erros.

---

### 🔢 Tipos Numéricos Inteiros

Representam **números inteiros** (sem casas decimais). A escolha entre eles depende do intervalo necessário:

| Tipo    | Tamanho | Intervalo                      | Exemplo                        |
| ------- | ------- | ------------------------------ | ------------------------------ |
| `byte`  | 8 bits  | 0 a 255                        | `byte idade = 30;`             |
| `sbyte` | 8 bits  | -128 a 127                     | `sbyte nota = -10;`            |
| `short` | 16 bits | -32.768 a 32.767               | `short valor = 15000;`         |
| `int`   | 32 bits | -2.147.483.648 a 2.147.483.647 | `int ano = 2025;`              |
| `long`  | 64 bits | ±9 quintilhões                 | `long populacao = 7800000000;` |

🎯 Use `int` como padrão, a não ser que haja necessidade específica para mais ou menos alcance.

---

### 🔍 Tipos Numéricos com Casas Decimais

Indicados para valores **com ponto flutuante**, como medições, preços ou porcentagens.

| Tipo      | Precisão        | Recomendado para     | Sufixo obrigatório | Exemplo                       |
| --------- | --------------- | -------------------- | ------------------ | ----------------------------- |
| `float`   | 6 a 9 dígitos   | Economia de memória  | `f`                | `float altura = 1.75f;`       |
| `double`  | 15 a 17 dígitos | Cálculos científicos | (nenhum)           | `double peso = 88.5;`         |
| `decimal` | Alta precisão   | Valores financeiros  | `m`                | `decimal salario = 4500.99m;` |

---

### 📝 Declarando Tipos de Variáveis

No C#, a estrutura da declaração é sempre:

```csharp

tipo nome = valor;

```

### Exemplos:

```csharp

int idade = 43;
string nome = "Fabio";
bool ativo = true;
double preco = 199.90;

```

---

### 🧪 Manipulando Variáveis

Variáveis podem ser **reutilizadas e alteradas** desde que o tipo seja mantido:

```csharp

int idade = 25;
idade = idade + 5; // idade agora é 30

string nome = "Maria";
nome = nome + " Clara"; // Resultado: "Maria Clara"

```

---

### ⚙️ Operadores Comuns

| Operador | Função               | Exemplo                      |
| -------- | -------------------- | ---------------------------- |
| `+`      | Soma ou concatenação | `idade + 10` / `"Oi" + nome` |
| `-`      | Subtração            | `preco - 5`                  |
| `*`      | Multiplicação        | `quantidade * valor`         |
| `/`      | Divisão              | `total / 2`                  |
| `++`     | Incrementa +1        | `contador++`                 |
| `--`     | Decrementa -1        | `contador--`                 |
| `+=`     | Soma e atribui       | `total += 50`                |

---

### ⏰ Tipo `DateTime`

`DateTime` é o tipo usado para lidar com **data e hora** em C#.


### Criando datas:

```csharp

DateTime hoje = DateTime.Now;
DateTime aniversario = new DateTime(1980, 5, 25);

```

### Operações com datas:

```csharp

DateTime futuro = DateTime.Now.AddDays(7);
TimeSpan diferenca = futuro - DateTime.Now;

Console.WriteLine(diferenca.TotalDays); // Saída: 7

```

---

### ❗ Observações Importantes

* Tipos numéricos sem casas decimais são mais rápidos, mas não servem para valores quebrados.
* `decimal` deve ser usado em valores de **dinheiro**, pois evita erros de arredondamento comuns em `float` e `double`.
* Sempre use sufixos (`f` ou `m`) ao trabalhar com `float` e `decimal`.

---

#### ✅ Conclusão

Compreender e utilizar corretamente os **tipos de dados** é essencial para garantir:

* Um código mais limpo e organizado
* Melhor uso da memória
* Menos bugs e erros de tipo

C# oferece uma gama poderosa de tipos para lidar com qualquer situação — da simples contagem até cálculos matemáticos e manipulação de datas.

---

### 🔗 Links Úteis

* [📄 Documentação Oficial — Tipos de Dados em C#](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/built-in-types)
* [🔧 Dotnetfiddle — Teste seu código C# online](https://dotnetfiddle.net/)
* [▶️ Vídeo: Tipos de Dados em C# – Curso em Vídeo](https://www.youtube.com/watch?v=8lugjL6i1cs)

---

##### ✍️ **Seção criada por:** *Fabio Zanneti* 🎯 Projeto: **WEX - End to End Engineering**
