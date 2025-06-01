# Explicação dos Comentários

1. **Diretiva Using**: Comentado o `using` para esclarecer que importa o namespace do serviço `EstacionamentoService`, necessário para acessar a classe correspondente.
2. **Método `Main`**: Adicionado comentário para indicar que é o ponto de entrada do programa, conforme convenção do C#.
3. **Instanciação de `EstacionamentoService`**: Comentado para explicar que a variável `estacionamento` gerencia as operações do sistema de estacionamento.
4. **Loop `while`**: Comentado para esclarecer que o loop infinito mantém o menu ativo até o usuário escolher sair.
5. **Leitura da Opção (`Console.ReadLine`)**: Comentado para indicar o tratamento de entrada nula, convertendo-a em string vazia para evitar erros.
6. **Estrutura `switch`**: 
   - Casos 1, 2 e 3: Comentados para explicar brevemente a chamada aos métodos correspondentes do serviço `EstacionamentoService`.
   - Caso 4: Comentado para esclarecer que o `return` encerra o programa ao sair do método `Main`.
   - Caso `default`: Não comentado, pois a mensagem de "Opção inválida" é autoexplicativa.
7. **Mensagens de Console**: Não comentadas, pois são claras e representam a interface do menu.