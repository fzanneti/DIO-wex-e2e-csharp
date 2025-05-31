using codification.models.DataTypes;

DataTypes tiposDeDados = new DataTypes
{
    Nome = "",
    Idade = 0,
    Altura = 0.00,
    Salario = 0.00M

};

tiposDeDados.Nome = "João";
tiposDeDados.Idade = 30;
tiposDeDados.Altura = 1.70;
tiposDeDados.Salario = 2500.00M;                 
tiposDeDados.Apresentar();