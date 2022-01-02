using System;
using System.Globalization;

namespace CasaMoeda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dolar? ");
            double cotacao = double.Parse(Console.ReadLine());
            Console.Write("Quantos dolares voce vai comprar? ");
            double quantia = double.Parse(Console.ReadLine());
            double r = ConversorDeMoeda.DolarParaReal(cotacao, quantia);
            Console.WriteLine(;
            Console.WriteLine("Valor a ser pago em reais = " + r.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
    