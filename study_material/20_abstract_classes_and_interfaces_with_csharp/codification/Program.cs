using codification.Models;

Corrente c = new Corrente();
c.Creditar(500);
c.ExibirSaldo();

Pessoa p1 = new Pessoa("José Manoel");
p1.Idade = 20;

Aluno a1 = new Aluno("Fabio Zanneti");
a1.Idade = 18;
a1.Curso = "Gestão da TI";
a1.Matricula = 123456;

Professor pr1 = new Professor("Pedro Gonçalves");
pr1.Idade = 56;
pr1.Salario = 2800.00M;

p1.Apresentar();
a1.Apresentar();
pr1.Apresentar();