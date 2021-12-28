using System;
using System.Globalization;

namespace Sequencial02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            Console.WriteLine("Digite o raio do circulo: ");
            
            double raio = double.Parse(Console.ReadLine());
            double area = pi * Math.Pow(raio, 2);
            Console.WriteLine($"A = {area.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}
