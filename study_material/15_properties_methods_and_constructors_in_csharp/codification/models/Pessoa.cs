using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Threading.Tasks;

namespace codification.models // Namespace para organizar o código
{
    /* 
        public é o modificador de acesso não tem restrições de acesso, permitindo que a classe seja acessada de qualquer lugar
        private é o modificador de acesso que tem restrições de acesso, permitindo que o campo ou método seja acessado apenas dentro da própria classe
    */
    public class Pessoa 
    {

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
        // public string NomeCompleto { get => $"{Nome} {Sobrenome}"; } // A linha acima é uma versão alternativa usando expressão de corpo (body expression) para a propriedade NomeCompleto, qual é mais concisa e direta.

        public int Idade // Propriedade Idade com validação
        {
            get => _idade; // Retorna o valor da idade

            set
            {
                if (value < 0) // Verifica se a idade é negativa
                {
                    throw new Exception("A idade não pode ser negativa."); // Lança uma exceção se a idade for negativa
                }

                _idade = value; // Atribui o valor à variável privada _idade
            }
        }


        public void Apresentar()
        {
            Console.Clear();
            Console.WriteLine($"Nome: {NomeCompleto} / Idade: {Idade}");
        }
    }
}   