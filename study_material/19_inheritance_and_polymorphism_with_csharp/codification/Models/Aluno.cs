using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codification.Models
{
    public class Aluno : Pessoa
    {
        public string Curso { get; set; }
        public int Matricula { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome} {Sobrenome}, tenho {Idade} anos e sou aluno do curso de {Curso} e minha matrícula é {Matricula}.");
        }

    }
}