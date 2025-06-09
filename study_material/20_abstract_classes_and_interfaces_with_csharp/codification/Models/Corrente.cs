using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codification.Models
{   
    /*
        Aqui, a classe Corrente herda da classe abstrata Conta, representando uma conta corrente específica. Ela implementa o método abstrato Creditar(decimal valor) com a anotação override, definindo que, ao adicionar um valor ao saldo, o atributo saldo (herdado de Conta e acessível por ser protected) é incrementado pelo valor recebido. Essa implementação simples permite que a classe Corrente atualize o saldo diretamente, cumprindo o contrato exigido pela classe base.
    */
    public class Corrente : Conta
    {
        public override void Creditar(decimal valor)
        {
            saldo += valor;
        }
    }
}