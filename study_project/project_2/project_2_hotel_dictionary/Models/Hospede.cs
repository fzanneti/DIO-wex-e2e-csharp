using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using project_2_hotel_dictionary.Services; // Importa os serviços de cadastro e reserva     

namespace project_2_hotel_dictionary.Models
{
    public class Hospede
    {
        public int Id { get; set; } // PT-BR: GET / SET ID do hóspede
        public string Nome { get; set; } // PT-BR: GET / SET Nome do hóspede
        public string Sobrenome { get; set; } // PT-BR: GET / SET Sobrenome do hóspede
        public Hospede(int id, string nome, string sobrenome) // PT-BR: Construtor da classe Hospede
        {
            Id = id; // PT-BR: Atribui o ID do hóspede
            Nome = nome; // PT-BR: Atribui o Nome do hóspede
            Sobrenome = sobrenome; // PT-BR: Atribui o Sobrenome do hóspede
        }

        public override string ToString() // PT-BR: Método ToString para exibir informações do hóspede
        {
            return $"ID: {Id}, Nome: {Nome} {Sobrenome}"; // PT-BR: Retorna uma string formatada com ID, Nome e Sobrenome do hóspede
        }
    }
}