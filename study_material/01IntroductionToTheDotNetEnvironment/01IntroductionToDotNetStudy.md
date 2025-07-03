# 🚀 Introdução ao .NET

A plataforma **.NET**, desenvolvida pela **Microsoft**, é um ambiente robusto e versátil que permite criar aplicações para **Windows**, **Web**, **Cloud**, **Mobile**, e até **IoT**.

Seu foco principal é oferecer uma base unificada e moderna para desenvolvimento em diversas linguagens — com destaque para o **C#**.

![GitHub repo size](https://img.shields.io/github/repo-size/fzanneti/wex-e2e-csharp)
![GitHub forks](https://img.shields.io/github/forks/fzanneti/wex-e2e-csharp?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/fzanneti/wex-e2e-csharp?style=social)
![Linguagem](https://img.shields.io/badge/Linguagem-CSharp-blue)
![Bootcamp](https://img.shields.io/badge/WEX-End--to--End%20Engineering-blueviolet?logo=vercel&logoColor=white)
![Plataforma](https://img.shields.io/badge/Powered%20by-DIO.io-red?logo=data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjZmZmIiB2aWV3Qm94PSIwIDAgMzIgMzIiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PHBhdGggZD0iTTYuNzEgMy4yNWMtMi44OCAxLjQxLTUuMDcgNC4yMy01LjA3IDcuNzYgMCAzLjU4IDIuMjggNi43IDUuMzMgOC4xNSAxLjgzLS42MiAyLjQtMi4yNiAyLjQtMy44MSAwLS4yMy0uMDItLjQ1LS4wNS0uNjZBLjQ0LjQ0IDAgMDExMC4xIDExYy4yNC0uNzUuMTEtMS41My0uMy0yLjIyQzguOTIgNy45NiA3LjMzIDcuNSA1Ljc0IDcuNjZhNS41NSA1LjU1IDAgM)
![Autor](https://img.shields.io/badge/Autor-fzanneti-blue?style=flat-square&logo=github)

---

### 🧠 Conceitos Principais

- 🧰 **.NET** é um ecossistema completo: inclui ferramentas, bibliotecas e o tempo de execução (**runtime**).
- 🖥️ **Multiplataforma**: roda no Windows, Linux e macOS.
- 🔤 Suporte a várias linguagens: **C#**, **F#**, **VB.NET**.

---

### 📅 Linha do Tempo do .NET

| 🗓️ Ano | 📌 Evento Importante |
|:------:|----------------------|
| 2002   | Lançamento do .NET Framework 1.0 |
| 2016   | Lançamento do .NET Core (cross-platform) |
| 2020   | Lançamento do .NET 5 (unificação) |
| 2021   | .NET 6 - Long Term Support (LTS) |
| 2022   | .NET 7 (melhorias de performance e APIs) |
| 2023   | .NET 8 (atualização contínua) |

---

#### **Conclusão**

O .NET passou de um framework limitado ao Windows para uma plataforma poderosa e multiplataforma, ideal para aplicações modernas.

---

## ⚖️ Comparando: .NET Framework vs .NET (Core/5+)

### 🏢 .NET Framework

- 🗂️ Lançado em **2002**.
- 🪟 Suporte apenas a sistemas **Windows**.
- 💼 Muito usado em sistemas corporativos e aplicações **legadas**.

---

### 🌐 .NET Core / .NET 5+

- 🧭 **Multiplataforma**.
- 🔓 **Open Source**.
- 🚀 Alta performance.
- 💬 Suporte ativo da comunidade.

---

### 📊 Tabela Comparativa

| Recurso            | .NET Framework | .NET Core / .NET 5+ |
|--------------------|----------------|----------------------|
| Multiplataforma    | ❌ Não         | ✅ Sim               |
| Código Aberto      | ⚠️ Parcial     | ✅ Sim               |
| Performance        | 🟡 Regular      | 🟢 Alta              |
| Suporte Moderno    | 🔴 Limitado     | ✅ Ativo             |
| Longevidade        | 🛠️ Manutenção   | 🌟 Futuro da Plataforma |

> 💡 **Resumo**: Use o **.NET 6 ou superior** para novos projetos. O .NET Framework continua sendo usado para sistemas legados, mas está em modo de manutenção.

---

#### ✅ **Conclusão**

Se você está começando hoje, foque no **.NET 6** ou superior. O .NET Framework ainda é usado, mas não receberá mais evoluções significativas. Ele permanece em modo de manutenção, ou seja:

- Recebe atualizações de segurança e correções críticas.
- Não receberá novos recursos ou grandes melhorias de performance.
- Continua sendo suportado em sistemas Windows que dependem de aplicações legadas.

A Microsoft incentiva a migração para o .NET 6+ (ou superior), que é o futuro da plataforma. O .NET moderno é multiplataforma, open source, com melhor performance e mais recursos.

💡 Resumo: o .NET Framework ainda é necessário para sistemas antigos, mas novos projetos devem usar o .NET atual (.NET 6, 7, 8...).

---

## 🛠️ Compiladores e Transpiladores no .NET

### 📚 Conceitos

- 🧮 **Compilador**: transforma código C# em **CIL** (*Common Intermediate Language*).
- 🔁 **CLR** (*Common Language Runtime*): executa o código CIL no sistema.
- 🔄 **Transpilador**: converte código de uma linguagem para outra. (Menos comum no .NET, mas útil para interoperabilidade.)

---

### 🔧 Como funciona o compilador .NET

1. Você escreve código em C#.
2. O compilador converte esse código em **CIL**.
3. O **CLR** interpreta e executa esse código CIL na máquina.

``` csharp

// Exemplo básico em C#
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Olá, mundo!");
    }
}

```

> 🧪 Esse código é compilado para **CIL** e executado pelo **CLR** na plataforma destino.

---

#### ✅ Conclusão

O sistema de compilação do .NET fornece:

* 🔒 **Segurança**
* 📦 **Portabilidade**
* ⚡ **Performance**

Com isso, você pode escrever em C# e rodar sua aplicação em diversos sistemas com eficiência.

---

#### 📚 Materiais Complementares

* 📘 [Documentação oficial da Microsoft](https://learn.microsoft.com/pt-br/dotnet/)
* 📖 [Livro gratuito da Microsoft](https://docs.microsoft.com/dotnet/standard/)

---

##### ✍️ Seção criada por: *Fabio Zanneti* - 🎯 Projeto: **WEX - End to End Engineering**
