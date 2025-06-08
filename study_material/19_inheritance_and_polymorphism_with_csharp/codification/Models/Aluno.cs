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

        public void ApresentarAluno()
        {
            Console.WriteLine($"Eu sou aluno do curso de {Curso} e minha matrícula é {Matricula}.");   
        }

    }
}