# 🚗 Sistema de Estacionamento com C# (.NET)

### 📘 Visão Geral do Projeto

#### 🎯 Objetivo

Desenvolver um sistema console simples, porém estruturado, para gerenciar a entrada e saída de veículos em um estacionamento. O sistema permite:

- Cadastro de veículos
- Remoção (saída) de veículos com cálculo do tempo estacionado e valor a pagar
- Listagem de veículos presentes
- Alteração do preço inicial e do preço por hora
- Exibição da tabela de preços
- Exibição da lista de veículos ao solicitar a remoção

---

#### 🧱 Arquitetura e Organização

> O projeto segue princípios de boas práticas, com separação de responsabilidades, legibilidade e foco em manutenção. A estrutura é a seguinte:

/Estacionamento
│
├── /Estacionamento                         # Diretório principal do projeto
│   ├── Models                              # Contém as classes de domínio
│   │   └── Veiculo.cs
│   │
│   ├── Services                            # Contém a lógica de negócio
│   │   └── EstacionamentoService.cs
│   │
│   ├── Utils                               # Classes auxiliares (opcional, não implementado)
│   │   └── ValidadorPlaca.cs
│   │
│   └── Program.cs                          # Ponto de entrada do programa
│
├── Estacionamento.sln                      # Solução do projeto
├── Estacionamento.csproj                   # Arquivo de projeto especificando o .NET 9.0
└── README.md                               # Descrição do projeto

```

---

#### 📋 Requisitos Funcionais

- Registrar a entrada de um veículo com placa e hora de entrada.
- Remover um veículo pela placa, exibindo a lista de veículos estacionados antes da remoção, calculando o tempo estacionado e o valor a pagar.
- Exibir a lista de veículos atualmente no estacionamento.
- Alterar o preço inicial e o preço por hora, exibindo os valores anterior e atual.
- Exibir a tabela de preços com os valores atuais.
- Tratar erros, como:
  - Placa não encontrada ao remover.
  - Entrada inválida (ex.: valores não numéricos para preços).
- Utilizar um modelo de cobrança com valor fixo + valor por hora (ex.: R$ 5 fixo + R$ 2 por hora).

---

#### 🧪 Requisitos Não Funcionais

- Desenvolvido em C# com .NET 9.0.
- Interface em modo console com tela limpa após cada interação.
- Código modularizado com separação de responsabilidades.
- Código comentado e fácil de entender.
- Pausa após exibição de resultados para visualização antes de limpar a tela.

---

### 📦 Instalação e Execução

#### Pré-requisitos:

- .NET 9.0 SDK
- Git

```bash
git clone https://github.com/seu_usuario/wex_e2e_csharp/tree/main/study_project/project_1_building_a_parking_system_with_csharp
cd project_1_building_a_parking_system_with_csharp
dotnet run
```

---

## 💡 Planejamento Inicial

### 💭 Casos de Uso

1. **Entrada de Veículo**
   - Entrada: Placa do veículo.
   - Ação: Armazena a placa e a hora de entrada em uma lista.
2. **Saída de Veículo**
   - Entrada: Placa do veículo.
   - Ação: Exibe a lista de veículos, busca a placa, calcula o tempo estacionado e o valor total, remove o veículo da lista.
3. **Listagem de Veículos**
   - Ação: Exibe todas as placas e horários de entrada dos veículos estacionados.
4. **Alteração de Preços**
   - Entrada: Novo valor para preço inicial ou preço por hora.
   - Ação: Altera o valor, exibe o preço anterior e o atual, com validação para valores não negativos.
5. **Exibição da Tabela de Preços**
   - Ação: Mostra os valores atuais do preço inicial e preço por hora.

---

### 📚 Classes Implementadas
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
- Representa um veículo com placa e hora de entrada.

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
    public void AlterarPrecoInicial(decimal novoPreco) { /* lógica */ }
    public void AlterarPrecoPorHora(decimal novoPreco) { /* lógica */ }
    public void ExibirTabelaPrecos() { /* lógica */ }
}
```
- Gerencia a lógica de negócio, incluindo adição, remoção, listagem, alteração de preços e exibição da tabela de preços.

#### 🔹 `ValidadorPlaca.cs` (Opcional, não implementado)
- Planejado para validar formatos de placa (ex.: `^[A-Z]{3}-[0-9]{4}$`), mas não implementado na versão atual.

### 💻 Interface no Console (`Program.cs`)
- Exibe um menu com as opções:
  1. Adicionar Veículo
  2. Remover Veículo (exibe lista de veículos antes da remoção)
  3. Listar Veículos
  4. Alterar Preço Inicial
  5. Alterar Preço por Hora
  6. Exibir Tabela de Preços
  7. Sair
- Limpa a tela antes de cada menu ou interação (usando `Console.Clear()`).
- Pausa após cada ação (usando `Console.ReadKey()`) para permitir a visualização dos resultados.

### 🚀 Atualizações Recentes
- Atualizado o framework para .NET 9.0.
- Adicionada opção para alterar o preço inicial e preço por hora, com exibição dos valores anterior e atual.
- Implementada exibição da tabela de preços.
- Adicionada listagem de veículos ao selecionar a opção de remoção, facilitando a escolha da placa.
- Interface aprimorada com limpeza de tela antes de cada interação e pausa para visualização de resultados.

## 📈 Próximos Passos
- Implementar `ValidadorPlaca.cs` para validar formatos de placa.
- Adicionar tratamento de placas duplicadas ao adicionar veículos.
- Refatorar para suportar persistência de dados (ex.: salvar em arquivo).
- Adicionar testes unitários para validar a lógica de negócio.
- Melhorar a interface do console com formatação avançada (ex.: cores ou tabelas).

**Seção criada por: Fabio Zanneti - Projeto: WEX - End to End Engineering - Guia de estudos.**