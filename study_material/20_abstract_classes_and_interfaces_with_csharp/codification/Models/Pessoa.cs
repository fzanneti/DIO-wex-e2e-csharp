using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codification.Models
{
    public class Pessoa
    {
        /*
            Construtor da classe base (Pessoa)
            Esse construtor será chamado quando uma classe filha (como Aluno, Professor, etc.) for instanciada.
            Usamos a palavra "base" na classe filha para chamar este construtor e passar valores para ele.
            Isso permite que a classe filha aproveite a inicialização da classe base sem repetir código.  
        */
        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }


        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome} e tenho {Idade} anos!");
        }
    } 
}