# 📘 Resumos Explicativos - Exercícios de Filtrando Dados e Validando Entradas em C#

#### 🧾 RESUMO EXPLICATIVO - FILTRAGEM DE DESPESAS VÁLIDAS (C#)

```csharp

using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        int quantidade = int.Parse(Console.ReadLine());
        List<int> despesas = new List<int>();

        for (int i = 0; i < quantidade; i++)
        {
            int valor = int.Parse(Console.ReadLine());

            // TODO: Adicione o valor à lista somente se for maior que zero
            
        }

        if (despesas.Count == 0)
        {
            Console.WriteLine("Sem despesas validas");
        }
        else
        {

            // TODO: Imprima cada valor da lista de despesas válidas

        }
    }
}

```

#### 🎯 Objetivo

Ler uma quantidade de valores inteiros (representando despesas) e armazenar apenas aqueles que forem **maiores que zero**.

Ao final, exibir apenas os valores válidos.  
Se não houver despesas válidas, exibir: `"Sem despesas validas"`.

---

#### 🧩 Etapas do Processo

1. **Leitura da quantidade de valores:**
   - O programa começa lendo um número inteiro que define quantos valores o usuário vai informar.

2. **Laço de repetição:**
   - Um `for` é usado para repetir a leitura de valores conforme o número informado.
   - Cada valor é lido com `Console.ReadLine()` e convertido para `int` com `int.Parse()`.

3. **Filtro de despesas:**
   - Cada valor lido é testado: se for **maior que zero**, ele é adicionado à lista de despesas (`despesas.Add(valor)`).
   - Valores menores ou iguais a zero são ignorados.

4. **Verificação e exibição:**
   - Se a lista estiver vazia (`despesas.Count == 0`), exibe: `"Sem despesas validas"`.
   - Caso contrário, imprime cada valor da lista em uma nova linha.

---

#### 📌 Exemplo 1

**Entrada:**

```

-10
0
100
50
-30

```

**Saída:**

```

100
50

```

---

#### 📌 Exemplo 2

**Entrada:**

```

-1
0
-20

```

**Saída:**


```

Sem despesas validas

```

---

#### 💡 Importante

- A verificação `if (valor > 0)` é essencial para garantir que apenas despesas positivas sejam consideradas.
- `Console.ReadLine()` sempre retorna string → use `int.Parse()` para converter.
- O uso de uma `List<int>` permite armazenar todos os valores válidos dinamicamente.

---

#### ✅ Resultado

```csharp

using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        int quantidade = int.Parse(Console.ReadLine());
        List<int> despesas = new List<int>();

        for (int i = 0; i < quantidade; i++)
        {
            int valor = int.Parse(Console.ReadLine());

            // Adicionado abaixo:

            if (valor > 0)
            {
                despesas.Add(valor);
            }
            
        }

        if (despesas.Count == 0)
        {
            Console.WriteLine("Sem despesas validas");
        }
        else
        {

            // Adicionado abaixo:

            foreach (int despesa in despesas)
            {
                Console.WriteLine(despesa);
            }

        }
    }
}

```

---

### 🧾 RESUMO EXPLICATIVO - FILTRAGEM DE NOMES POR LETRA (C#)

```csharp

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string linhaDeNomes = Console.ReadLine();

        // Separa os nomes e remove espaços extras

        List<string> nomes = linhaDeNomes
            .Split(',')
            .Select(nome => nome.Trim())
            .ToList();

        char letraFiltro = char.Parse(Console.ReadLine());

        // TODO: Filtre a lista de nomes que começam com a letra (ignore maiúsculas/minúsculas):
        
        

        // TODO: Retorne o resultado e implemente a condição if para retornar 'Nenhum nome encontrado' e exiba o resultado: 
        
        
        else
        {
            foreach (var nome in filtrados)
            {
                Console.WriteLine(nome);
            }
        }
    }
}

```

#### 🎯 Objetivo

O programa lê uma lista de nomes separados por vírgula e uma letra como filtro.  
Retorna todos os nomes que começam com essa letra, **ignorando maiúsculas/minúsculas**.  
Se nenhum nome for encontrado, exibe: `"Nenhum nome encontrado"`.

---

#### 🧩 Etapas do Processo

1. **Leitura da linha de nomes:**
   - O usuário digita nomes separados por vírgula (ex: `Ana, joao, Maria`).

2. **Separação dos nomes:**
   - `Split(',')` quebra a string em uma lista.
   - `Trim()` remove espaços antes e depois dos nomes.

3. **Leitura da letra de filtro:**
   - O usuário digita uma letra (ex: `a`), que será usada como base para filtragem.

4. **Filtragem dos nomes:**
   - Usa-se `StartsWith()` com `StringComparison.OrdinalIgnoreCase` para ignorar diferenças entre maiúsculas/minúsculas.
   - Os nomes válidos são armazenados na lista `filtrados`.

5. **Verificação e exibição:**
   - Se a lista `filtrados` estiver vazia → exibe: `"Nenhum nome encontrado"`.
   - Caso contrário → imprime os nomes filtrados, um por linha.

---

#### 📌 Exemplo 1

**Entrada:**
```

Ana, joao, Maria, arthur, miguel
a

```

**Saída:**
```

Ana
arthur

```

---

#### 📌 Exemplo 2

**Entrada:**
```

Joao, Pedro, Lucas
z

```

**Saída:**
```

Nenhum nome encontrado

```

---

#### 💡 Importante

- O filtro ignora se a letra é maiúscula ou minúscula.
- O `Trim()` é essencial para que espaços não prejudiquem a comparação.
- `StartsWith()` é ideal para verificar se um nome **começa** com determinada letra.

---

#### 🚀 Finalidade

Esses exercícios ajudam a praticar:
- Entrada de dados via console.
- Conversão de tipos (`string` → `int`).
- Manipulação de strings e listas.
- Uso de filtros e estruturas condicionais.

---

#### ✅ Resultado

```csharp

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string linhaDeNomes = Console.ReadLine();

        // Separa os nomes e remove espaços extras

        List<string> nomes = linhaDeNomes
            .Split(',')
            .Select(nome => nome.Trim())
            .ToList();

        char letraFiltro = char.Parse(Console.ReadLine());

        // Filtro abaixo:
        
        var filtrados = nomes
        
        .Where(nome => nome.StartsWith(letraFiltro.ToString(), StringComparison.OrdinalIgnoreCase))
        
        .ToList();

        // TODO: Resultado: 
        

        
        else
        {
            foreach (var nome in filtrados)
            {
                Console.WriteLine(nome);
            }
        }
    }
}

```

---

##### Seção criada por: *Fabio Zanneti - Projeto: WEX - End to End Engineering* - Guia de estudos.