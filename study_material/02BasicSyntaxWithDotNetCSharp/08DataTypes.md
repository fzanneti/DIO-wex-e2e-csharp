# 📘 Tipos de Dados em C#

Guia completo para iniciantes que estão aprendendo C# e desejam entender os principais tipos de dados utilizados no desenvolvimento de aplicações na plataforma .NET.

![GitHub repo size](https://img.shields.io/github/repo-size/fzanneti/wex-e2e-csharp)
![GitHub forks](https://img.shields.io/github/forks/fzanneti/wex-e2e-csharp?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/fzanneti/wex-e2e-csharp?style=social)
![Linguagem](https://img.shields.io/badge/Linguagem-CSharp-blue)
![Bootcamp](https://img.shields.io/badge/WEX-End--to--End%20Engineering-blueviolet?logo=vercel&logoColor=white)
![Plataforma](https://img.shields.io/badge/Powered%20by-DIO.io-red?logo=data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjZmZmIiB2aWV3Qm94PSIwIDAgMzIgMzIiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PHBhdGggZD0iTTYuNzEgMy4yNWMtMi44OCAxLjQxLTUuMDcgNC4yMy01LjA3IDcuNzYgMCAzLjU4IDIuMjggNi43IDUuMzMgOC4xNSAxLjgzLS42MiAyLjQtMi4yNiAyLjQtMy44MSAwLS4yMy0uMDItLjQ1LS4wNS0uNjZBLjQ0LjQ0IDAgMDExMC4xIDExYy4yNC0uNzUuMTEtMS41My0uMy0yLjIyQzguOTIgNy45NiA3LjMzIDcuNSA1Ljc0IDcuNjZhNS41NSA1LjU1IDAgM)
![Autor](https://img.shields.io/badge/Autor-fzanneti-blue?style=flat-square&logo=github)

---

### 🧠 Introdução

No Bootcamp WEX, você está aprendendo C#, .NET, Git e GitHub. Dominar **tipos de dados** é fundamental para criar códigos eficientes e livres de erros. Este módulo explora os principais tipos do C#, suas aplicações e boas práticas, preparando você para projetos práticos.

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

`tipo nome = valor;`

### 📝 Tipos de Texto e Booleanos

- **string**: Texto Unicode.
```csharp
string nome = "Fabio Zanneti";
```
- **char**: Caractere único.
```csharp
char inicial = 'F';
```
- **bool**: `true` ou `false`.
```csharp
bool ativo = true;
```

---

### 🔄 Conversão de Tipos

- **Implícita**:

```csharp

int numero = 42;
double numeroDecimal = numero; // Saída: 42.0

```

- **Explícita**:

```csharp

double preco = 99.99;
int precoInteiro = (int)preco; // Saída: 99

```

- **Métodos**:

```csharp

string texto = "123";
int numero = int.Parse(texto);

```

---

### ⏰ Tipo `DateTime`

```csharp

DateTime hoje = DateTime.Now;
DateTime aniversario = new DateTime(1980, 5, 25);
TimeSpan diferenca = hoje - aniversario;
Console.WriteLine($"Idade em dias: {diferenca.TotalDays}");

```

`DateTime` é o tipo usado para lidar com **data e hora** em C#.

---

### Operações com datas:

```csharp

DateTime futuro = DateTime.Now.AddDays(7);
TimeSpan diferenca = futuro - DateTime.Now;

Console.WriteLine(diferenca.TotalDays); // Saída: 7

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
* [▶️ Vídeo: Tipos de Dados em C#](https://www.youtube.com/watch?v=aUlTrGWsCuc)

---

##### ✍️ Seção criada por: *Fabio Zanneti* - 🎯 Bootcamp: **WEX - End to End Engineering**
[![GitHub](https://img.shields.io/badge/GitHub-fzanneti-181717?style=flat&logo=github)](https://github.com/fzanneti)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-fzanneti-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/fzanneti)