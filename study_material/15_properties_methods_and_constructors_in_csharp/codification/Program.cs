using codification.Models; // Importa o namespace onde as classes Pessoa e Curso estão definidas

/*
Pessoa p1 = new Pessoa();
p1.Nome = "João"; // Define o nome da pessoa
p1.Sobrenome = "Carvalho"; // Define o sobrenome da pessoa
p1.Idade = 30;
p1.Apresentar();
*/

Pessoa p1 = new Pessoa(); // Cria uma nova instância de Pessoa usando o construtor padrão
p1.Nome = "João"; // Define o nome da pessoa
p1.Sobrenome = "Carvalho"; // Define o sobrenome da pessoa

Pessoa p2 = new Pessoa(); // Cria uma nova instância de Pessoa usando o construtor com parâmetros
p2.Nome = "Fabio"; // Define o nome da pessoa
p2.Sobrenome = "Zanneti";// Define o sobrenome da pessoa

Curso nomeCurso = new Curso(); // Cria uma nova instância de Curso
nomeCurso.Nome = "Programação C#"; // Define o nome do curso
nomeCurso.Alunos = new List<Pessoa>(); // Inicializa a lista de alunos do curso

nomeCurso.AdicionarAluno(p1); // Adiciona o aluno p1 ao curso
nomeCurso.AdicionarAluno(p2); // Adiciona o aluno p2 ao curso
nomeCurso.ListarAlunos(); // Lista os alunos do curso