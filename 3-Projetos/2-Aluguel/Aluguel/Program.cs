using System;

namespace Aluguel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serao alugados? ");
            int n = int.Parse(Console.ReadLine());
            Quarto[] Q = new Quarto[10];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Aluguel #{i+ 1}: ");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int nQuarto = int.Parse(Console.ReadLine());
                Q[nQuarto] = new Quarto(nome, email);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for(int i = 0; i < 10;i++)
            {
                if (Q[i] != null)
                {
                    Console.WriteLine($"{i} {Q[i]}");
                }
            }
        }
    }
}
