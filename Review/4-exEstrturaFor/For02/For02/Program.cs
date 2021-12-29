using System;

namespace For02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a quantidade de valores a serem lidos: ");
            int x = int.Parse(Console.ReadLine());
            int dentro = 0, fora = 0;
            for (int i = 0; i < x; i++)
            {
                int y = int.Parse(Console.ReadLine());
                if (y >= 10 && y <= 20) dentro++;
                else fora++;
            }

            Console.WriteLine();
            Console.WriteLine(dentro + " Dentro");
            Console.WriteLine(fora + " Fora");
            

        }
    }
}
