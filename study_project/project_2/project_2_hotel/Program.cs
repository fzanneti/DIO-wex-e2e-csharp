using System;
using project_2_hotel.models;
using System.Collections.Generic;

namespace project_2_hotel.models
{
    class Program
    {
        static Dictionary<string, Pessoa> hospedes = new Dictionary<string, Pessoa>();
        static Dictionary<string, Suite> suites = new Dictionary<string, Suite>();
        static Dictionary<string, Reserva> reservas = new Dictionary<string, Reserva>();

        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Sistema de Hospedagem ===");
                Console.WriteLine("1. Cadastrar Hóspede");
                Console.WriteLine("2. Cadastrar Suíte");
                Console.WriteLine("3. Cadastrar Reserva");
                Console.WriteLine("4. Visualizar Dados");
                Console.WriteLine("5. Sair");
                Console.Write("Escolha uma opção: ");
                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        CadastrarHospede();
                        break;
                    case "2":
                        CadastrarSuite();
                        break;
                    case "3":
                        CadastrarReserva();
                        break;
                    case "4":
                        VisualizarDados();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Pressione Enter para continuar.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        static void CadastrarHospede()
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Sobrenome: ");
            string sobrenome = Console.ReadLine();
            string chave = nome.ToLower() + sobrenome.ToLower();
            hospedes[chave] = new Pessoa { Nome = nome, Sobrenome = sobrenome };
            Console.WriteLine("Hóspede cadastrado com sucesso!");
            Console.ReadLine();
        }

        static void CadastrarSuite()
        {
            Console.Write("Tipo da suíte: ");
            string tipo = Console.ReadLine();
            Console.Write("Capacidade: ");
            int capacidade = int.Parse(Console.ReadLine());
            Console.Write("Valor da diária: ");
            decimal valor = decimal.Parse(Console.ReadLine());
            suites[tipo.ToLower()] = new Suite { TipoSuite = tipo, Capacidade = capacidade, ValorDiaria = valor };
            Console.WriteLine("Suíte cadastrada com sucesso!");
            Console.ReadLine();
        }

        static void CadastrarReserva()
        {
            Console.Write("Informe o tipo da suíte: ");
            string tipo = Console.ReadLine().ToLower();
            if (!suites.ContainsKey(tipo))
            {
                Console.WriteLine("Suíte não encontrada.");
                Console.ReadLine();
                return;
            }

            Suite suiteSelecionada = suites[tipo];

            Console.Write("Informe quantos hóspedes serão cadastrados: ");
            int total = int.Parse(Console.ReadLine());
            if (total > suiteSelecionada.Capacidade)
            {
                Console.WriteLine("Erro: número de hóspedes excede a capacidade da suíte.");
                Console.ReadLine();
                return;
            }

            List<Pessoa> listaHospedes = new List<Pessoa>();
            for (int i = 0; i < total; i++)
            {
                Console.Write($"Nome do hóspede {i + 1}: ");
                string nome = Console.ReadLine();
                Console.Write("Sobrenome: ");
                string sobrenome = Console.ReadLine();
                string chave = nome.ToLower() + sobrenome.ToLower();
                if (hospedes.ContainsKey(chave))
                    listaHospedes.Add(hospedes[chave]);
                else
                    listaHospedes.Add(new Pessoa { Nome = nome, Sobrenome = sobrenome });
            }

            Console.Write("Dias reservados: ");
            int dias = int.Parse(Console.ReadLine());

            Reserva novaReserva = new Reserva(dias);
            novaReserva.CadastrarSuite(suiteSelecionada);
            novaReserva.CadastrarHospedes(listaHospedes);

            string idReserva = Guid.NewGuid().ToString();
            reservas[idReserva] = novaReserva;

            Console.WriteLine($"Reserva cadastrada com sucesso! Total: R$ {novaReserva.CalcularValorDiaria()}");
            Console.ReadLine();
        }

        static void VisualizarDados()
        {
            Console.WriteLine("--- Hóspedes ---");
            foreach (var h in hospedes.Values)
                Console.WriteLine($"{h.Nome} {h.Sobrenome}");

            Console.WriteLine("--- Suítes ---");
            foreach (var s in suites.Values)
                Console.WriteLine($"{s.TipoSuite} - Capacidade: {s.Capacidade} - Valor Diária: R$ {s.ValorDiaria}");

            Console.WriteLine("--- Reservas ---");
            foreach (var r in reservas.Values)
                Console.WriteLine($"Hospedes: {r.ObterQuantidadeHospedes()} - Dias: {r.DiasReservados} - Total: R$ {r.CalcularValorDiaria()}");

            Console.ReadLine();
        }
    }
}