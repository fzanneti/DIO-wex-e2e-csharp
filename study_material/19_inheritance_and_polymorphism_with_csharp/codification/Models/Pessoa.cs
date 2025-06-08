using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codification.Models
{
    public class Pessoa
    /*
        Herança é um conceito da programação que permite que uma classe filho (subclasse) herde atributos e métodos de uma classe pai (superclasse). Isso promove o reuso de código, pois a classe filho adquire funcionalidades prontas, podendo também adicionar suas próprias ou sobrescrever as herdadas. É uma forma de criar uma hierarquia "é um tipo de" entre classes, nesse exemplo (Professor e Aluno(classes filhos)) herdam dados de (Pessoa (classe pai)). 
    */
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} {Sobrenome} e tenho {Idade} anos.");
        }
    }
}