using System;
using System.Globalization;
namespace Sequencial04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero do funcionario: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite suas horas trabalhadas e o valor: ");
            int horast = int.Parse(Console.ReadLine());
            double ph = double.Parse(Console.ReadLine());
            double salario = ph * horast;

            Console.WriteLine($"Numero funcionario = {num}");
            Console.WriteLine($"Salario = R$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
