using System;

namespace For01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero inteiro: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i <= x; i++)
            {
                if (i % 2 == 1) Console.WriteLine(i);
            }
        }
    }
}
