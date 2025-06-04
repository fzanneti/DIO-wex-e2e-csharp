namespace project_2_hotel.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public Hospede Hospede { get; set; }
        public Suite Suite { get; set; }
        public int Dias { get; set; }
        public decimal CustoTotal { get; set; }

        public Reserva(int id, Hospede hospede, Suite suite, int dias)
        {
            Id = id;
            Hospede = hospede;
            Suite = suite;
            Dias = dias;
            CustoTotal = CalcularCusto();
            Suite.Disponivel = false;
        }

        public decimal CalcularCusto()
        {
            decimal custo = Dias * Suite.PrecoDiaria;
            if (Dias >= 10)
                custo *= 0.9m; // Aplica 10% de desconto
            return custo;
        }

        public override string ToString()
        {
            return $"Reserva ID: {Id}, Hóspede: {Hospede.Nome} {Hospede.Sobrenome}, Suíte: {Suite.Nome}, Dias: {Dias}, Custo: R${CustoTotal:F2}";
        }
    }
}