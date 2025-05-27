# 🧮 Operadores Aritméticos em C#

#### Introdução aos Operadores Aritméticos

Em C#, operadores aritméticos são símbolos usados para realizar cálculos matemáticos. Eles funcionam com tipos numéricos como `int`, `double`, `float`, entre outros. São fundamentais para qualquer aplicação que envolva matemática.

---

#### Principais operadores:

| Operador | Operação         | Exemplo       |
|----------|------------------|----------------|
| `+`      | Adição            | `5 + 3 = 8`    |
| `-`      | Subtração         | `5 - 3 = 2`    |
| `*`      | Multiplicação     | `5 * 3 = 15`   |
| `/`      | Divisão           | `6 / 2 = 3`    |
| `%`      | Módulo (resto)    | `5 % 2 = 1`    |

---

#### Criando a Nossa Classe Calculadora

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

#### Exemplo de uso:

var calc = new Calculadora();
Console.WriteLine(calc.Somar(4, 5)); // Saída: 9

---

#### Usando Potência

Para calcular potências (ex: 2³ = 8), usamos a função Math.Pow():

double resultado = Math.Pow(2, 3); // 8
Console.WriteLine($"2 elevado a 3 é {resultado}");

---

#### Funções Trigonométricas

O C# fornece funções trigonométricas através da classe Math. Todos os métodos trabalham em radianos.

double angulo = Math.PI / 2; // 90 graus em radianos
double seno = Math.Sin(angulo);       // 1
double cosseno = Math.Cos(angulo);    // 0
double tangente = Math.Tan(angulo);   // Infinito (muito alto)

Console.WriteLine($"Seno: {seno}, Cosseno: {cosseno}, Tangente: {tangente}");

> Para converter de graus para radianos: Math.PI * graus / 180.

---

#### Incremento e Decremento

Esses operadores servem para aumentar ou diminuir o valor de uma variável em 1.

int x = 5;
x++; // Agora x é 6
x--; // Agora x é 5 novamente

++x; // incrementa antes de usar
--x; // decrementa antes de usar

---

#### Calculando Raiz Quadrada

Para obter a raiz quadrada de um número, use Math.Sqrt():

double raiz = Math.Sqrt(25); // 5
Console.WriteLine($"Raiz quadrada de 25 é {raiz}");

---

#### Conclusão

Operadores aritméticos são essenciais no dia a dia da programação. Entender como aplicá-los e usá-los com as funções da biblioteca Math oferece uma base sólida para cálculos e manipulação de dados numéricos. Experimente criar novos métodos na Calculadora com base nessas funções!

---