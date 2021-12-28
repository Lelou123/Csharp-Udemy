using System;
using System.Globalization;

namespace Sequencial05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 valores: ");
            string val = Console.ReadLine();
            string[] v = val.Split(" ");
            double A = double.Parse(v[0]);
            double B = double.Parse(v[1]);
            double C = double.Parse(v[2]);

            double triagulo = (A * C) / 2;
            double pi = 3.14159;
            double circulo = pi * Math.Pow(C, 2);
            double trapezio = (A + B) * C / 2;
            double quadrado = Math.Pow(B, 2);
            double retangulo = A * B;

            Console.WriteLine($"TRIANGULO = {triagulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO = {circulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO = {trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO = {quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO = {retangulo.ToString("F3", CultureInfo.InvariantCulture)}");

        }
    }
}
