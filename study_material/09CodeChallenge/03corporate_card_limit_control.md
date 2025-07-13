# 🎯 Desafio 01/02 - Módulo 04 - Controle de Limite de Cartão Corporativo

![GitHub repo size](https://img.shields.io/github/repo-size/fzanneti/wex-e2e-csharp)
![GitHub forks](https://img.shields.io/github/forks/fzanneti/wex-e2e-csharp?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/fzanneti/wex-e2e-csharp?style=social)
![Linguagem](https://img.shields.io/badge/Linguagem-CSharp-blue)
![Bootcamp](https://img.shields.io/badge/WEX-End--to--End%20Engineering-blueviolet?logo=vercel&logoColor=white)
![Plataforma](https://img.shields.io/badge/Powered%20by-DIO.io-red?logo=data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjZmZmIiB2aWV3Qm94PSIwIDAgMzIgMzIiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PHBhdGggZD0iTTYuNzEgMy4yNWMtMi44OCAxLjQxLTUuMDcgNC4yMy01LjA3IDcuNzYgMCAzLjU4IDIuMjggNi43IDUuMzMgOC4xNSAxLjgzLS42MiAyLjQtMi4yNiAyLjQtMy44MSAwLS4yMy0uMDItLjQ1LS4wNS0uNjZBLjQ0LjQ0IDAgMDExMC4xIDExYy4yNC0uNzUuMTEtMS41My0uMy0yLjIyQzguOTIgNy45NiA3LjMzIDcuNSA1Ljc0IDcuNjZhNS41NSA1LjU1IDAgM)
![Autor](https://img.shields.io/badge/Autor-fzanneti-blue?style=flat-square&logo=github)

---

### 1. **Importação de Bibliotecas**

```csharp

using System;
using System.Collections.Generic;
using System.Linq;

```

* `System`: Biblioteca principal do C#, com recursos como `Console.WriteLine` e `Console.ReadLine`.
* `System.Collections.Generic`: Permite trabalhar com **listas genéricas**, como `List<decimal>`.
* `System.Linq`: Habilita métodos como `.Sum()`, usado para somar todos os valores de uma lista.

---

### 2. **Classe `CartaoCorporativo`**

Essa classe **simula um cartão de crédito corporativo** que registra gastos e verifica se o limite foi ultrapassado.

```csharp

public decimal Limite { get; }
public List<decimal> Transacoes { get; }

```

* `Limite`: Um valor decimal fixo (sem casas binárias como float/double) que representa o limite do cartão.
* `Transacoes`: Lista que armazena cada gasto/compra feita.

### Construtor

```csharp

public CartaoCorporativo(decimal limite)
{
    Limite = limite;
    Transacoes = new List<decimal>();
}

```

* Define o limite informado na criação do objeto.
* Inicializa a lista de transações como vazia.

---

### 3. **Método `AdicionarTransacao`**

```csharp

public void AdicionarTransacao(decimal valor)
{
    Transacoes.Add(valor);
}

```

Adiciona o valor informado à lista de transações. Simula uma compra ou gasto no cartão.

---

### 4. **Método `CalcularTotal`**

```csharp

public decimal CalcularTotal()
{
    return Transacoes.Sum();
}

```

* Usa o método `Sum()` do LINQ para **somar todos os valores na lista de transações**.
* Retorna o total gasto até o momento.

---

### 5. **Método `UltrapassouLimite`**

```csharp

public bool UltrapassouLimite()
{
    return CalcularTotal() > Limite;
}

```

* **Compara o total gasto com o limite**.
* Retorna `true` se o total for maior que o limite, `false` caso contrário.

---

### 6. **Método `ExibirResumo`**

```csharp

public void ExibirResumo()
{
    decimal total = CalcularTotal();
    Console.WriteLine($"Total gasto: {total:F2}");
    
    if (UltrapassouLimite())
    {
        Console.WriteLine("Limite ultrapassado");
    }
    else
    {
        Console.WriteLine("Limite OK");
    }
}

```

* Calcula o total de transações.
* Exibe o total com **2 casas decimais** (`{total:F2}` formata o número com 2 decimais).
* Informa se o limite foi ultrapassado ou não, chamando `UltrapassouLimite()`.

---

### 7. **Classe `Program` e o `Main()`**

Esse é o ponto de entrada da aplicação.

```csharp

decimal limite = decimal.Parse(Console.ReadLine());
int quantidade = int.Parse(Console.ReadLine());

```

* Lê o limite do cartão e a quantidade de transações que serão inseridas.

```csharp

var cartao = new CartaoCorporativo(limite);

```

* Cria uma nova instância do cartão com o limite informado.

```csharp

for (int i = 0; i < quantidade; i++)
{
    decimal valor = decimal.Parse(Console.ReadLine());
    cartao.AdicionarTransacao(valor);
}

```

* Um laço para ler cada valor de transação informado pelo usuário e adicioná-lo ao cartão.

```csharp

cartao.ExibirResumo();

```

* Por fim, exibe o resumo total dos gastos e informa se o limite foi ou não ultrapassado.

---

### ✅ **Resumo**

Este programa:

1. Cria um cartão com limite definido.
2. Registra uma série de transações.
3. Exibe o total gasto e verifica se o limite foi ultrapassado.

---

##### ✍️ Seção criada por: *Fabio Zanneti* - 🎯 Bootcamp: **WEX - End to End Engineering**
[![GitHub](https://img.shields.io/badge/GitHub-fzanneti-181717?style=flat&logo=github)](https://github.com/fzanneti)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-fzanneti-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/fzanneti)