# 🏨 Projeto: Sistema de Hospedagem em Hotelaria em C#

Este projeto é um sistema simples de hospedagem desenvolvido em **C#** com fins educacionais, fazendo parte do portfólio de estudos de Fabio Zanneti. O objetivo é aplicar conceitos essenciais da linguagem em um cenário prático, simulando a operação de um sistema de reservas de hotel.

---

#### 🎯 Objetivo

Permitir o **cadastro de hóspedes**, **suítes**, e **reservas** com controle de:

- Capacidade da suíte
- Valor da diária
- Cálculo de valor total com desconto por tempo de estadia
- Validação de regras
- Exceções personalizadas
- Interação via menu de terminal

---

#### 🛠️ Funcionalidades implementadas

- Cadastro de hóspedes via menu interativo
- Cadastro de suítes
- Criação de reservas com base em hóspedes e suítes
- Verificação da quantidade de hóspedes compatível com a suíte
- Cálculo automático do valor da estadia
- **Desconto de 10%** aplicado automaticamente em reservas com **10 ou mais diárias**
- Visualização de todos os dados cadastrados
- Uso de coleções `Dictionary` para armazenar as entidades
- Tratamento de exceções com mensagens claras para o usuário

---

#### 📦 Estrutura do projeto

```

ProjetoHospedagemHotelaria/
├── Models/
│   ├── Pessoa.cs
│   ├── Suite.cs
│   └── Reserva.cs
├── Program.cs
└── README.md

````

---

### 📌 Classes e Propriedades

#### 👤 Pessoa
```csharp
string Nome
string Sobrenome
````

#### 🛏️ Suite

```csharp
string TipoSuite
int Capacidade
decimal ValorDiaria
```

#### 📄 Reserva

```csharp
List<Pessoa> Hospedes
Suite Suite
int DiasReservados

void CadastrarHospedes(List<Pessoa> hospedes)
void CadastrarSuite(Suite suite)
int ObterQuantidadeHospedes()
decimal CalcularValorDiaria()
```

---

#### 🧮 Regras de negócio

* A quantidade de hóspedes **não pode exceder** a capacidade da suíte.
* Reservas com **10 dias ou mais** recebem **10% de desconto** no valor total.
* Todos os dados são armazenados temporariamente em coleções (`Dictionary<string, T>`), simulando um pequeno banco de dados em memória.
* Exceções são lançadas e tratadas para proteger o sistema contra entradas inválidas.

---

#### 📲 Menu Interativo

O sistema exibe um menu com as seguintes opções:

1. Cadastrar hóspede
2. Cadastrar suíte
3. Criar reserva
4. Visualizar todos os dados cadastrados
5. Sair

O fluxo é controlado no `Program.cs`.

---

#### 🧠 Aprendizados aplicados

* Fundamentos da Programação Orientada a Objetos (POO)
* Classes, objetos, métodos e encapsulamento
* Estruturas de repetição e decisão
* Manipulação de listas e dicionários
* Tratamento de exceções
* Estruturação de projeto em camadas
* Interação via terminal

---

#### 🚀 Como executar o projeto

1. Clone o repositório:

```bash
git clone https://github.com/seuusuario/ProjetoHospedagemHotelaria.git
```

2. Navegue até a pasta:

```bash
cd ProjetoHospedagemHotelaria
```

3. Execute:

```bash
dotnet run
```

---

##### Seção criada por: *Fabio Zanneti - Projeto: WEX - End to End Engineering* - Guia de estudos.