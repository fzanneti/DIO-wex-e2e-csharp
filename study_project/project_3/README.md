# 📱 Desafio: Programação Orientada a Objetos com .NET

**Plataforma:** [DIO - Digital Innovation One](https://www.dio.me/)  
**Trilha:** .NET Developer – WEX - End to End Engineering  
**Módulo:** Programação Orientada a Objetos  
**Desafio:** Abstração de um sistema de celulares utilizando orientação a objetos (POO)

---

### 📋 Descrição do Desafio

Neste projeto, o objetivo é aplicar os fundamentos da Programação Orientada a Objetos (POO) em .NET, utilizando conceitos como **abstração**, **herança** e **polimorfismo**.

O desafio consiste em desenvolver um sistema de console que simula o funcionamento básico de celulares, modelando diferentes marcas e seus comportamentos específicos.

---

### 🧩 Requisitos Técnicos

- A classe `Smartphone` deve ser **abstrata** e servir como modelo base para os demais celulares.
- As classes `Nokia` e `Iphone` devem **herdar** da classe `Smartphone`.
- O método `InstalarAplicativo` deve ser **sobrescrito** em cada uma das subclasses (`Nokia` e `Iphone`), simulando diferentes formas de instalação.

---

### 🛠️ Estrutura de Classes

```

Smartphone (abstrata)
│
├──> Nokia : Smartphone
│     └──> Sobrescreve o método InstalarAplicativo
│
└──> Iphone : Smartphone
└──> Sobrescreve o método InstalarAplicativo

```

---

### 💻 Tecnologias Utilizadas

- [.NET 6.0 ou superior](https://dotnet.microsoft.com/download)
- C#
- Programação orientada a objetos (POO)
- Console Application

---

### ▶️ Como Executar

1. Clone o repositório:

```bash

git clone https://github.com/fzanneti/wex_e2e_csharp/blob/main/study_project/project_3

```

2. Acesse o diretório do projeto:

```bash

cd nome-do-projeto

```

3. Compile e execute:

```bash

dotnet build
dotnet run

```

---

### ✅ Funcionalidades Implementadas

* Criação de uma instância do `Nokia` e do `Iphone`
* Chamada dos métodos:

  * `Ligar()`
  * `ReceberLigacao()`
  * `InstalarAplicativo(string nome)`

---

### 🧠 Conceitos Trabalhados

* Abstração
* Herança
* Polimorfismo
* Classes e Métodos
* Sobrescrita de métodos (`override`)
* Encapsulamento

---

### 📌 Observações

O código original fornecido pela DIO estava incompleto, com marcações `// TODO`. A proposta foi completada conforme as regras exigidas no enunciado e está disponível neste repositório.

---

##### ✍️ **Criado por:** *Fabio Zanneti* 🎯 Projeto: **WEX - End to End Engineering*