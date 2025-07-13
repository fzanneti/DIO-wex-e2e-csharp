# 🎯 Desafio 01/02 - Módulo 03 - Registro de Despesas Válido

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

```

* `System`: Permite o uso de recursos básicos como entrada e saída de dados no console.
* `System.Collections.Generic`: Dá acesso às **listas genéricas** com tipos definidos, no caso, `List<int>`.

---

### 2. **Classe Program e Método Main**

```csharp

static void Main()

```

* Ponto de entrada do programa. Quando você executa, o código começa aqui.

---

### 3. **Leitura da Quantidade de Despesas**

```csharp

int quantidade = int.Parse(Console.ReadLine());

```

* Lê do console um número inteiro que representa **quantas despesas serão informadas**.

---

### 4. **Criação da Lista de Despesas**

```csharp

List<int> despesas = new List<int>();

```

* Cria uma lista chamada **`despesas`** para guardar valores inteiros **maiores que zero**.

---

### 5. **Loop para Receber os Valores**

```csharp

for (int i = 0; i < quantidade; i++)
{
    int valor = int.Parse(Console.ReadLine());
    if (valor > 0)
    {
        despesas.Add(valor);
    }
}

```

* O `for` vai repetir até atingir a quantidade de despesas que o usuário informou.
* Para cada iteração:

  1. Lê um número inteiro digitado.
  2. **Se o valor for maior que zero**, ele é adicionado à lista `despesas`.
  3. **Se for zero ou negativo, o valor é ignorado**.

---

### 6. **Verificação se há Despesas Válidas**

```csharp

if (despesas.Count == 0)
{
    Console.WriteLine("Sem despesas validas");
}

```

* Caso a lista esteja **vazia** (nenhum número maior que zero foi informado), o programa exibe:

```

Sem despesas validas

```

---

### 7. **Exibição das Despesas**

```csharp

else
{
    foreach (int despesa in despesas)
    {
        Console.WriteLine(despesa);
    }
}

```

* Se a lista **tem algum valor**, ele percorre todos os itens e imprime **cada despesa válida em uma linha separada**.

---

### ✅ **Exemplo Prático**

Se o usuário digitar:

```

5
10
-2
0
15
20

```

* Quantidade: 5
* Valores: 10, -2, 0, 15, 20

O programa armazenará apenas `10, 15, 20` e imprimirá:

```

10
15
20

```

Se todos os números forem **0 ou negativos**, o programa responde:

```

Sem despesas validas

```

---

### ✅ **Resumo**

Esse programa:

* Lê um número de despesas.
* Guarda **apenas os valores positivos**.
* Exibe todas as despesas válidas ou uma mensagem dizendo que não houve nenhuma.

---

##### ✍️ Seção criada por: *Fabio Zanneti* - 🎯 Bootcamp: **WEX - End to End Engineering**
[![GitHub](https://img.shields.io/badge/GitHub-fzanneti-181717?style=flat&logo=github)](https://github.com/fzanneti)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-fzanneti-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/fzanneti)