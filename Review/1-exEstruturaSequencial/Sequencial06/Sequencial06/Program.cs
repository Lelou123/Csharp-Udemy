using System;
using System.Globalization; 

namespace Sequencial06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os dados da peça 1: ");
            string peça1 = Console.ReadLine();
            string[] p1 = peça1.Split(" ");
            int cod1 = int.Parse(p1[0]);
            int num1 = int.Parse(p1[1]);
            double valuni1 = double.Parse(p1[2]);

            Console.WriteLine("Digite os dados da peça 2: ");
            string peça2 = Console.ReadLine();
            string[] p2 = peça2.Split(" ");
            int cod2 = int.Parse(p2[0]);
            int num2 = int.Parse(p2[1]);
            double valuni2 = double.Parse(p2[2]);

            double pagar = (num1 * valuni1) + (num2 * valuni2);
            Console.WriteLine($"VALOR A PAGAR = R$ {pagar.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
