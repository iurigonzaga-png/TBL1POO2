using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> salas = new List<string>();
        List<string> responsaveis = new List<string>();
        List<string> reservas = new List<string>();

        while (true)
        {
            Console.WriteLine("\n1-Nova Sala | 2-Novo Responsável | 3-Ver Salas | 4-Reservar | 5-Ver Reservas | 0-Sair");
            Console.Write("Opção: ");
            string op = Console.ReadLine();

            if (op == "0") break;

            if (op == "1")
            {
                Console.Write("Nome da sala: ");
                salas.Add(Console.ReadLine());
            }
            else if (op == "2")
            {
                Console.Write("Nome do responsável: ");
                responsaveis.Add(Console.ReadLine());
            }
            else if (op == "3")
            {
                Console.WriteLine("\n--- Salas Cadastradas ---");
                if (salas.Count == 0) Console.WriteLine("Nenhuma.");
                foreach (var s in salas) Console.WriteLine($"- {s}");
            }
            else if (op == "4")
            {
                Console.Write("Nome da sala: ");
                string sala = Console.ReadLine();
                Console.Write("Nome do responsável: ");
                string resp = Console.ReadLine();
                Console.Write("Data e Horário (ex: 20/10 às 14h): ");
                string data = Console.ReadLine();

                reservas.Add($"{sala} reservada por {resp} para {data}");
                Console.WriteLine("Reserva confirmada!");
            }
            else if (op == "5")
            {
                Console.WriteLine("\n--- Reservas Realizadas ---");
                if (reservas.Count == 0) Console.WriteLine("Nenhuma.");
                foreach (var r in reservas) Console.WriteLine($"- {r}");
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }
        }
    }
}
