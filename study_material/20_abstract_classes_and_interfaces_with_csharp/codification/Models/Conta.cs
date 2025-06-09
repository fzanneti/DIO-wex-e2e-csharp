using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codification.Models
{
    /*
        A classe Conta é abstrata em C#, servindo como modelo para contas específicas (ex.: conta corrente, poupança), não podendo ser instanciada diretamente, apenas herdada. O atributo saldo, declarado como protected decimal saldo, armazena o valor monetário da conta com precisão (tipo decimal) e é acessível na própria classe e em classes derivadas, mas não fora delas. O modificador protected diferencia-se de private, pois private restringe o acesso exclusivamente à classe que define o atributo, bloqueando até mesmo as classes derivadas. O método abstrato public abstract void Creditar(decimal valor); exige que classes derivadas implementem sua própria lógica para adicionar valores ao saldo, sem fornecer implementação na classe base. Já o método public void ExibirSaldo() é concreto, compartilhado por todas as classes derivadas, e exibe o saldo atual no console. Essa estrutura organiza e reutiliza código em sistemas bancários, com protected garantindo flexibilidade para herança, ao contrário de private, que é mais restritivo.
    */
    public abstract class Conta
    {
        protected decimal saldo;

        public abstract void Creditar(decimal valor);

        public void ExibirSaldo()
        {
            Console.WriteLine($"O seu saldo é: " + saldo);
        }
    }
}