using System;

namespace Condicional01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            int x = int.Parse(Console.ReadLine());
            if (x >= 0 ) Console.WriteLine("NAO NEGATIVO! ");
            else
            {
                Console.WriteLine("NEGATIVO!");
            }
        }
    }
}
