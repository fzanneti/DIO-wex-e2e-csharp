namespace project_2_hotel
{
    public class Hotel
    {
        private Dictionary<int, Hospede> hospedes;
        private Dictionary<string, Suite> suites;
        private Dictionary<int, Reserva> reservas;
        private int proximoIdHospede;
        private int proximoIdReserva;

        public Hotel()
        {
            hospedes = new Dictionary<int, Hospede>();
            suites = new Dictionary<string, Suite>();
            reservas = new Dictionary<int, Reserva>();
            proximoIdHospede = 1;
            proximoIdReserva = 1;

            // Inicializar suítes
            InicializarSuites();
        }

        private void InicializarSuites()
        {
            suites.Add("Suíte Conforto", new Suite("Suíte Conforto", 450.00m, 2));
            suites.Add("Suíte Luxo", new Suite("Suíte Luxo", 780.00m, 3));
            suites.Add("Suíte Presidencial", new Suite("Suíte Presidencial", 2500.00m, 4));
            suites.Add("Suíte Família", new Suite("Suíte Família", 950.00m, 5));
            suites.Add("Suíte Executiva", new Suite("Suíte Executiva", 620.00m, 2));
        }

        public void CadastrarHospede()
        {
            try
            {
                Console.Write("Digite o nome do hóspede: ");
                string nome = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(nome))
                    throw new ArgumentException("Nome não pode ser vazio.");

                Console.Write("Digite o sobrenome do hóspede: ");
                string sobrenome = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(sobrenome))
                    throw new ArgumentException("Sobrenome não pode ser vazio.");

                Hospede hospede = new Hospede(proximoIdHospede, nome, sobrenome);
                hospedes.Add(proximoIdHospede, hospede);
                Console.WriteLine($"Hóspede {nome} {sobrenome} cadastrado com ID {proximoIdHospede}.");
                proximoIdHospede++;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }
        }

        public void ListarHospedes()
        {
            if (hospedes.Count == 0)
            {
                Console.WriteLine("Nenhum hóspede cadastrado.");
                return;
            }

            Console.WriteLine("\nLista de Hóspedes:");
            foreach (var hospede in hospedes.Values)
            {
                Console.WriteLine(hospede);
            }

            try
            {
                Console.Write("\nDeseja excluir um hóspede? Digite o ID ou 0 para voltar: ");
                if (int.TryParse(Console.ReadLine(), out int id) && id != 0)
                {
                    if (hospedes.ContainsKey(id))
                    {
                        // Verificar se o hóspede está em uma reserva ativa
                        if (reservas.Any(r => r.Value.Hospede.Id == id))
                        {
                            Console.WriteLine("Não é possível excluir: hóspede possui reserva ativa.");
                            return;
                        }

                        hospedes.Remove(id);
                        Console.WriteLine("Hóspede excluído com sucesso.");
                    }
                    else
                    {
                        throw new KeyNotFoundException("ID de hóspede não encontrado.");
                    }
                }
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }
        }

        public void ListarSuites()
        {
            Console.WriteLine("\nLista de Suítes:");
            foreach (var suite in suites.Values)
            {
                Console.WriteLine(suite);
            }

            // Contagem de suítes disponíveis e não disponíveis
            int disponiveis = suites.Values.Count(s => s.Disponivel);
            int naoDisponiveis = suites.Values.Count(s => !s.Disponivel);
            Console.WriteLine($"\nTotal de suítes disponíveis: {disponiveis}");
            Console.WriteLine($"Total de suítes não disponíveis: {naoDisponiveis}");
        }

        public void RealizarReserva()
        {
            try
            {
                if (hospedes.Count == 0)
                {
                    Console.WriteLine("Nenhum hóspede cadastrado. Cadastre um hóspede primeiro.");
                    return;
                }

                if (!suites.Values.Any(s => s.Disponivel))
                {
                    Console.WriteLine("Nenhuma suíte disponível.");
                    return;
                }

                Console.WriteLine("\nHóspedes cadastrados:");
                foreach (var hospede in hospedes.Values)
                {
                    Console.WriteLine(hospede);
                }

                Console.Write("Digite o ID do hóspede: ");
                if (!int.TryParse(Console.ReadLine(), out int idHospede) || !hospedes.ContainsKey(idHospede))
                    throw new KeyNotFoundException("ID de hóspede inválido.");

                Console.WriteLine("\nSuítes disponíveis:");
                foreach (var suite in suites.Values.Where(s => s.Disponivel))
                {
                    Console.WriteLine(suite);
                }

                Console.Write("Digite o nome da suíte: ");
                string nomeSuite = Console.ReadLine();
                if (!suites.ContainsKey(nomeSuite) || !suites[nomeSuite].Disponivel)
                    throw new KeyNotFoundException("Suíte inválida ou não disponível.");

                Console.Write("Digite o número de hóspedes na reserva: ");
                if (!int.TryParse(Console.ReadLine(), out int numPessoas) || numPessoas <= 0)
                    throw new ArgumentException("Número de hóspedes inválido.");

                if (numPessoas > suites[nomeSuite].Capacidade)
                    throw new InvalidOperationException("Capacidade da suíte excedida.");

                Console.Write("Digite o número de dias: ");
                if (!int.TryParse(Console.ReadLine(), out int dias) || dias <= 0)
                    throw new ArgumentException("Número de dias inválido.");

                Reserva reserva = new Reserva(proximoIdReserva, hospedes[idHospede], suites[nomeSuite], dias);
                reservas.Add(proximoIdReserva, reserva);
                Console.WriteLine($"Reserva realizada com sucesso! Custo total: R${reserva.CustoTotal:F2}");
                proximoIdReserva++;
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }
        }

        public void ListarReservas()
        {
            if (reservas.Count == 0)
            {
                Console.WriteLine("Nenhuma reserva cadastrada.");
                return;
            }

            Console.WriteLine("\nLista de Reservas:");
            foreach (var reserva in reservas.Values)
            {
                Console.WriteLine(reserva);
            }

            try
            {
                Console.Write("\nDeseja encerrar uma reserva? Digite o ID ou 0 para voltar: ");
                if (int.TryParse(Console.ReadLine(), out int id) && id != 0)
                {
                    if (reservas.ContainsKey(id))
                    {
                        var reserva = reservas[id];
                        reserva.Suite.Disponivel = true; // Libera a suíte
                        Console.WriteLine($"Reserva ID {id} encerrada. Custo total: R${reserva.CustoTotal:F2}");
                        reservas.Remove(id);
                    }
                    else
                    {
                        throw new KeyNotFoundException("ID de reserva não encontrado.");
                    }
                }
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }
        }
    }

    // Classe principal do programa
    class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Sistema de Hospedagem ===");
                Console.WriteLine("1. Cadastrar Hóspede");
                Console.WriteLine("2. Listar Hóspedes");
                Console.WriteLine("3. Listar Suítes");
                Console.WriteLine("4. Realizar Reserva");
                Console.WriteLine("5. Listar Reservas");
                Console.WriteLine("6. Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();
                Console.Clear();

                try
                {
                    switch (opcao)
                    {
                        case "1":
                            hotel.CadastrarHospede();
                            break;
                        case "2":
                            hotel.ListarHospedes();
                            break;
                        case "3":
                            hotel.ListarSuites();
                            break;
                        case "4":
                            hotel.RealizarReserva();
                            break;
                        case "5":
                            hotel.ListarReservas();
                            break;
                        case "6":
                            Console.WriteLine("Saindo...");
                            return;
                        default:
                            Console.WriteLine("Opção inválida.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro inesperado: {ex.Message}");
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}