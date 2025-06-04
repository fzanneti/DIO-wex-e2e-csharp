namespace project_2_hotel.Models
{
    public class Hospede
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public Hospede(int id, string nome, string sobrenome)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Nome: {Nome} {Sobrenome}";
        }
    }
}