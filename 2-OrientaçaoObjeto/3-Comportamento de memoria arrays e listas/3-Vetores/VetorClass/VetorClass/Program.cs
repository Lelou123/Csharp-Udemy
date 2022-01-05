using System;
using System.Globalization;

namespace VetorClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos produtos deseja entrar? ");
            int n = int.Parse(Console.ReadLine());
            Produto[] produto = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o nome do produto: ");
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine());
                produto[i] = new Produto(nome, preco);

            }


            double soma = 0;

            for (int i = 0; i < n; i++)
            {
                soma += produto[i].Preco;
            }

            double media = soma / n;

            Console.WriteLine($"Preco medio = {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
