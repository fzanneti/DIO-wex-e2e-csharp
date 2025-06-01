# Explicação dos Comentários

1. **Diretiva Using**: Comentado o `using` para esclarecer que importa o namespace do serviço `ParkingServices`, necessário para acessar a classe correspondente.
2. **Método `Main`**: Adicionado comentário para indicar que é o ponto de entrada do programa, conforme convenção do C#.
3. **Instanciação de `ParkingServices`**: Comentado para explicar que a variável `estacionamento` gerencia as operações do sistema de estacionamento.
4. **Loop `while`**: Comentado para esclarecer que o loop infinito mantém o menu ativo até o usuário escolher sair.
5. **Linha `Console.Clear()`**: Comentado para explicar que limpa a tela do console antes de exibir o menu, garantindo uma interface renovada.
6. **Leitura da Opção (`Console.ReadLine`)**: Comentado para indicar o tratamento de entrada nula, convertendo-a em string vazia para evitar erros.
7. **Estrutura `switch`**:
   - **Caso 1 (Adicionar Veículo)**: Comentado para explicar a chamada ao método `AdicionarVeiculo` e o uso de `Console.ReadKey()` para pausar e permitir a visualização da mensagem de confirmação antes de limpar a tela.
   - **Caso 2 (Remover Veículo)**: Comentado para explicar a limpeza da tela com `Console.Clear()`, a exibição da lista de veículos com `ListarVeiculos` para auxiliar na escolha da placa, a chamada ao método `RemoverVeiculo`, e o uso de `Console.ReadKey()` para pausar.
   - **Caso 3 (Listar Veículos)**: Comentado para explicar a chamada ao método `ListarVeiculos` e o uso de `Console.ReadKey()` para permitir a visualização da lista antes de limpar a tela.
   - **Casos 4 e 5 (Alterar Preço Inicial e Preço por Hora)**: Comentados para explicar a conversão da entrada do usuário com `decimal.TryParse`, a chamada aos métodos de alteração de preço, e o uso de `Console.ReadKey()` para pausar após exibir mensagens de confirmação ou erro.
   - **Caso 6 (Exibir Tabela de Preços)**: Comentado para explicar a chamada ao método `ExibirTabelaPrecos` e o uso de `Console.ReadKey()` para permitir a visualização da tabela antes de limpar a tela.
   - **Caso 7 (Sair)**: Comentado para esclarecer que o `return` encerra o programa ao sair do método `Main`.
   - **Caso `default`**: Não comentado, pois a mensagem de "Opção inválida" é autoexplicativa, mas o uso de `Console.ReadKey()` é comentado para indicar a pausa para visualização.
8. **Mensagens de Console**: Não comentadas, pois são claras e representam a interface do menu ou prompts de entrada do usuário.
