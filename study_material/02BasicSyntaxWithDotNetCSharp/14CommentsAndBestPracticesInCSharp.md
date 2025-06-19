# 📝 Comentários e Boas Práticas em C#

Este módulo tem como objetivo apresentar o uso correto dos comentários em C#, reforçando a importância da **documentação interna do código** e as **boas práticas de legibilidade e manutenção**.

---

### ✍️ Introdução aos Comentários

Comentários são trechos ignorados pelo compilador, usados para:

- Explicar trechos complexos de código
- Documentar intenções ou lógica
- Marcar pontos de atenção
- Criar documentação automatizada (em ferramentas como o XML Docs)

> 🧠 Comentário bom é aquele que realmente **ajuda a entender o "porquê" do código**, e não apenas repetir o que ele já faz.

---

### 💬 Comentário de Linha Única

Para comentários simples, use `//`:

```csharp

int idade = 30; // idade do usuário

```

Use-os para **resumos rápidos** ou **explicações pontuais**.

---

### 🧾 Comentário de Múltiplas Linhas

Quando precisar explicar com mais detalhes:

```csharp

/*
 Este bloco realiza o cálculo do
 desconto progressivo com base
 no valor total da compra.
*/
double desconto = CalculaDesconto(totalCompra);

```

Pode ser útil para **ocultar temporariamente** trechos de código durante testes:

```csharp

/*
Console.WriteLine("Teste de saída");
Console.WriteLine("Outro teste");
*/

```

---

### 🏷️ Comentando Nossas Classes

É importante documentar o propósito das classes e sua responsabilidade:

```csharp

/// <summary>
/// Representa um aluno com nome, idade e matrícula.
/// </summary>
public class Aluno
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}

```

Essa abordagem permite a geração de documentação XML e integração com ferramentas como o IntelliSense.

---

### 🧪 Comentários nos Métodos

Documente o comportamento e parâmetros dos métodos:

```csharp

/// <summary>
/// Calcula o valor total com desconto.
/// </summary>
/// <param name="valor">Valor base do produto.</param>
/// <param name="porcentagem">Porcentagem de desconto aplicada.</param>
/// <returns>Valor final com desconto.</returns>
public double CalcularDesconto(double valor, double porcentagem)
{
    return valor - (valor * porcentagem / 100);
}

```

💡 Utilize sempre que criar **métodos públicos ou complexos**, mesmo que sejam simples hoje — isso ajuda quem vai manter o código no futuro (inclusive você mesmo).

---

#### ✅ Considerações Finais

- 🟢 **Use comentários com moderação**. Um código bem escrito deve ser, por si só, fácil de entender.
- 🔵 **Comente intenções, não implementações óbvias**.
- 🟡 **Evite comentários desatualizados**, eles são mais prejudiciais do que não comentar.
- 🔴 **Nunca use comentários para justificar "gambiarras"** — o ideal é refatorar.

---

### 📌 Dica de Boas Práticas

| Boa Prática                                 | Evite                                  |
| ------------------------------------------- | -------------------------------------- |
| Comentários explicativos sobre decisões     | Comentários que explicam o óbvio       |
| Documentar APIs públicas                    | Comentários redundantes                |
| Comentar códigos temporários com TODO/FIXME | Comentários desatualizados ou confusos |

### Exemplo com `TODO` e `FIXME`:

```csharp

// TODO: Criar validação de CPF
// FIXME: Corrigir erro de arredondamento

```

---

Top demais, Fabio! Esse tema **“Comentários e Boas Práticas em C#”** é ouro pra mostrar que você escreve código limpo, organizado e fácil de entender — qualidade que todo recrutador ou dev experiente valoriza.

Segue o material em `.md`, pronto pra ser colado no seu repositório no GitHub.

---

### 🔗 **Comentários e Boas Práticas em C#**

````md
## 💬 Comentários e Boas Práticas em C#

Comentários bem usados tornam o código mais legível, explicam decisões e facilitam a manutenção. Mas cuidado: excesso ou uso errado pode atrapalhar mais do que ajudar.

---

### 🗒️ Tipos de Comentários em C#

#### ✅ Comentário de Linha
```csharp
// Isso é um comentário de linha
int idade = 30; // Armazena a idade da pessoa
````

#### ✅ Comentário de Bloco

```csharp
/*
Esse é um comentário de bloco.
Pode ocupar múltiplas linhas.
*/
```

#### ✅ Comentário de Documentação XML

Usado para gerar documentação automática.

```csharp
/// <summary>
/// Soma dois números inteiros
/// </summary>
/// <param name="a">Primeiro número</param>
/// <param name="b">Segundo número</param>
/// <returns>Soma dos dois números</returns>
public int Somar(int a, int b)
{
    return a + b;
}
```

---

## 📚 Material de apoio

### 🎓 Vídeos e Aulas Gratuitas

* [Boas práticas de código em C# – Balta.io](https://www.youtube.com/watch?v=GS5jFfwQ5yI)
* [Dicas de comentários e organização – DevAprender](https://www.youtube.com/watch?v=wuDnAtdzWgc)
* [Código limpo com C# – CFBCursos](https://www.youtube.com/watch?v=l1xWXFDw7bw)

---

### 📚 Leitura Complementar

* [Guia de Estilo para C# – Microsoft](https://learn.microsoft.com/pt-br/dotnet/csharp/fundamentals/coding-style/coding-conventions)
* [Clean Code com C# – Medium](https://medium.com/@danieloliveira/clean-code-com-c-dicas-pr%C3%A1ticas-6ffb2c275f7a)
* [Boas práticas de desenvolvimento – Alura](https://www.alura.com.br/artigos/boas-praticas-codigo-limpo)

---

##### ✍️ **Seção criada por:** *Fabio Zanneti* 🎯 Projeto: **WEX - End to End Engineering**
