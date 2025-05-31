using codification.models.Pessoa;

Pessoa pessoa = new Pessoa
{
    Nome = "",
    Idade = 0
};

Pessoa pessoa1 = new Pessoa
{
    Nome = "",
    Idade = 0
};

Console.WriteLine($"");

pessoa.Nome = "Fabio Zanneti";
pessoa.Idade = 44;
pessoa.Apresentar();

Console.WriteLine($"");

pessoa1.Nome = "John Doe";
pessoa1.Idade = 30;
pessoa1.Apresentar();

Console.WriteLine($"");