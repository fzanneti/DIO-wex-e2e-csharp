# **Introdução ao .NET**

---

A plataforma .NET, desenvolvida pela Microsoft, é um ambiente de desenvolvimento que permite criar aplicações para Windows, web, nuvem, mobile, e até IoT. Seu principal objetivo é fornecer uma base comum e unificada para o desenvolvimento em diferentes linguagens, com destaque para o C#.

---

### **Conceitos principais**

> - **.NET** é um ecossistema que inclui ferramentas, bibliotecas e runtime (tempo de execução).
> - É **multiplataforma:** roda no Windows, Linux e macOS.
> - Suporta várias linguagens como C#, F# e VB.NET.

---

### **Linha do tempo do .NET**

|Ano|Evento Importante|
|:---:|:---:|
|2002|Lançamento do .NET Framework 1.0|
|2016|Lançamento do .NET Core (cross-platform)|
|2020|Lançamento do .NET 5 (unificação)|
|2021|.NET 6 - Long Term Support (LTS)|
|2022|.NET 7 (performance e APIs)|
|2023|.NET 8 (atualização contínua)|

---

### **Conclusão**

O .NET passou de um framework limitado ao Windows para uma plataforma poderosa e multiplataforma, ideal para aplicações modernas.

---

## **Diferença entre .NET Framework e .NET (Core/5+)**

### **.NET Framework**

> - Criado em 2002.
> - Suporte apenas para Windows.
> - Usado principalmente em aplicações desktop corporativas e ASP.NET Web Forms.

---

### **.NET Core / .NET (5 e superior)**

> - Multiplataforma.
> - Código aberto (open-source).
> - Melhor performance.
> - Suporte ativo da comunidade.

---

### **Tabela Comparativa**

|Recurso|.NET Framework|.NET Core / .NET 5+|
|:---:|:---:|:---:|
|Multiplataforma|Não|Sim|
|Open Source|Parcial|Sim|
|Performance|Regular|Alta|
|Suporte Moderno|Limitado|Ativo|
|Longevidade|Manutenção|Futuro da plataforma|

---

### **Conclusão**

Se você está começando hoje, foque no **.NET 6** ou superior. O .NET Framework ainda é usado, mas não receberá mais evoluções significativas. Ele permanece em modo de manutenção, ou seja:

> - Recebe atualizações de segurança e correções críticas.
> - Não receberá novos recursos ou grandes melhorias de performance.
> - Continua sendo suportado em sistemas Windows que dependem de aplicações legadas.

A Microsoft incentiva a migração para o .NET 6+ (ou superior), que é o futuro da plataforma. O .NET moderno é multiplataforma, open source, com melhor performance e mais recursos.

💡 Resumo: o .NET Framework ainda é necessário para sistemas antigos, mas novos projetos devem usar o .NET atual (.NET 6, 7, 8...).

---

## **Compiladores e Transpiladores no .NET**

### **Conceitos**

> - **Compilador:** transforma o código-fonte em código intermediário (CIL - Common Intermediate Language).
> - **CLR (Common Language Runtime):** executa o CIL em tempo de execução.
> - **Transpilador:** converte código de uma linguagem para outra com comportamento semelhante (menos comum em .NET, mas usado para interoperabilidade).

## **Funcionamento do Compilador .NET**

1. Você escreve código em C#.
2. O compilador converte esse código em **CIL**.
3. O **CLR** interpreta e executa esse código CIL na máquina.

---

```~~~c#

// Exemplo simples em C#

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Olá, mundo!");
    }
}

```

Esse código será transformado em CIL e executado pelo CLR.

---

## **Conclusão**

O sistema de compilação do .NET permite portabilidade, segurança e performance ao transformar código C# em um formato intermediário executável em diferentes sistemas.

---

## **Materiais Complementares**

Documentação oficial: https://learn.microsoft.com/pt-br/dotnet/
Livro gratuito da Microsoft: https://docs.microsoft.com/dotnet/standard/
Canal do YouTube da DIO: https://www.youtube.com/@digitalinnovationone

> ###### **Seção criada por:** *Fabio Zanneti - Projeto: WEX - End to End Engineering* - Guia de estudos.