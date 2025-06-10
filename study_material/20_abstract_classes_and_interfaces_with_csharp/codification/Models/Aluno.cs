using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codification.Models
{
    public class Aluno : Pessoa
    {
        /*
            A classe Aluno herda de Pessoa, reutilizando suas propriedades.
            O construtor com base(nome) chama o construtor da classe Pessoa.
        */
        public Aluno(string nome) : base(nome)
        {

        }
        public string Curso { get; set; }
        public int Matricula { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome}, tenho {Idade} anos e sou aluno do curso de {Curso} e minha matrícula é {Matricula}.");
        }
    }
}