using codification.Models; // Importa o namespace onde as classes Pessoa e Curso estão definidas
using System; // Importa o namespace System para acesso a funcionalidades básicas do C#

/* 
Pessoa p1 = new Pessoa();
p1.Nome = "João"; // Define o nome da pessoa
p1.Sobrenome = "Carvalho"; // Define o sobrenome da pessoa
p1.Idade = 30;
p1.Apresentar();

Exemplo de uso sem construtor

Pessoa p1 = new Pessoa(); // Cria uma nova instância de Pessoa usando o construtor padrão
p1.Nome = "João"; // Define o nome da pessoa
p1.Sobrenome = "Carvalho"; // Define o sobrenome da pessoa

Pessoa p2 = new Pessoa(); // Cria uma nova instância de Pessoa usando o construtor com parâmetros
p2.Nome = "Fabio"; // Define o nome da pessoa
p2.Sobrenome = "Zanneti";// Define o sobrenome da pessoa
*/

/*
Pode ser utilizado da seguinte forma:
Pessoa p1 = new Pessoa("João", "Carvalho");
Porém a escrita abaixo deve ser utilizada para entregar um código mais legível e compreensível, especialmente em casos onde há muitos parâmetros.
*/

Pessoa p1 = new Pessoa(nome: "João", sobrenome: "Carvalho"); // Exemplo de uso com construtor
Pessoa p2 = new Pessoa(nome: "Fabio", sobrenome: "Zanneti"); // Exemplo de uso com construtor

Curso nomeCurso = new Curso(); // Cria uma nova instância de Curso
nomeCurso.NomeCurso = "Programação C#"; // Define o nome do curso
nomeCurso.Alunos = new List<Pessoa>(); // Inicializa a lista de alunos do curso

nomeCurso.AdicionarAluno(p1); // Adiciona o aluno p1 ao curso
nomeCurso.AdicionarAluno(p2); // Adiciona o aluno p2 ao curso
nomeCurso.ListarAlunos(); // Lista os alunos do curso

// Concatenando valores numéricos com strings:
Console.WriteLine("");

string numero1 = "10";  
string numero2 = "20"; 
string resultadoConcatenado = numero1 + numero2;

// Convertendo strings para números:

int numero3 = Convert.ToInt32(numero1);
int numero4 = Convert.ToInt32(numero2);
int resultadoNumerico = numero3 + numero4; // Soma os dois números inteiros, resultando em 30


Console.WriteLine($"Resultado da concatenação: {resultadoConcatenado} / Resultado da soma numérica: {resultadoNumerico}");