using System;

namespace Condicional07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois valores: ");
            string val = Console.ReadLine();
            string[] num = val.Split(' ');
            double x = double.Parse(num[0]);
            double y = double.Parse(num[1]);
            Console.WriteLine();

            if (x > 0 && y > 0) Console.WriteLine("Q1");
            else if (x < 0 && y > 0) Console.WriteLine("Q2");
            else if (x < 0 && y < 0) Console.WriteLine("Q3");
            else if (x > 0 && y < 0) Console.WriteLine("Q4");
            else if (x == 0 && y == 0) Console.WriteLine("ORIGEM");
            Console.WriteLine();
        }
    }
}
