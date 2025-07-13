# 🎯 Desafio 02/02 - Módulo 04 - Identificador de transação suspeita

![GitHub repo size](https://img.shields.io/github/repo-size/fzanneti/wex-e2e-csharp)
![GitHub forks](https://img.shields.io/github/forks/fzanneti/wex-e2e-csharp?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/fzanneti/wex-e2e-csharp?style=social)
![Linguagem](https://img.shields.io/badge/Linguagem-CSharp-blue)
![Bootcamp](https://img.shields.io/badge/WEX-End--to--End%20Engineering-blueviolet?logo=vercel&logoColor=white)
![Plataforma](https://img.shields.io/badge/Powered%20by-DIO.io-red?logo=data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjZmZmIiB2aWV3Qm94PSIwIDAgMzIgMzIiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PHBhdGggZD0iTTYuNzEgMy4yNWMtMi44OCAxLjQxLTUuMDcgNC4yMy01LjA3IDcuNzYgMCAzLjU4IDIuMjggNi43IDUuMzMgOC4xNSAxLjgzLS42MiAyLjQtMi4yNiAyLjQtMy44MSAwLS4yMy0uMDItLjQ1LS4wNS0uNjZBLjQ0LjQ0IDAgMDExMC4xIDExYy4yNC0uNzUuMTEtMS41My0uMy0yLjIyQzguOTIgNy45NiA3LjMzIDcuNSA1Ljc0IDcuNjZhNS41NSA1LjU1IDAgM)
![Autor](https://img.shields.io/badge/Autor-fzanneti-blue?style=flat-square&logo=github)

---

### ✅ **Objetivo do Programa**

O programa simula um **analisador de transações financeiras** que:

1. Lê um **limite de valor**.
2. Lê um conjunto de transações.
3. Identifica e exibe as transações **acima desse limite**, chamadas de **transações suspeitas**.
4. Mostra um **relatório** com o total e a quantidade de transações suspeitas ou uma mensagem caso não haja nenhuma.

---

### ✅ **Importações**

```csharp

using System;
using System.Collections.Generic;
using System.Linq;

```

* `System`: Entrada e saída de console.
* `System.Collections.Generic`: Para usar a **List<decimal>**.
* `System.Linq`: Para aplicar **filtros, somas e contagens com facilidade**.

---

### ✅ **Classe `AnalisadorDeTransacoes`**

### Propriedades

```csharp

public decimal Limite { get; set; }
public List<decimal> Transacoes { get; set; }

```

* **`Limite`**: Valor máximo que define o que é uma transação suspeita.
* **`Transacoes`**: Lista de todas as transações adicionadas.

### Construtor

```csharp

public AnalisadorDeTransacoes(decimal limite)
{
    Limite = limite;
    Transacoes = new List<decimal>();
}

```

* Define o limite no momento de criação do objeto.
* Inicializa a lista de transações vazia.

---

### ✅ **Método para Adicionar Transação**

```csharp

public void AdicionarTransacao(decimal valor)
{
    Transacoes.Add(valor);
}

```

* Apenas adiciona o valor informado à lista de transações.

---

### ✅ **Método que Filtra Transações Suspeitas**

```csharp

public List<decimal> ObterTransacoesSuspeitas()
{
    return Transacoes.Where(t => t > Limite).ToList();
}

```

* Usa **LINQ com `.Where()`** para filtrar os valores da lista que **são maiores que o limite**.
* Converte o resultado em uma lista (`ToList`).

---

### ✅ **Relatório Final**

```csharp

public void ExibirRelatorio()
{
    var suspeitas = ObterTransacoesSuspeitas();

    if (suspeitas.Count == 0)
    {
        Console.WriteLine("Nenhuma transacao suspeita encontrada");
    }
    else
    {
        decimal totalSuspeitas = suspeitas.Sum();
        int numeroSuspeitas = suspeitas.Count();

        string transacaoTexto = numeroSuspeitas == 1 ? "transacao suspeita" : "transacoes suspeitas";

        Console.WriteLine($"Transacoes suspeitas: {totalSuspeitas:F2}");
        Console.WriteLine($"{numeroSuspeitas} {transacaoTexto}");
    }
}

```

### O que acontece aqui:

1. Chama o método que retorna as transações suspeitas.
2. Se **nenhuma transação suspeita foi encontrada**, exibe:

```

Nenhuma transacao suspeita encontrada

```

3. Caso contrário:

* Soma o total das suspeitas: `.Sum()`.
* Conta quantas são: `.Count()`.
* Usa um **ternário** para ajustar o texto no plural ou singular.
* Exibe:

```

Transacoes suspeitas: <total> (com duas casas decimais)
<quantidade> transacao/transacoes suspeita(s)

```

---

### ✅ **Classe Program / Método Main**

```csharp

decimal limite = decimal.Parse(Console.ReadLine());
int quantidade = int.Parse(Console.ReadLine());

```

* Lê o limite do usuário.
* Lê quantas transações o usuário vai informar.

### Criando o objeto:

```csharp

var analisador = new AnalisadorDeTransacoes(limite);

```

* Cria o analisador já com o limite definido.

### Loop para registrar as transações:

```csharp

for (int i = 0; i < quantidade; i++)
{
    decimal valor = decimal.Parse(Console.ReadLine());
    analisador.AdicionarTransacao(valor);
}

```

* Lê cada valor digitado e adiciona à lista de transações.

### Exibe o relatório ao final:

```csharp

analisador.ExibirRelatorio();

```

---

### ✅ **Exemplo Prático**

### Entrada:

```

1000
5
500
1500
900
2000
800

```

* Limite: 1000
* Transações: 500, 1500, 900, 2000, 800

Transações suspeitas: **1500** e **2000**.

### Saída:

```

Transacoes suspeitas: 3500.00
2 transacoes suspeitas

```

---

### ✅ **Resumo**

O fluxo geral:

1. Define limite.
2. Registra as transações.
3. Identifica valores acima do limite.
4. Exibe um relatório resumido.

---

##### ✍️ Seção criada por: *Fabio Zanneti* - 🎯 Bootcamp: **WEX - End to End Engineering**
[![GitHub](https://img.shields.io/badge/GitHub-fzanneti-181717?style=flat&logo=github)](https://github.com/fzanneti)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-fzanneti-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/fzanneti)