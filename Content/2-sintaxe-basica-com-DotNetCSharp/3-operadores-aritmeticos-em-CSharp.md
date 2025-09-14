# WEX - End to End Engineering

## 2.3 - Operadores Aritméticos em C#

![GitHub repo size](https://img.shields.io/github/repo-size/fzanneti/wex-e2e-csharp)
![GitHub forks](https://img.shields.io/github/forks/fzanneti/wex-e2e-csharp?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/fzanneti/wex-e2e-csharp?style=social)
![Linguagem](https://img.shields.io/badge/Linguagem-CSharp-blue)
![Bootcamp](https://img.shields.io/badge/WEX-End--to--End%20Engineering-blueviolet?logo=vercel&logoColor=white)
![Plataforma](https://img.shields.io/badge/Powered%20by-DIO.io-red?logo=data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjZmZmIiB2aWV3Qm94PSIwIDAgMzIgMzIiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PHBhdGggZD0iTTYuNzEgMy4yNWMtMi44OCAxLjQxLTUuMDcgNC4yMy01LjA3IDcuNzYgMCAzLjU4IDIuMjggNi43IDUuMzMgOC4xNSAxLjgzLS42MiAyLjQtMi4yNiAyLjQtMy44MSAwLS4yMy0uMDItLjQ1LS4wNS0uNjZBLjQ0LjQ0IDAgMDExMC4xIDExYy4yNC0uNzUuMTEtMS41My0uMy0yLjIyQzguOTIgNy45NiA3LjMzIDcuNSA1Ljc0IDcuNjZhNS41NSA1LjU1IDAgM)
![Autor](https://img.shields.io/badge/Autor-fzanneti-blue?style=flat-square&logo=github)

---

### Introdução aos Operadores Aritméticos

No Bootcamp WEX, você está construindo aplicações com C#, .NET, Git e GitHub. **Operadores aritméticos** e a classe `Math` são essenciais para cálculos em projetos como sistemas financeiros ou APIs. Este módulo explora operadores básicos, funções matemáticas e boas práticas. Em C#, operadores aritméticos são símbolos usados para realizar cálculos matemáticos. Eles funcionam com tipos numéricos como `int`, `double`, `float`, entre outros. São fundamentais para qualquer aplicação que envolva matemática.

---

### Principais Operadores

| Operador | Operação         | Exemplo       |
|----------|------------------|----------------|
| `+`      | Adição            | `5 + 3 = 8`    |
| `-`      | Subtração         | `5 - 3 = 2`    |
| `*`      | Multiplicação     | `5 * 3 = 15`   |
| `/`      | Divisão           | `6 / 2 = 3`    |
| `%`      | Módulo (resto)    | `5 % 2 = 1`    |

---

### Criando uma Classe Calculadora

Vamos criar uma classe simples que implementa essas operações básicas:

```csharp

public class Calculadora
{
    public double Somar(double a, double b) => a + b;
    public double Subtrair(double a, double b) => a - b;
    public double Multiplicar(double a, double b) => a * b;
    public double Dividir(double a, double b) => b != 0 ? a / b : throw new DivideByZeroException();
    public double Modulo(double a, double b) => a % b;
}

```

---

### Exemplo de Uso

```csharp

var calc = new Calculadora();
Console.WriteLine(calc.Somar(4, 5)); // Saída: 9

```

---

### Usando Potência com `Math.Pow()`

Para calcular potências (ex: 2³ = 8), usamos a função Math.Pow():

```csharp

double resultado = Math.Pow(2, 3); // 8
Console.WriteLine($"2 elevado a 3 é {resultado}");

```

---

### Funções Trigonométricas

As funções trigonométricas em C# são acessadas pela classe `Math`, utilizando **radianos** como unidade.

```csharp

double angulo = Math.PI / 2; // 90 graus em radianos
double seno = Math.Sin(angulo);       // 1
double cosseno = Math.Cos(angulo);    // 0
double tangente = Math.Tan(angulo);   // Infinito (muito alto)

Console.WriteLine($"Seno: {seno}, Cosseno: {cosseno}, Tangente: {tangente}");

```

> Para converter de graus para radianos: ```Math.PI * graus / 180```.

---

### Incremento e Decremento

Esses operadores servem para aumentar ou diminuir o valor de uma variável em 1.

```csharp

int x = 5;
x++; // Agora x é 6
x--; // Agora x é 5 novamente

++x; // incrementa antes de usar
--x; // decrementa antes de usar

```

---

### Raiz Quadrada com `Math.Sqrt()`

Para obter a raiz quadrada de um número, use Math.Sqrt():

```csharp

double raiz = Math.Sqrt(25); // 5
Console.WriteLine($"Raiz quadrada de 25 é {raiz}");

```

---

### Links Complementares de Estudo – Operadores Aritméticos em C#

Operadores aritméticos são fundamentais em C# para realizar cálculos simples ou composições mais complexas dentro de expressões matemáticas e lógicas. Dominar esses operadores é base para qualquer algoritmo.

🔗[Operadores Aritméticos – C# Docs](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/arithmetic-operators)    
🔗[Tabela Geral de Operadores – Microsoft](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/)     
🔗[DotNetFiddle](https://dotnetfiddle.net/)    
🔗[LINQPad](https://www.linqpad.net/)    

---

### Conclusão

Operadores aritméticos são **base da programação matemática**. Dominar o uso de operadores básicos, combinados com funções da classe `Math`, te dá uma boa base para:

- Processamento de dados
- Aplicações financeiras
- Algoritmos matemáticos
- Jogos e simulações

> Desafio: Adicione novos métodos na `Calculadora` para `potência`, `raiz` e `conversão de ângulo`!

---

### Certificado

<img src="https://github.com/fzanneti/DIO-wex-e2e-csharp/blob/main/Assets/images/certificados/8-operadores-aritmeticos-em-CSharp.jpg" alt="Certificado" width="600px">

---

##### ✍️ Seção criada por: *Fabio Zanneti* - 🎯 Bootcamp: **WEX - End to End Engineering**
[![GitHub](https://img.shields.io/badge/GitHub-fzanneti-181717?style=flat&logo=github)](https://github.com/fzanneti)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-fzanneti-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/fzanneti)