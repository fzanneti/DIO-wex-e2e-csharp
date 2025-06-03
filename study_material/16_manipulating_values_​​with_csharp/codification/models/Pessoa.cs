using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Threading.Tasks;

namespace codification.Models // Namespace para agrupar as classes relacionadas a pessoas
{
    /* 
        public é o modificador de acesso não tem restrições de acesso, permitindo que a classe seja acessada de qualquer lugar
        private é o modificador de acesso que tem restrições de acesso, permitindo que o campo ou método seja acessado apenas dentro da própria classe
    */
    public class Pessoa
    {
        /*
        Construtor padrão sem parâmetros, que deve ser sempre chamado pelo nome da classe seguido de parênteses.
        Não há limites para o número de construtores que uma classe pode ter, mas é comum ter pelo menos um construtor padrão.
        Construtores devem iniciar os campos da classe ou executar alguma lógica de inicialização quando uma nova instância da classe é criada.
        */
        public Pessoa()
        {
            /*
            Este construtor é chamado quando uma nova instância de Pessoa é criada sem passar nenhum parâmetro.
            Ele pode ser usado para inicializar valores padrão, se necessário.
            */
        }

        public Pessoa(string nome, string sobrenome) // Construtor com parâmetros para inicializar Nome e Sobrenome
        {
            Nome = nome;
            /*
                Atribui o valor do parâmetro nome à propriedade Nome
                Equivale a:
                public string Nome { get; set; }
            */
            Sobrenome = sobrenome;
            /* 
                Atribui o valor do parâmetro sobrenome à propriedade Sobrenome
                Equivale a:
                public string Sobrenome { get; set; }

                Os construtores recebem os valores padrões para as propriedades Nome e Sobrenome
                e podem ser usados para criar instâncias da classe Pessoa com esses valores já definidos.
                Exemplo de uso:
                Pessoa p1 = new Pessoa(nome: "João", sobrenome: "Carvalho");
                Isso cria uma nova instância de Pessoa com o nome "João" e sobrenome "Carvalho".
            */
        }

        /*
            get recebe o valor da propriedade
            set atribui o valor da propriedade
        */

        private string _nome; // Campo privado para armazenar o nome
        private string _sobrenome; // Campo privado para armazenar o sobrenome
        private int _idade; // Campo privado para armazenar a idade

        public string Nome
        {
            get => _nome.ToUpper(); // Bodyexpression "=>" deve ser usado para propriedades simples, aqui converte o nome para maiúsculas ao obter o valor

            set // Define o nome com validação
            {
                if (value.Length > 3) // Verifica se o nome tem mais de 3 caracteres
                {
                    _nome = value; // Atribui o valor à variável privada _nome
                }
                else
                {
                    throw new Exception("O nome deve ter mais de 3 caracteres."); // Lança uma exceção se o nome for inválido
                }
            }
        }

        public string Sobrenome
        {
            get => _sobrenome.ToUpper(); // Bodyexpression "=>" deve ser usado para propriedades simples, aqui converte o sobrenome para maiúsculas ao obter o valor

            set
            {
                if (value.Length > 3) // Verifica se o nome tem mais de 3 caracteres
                {
                    _sobrenome = value; // Atribui o valor à variável privada _nome
                }
                else
                {
                    throw new Exception("O nome deve ter mais de 3 caracteres."); // Lança uma exceção se o nome for inválido
                }
            }
        }

        // Propriedade NomeCompleto que combina Nome e Sobrenome    

        public string NomeCompleto => $"{Nome} {Sobrenome}";// Propriedade somente leitura que retorna o nome completo concatenando Nome e Sobrenome

        // public string NomeCompleto { get => $"{Nome} {Sobrenome}"; } 
        // A linha acima é uma versão alternativa usando expressão de corpo (body expression) para a propriedade NomeCompleto, qual é mais concisa e direta.

        public int Idade // Propriedade Idade com validação
        {
            get => _idade; // Retorna o valor da idade

            set
            {
                if (value < 0 || value > 120) // Verifica se a idade está dentro de um intervalo válido
                {
                    throw new Exception("Idade inválida. Deve ser entre 0 e 120 anos."); // Lança uma exceção se a idade for inválida
                }

                _idade = value; // Atribui o valor à variável privada _idade
            }
        }

        public void Apresentar()
        {
            Console.Clear(); // Limpa o console antes de apresentar a pessoa
            Console.WriteLine($"Olá, meu nome é {NomeCompleto} e tenho {Idade} anos.\n"); // Exibe uma mensagem de apresentação com o nome completo e a idade da pessoa
        }
    }

}