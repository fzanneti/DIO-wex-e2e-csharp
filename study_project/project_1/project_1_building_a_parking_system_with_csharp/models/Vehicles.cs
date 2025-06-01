using System;

namespace project_1_building_a_parking_system_with_csharp.models
{
    public class Veiculo
    {   
        public string Placa { get; set; } // Propriedade pública para armazenar a placa do veículo.
        public DateTime HoraEntrada { get; set; } // Propriedade pública para armazenar o horário de entrada do veículo.

        public Veiculo(string placa) // Construtor inicializa o veículo com uma placa e define o horário de entrada como o momento atual.
        {
            Placa = placa;
            HoraEntrada = DateTime.Now; // Registra a data e hora atuais no momento da criação do veículo.
        }
    }
    
}