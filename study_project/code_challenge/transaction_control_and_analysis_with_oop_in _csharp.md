# 💳 Desafio: Controle de Despesas com Cartão Corporativo (DIO .NET)

#### 📘 Descrição

Este projeto foi desenvolvido como parte de um desafio da plataforma [DIO](https://www.dio.me/) na trilha .NET. O objetivo é simular um sistema de controle de despesas de um cartão corporativo, utilizando lógica de programação básica e conceitos fundamentais de orientação a objetos.

---

#### 🎯 Objetivo

Complementar um programa em C# que:

- Leia o **limite do cartão corporativo**.
- Leia a **quantidade de transações** realizadas no mês.
- Leia os **valores das transações**.
- Calcule o total gasto.
- Informe se o limite foi **ultrapassado** ou se ainda está **dentro do permitido**.

---

## 🧠 Conceitos abordados

- Classes e objetos
- Encapsulamento
- Métodos e propriedades
- Coleções (`List`)
- Lógica condicional
- Formatação de saída

---

### 🖥️ Estrutura do Código

#### Classe `CartaoCorporativo`

```csharp

class CartaoCorporativo
{
    public decimal Limite { get; }
    public List<decimal> Transacoes { get; }

    public CartaoCorporativo(decimal limite);
    public void AdicionarTransacao(decimal valor);
    public decimal CalcularTotal();
    public bool UltrapassouLimite();
    public void ExibirResumo();
}

````

* `Limite`: valor máximo que pode ser gasto.
* `Transacoes`: lista que armazena os valores das compras.
* `AdicionarTransacao`: adiciona valores à lista.
* `CalcularTotal`: soma todos os valores da lista.
* `UltrapassouLimite`: verifica se o total excedeu o limite.
* `ExibirResumo`: mostra o total gasto e o status do limite.

---

#### 📥 Entradas esperadas

O programa recebe os seguintes dados via console:

1. Limite do cartão (decimal)
2. Quantidade de transações (inteiro)
3. Valores das transações (um por linha)

#### Exemplo:

```

1000.00
3
200.00
300.00
150.00

```

---

#### 📤 Saída esperada

A saída deve ser formatada exatamente como abaixo:

```

Total gasto: 650.00
Limite OK

```

Outro exemplo:

```

Total gasto: 900.00
Limite ultrapassado

```

---

#### ✅ Regras importantes

* A saída deve seguir **rigorosamente** o formato exigido (mesmo texto, letras maiúsculas e minúsculas e número com 2 casas decimais).
* Utilize `Console.ReadLine()` para capturar os dados de entrada.
* Formate valores com `decimal` usando `:F2` para garantir duas casas decimais.

---

### 🧪 Exemplos de teste

#### Entrada:

```

500.00
2
100.00
450.00

```

#### Saída:

```

Total gasto: 550.00
Limite ultrapassado

```

---

## 🚀 Aprendizado

Este exercício reforça:

* Leitura e escrita no console
* Manipulação de listas
* Uso de classes e métodos em C#
* Organização e clareza no código
* Atenção a detalhes no formato da saída (essencial em desafios de código)

---

# 🚨 Desafio: Analisador de Transações Suspeitas (DIO .NET)

#### 📋 Descrição

Este desafio tem como objetivo desenvolver um programa em C# que analisa as transações feitas em um cartão corporativo e identifica aquelas que ultrapassam um limite definido por transação — consideradas suspeitas.

O programa deve receber o limite individual, o número de transações, e os valores de cada uma. No final, exibe um relatório com o total e a quantidade de transações suspeitas, ou informa se nenhuma foi encontrada.

---

#### 🎯 Objetivo

- Armazenar transações financeiras em uma lista.
- Identificar quais transações ultrapassam o limite definido.
- Exibir um relatório detalhado das transações suspeitas.
- Tratar casos onde não há transações suspeitas.

---

#### 🧠 Conceitos trabalhados

- Criação e manipulação de classes e objetos.
- Uso de listas (`List<T>`).
- Filtragem de dados com LINQ (`Where`, `Sum`, `Count`).
- Condicional para tratamento de diferentes casos.
- Formatação de saída numérica com duas casas decimais.
- Entrada e saída padrão (Console).

---

### 📂 Estrutura do código

#### Classe `AnalisadorDeTransacoes`

- Propriedades:
  - `decimal Limite` — limite máximo por transação.
  - `List<decimal> Transacoes` — lista para armazenar transações.
- Métodos:
  - `AdicionarTransacao(decimal valor)` — adiciona uma transação à lista.
  - `ObterTransacoesSuspeitas()` — retorna as transações que ultrapassam o limite.
  - `ExibirRelatorio()` — exibe um relatório com total e quantidade de transações suspeitas, ou mensagem caso não haja suspeitas.

---

### 🖥️ Entrada e saída

#### Entrada

1. Limite por transação (decimal)
2. Quantidade de transações (inteiro)
3. Valores das transações (uma por linha)

#### Exemplo de entrada:

```

200.00
3
100.00
250.00
300.00

```

#### Saída esperada:

```

Total suspeito: 550.00
2 transacoes suspeitas

```

---

### 📥 Exemplo sem transações suspeitas

#### Entrada:

```

500.00
2
100.00
300.00

```

#### Saída:

```

Nenhuma transacao suspeita encontrada

```

---

#### 🚀 Passo a passo da solução

1. **Criar a classe `AnalisadorDeTransacoes`** com as propriedades `Limite` e `Transacoes`.
2. **No construtor**, inicializar o limite e criar a lista de transações.
3. **Adicionar método** para adicionar valores à lista de transações.
4. **Implementar método** para filtrar transações acima do limite usando LINQ.
5. **Implementar método de exibição** que:
   - Verifica se há transações suspeitas.
   - Caso não haja, exibe mensagem adequada.
   - Caso haja, calcula e exibe o total e a quantidade formatados corretamente.
6. **No programa principal**, ler as entradas do usuário, adicionar as transações e exibir o relatório.

---

## 📚 Referências

- Plataforma DIO: https://www.dio.me/
- Documentação C#: https://learn.microsoft.com/dotnet/csharp/

---

## 📝 Observações

- Atenção à formatação das mensagens e valores para passar no validador automático.
- Use sempre duas casas decimais nos valores monetários.
- Strings devem ser impressas exatamente como no enunciado, sem acentuação.

---

**Boa prática e bons estudos!** 💻🚀

---