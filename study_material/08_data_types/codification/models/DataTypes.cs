using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codification.models.DataTypes
{
    public class DataTypes
    {

        public required string Nome { get; set; }
        public required int Idade { get; set; }
        public required double Altura { get; set; }
        public required decimal Salario { get; set; }

        /* 
             No caso de números decimais, o método ToString("0.00") é utilizado para formatar o número com duas casas decimais, porém, a melhor prática indicada é utilizar o método decimal para exibir o número com duas casas decimais.
        */

        public void Apresentar()
        {

            Console.WriteLine($"");

            Console.WriteLine($"Hello, nice to meet you. My name is {Nome} - string method. I am {Idade} years old - integer method, my height is {Altura.ToString("0.00")} meters - double method and my salary is R$ {Salario} reais - decimal method.");

            Console.WriteLine($"");

            Console.WriteLine($"Olá prazer em conhecê-lo. Meu nome é {Nome} - método string. Tenho {Idade} anos - método inteiro, minha altura é {Altura.ToString("0.00")} metros - método double e meu salário é R$ {Salario} reais - método decimal.");

            Console.WriteLine($"");

            /* 
                Exemplo de uso do tipo DateTime
                ToString é utilizado para formatar os dados para exibição em texto.
            */
            DateTime dataAtual = DateTime.Now;
            Console.WriteLine($"Verificação em {dataAtual.ToString("dd/MM/yyyy - HH:mm")} - método DateTime.");

            Console.WriteLine($"");
        }

    }

}