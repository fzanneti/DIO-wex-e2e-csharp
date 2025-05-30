# 📘 Tipos de Dados em C#

Guia completo para iniciantes que estão aprendendo C# e desejam entender os principais tipos de dados utilizados no desenvolvimento de aplicações na plataforma .NET.

---

#### 🧠 Introdução

Em C#, **tipos de dados** são usados para declarar o tipo de valor que uma variável pode armazenar. Isso é essencial porque C# é uma linguagem **fortemente tipada** — ou seja, cada variável deve ter um tipo definido desde o início.

A escolha correta do tipo de dado influencia diretamente no desempenho e na memória da aplicação.

---

#### 🔢 Tipos Inteiros

Os tipos inteiros representam **números inteiros** (sem casas decimais). Eles variam em tamanho e capacidade:

| Tipo     | Tamanho | Intervalo                         | Exemplo                        |
|----------|---------|-----------------------------------|--------------------------------|
| `byte`   | 8 bits  | 0 a 255                           | `byte idade = 30;`             |
| `sbyte`  | 8 bits  | -128 a 127                        | `sbyte nota = -10;`            |
| `short`  | 16 bits | -32.768 a 32.767                  | `short valor = 15000;`         |
| `int`    | 32 bits | -2 bi a 2 bi                      | `int ano = 2025;`              |
| `long`   | 64 bits | -9 quintilhões a 9 quintilhões    | `long populacao = 7800000000;` |

Use `int` como padrão, a menos que haja necessidade específica.

---

#### 🔍 Números com Casas Decimais

Para representar valores com casas decimais, usamos:

| Tipo       | Precisão            | Indicação            | Exemplo                       |
|------------|---------------------|----------------------|-------------------------------|
| `float`    | 6 a 9 dígitos       | Sufixo `f`           | `float altura = 1.75f;`       |
| `double`   | 15 a 17 dígitos     | Padrão para decimais | `double preco = 19.99;`       |
| `decimal`  | Alta precisão       | Sufixo `m`           | `decimal salario = 4500.99m;` |

- Use `float` para economia de memória.
- Use `double` para cálculos científicos.
- Use `decimal` para valores financeiros.

---

#### 📝 Declarando Tipos de Variáveis

Para declarar uma variável, você define o tipo seguido do nome:

```csharp
int idade = 43;
double preco = 199.90;
string nome = "Fabio";
bool ativo = true;
```

---

#### 🧪 Manipulando Variáveis

Você pode atribuir novos valores a qualquer variável (desde que respeite o tipo):

```csharp
int idade = 25;
idade = idade + 5; // Agora idade vale 30

string nome = "Maria";
nome = nome + " Clara"; // Resultado: "Maria Clara"
```

Alguns operadores úteis:

````+````, ```` -````, ````*````, ````/````: operadores matemáticos

````++```` / ````--````: incremento e decremento

````+=```` / ````-=````: atribuição composta

---

#### ⏰ O Tipo ````DateTime````

O ````DateTime```` é usado para armazenar **data e hora**:


````csharp
DateTime hoje = DateTime.Now;
DateTime aniversario = new DateTime(1980, 5, 25);
````

Operações com ````DateTime````:

````csharp
DateTime futuro = DateTime.Now.AddDays(7);
TimeSpan diferenca = futuro - DateTime.Now;
Console.WriteLine(diferenca.TotalDays); // Diferença em dias 
````

---

#### ✅ Conclusão

Conhecer e saber escolher o tipo de dado adequado é fundamental para um código eficiente e confiável. C# oferece uma ampla gama de tipos nativos para cobrir os mais diversos cenários, desde simples contagens até operações complexas com datas e dinheiro.

---

#### 🔗 Links Úteis

- [Documentação Oficial - Tipos de Dados C#](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/built-in-types)
- [Dotnetfiddle - Playground para testar código C# online](https://dotnetfiddle.net/)
- [Vídeo: Tipos de Dados em C# - Curso em Vídeo](https://www.youtube.com/watch?v=8lugjL6i1cs)

---

##### Seção criada por: *Fabio Zanneti - Projeto: WEX - End to End Engineering* - Guia de estudos.