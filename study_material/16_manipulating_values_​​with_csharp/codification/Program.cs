using codification.Models; // Importa o namespace onde as classes Pessoa e Curso estão definidas
using System; // Importa o namespace System para acesso a funcionalidades básicas do C#
using System.Globalization; // Importa o namespace System.Globalization para manipulação de culturas

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


Console.WriteLine($"Resultado da concatenação: {resultadoConcatenado} / Resultado da soma numérica: {resultadoNumerico}\n");

// Formatando valores monetários:

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US"); 
/*
    Define a cultura padrão do thread atual para "en-US" (Inglês - Estados Unidos). Isso afeta a formatação de valores monetários, datas, números, etc. Esse método é útil quando você deseja garantir que a formatação de valores seja consistente com uma cultura específica, independentemente da configuração regional do sistema. Mas deve ser usado com cautela, pois pode afetar a formatação de outros valores no programa. É importante lembrar que essa configuração afeta apenas o thread atual, e não o sistema como um todo.    
*/

decimal valorMonetario = 1234.56M; // Valor monetário - O M indica que é um decimal

Console.WriteLine($"Valor formatado usando o método CreateSpecificCulture(): {valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}\n"); 
/* 
    Formata o valor monetário como moeda na cultura "en-US" - Esse método converte o valor independentemente da cultura do sistema, garantindo que o valor seja exibido corretamente como moeda na cultura especificada. O "C" indica que o valor deve ser formatado como moeda.
*/

Console.WriteLine($"Valor sem formatação: {valorMonetario} \nValor formatado na cultura padrão do sistema: {valorMonetario:C} \n\nTambém podemos escolher o número de casa decimais utilizando C1: {valorMonetario:C1} para uma casa decimal. \nC2 para duas casas decimais: {valorMonetario:C2} \nC3 para três casas decimais: {valorMonetario:C3} e assim por diante.\n");
/*
    Sem o a utilização do :C o valor não é exibido com a formatação da moeda, já com o :C (que significa Courrency -> Moeda), o valor será exibido formatado na moeda de acordo com a cultura do sistema, por exemplo, em português brasileiro será exibido como R$ 1.234,56
*/

// Formatando porcentagens:

decimal valorPorcentagem = 0.1234M;
Console.WriteLine($"Valor formatado como porcentagem: {valorPorcentagem:P}\n");
/* 
    O "P" indica que o valor deve ser formatado como porcentagem. O valor será exibido como 12,34% (dependendo da cultura do sistema). 
    Se você quiser exibir com uma casa decimal, pode usar P1, P2, etc.
*/

// Formatando tipo DateTime:

DateTime dataAtual = DateTime.Now; // A propriedade Now retorna a data e hora atual do sistema
Console.WriteLine($"Data atual: {dataAtual.ToString("dd/MM/yyyy HH:mm:ss")} - Caso queira resumir detalhes podemos personalizar de qualquer forma, exemplo: {dataAtual.ToString("MM/yyyy HH:mm")}\n");
/* 
    O método ToString() com o formato "dd/MM/yyyy HH:mm:ss" formata a data e hora atual para o formato dia/mês/ano horas:minutos:segundos. 
    Você pode personalizar o formato de acordo com suas necessidades, como "MM/yyyy HH:mm" para exibir apenas mês/ano e horas:minutos.
*/

Console.WriteLine($"Data atual com o método ToShortDateString(): {dataAtual.ToShortDateString()}, exibe a data atual no formato curto, que varia de acordo com a cultura do sistema. Podemos usar também o método ToShortTimeString() para exibir apenas a hora no formato curto: {dataAtual.ToShortTimeString()}\n");
/* 
    O método ToShortDateString() exibe a data atual no formato curto, que varia de acordo com a cultura do sistema. 
    O método ToShortTimeString() exibe apenas a hora no formato curto.
*/

DateTime dataParse = DateTime.Parse("2023-10-01 14:30:00"); // Parse converte uma string em um objeto DateTime porém é importante garantir que a string esteja em um formato reconhecido pelo método Parse() para evitar exceções.
Console.WriteLine($"Data convertida de string para DateTime: {dataParse.ToString("dd/MM/yyyy HH:mm:ss")}\n");
/* 
    O método Parse() converte uma string organizando e interpretando a data e hora de acordo com o formato especificado.
    É importante garantir que a string esteja em um formato reconhecido pelo método Parse() para evitar exceções.
*/

string dataTryParse = "2023-11-01 14:30:00";

bool sucesso = DateTime.TryParseExact(dataTryParse,
                                    "yyyy-MM-dd HH:mm:ss",
                                    CultureInfo.InvariantCulture,
                                    DateTimeStyles.None, out DateTime data);

if (sucesso)
{
    Console.WriteLine($"Conversão bem-sucedida, o resultado é: {data}\n");
}
else
{
    Console.WriteLine("Conversão falhou.\n");
}
/* 
   O método TryParseExact é a melhor opção quando você precisa garantir que a string esteja em um formato específico evitando erros de conversão. O boolean do TryParseExact indica se a conversão foi bem-sucedida ou não e não quebra o programa caso a conversão falhe. No exemplo acima utilizamos um if para verificar se a conversão foi bem-sucedida e exibir o resultado ou uma mensagem de erro.
*/

