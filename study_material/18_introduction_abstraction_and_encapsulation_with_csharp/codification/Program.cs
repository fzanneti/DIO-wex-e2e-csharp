using codification.Models;

Pessoa p1 = new Pessoa(); // Objeto da classe pessoa, execução de ações da reprentação da classe.
p1.Nome = "Fabio";
p1.Idade = 44;
p1.Apresentar();

ContaCorrente c1 = new ContaCorrente(123, 1000); // Método de exemplificação de encapsulamento.
c1.ExibirSaldo();
c1.Sacar(5000);
c1.ExibirSaldo();
