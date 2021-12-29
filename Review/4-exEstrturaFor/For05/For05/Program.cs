using System;

namespace For05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor a calcular o fatorial: ");
            int n = int.Parse(Console.ReadLine());

            int fat = 1;
            for(int i = 1; i <= n; i++)
            {
                fat = fat * i;
            }
            Console.WriteLine(fat);
        }
    }
}
