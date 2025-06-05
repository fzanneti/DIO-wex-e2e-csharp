using System; 
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using project_2_hotel_dictionary.Services; // Importa os serviços de cadastro e reserva     

namespace project_2_hotel_dictionary.Models // PT-BR: Classe que representa uma reserva de hotel
{
    public class Reserva // PT-BR: Classe que representa uma reserva de hotel
    {
        public int Id { get; set; } // PT-BR: GET / SET ID da reserva
        public Hospede Hospede { get; set; } // PT-BR: GET / SET Hóspede associado à reserva
        public Suite Suite { get; set; } // PT-BR: GET / SET Suíte reservada
        public int Dias { get; set; } // PT-BR: GET / SET Número de dias da reserva
        public decimal CustoTotal { get; set; } // PT-BR: GET / SET Custo total da reserva

        public Reserva(int id, Hospede hospede, Suite suite, int dias) // PT-BR: Construtor da classe Reserva
        {
            Id = id; // PT-BR: Atribui o ID da reserva
            Hospede = hospede; // PT-BR: Atribui o Hóspede associado à reserva
            Suite = suite; // PT-BR: Atribui a Suíte reservada
            Dias = dias; // PT-BR: Atribui o número de dias da reserva    
            CustoTotal = CalcularCusto(); // PT-BR: Calcula o custo total da reserva
            Suite.Disponivel = false; // PT-BR: Marca a suíte como indisponível após a reserva
        }

        public decimal CalcularCusto() // PT-BR: Método para calcular o custo total da reserva
        {
            decimal custo = Dias * Suite.PrecoDiaria; // PT-BR: Custo é o número de dias multiplicado pelo preço da diária da suíte 
            if (Dias >= 10) // PT-BR: Se a reserva for para 10 dias ou mais
                custo *= 0.9m; // PT-BR: Aplica um desconto de 10% no custo total
            return custo; // PT-BR: Retorna o custo total calculado
        }

        public override string ToString() // PT-BR: Método ToString para exibir informações da reserva
        {
            return $"Reserva ID: {Id}, Hóspede: {Hospede.Nome} {Hospede.Sobrenome}, Suíte: {Suite.Nome}, Dias: {Dias}, Custo: R${CustoTotal:F2}"; // PT-BR: Retorna uma string formatada com ID da reserva, Nome do hóspede, Nome da suíte, número de dias e custo total
        }
    }
}