# 🚗 Sistema de Estacionamento com C# (.NET)

### 📘 Visão Geral do Projeto

#### 🎯 Objetivo

Desenvolver um sistema console simples, porém estruturado, para gerenciar a entrada e saída de veículos em um estacionamento. O sistema permitirá:

* Cadastro de veículos
* Remoção (saída) de veículos
* Cálculo de tempo estacionado e valor a pagar
* Listagem de veículos presentes

---

#### 🧱 Arquitetura e Organização

> Esse projeto será criado com base nos princípios de **boas práticas**, separação de responsabilidades e foco em legibilidade e manutenção.

```
/Estacionamento
│
├── /Estacionamento                          # Diretório principal do projeto
│   ├── Models                               # Contém as classes de domínio
│   │   └── Veiculo.cs
│   │
│   ├── Services                             # Contém a lógica de negócio
│   │   └── EstacionamentoService.cs
│   │
│   ├── Utils                                # Classes auxiliares (opcional)
│   │   └── ValidadorPlaca.cs
│   │
│   └── Program.cs                           # Ponto de entrada do programa
│
├── Estacionamento.sln                       # Solução do projeto
└── README.md                                # Descrição do projeto
```

---

#### 📋 Requisitos Funcionais

1. O sistema deve permitir registrar a entrada de um veículo.
2. O sistema deve permitir remover um veículo, solicitando a placa e calculando o valor a pagar.
3. O sistema deve exibir uma lista de veículos atualmente no estacionamento.
4. O sistema deve tratar erros como:

   * Placa não encontrada ao remover
   * Placa duplicada ao adicionar
   * Formato inválido de entrada
5. O sistema deve utilizar um modelo de valor fixo + valor por hora (ex: R\$ 5 fixo + R\$ 2 por hora).

---

#### 🧪 Requisitos Não Funcionais

* O sistema deve ser desenvolvido em C# com .NET 6 ou superior.
* O sistema deve rodar em modo console.
* O código deve ser modularizado.
* O código deve ser comentado e fácil de entender.

---

### 📦 Instalação e Execução

#### Pré-requisitos:

* [.NET 6 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
* Git

```bash
git clone https://github.com/seu-usuario/Estacionamento.git
cd Estacionamento
dotnet run
```

---

## 💡 Planejamento Inicial

### 💭 Casos de Uso

#### ✅ Entrada de Veículo

* Entrada do usuário: placa do veículo
* Validação da placa
* Armazenamento em uma lista com a hora de entrada

#### ✅ Saída de Veículo

* Entrada do usuário: placa
* Busca da placa na lista
* Cálculo de valor total
* Remoção da lista

#### ✅ Listagem

* Mostra todas as placas e horários de entrada

---

### 📚 Classes Planejadas

#### 🔹 `Veiculo.cs`

```csharp
public class Veiculo
{
    public string Placa { get; set; }
    public DateTime HoraEntrada { get; set; }

    public Veiculo(string placa)
    {
        Placa = placa;
        HoraEntrada = DateTime.Now;
    }
}
```

#### 🔹 `EstacionamentoService.cs`

```csharp
public class EstacionamentoService
{
    private decimal precoInicial = 5;
    private decimal precoPorHora = 2;
    private List<Veiculo> veiculos = new List<Veiculo>();

    public void AdicionarVeiculo(string placa) { /* lógica */ }
    public void RemoverVeiculo(string placa) { /* lógica */ }
    public void ListarVeiculos() { /* lógica */ }
}
```

#### 🔹 `ValidadorPlaca.cs` (Opcional)

```csharp
public static class ValidadorPlaca
{
    public static bool PlacaValida(string placa)
    {
        return Regex.IsMatch(placa, "^[A-Z]{3}-[0-9]{4}$");
    }
}
```

---

#### 💻 Interface no Console (`Program.cs`)

```csharp
while (true)
{
    Console.Clear();
    Console.WriteLine("Estacionamento WEX");
    Console.WriteLine("1 - Adicionar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Sair");
    Console.Write("Opção: ");

    var opcao = Console.ReadLine();
    switch(opcao)
    {
        case "1":
            // adicionar
            break;
        case "2":
            // remover
            break;
        case "3":
            // listar
            break;
        case "4":
            return;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar...");
    Console.ReadKey();
}
```

---

#### 🚀 Próximos passos

1. Criar repositório `Estacionamento`
2. Subir estrutura com `Program.cs`, `Models`, `Services`
3. Implementar classes com base nesse planejamento
4. Documentar cada parte com comentários
5. Refatorar se necessário

---

##### Seção criada por: *Fabio Zanneti - Projeto: WEX - End to End Engineering* - Guia de estudos.
