using System.Globalization;
using codification.models; // Importa o namespace onde a classe ExemploThrow está definida

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
    Console.WriteLine($"Ocorreu uma exceção genérica: {ex.Message}"); // Exibe a mensagem da exceção no console
}

Console.WriteLine("1 - Pressione qualquer tecla para continuar...\n");

// Disparando uma exceção específica

try
{
    string[] linhasOpcao3 = File.ReadAllLines("assets/arquivo_Leitura.txt"); // Exemplo de caminho incorreto para disparar uma exceção

    foreach (string linha in linhasOpcao3) // Itera sobre cada linha do arquivo
    {
        Console.WriteLine(linha); // Exibe a linha no console
    }
}
catch (FileNotFoundException ex) // Captura a exceção específica de arquivo não encontrado
{
    Console.WriteLine($"Ocorreu uma exceção de arquivo não encontrado: {ex.Message}\n"); // Exibe a mensagem da exceção no console
}
catch (DirectoryNotFoundException ex) // Captura a exceção específica de diretório não encontrado
{
    Console.WriteLine($"Ocorreu uma exceção de diretório não encontrado: {ex.Message}\n"); // Exibe a mensagem da exceção no console
}
catch (Exception ex) // Captura qualquer outra exceção genérica
{
    Console.WriteLine($"Ocorreu uma exceção genérica: {ex.Message}\n"); // Exibe a mensagem da exceção no console
}
finally
{
    Console.WriteLine("2 - Pressione qualquer tecla para continuar...\n");
    /* 
        Mensagem final independente de exceção. Um bom motivo para usar o bloco finally é garantir que certas ações sejam executadas, como liberar recursos ou fechar conexões, independentemente de uma exceção ter ocorrido ou não.
    */
}

// Disparando Throw

new ExemploThrow().Metodo1(); // Cria uma instância da classe ExemploThrow e chama o método Metodo1, que dispara uma exceção
Console.WriteLine("...\n");

// Exibindo coleções queue - Fila

Queue<string> fila = new Queue<string>(); // Cria uma nova fila de strings

fila.Enqueue("Primeiro"); // Adiciona o elemento "Primeiro" à fila 
fila.Enqueue("Segundo"); // Adiciona o elemento "Segundo" à fila
fila.Enqueue("Terceiro"); // Adiciona o elemento "Terceiro" à fila  
fila.Enqueue("Quarto"); // Adiciona o elemento "Quarto" à fila

foreach (string item in fila) // Itera sobre cada item na fila
{
    Console.WriteLine(item); // Exibe o item no console em sequência FIFO (First In, First Out)
}

Console.WriteLine($"\nFila após remoção do primeiro item: {fila.Dequeue()}"); // Remove e exibe o primeiro item da fila

foreach (string item in fila) // Itera sobre cada item restante na fila
{
    Console.WriteLine(item); // Exibe o item no console
}

Console.WriteLine("...");

// Exibindo coleções stack - Pilha

Stack<string> pilha = new Stack<string>(); // Cria uma nova pilha de strings

pilha.Push("Primeiro"); // Adiciona o elemento "Primeiro" à pilha
pilha.Push("Segundo"); // Adiciona o elemento "Segundo" à pilha
pilha.Push("Terceiro"); // Adiciona o elemento "Terceiro" à pilha
pilha.Push("Quarto"); // Adiciona o elemento "Quarto" à pilha

foreach (string item in pilha) // Itera sobre cada item na pilha
{
    Console.WriteLine(item); // Exibe o item no console em sequência LIFO (Last In, First Out)
}

Console.WriteLine($"\nPilha após remoção do primeiro item: {pilha.Pop()}"); // Exibe o item no topo da pilha sem removê-lo, para remover o ultimo item da pilha, deve-se remover todos os itens acima dele.

pilha.Push("Adicionando o Quinto"); // Adiciona um novo item à pilha

foreach (string item in pilha) // Itera sobre cada item restante na pilha
{
    Console.WriteLine(item); // Exibe o item no console
}

// Introdução ao Dictionary

Dictionary<string, string> estados = new Dictionary<string, string>(); // Cria um novo dicionário com chaves e valores do tipo string

// Adicionando estados ao dicionário com chaves representando siglas e valores representando os nomes dos estados

estados.Add("SP", "São Paulo"); // Adiciona o estado de São Paulo ao dicionário
estados.Add("RJ", "Rio de Janeiro"); // Adiciona o estado do Rio de Janeiro ao dicionário
estados.Add("MG", "Minas Gerais"); // Adiciona o estado de Minas Gerais ao dicionário
estados.Add("RS", "Rio Grande do Sul"); // Adiciona o estado do Rio Grande do Sul ao dicionário

Console.WriteLine("\nDicionário de estados:");

foreach (/*KeyValuePair<string, string> ou */var estado in estados) // Itera sobre cada par chave-valor no dicionário, o uso de var permite que o compilador infira o tipo do elemento substituindo KeyValuePair<string, string>... ambos são válidos.
{
    Console.WriteLine($"Chave: {estado.Key}, Valor: {estado.Value}"); // Exibe a chave e o valor no console
}

/*
    O método Dictionary permite armazenar pares de chave-valor, onde cada chave é única. Isso facilita a busca e o acesso aos valores associados a uma chave específica. O uso de var na iteração permite que o compilador infira o tipo do elemento, tornando o código mais conciso e legível.
*/

// Removendo um estado do dicionário

estados.Remove("SP"); // Remove o estado de São Paulo do dicionário utilizando a chave
Console.WriteLine("\nDicionário de estados após remoção de SP:");

foreach (var estado in estados) // Itera sobre cada par chave-valor restante no dicionário
{
    Console.WriteLine($"Chave: {estado.Key}, Valor: {estado.Value}"); // Exibe a chave e o valor no console
}

// Verificando se uma chave existe no dicionário

if (estados.ContainsKey("RJ")) // Verifica se a chave "RJ" existe no dicionário
{
    Console.WriteLine("\nA chave 'RJ' existe no dicionário."); // Exibe mensagem se a chave existir
}
else
{
    Console.WriteLine("\nA chave 'RJ' não existe no dicionário."); // Exibe mensagem se a chave não existir
}

if (estados.ContainsKey("PA")) // Verifica se a chave "PA" existe no dicionário
{
    Console.WriteLine("\nA chave 'PA' existe no dicionário."); // Exibe mensagem se a chave existir
}
else
{
    Console.WriteLine("\nA chave 'PA' não existe no dicionário."); // Exibe mensagem se a chave não existir
}

// Verificando se um valor existe no dicionário

if (estados.ContainsValue("Minas Gerais")) // Verifica se o valor "Minas Gerais" existe no dicionário
{
    Console.WriteLine("\nO valor 'Minas Gerais' existe no dicionário."); // Exibe mensagem se o valor existir
}
else
{
    Console.WriteLine("\nO valor 'Minas Gerais' não existe no dicionário."); // Exibe mensagem se o valor não existir
}