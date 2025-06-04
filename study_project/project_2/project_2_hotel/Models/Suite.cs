namespace project_2_hotel.Models
{
    public class Suite
    {
        public string Nome { get; set; }
        public decimal PrecoDiaria { get; set; }
        public int Capacidade { get; set; }
        public bool Disponivel { get; set; }

        public Suite(string nome, decimal precoDiaria, int capacidade)
        {
            Nome = nome;
            PrecoDiaria = precoDiaria;
            Capacidade = capacidade;
            Disponivel = true;
        }

        public override string ToString()
        {
            return $"Suíte: {Nome}, Preço: R${PrecoDiaria:F2}, Capacidade: {Capacidade}, Disponível: {(Disponivel ? "Sim" : "Não")}";
        }
    }
}