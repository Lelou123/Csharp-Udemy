using System;
using System.Globalization;

namespace ExpressaoTernaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double preco = 34.5;
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
            double pFinal = preco - desconto; 
            Console.WriteLine(pFinal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
