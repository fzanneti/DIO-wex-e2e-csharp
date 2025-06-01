# Explicação dos Comentários

1. **Diretivas Using**: Comentado o `using System` para esclarecer sua necessidade para funcionalidades como `DateTime` e `Console`, `System.Collections.Generic` para a classe `List`, `System.Linq` para métodos como `FirstOrDefault` e `Any`, e `project_1_building_a_parking_system_with_csharp.models` para acessar a classe `Veiculo`.
2. **Campos da Classe**: Adicionados comentários para `veiculos`, `precoInicial` e `precoPorHora` para descrever seus propósitos (lista de veículos, preço inicial fixo, preço por hora), já que seus nomes são claros, mas a documentação explícita melhora a manutenção.
3. **Método `AdicionarVeiculo`**: Comentado para explicar que adiciona um veículo à lista com a placa fornecida e exibe uma mensagem de confirmação, beneficiando-se de uma descrição clara apesar da simplicidade.
4. **Método `RemoverVeiculo`**:
   - Comentada a busca com `FirstOrDefault` para indicar o uso de LINQ na procura do veículo pela placa.
   - Comentado o cálculo do tempo de permanência (`TimeSpan`) para esclarecer a subtração da hora de entrada do momento atual.
   - Comentado o cálculo do valor total para explicar a lógica de negócio baseada no preço inicial e no tempo em horas.
   - As mensagens de console são autoexplicativas e não comentadas.
5. **Método `ListarVeiculos`**:
   - Comentado o uso de `Any()` para indicar a verificação de veículos na lista com LINQ.
   - As mensagens de console e o loop `foreach` são claros e não requerem comentários adicionais.
6. **Método `AlterarPrecoInicial`**:
   - Comentada a linha que armazena o preço anterior para explicar sua função na exibição do valor antes da alteração.
   - Comentada a mensagem de alteração para indicar que exibe os preços anterior e atual, com validação para valores não negativos.
7. **Método `AlterarPrecoPorHora`**:
   - Comentada a linha que armazena o preço anterior para explicar sua função na exibição do valor antes da alteração.
   - Comentada a mensagem de alteração para indicar que exibe os preços anterior e atual, com validação para valores não negativos.
8. **Método `ExibirTabelaPrecos`**: Comentado para explicar que exibe a tabela de preços com os valores atuais de `precoInicial` e `precoPorHora`, com formatação monetária.
