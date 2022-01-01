using System;
using System.Globalization;

namespace Retangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RetanguloCal retangulo = new RetanguloCal();

            Console.WriteLine("Entre a largura e altura do retangulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine());
            retangulo.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine($"Area = {retangulo.Area().ToString("F2", CultureInfo.InvariantCulture)} ");
            Console.WriteLine($"Perimetro = {retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Diagonal = {retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture)} ");
        }
    }
}
