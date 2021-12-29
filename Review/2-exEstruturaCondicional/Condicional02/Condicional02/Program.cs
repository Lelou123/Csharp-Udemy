using System;

namespace Condicional02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero inteiro: ");
            int x = int.Parse(Console.ReadLine());
            if (x % 2 == 0) Console.WriteLine("PAR");
            else Console.WriteLine("IMPAR");
        }
    }
}
