using System;

namespace Repetitivas02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as coordenadas: ");
            
            string[] num = Console.ReadLine().Split(' ');

            int x = int.Parse(num[0]);
            int y = int.Parse(num[1]);

            while (x != 0 || y != 0 )
            {
                if (x > 0 && y > 0) Console.WriteLine("Primeiro");
                else if (x < 0 && y > 0) Console.WriteLine("Segundo");
                else if (x < 0 && y < 0) Console.WriteLine("Terceiro");
                else if (x > 0 && y < 0) Console.WriteLine("Quarto");
                num = Console.ReadLine().Split(' ');
                x = int.Parse(num[0]);
                y = int.Parse(num[1]);
            }

        }
    }
}
