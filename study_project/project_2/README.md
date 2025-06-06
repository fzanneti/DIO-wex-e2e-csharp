# 🧠 WEX End-to-End Engineering | Sistema de Hospedagem em .NET com C#

**Repositório educacional criado para consolidar o aprendizado da plataforma .NET com C#, baseado no curso _WEX - End to End Engineering_ da [Digitaliza](https://www.digitaliza.com.br). Este projeto combina prática e teoria, demonstrando o uso de coleções `List` e `Dictionary` em um sistema de gerenciamento de hotel.**

---

#### 📚 Conteúdo

Este repositório apresenta o projeto **HotelSystem**, um aplicativo console em C# que gerencia hospedagens, suítes e reservas, com opção de usar `List` ou `Dictionary`. O conteúdo é organizado em módulos de aprendizado, com exemplos práticos e explicações.

---

#### ✅ Fundamentos do .NET e C#

- **Plataforma .NET**: Introdução ao .NET 6.0, CLR, e compilação JIT.
- **C#**: Tipagem forte, sintaxe moderna, e integração com .NET.
- **Estrutura do Projeto**: Uso de namespaces, classes, e interfaces.
- **Exemplo**:

  ```csharp
  CultureInfo.CurrentCulture = new CultureInfo("pt-BR"); // Define formatação brasileira
  Console.WriteLine(500.50m.ToString("C")); // Saída: R$ 500,50
  ```

---

- **Tabela de Comparação**:
  | Recurso          | .NET Framework | .NET 6.0       |
  |------------------|----------------|----------------|
  | Plataforma       | Apenas Windows | Cross-platform |
  | Performance      | Boa            | Otimizada      |
  | Suporte          | Até 2026     | Longo prazo    |

---

- **Links**: [Documentação .NET](https://learn.microsoft.com/dotnet), [História do C#](https://learn.microsoft.com/csharp/tour-of-csharp).

---

#### 🧪 Sintaxe e Lógica de Programação

- **Variáveis e Tipos**:

  ```csharp
  int id = 1;
  string nome = "João";
  decimal preco = 450.00m;
  ```

- **Condicionais**:

  ```csharp
  if (dias >= 10)
      custo *= 0.9m; // Aplica desconto
  ```

- **Laços**:

  ```csharp
  foreach (var h in hospedes)
      Console.WriteLine(h.ToString());
  ```

- **Métodos**:

  ```csharp
  private decimal CalcularCusto()
  {
      decimal custo = Dias * Suite.PrecDiaria;
      return Dias >= 10 ? custo * 0.9m : custo;
  }
  ```

- **Aplicação**: O menu interativo usa `switch` para navegar pelas opções, e validações garantem entradas seguras.

---

#### 🏗️ Programação Orientada a Objetos

- **Classes**:

  - `Hospede`: Armazena ID, Nome, Sobrenome.
  - `Suite`: Inclui ID, Nome, Preço Diária, Capacidade, Disponibilidade.
  - `Reserva`: Gerencia ID, Hóspede, Suíte, Dias, Custo Total.
  - `IHotelRepository`: Interface para abstrair acesso a dados.

- **Exemplo**:

  ```csharp
  public class Hospede
  {
      public int Id { get; set; }
      public string Nome { get; set; }
      public string Sobrenome { get; set; }
      public Hospede(int id, string nome, string sobrenome)
      {
          Id = id;
          Nome = nome;
          Sobrenome = sobrenome;
      }
  }
  ```

- **Herança/Interfaces**: Uso de `IHotelRepository` para suportar `List` e `Dictionary`.
- **Encapsulamento**: Propriedades com validação no construtor.

---

#### 📌 Manipulando Valores com C#

- **Formatação Monetária**:

  ```csharp
  Console.WriteLine(s.PrecioDiaria.ToString("C2", new CultureInfo("pt-BR"))); // Saída: R$450,00
  ```

- **Validação de Entradas**:

  ```csharp
  if (!int.TryParse(Console.ReadLine(), out int id))
      throw new ArgumentException("ID inválido.");
  ```

- **Cultura**:

  ```csharp
  CultureInfo cultura = new CultureInfo("pt-BR");
  Console.WriteLine(custo.ToString("C2", cultura)); // Saída: R$2250,00
  ```

- **Aplicação**: Preços formatados em reais, validação de números inteiros e decimais.

---

#### ❗ Tratamento de Exceções

- **Bloco `try-catch`**:

  ```csharp
  try
  {
      if (!int.TryParse(Console.ReadLine(), out int id))
          throw new ArgumentException("ID inválido.");
  }
  catch (ArgumentException ex)
  {
          Console.WriteLine($"Erro: {ex.Message}");
      }
  ```

- **Exceções Específicas**:

  - `KeyNotFoundException`: Para IDs inválidos.
  - `ArgumentException`: Para entradas inválidas.
  - `InvalidOperationException`: Para ações proibidas.

- **Exportação CSV**:

  ```csharp
  try
  {
      using (var writer = new StreamWriter("hospedes.csv"))
      {
          writer.WriteLine("ID,Nome,Sobrenome");
          foreach (var h in hospedes)
              writer.WriteLine($"{h.Id},{h.Nome},{h.Sobrenome}");
      }
  }
  catch (IOException)
  {
          Console.WriteLine("Erro ao acessar o arquivo hospedes.csv.");
      }
  ```

---

### 📦 Coleções em C#

- **List**:

  - Usada em `HotelListRepository`.
  - Busca linear (O(n)).
  - Exemplo:
    ```csharp
    List<Hospede> hospedes = new List<Hospede>();
    hospedes.Add(new Hospede(1, "João", "Silva"));
    var hospede = hospedes.Find(h => h.Id == 1);
    ```

- **Dictionary**:

  - Usada em `HotelDictionaryRepository`.
  - Busca por chave (O(1)).
  - Exemplo:
    ```csharp
    Dictionary<int, Hospede> hospedes = new Dictionary<int, Hospede>();
    hospedes.Add(1, new Hospede(1, "Maria", "Oliveira"));
    var hospede = hospedes[1];
    ```

- **Comparação**:

  | Coleção   | Busca | Inserção | Remoção | Caso de Uso              |
  |-------------|---------|------------|-----------|-----------------------|
  | List       | O(n)   | O(1)     | O(n)     | Coleções pequenas     |
  | Dictionary | O(1)     | O(1)      | O(1)      | Acesso rápido por ID  |

- **Aplicação**: O usuário escolhe entre `List` e `Dictionary` no início, permitindo comparar desempenho.

---

#### 🧾 Versionamento de Código

- **Git/GitHub**:

  ```bash
  git clone https://github.com/fzanneti/wex_e2e_csharp/tree/main/study_project
  git add .
  git commit -m "Adiciona funcionalidade de hospedagem com List/Dictionary"
  git push origin main
  ```

- **Boas Práticas**:

  - Commits claros e frequentes.
  - Uso de branches para novas funcionalidades.
  - Pull requests para revisão colaborativa.

---

#### 🛠️ Projetos Práticos e Desafios Técnicos

- **Projeto: HotelSystem**

  - **Descrição**: Aplicativo console que simula um sistema de hotel, permitindo:
    - Cadastrar/listar/excluir hóspedes.
    - Listar suítes com seleção por ID.
    - Realizar/encerrar reservas com cálculo de custo e desconto.
    - Exportar hóspedes para CSV.
    - Exibir dados em tabelas formatadas.

  Exemplo **Exemplo de Saída**:

    #### Lista de Hóspedes

    ```
    +-------+----------------------+----------------------+
    | ID    | Nome                 | Sobrenome            |
    +-------+----------------------+----------------------+
    | 1     | João                 | Silva                |
    | 2     | Maria                | Oliveira             |
    +-------+----------------------+----------------------+
    ```

    #### Lista de Suítes

    ```
    +-------+----------------------+-----------------+------------+------------+
    | ID    | Nome                 | Preço Diária    | Capacidade | Disponível |
    +-------+----------------------+-----------------+------------+------------+
    | 1    | Suíte Conforto       | R$450,00       | 2          | Sim        |
    | 2     | Suíte Luxo         | R$780,00         | 3 em R$     | Sim        |
    | 3     | Suíte Preço Diária   | R$2500,00   | 4          | Sim        |
    | 4     | Suíte Família       | R$950,00       | 5          | Sim        |
    | 5     | Suíte Executiva    | R$620,00       | 2          | Sim        |
    +-------+----------------------+-----------------+------------+------------+
    ```

    #### Lista de Reservas

    ```
    +-------+------------------------------+--------------------+-------+-----------------+
    | ID    | Hóspede                      | Suíte             | Dias  | Custo Total     |
    +-------+------------------------------+--------------------+-------+-----------------+
    | 1     | João Silva                  | Suí te Conforto     | 5     | R$2250,00       |
    | 2     | Maria Oliveira             | Suíte Luxo         | 12    | R$8424,00       |
    +-------+------------------------------+--------------------+-------+-----------------++
    ```

- **Como Executar**:

  ```bash
  git clone https://github.com/fzanneti/HotelSystem.git
  cd HotelSystem/src
  dotnet run
  ```
  - Escolha entre `List` ou `Dictionary` na inicialização.
  - Siga o menu interativo.

- **Captura de Tela**:

  ![Tabela de Suítes](https://github.com/Hospede/docs/images/suites.png)

- **Desafios**:

  - Comparear desempenho entre `List` e `Dictionary` com cronômetro.
  - Adicione validação de datas para reservas.
  - Implemente interface gráfica simples.

---

#### ✨ Objetivo

- Fornecer um projeto prático que consolide fundamentos de C# e .NET.
- Demonstrar habilidades em POO, coleções, e tratamento de erros.
- Servir como portfólio para transição de carreira em tecnologia.
- Preparar para desafios técnicos com clareza e confiança.

---

#### 🚀 Para quem é este projeto?

- 🧑‍💻 Iniciantes em .NET e C#.
- 🎓 Alunos do curso WEX - End-to-End Engineering.
- 🔁 Profissionais em transição de carreira.
- 📚 Estudantes reforçando fundamentos.
- 🧠 Autodidatas buscando prática organizada.

---

#### 🔗 Links Úteis

- [Documentação Oficial .NET](https://learn.microsoft.com/dotnet)
- [Canal da Digitaliza](https://www.youtube.com/@digitaliza)
- [Artigo: Guia de C#](https://learn.microsoft.com/csharp/tour-of-csharp)
- [Git Cheat Sheet](https://education.github.com/git-cheat-sheet)

---

#### Licença
[MIT License](LICENSE)

---

> ###### **Seção criada por:** *Fabio Zanneti - Projeto: WEX - End to End Engineering* - Guia de estudos.