using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codification.Models
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }

        public void ApresentarProfessor()
        {
            Console.WriteLine($"O professor {Nome} {Sobrenome} tem {Idade} anos e recebe o salário de {Salario:C}");
        }
    }
}