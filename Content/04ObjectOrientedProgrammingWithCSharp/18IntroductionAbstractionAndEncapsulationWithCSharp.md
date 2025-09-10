# 📚 Introdução, Abstração e Encapsulamento em C#

No Bootcamp WEX, você está aprendendo C#, .NET, Git e GitHub. **Abstração** e **encapsulamento** são pilares da POO que organizam e protegem o código. Este módulo explora como modelar entidades e proteger dados.

![GitHub repo size](https://img.shields.io/github/repo-size/fzanneti/wex-e2e-csharp)
![GitHub forks](https://img.shields.io/github/forks/fzanneti/wex-e2e-csharp?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/fzanneti/wex-e2e-csharp?style=social)
![Linguagem](https://img.shields.io/badge/Linguagem-CSharp-blue)
![Bootcamp](https://img.shields.io/badge/WEX-End--to--End%20Engineering-blueviolet?logo=vercel&logoColor=white)
![Plataforma](https://img.shields.io/badge/Powered%20by-DIO.io-red?logo=data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjZmZmIiB2aWV3Qm94PSIwIDAgMzIgMzIiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PHBhdGggZD0iTTYuNzEgMy4yNWMtMi44OCAxLjQxLTUuMDcgNC4yMy01LjA3IDcuNzYgMCAzLjU4IDIuMjggNi43IDUuMzMgOC4xNSAxLjgzLS42MiAyLjQtMi4yNiAyLjQtMy44MSAwLS4yMy0uMDItLjQ1LS4wNS0uNjZBLjQ0LjQ0IDAgMDExMC4xIDExYy4yNC0uNzUuMTEtMS41My0uMy0yLjIyQzguOTIgNy45NiA3LjMzIDcuNSA1Ljc0IDcuNjZhNS41NSA1LjU1IDAgM)
![Autor](https://img.shields.io/badge/Autor-fzanneti-blue?style=flat-square&logo=github)

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

### 📚 Documentação Oficial da Microsoft

- [Programação Orientada a Objetos – C# Microsoft Learn](https://learn.microsoft.com/pt-br/dotnet/csharp/fundamentals/tutorials/oop)
- [Modificadores de Acesso – private, public, protected](https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers)
- [Propriedades em C# (`get`, `set`)](https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/using-properties)

---

#### ✅ Conclusão

Abstração e Encapsulamento são **fundamentos essenciais** para qualquer desenvolvedor que deseja escrever **código limpo, seguro e reutilizável**.

Estes conceitos estão presentes no dia a dia de qualquer sistema orientado a objetos, seja em pequenos projetos ou grandes aplicações empresariais.

Use abstração para modelar entidades e encapsulamento para proteger dados. Continue praticando!

---

##### ✍️ Seção criada por: *Fabio Zanneti* - 🎯 Bootcamp: **WEX - End to End Engineering**
[![GitHub](https://img.shields.io/badge/GitHub-fzanneti-181717?style=flat&logo=github)](https://github.com/fzanneti)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-fzanneti-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/fzanneti)