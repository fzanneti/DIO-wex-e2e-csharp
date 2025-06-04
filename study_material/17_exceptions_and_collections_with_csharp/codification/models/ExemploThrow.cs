using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codification.models
{
    public class ExemploThrow
    {
        public void Metodo1() // Chamada inicial do método que inicia a cadeia de chamadas
        {
            try // Tenta executar o bloco de código que pode disparar uma exceção
            {
                Metodo2(); // Chamada intermediária do método que continua a cadeia de chamadas
            }
            catch (Exception ex) // Captura qualquer exceção que ocorra durante a execução do bloco try
            {
                Console.WriteLine($"Exceção tratada:" + ex.Message + "\n"); // Exibe a mensagem da exceção no console
            }
        }
        public void Metodo2() // Chamada intermediária do método que continua a cadeia de chamadas
        {
            Metodo3(); // Chamada intermediária do método que continua a cadeia de chamadas
        }
        public void Metodo3() // Chamada intermediária do método que continua a cadeia de chamadas
        {
            Metodo4(); // Chamada final do método que realmente dispara a exceção
        }
        public void Metodo4() // Chamada final do método que realmente dispara a exceção
        {
            throw new Exception("Exceção disparada do Método 4\n"); // Dispara uma exceção com uma mensagem específica
        }

    }
}
