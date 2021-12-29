using System;

namespace Condicional03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois numeros: ");
            string val = Console.ReadLine();
            string [] v = val.Split(' ');
            int a = int.Parse(v[0]);
            int b = int.Parse(v[1]);

            if (a % b == 0 || b % a == 0) Console.WriteLine("Sao multiplos");
            else Console.WriteLine("Nao sao multiplos");
        }
    }
}
