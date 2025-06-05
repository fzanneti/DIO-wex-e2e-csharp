using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using project_2_hotel_dictionary.Services; // Importa os serviços de cadastro e reserva     

namespace project_2_hotel_dictionary.Models
{
    public class Suite // PT-BR: Classe que representa uma suíte de hotel
    {
        public string Nome { get; set; } // PT-BR: GET / SET Nome da suíte
        public decimal PrecoDiaria { get; set; } // PT-BR: GET / SET Preço da diária da suíte
        public int Capacidade { get; set; } // PT-BR: GET / SET Capacidade máxima de hóspedes na suíte
        public bool Disponivel { get; set; } // PT-BR: GET / SET Disponibilidade da suíte (se está disponível para reserva)

        public Suite(string nome, decimal precoDiaria, int capacidade) // PT-BR: Construtor da classe Suite
        {
            Nome = nome; // PT-BR: Atribui o Nome da suíte
            PrecoDiaria = precoDiaria; // PT-BR: Atribui o Preço da diária da suíte
            Capacidade = capacidade; // PT-BR: Atribui a Capacidade máxima de hóspedes na suíte
            Disponivel = true; // PT-BR: Inicializa a disponibilidade da suíte como verdadeira (disponível)
        }

        public override string ToString() // PT-BR: Método ToString para exibir informações da suíte
        {
            return $"Suíte: {Nome}, Preço: R${PrecoDiaria:F2}, Capacidade: {Capacidade}, Disponível: {(Disponivel ? "Sim" : "Não")}";
            // PT-BR: Retorna uma string formatada com Nome, Preço, Capacidade e Disponibilidade da suíte
        }
    }
}