# 🎯 Desafio 02/02 - Módulo 03 - Seleção de Nome por Letra

![GitHub repo size](https://img.shields.io/github/repo-size/fzanneti/wex-e2e-csharp)
![GitHub forks](https://img.shields.io/github/forks/fzanneti/wex-e2e-csharp?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/fzanneti/wex-e2e-csharp?style=social)
![Linguagem](https://img.shields.io/badge/Linguagem-CSharp-blue)
![Bootcamp](https://img.shields.io/badge/WEX-End--to--End%20Engineering-blueviolet?logo=vercel&logoColor=white)
![Plataforma](https://img.shields.io/badge/Powered%20by-DIO.io-red?logo=data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjZmZmIiB2aWV3Qm94PSIwIDAgMzIgMzIiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PHBhdGggZD0iTTYuNzEgMy4yNWMtMi44OCAxLjQxLTUuMDcgNC4yMy01LjA3IDcuNzYgMCAzLjU4IDIuMjggNi43IDUuMzMgOC4xNSAxLjgzLS42MiAyLjQtMi4yNiAyLjQtMy44MSAwLS4yMy0uMDItLjQ1LS4wNS0uNjZBLjQ0LjQ0IDAgMDExMC4xIDExYy4yNC0uNzUuMTEtMS41My0uMy0yLjIyQzguOTIgNy45NiA3LjMzIDcuNSA1Ljc0IDcuNjZhNS41NSA1LjU1IDAgM)
![Autor](https://img.shields.io/badge/Autor-fzanneti-blue?style=flat-square&logo=github)

---

### ✅ **Objetivo**

Esse programa:

1. Lê uma lista de nomes separados por vírgula.
2. Lê uma letra para filtro.
3. Filtra os nomes que **começam com essa letra**, sem diferenciar maiúsculas de minúsculas.
4. Exibe os nomes filtrados ou uma mensagem dizendo que **nenhum nome foi encontrado**.

---

### ✅ **Importações**

```csharp

using System;
using System.Collections.Generic;
using System.Linq;

```

* `System`: Entrada/saída no console.
* `System.Collections.Generic`: Uso de lista genérica (`List<string>`).
* `System.Linq`: Permite usar **LINQ** para filtrar e manipular listas de forma elegante.

---

### ✅ **Leitura e Processamento da Lista de Nomes**

```csharp

string linhaDeNomes = Console.ReadLine();

```

* Lê uma **string única**, por exemplo:

```

Carlos, maria, João, carla, Mariana

```

```csharp

List<string> nomes = linhaDeNomes
    .Split(',')
    .Select(nome => nome.Trim())
    .ToList();

```

Aqui:

* `Split(',')`: Quebra a string em um array de nomes onde houver vírgula.
* `Select(nome => nome.Trim())`: Remove **espaços extras** antes/depois de cada nome.
* `ToList()`: Converte para **lista**.

Resultado:

```csharp

["Carlos", "maria", "João", "carla", "Mariana"]

```

---

### ✅ **Leitura da Letra de Filtro**

```csharp

char letraFiltro = char.Parse(Console.ReadLine());

```

Exemplo de entrada:

```

M

```

---

### ✅ **Filtrando os Nomes**

```csharp

var filtrados = nomes
    .Where(nome => nome.StartsWith(letraFiltro.ToString(), StringComparison.OrdinalIgnoreCase))
    .ToList();

```

* **`Where`**: Percorre cada nome da lista e aplica uma condição.
* **`StartsWith`**: Verifica se o nome começa com a letra desejada.
* **`StringComparison.OrdinalIgnoreCase`**: Ignora se a letra é maiúscula ou minúscula.

Exemplo:

* Letra: `M`
* Resultado:

```

["maria", "Mariana"]

```

---

### ✅ **Exibindo o Resultado**

```csharp

if (filtrados.Count == 0)
{
    Console.WriteLine("Nenhum nome encontrado");
}
else
{
    foreach (var nome in filtrados)
    {
        Console.WriteLine(nome);
    }
}

```

* Se **não houver nomes filtrados**, exibe:

```

Nenhum nome encontrado

```

* Caso contrário, imprime cada nome filtrado numa linha.

---

### ✅ **Exemplo Completo**

Entrada:

```

Carlos, maria, João, carla, Mariana
m

```

Saída:

```

maria
Mariana

```

---

### ✅ **Resumo**

Esse código:

1. Lê uma lista de nomes.
2. Lê uma letra.
3. Filtra os nomes que começam com essa letra.
4. Imprime os nomes ou uma mensagem padrão.

---

##### ✍️ Seção criada por: *Fabio Zanneti* - 🎯 Bootcamp: **WEX - End to End Engineering**
[![GitHub](https://img.shields.io/badge/GitHub-fzanneti-181717?style=flat&logo=github)](https://github.com/fzanneti)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-fzanneti-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/fzanneti)