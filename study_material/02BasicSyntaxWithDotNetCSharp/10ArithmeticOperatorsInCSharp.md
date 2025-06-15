# 🧮 Operadores Aritméticos em C#

### ➕ Introdução aos Operadores Aritméticos

> Entenda os operadores aritméticos do C# e aprenda a usar a classe `Math` para realizar operações matemáticas mais avançadas, como potência, raiz quadrada e trigonometria.

Em C#, operadores aritméticos são símbolos usados para realizar cálculos matemáticos. Eles funcionam com tipos numéricos como `int`, `double`, `float`, entre outros. São fundamentais para qualquer aplicação que envolva matemática.

---

### 🧰 Principais Operadores

| Operador | Operação         | Exemplo       |
|----------|------------------|----------------|
| `+`      | Adição            | `5 + 3 = 8`    |
| `-`      | Subtração         | `5 - 3 = 2`    |
| `*`      | Multiplicação     | `5 * 3 = 15`   |
| `/`      | Divisão           | `6 / 2 = 3`    |
| `%`      | Módulo (resto)    | `5 % 2 = 1`    |

---

### 🧮 Criando uma Classe Calculadora

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

### 🔍 Exemplo de Uso

```csharp

var calc = new Calculadora();
Console.WriteLine(calc.Somar(4, 5)); // Saída: 9

```

---

### ⚡ Usando Potência com `Math.Pow()`

Para calcular potências (ex: 2³ = 8), usamos a função Math.Pow():

```csharp

double resultado = Math.Pow(2, 3); // 8
Console.WriteLine($"2 elevado a 3 é {resultado}");

```

---

### 📐 Funções Trigonométricas

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

### 🔼 Incremento e 🔽 Decremento

Esses operadores servem para aumentar ou diminuir o valor de uma variável em 1.

```csharp

int x = 5;
x++; // Agora x é 6
x--; // Agora x é 5 novamente

++x; // incrementa antes de usar
--x; // decrementa antes de usar

```

---

### 🧪 Raiz Quadrada com `Math.Sqrt()`

Para obter a raiz quadrada de um número, use Math.Sqrt():

```csharp

double raiz = Math.Sqrt(25); // 5
Console.WriteLine($"Raiz quadrada de 25 é {raiz}");

```

---

#### ✅ Conclusão

Operadores aritméticos são **base da programação matemática**. Dominar o uso de operadores básicos, combinados com funções da classe `Math`, te dá uma boa base para:

* Processamento de dados
* Aplicações financeiras
* Algoritmos matemáticos
* Jogos e simulações

> 💡 Desafio: Adicione novos métodos na `Calculadora` para `potência`, `raiz` e `conversão de ângulo`!

---

##### ✍️ **Seção criada por:** *Fabio Zanneti*
##### 🎯 Projeto: **WEX - End to End Engineering**