using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codification.Models
{
    public class ContaCorrente
    {

        public ContaCorrente(int conta, decimal saldoInicial) // Construtor
        {
            numeroConta = conta;
            saldo = saldoInicial;
        }


        public int numeroConta { get; set; }
        private decimal saldo { get; set; } // Exemplo de encapsulamento - Alteração permitida apenas dentro da classe Conta Corrente.


        public void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Valor desejado é maior que o saldo disponível.");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo disponível é de " + saldo);
        }
    }
}