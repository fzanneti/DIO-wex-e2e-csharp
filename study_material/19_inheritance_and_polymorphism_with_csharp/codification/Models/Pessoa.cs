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
    /*
        Polimorfismo permite que objetos relacionados por herança exibam comportamentos diferentes para o mesmo método. Em C#, o uso de virtual na classe pai sinaliza que um método pode ser sobrescrito, enquanto override na classe filha fornece a nova implementação, garantindo que o comportamento correto seja executado em tempo de execução. Isso torna o código mais flexível e extensível.
    */
        public virtual void Apresentar()
        {
            
        }
    }
}