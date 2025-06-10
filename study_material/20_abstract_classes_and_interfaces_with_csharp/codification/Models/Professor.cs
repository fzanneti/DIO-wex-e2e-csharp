using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codification.Models
{
    public sealed class Professor : Pessoa
    {
        public Professor(string nome) : base(nome)
        {
            
        }
        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"O professor {Nome} tem {Idade} anos e recebe o salário de {Salario:C}");
        }
    }    

}