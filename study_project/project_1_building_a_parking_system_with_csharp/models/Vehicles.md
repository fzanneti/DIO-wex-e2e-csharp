# Explicação dos Comentários

1. **Usando Diretivas:** Comentou-se sobre ``System`` para esclarecer sua necessidade de ``DateTime``. Observou-se namespaces não utilizados (``System.Collections.Generic``, ``System.Linq``, ``System.Threading.Tasks``) com uma sugestão de remoção, pois não são referenciados no código e poderiam reduzir a desorganização.
2. **Namespace e Classe:** Nenhum comentário adicionado, pois a declaração de namespace e classe é autoexplicativa e segue as convenções de nomenclatura padrão.
3. **Propriedades (``Placa``, ``HoraEntrada``):** Adicionados breves comentários para descrever a finalidade de cada propriedade, pois seus nomes são, em sua maioria, claros, mas se beneficiam de documentação explícita para manutenção.
4. **Construtor:** Comentou-se sobre a atribuição de ``HoraEntrada`` para explicar que ela captura a hora atual, o que não é óbvio sem contexto. A atribuição de ``Placa`` é autoexplicativa e, portanto, não comentada.