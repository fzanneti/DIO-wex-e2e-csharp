# 📚 Introdução, Abstração e Encapsulamento em C#

Este material tem como objetivo apresentar, de forma objetiva e prática, os conceitos fundamentais de Programação Orientada a Objetos (POO) com foco em **abstração** e **encapsulamento** utilizando a linguagem **C#**.

---

### 🧭 Introdução

Com a crescente complexidade dos sistemas, técnicas que organizam o código e o tornam mais legível, reutilizável e fácil de manter são essenciais.  
A Programação Orientada a Objetos (POO) é um paradigma que visa modelar o software baseado em "objetos" do mundo real.

---

### 🧠 Introdução à Programação Orientada a Objetos (POO)

A POO permite que o código seja organizado em **classes**, que são moldes para **objetos**. Cada objeto encapsula **dados** (atributos) e **comportamentos** (métodos).

### 🧱 Pilares da POO

1. **Abstração** – foca no que é essencial, omitindo detalhes desnecessários.
2. **Encapsulamento** – protege os dados internos de acesso direto e não autorizado.
3. **Herança** – permite reutilizar código através de hierarquias entre classes.
4. **Polimorfismo** – permite tratar objetos de diferentes tipos de forma uniforme.

---

### 🧬 Tipos de Paradigmas de Programação

| Paradigma           | Característica Principal                                  |
|---------------------|-----------------------------------------------------------|
| Procedural          | Código executado passo a passo com funções e variáveis.  |
| Funcional           | Usa funções puras e evita o estado compartilhado.        |
| Orientado a Objetos | Estrutura o código em classes e objetos.                 |
| Declarativo         | Especifica o que deve ser feito, e não como.             |

---

### 🧩 Introdução à Abstração

**Abstração** é o processo de representar entidades do mundo real com classes, focando apenas nos **atributos** e **comportamentos essenciais**.

📌 **Exemplo real:** Um sistema de hotel precisa de hóspedes, suítes e reservas.  
Você não precisa modelar o RG do hóspede ou a cor das cortinas da suíte, apenas os dados relevantes para o sistema.

---

### 🛠️ Abstração na prática (C#)

```csharp

public class Hospede
{
    public string Nome { get; set; }
    public string Sobrenome { get; set; }

    public string NomeCompleto()
    {
        return $"{Nome} {Sobrenome}";
    }
}

```

👉 Aqui abstraímos um hóspede com apenas **nome** e **sobrenome**, o suficiente para identificar no contexto do sistema.

---

### 🧱 Introdução ao Encapsulamento

**Encapsulamento** significa **ocultar os detalhes internos** de implementação e expor apenas o necessário.
A ideia é proteger os dados e garantir que sejam acessados ou modificados apenas por métodos controlados.

📌 Proteção + organização = menos bugs + código limpo.

---

### 🔐 Encapsulamento na prática (C#)

```csharp

public class ContaBancaria
{
    private decimal saldo;

    public void Depositar(decimal valor)
    {
        if (valor > 0)
        {
            saldo += valor;
        }
    }

    public decimal ConsultarSaldo()
    {
        return saldo;
    }
}

```

✅ A variável `saldo` está protegida (privada), e só pode ser alterada através dos métodos `Depositar` e `ConsultarSaldo`.

---

## 🎯 Links Complementares de Estudo – Introdução, Abstração e Encapsulamento em C#

Os pilares da Programação Orientada a Objetos (POO) começam com:
- **Introdução à POO**
- **Abstração**
- **Encapsulamento**

Dominar esses conceitos permite criar sistemas mais seguros, organizados e reutilizáveis. Aqui estão conteúdos gratuitos e objetivos para aprofundar nesses fundamentos usando C#:

### 🎓 Aulas e Cursos Gratuitos

- [POO em C# – Introdução e Conceitos (Balta.io)](https://www.youtube.com/watch?v=KhzGSHNhnbI)
- [Abstração e Encapsulamento – CFBCursos (YouTube)](https://www.youtube.com/watch?v=Da0RtgZsMQs)
- [Curso POO Completo – DevAprender](https://www.youtube.com/watch?v=JLf9qU9KKuk)

### 📚 Documentação Oficial da Microsoft

- [Programação Orientada a Objetos – C# Microsoft Learn](https://learn.microsoft.com/pt-br/dotnet/csharp/fundamentals/tutorials/oop)
- [Modificadores de Acesso – private, public, protected](https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers)
- [Propriedades em C# (`get`, `set`)](https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/using-properties)

### 🧠 Artigos Técnicos e Explicações

- [POO em C# – Entendendo Abstração e Encapsulamento (DevMedia)](https://www.devmedia.com.br/poo-em-c-introducao-a-encapsulamento-e-abstracao/18801)
- [Encapsulamento e Abstração: Diferenças e Aplicações – TreinaWeb](https://www.treinaweb.com.br/blog/entendendo-o-encapsulamento-e-a-abstracao-na-orientacao-a-objetos)
- [Diferença entre Abstração e Encapsulamento (Medium)](https://medium.com/@wilsonneto/entendendo-a-diferen%C3%A7a-entre-abstra%C3%A7%C3%A3o-e-encapsulamento-6f1438a09f29)

---

#### ✅ Conclusão

Abstração e Encapsulamento são **fundamentos essenciais** para qualquer desenvolvedor que deseja escrever **código limpo, seguro e reutilizável**.

Estes conceitos estão presentes no dia a dia de qualquer sistema orientado a objetos, seja em pequenos projetos ou grandes aplicações empresariais.

---

##### ✍️ **Seção criada por:** *Fabio Zanneti* 🎯 Projeto: **WEX - End to End Engineering**
