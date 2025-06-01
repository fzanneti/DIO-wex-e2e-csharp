using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Threading.Tasks;

namespace codification.models // Namespace para organizar o código
{
    /* 
        public é o modificador de acesso que permite que a classe seja acessada de qualquer lugar
        private é o modificador de acesso que permite que o campo seja acessado apenas dentro da classe
    */
    public class Pessoa // Classe Pessoa
    {
        /*
            get recebe o valor da propriedade
            set atribui o valor da propriedade
        */
        private string _nome; // Campo privado para armazenar o nome
        private int _idade; // Campo privado para armazenar a idade
        
        public string Nome
        {
            get => _nome.ToUpper(); // Retorna o nome em letras maiúsculas - bodyexpression "=>" deve ser usado para propriedades simples

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
            Console.WriteLine($"Nome: {Nome} / Idade: {Idade}");
        }
    }
}   