using System.Globalization;

// Realiza a leitura de um arquivo de texto e exibe seu conteúdo no console

string[] linhasOpcao1 = File.ReadAllLines("assets/arquivoLeitura.txt"); // Lê todas as linhas do arquivo encontrado no caminho especificado

foreach (string linha in linhasOpcao1) // Itera sobre cada linha do arquivo
{
    Console.WriteLine(linha); // Exibe a linha no console
}

// Disparando uma exceção genérica

try
{
    string[] linhasOpcao2 = File.ReadAllLines("assets/arquivoLeitura.txt");
    foreach (string linha in linhasOpcao2) // Itera sobre cada linha do arquivo
{
    Console.WriteLine(linha); // Exibe a linha no console
}
}
catch (Exception ex) // Captura a exceção genérica
{
    Console.WriteLine($"Ocorreu uma exceção: {ex.Message}"); // Exibe a mensagem da exceção no console
}