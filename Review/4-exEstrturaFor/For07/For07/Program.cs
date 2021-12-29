using System;

namespace For07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quantas linhas deseja: ");
            int n = int.Parse(Console.ReadLine());
            int quad, cub, primeiro;
            for(int i = 1; i <= n; i++)
            {
                primeiro = i;
                quad = i * i ;
                cub = i * i * i ;
                Console.WriteLine($"{primeiro} {quad} {cub}");
            }
        }
    }
}
