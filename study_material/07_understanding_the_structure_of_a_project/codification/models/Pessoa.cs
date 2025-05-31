using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codification.models.Pessoa
{

    public class Pessoa
    {

        public required string Nome { get; set; }
        public required int Idade { get; set; }

        public void Apresentar()
        {

            Console.WriteLine($"Olá prazer em conhecê-lo. Meu nome é {Nome}. Tenho {Idade} anos");
            Console.WriteLine($"Hello, nice to meet you. My name is {Nome}. I'm {Idade} years old.");

        }
        
    }
}