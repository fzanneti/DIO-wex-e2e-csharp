using System.Globalization;

string[] linhas = File.ReadAllLines("assets/arquivoLeitura.txt"); // Lê todas as linhas do arquivo encontrado no caminho especificado

foreach (string linha in linhas) // Itera sobre cada linha do arquivo
{
   Console.WriteLine(linha); // Exibe a linha no console
}