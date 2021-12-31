using System;
using System.Globalization;

namespace Funcionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario primeiro = new Funcionario();
            Funcionario segundo = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario: ");
            Console.Write("Nome: ");
            primeiro.nome = Console.ReadLine();
            Console.Write("Salario: ");
            primeiro.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionario: ");
            Console.Write("Nome: ");
            segundo.nome = Console.ReadLine();
            Console.Write("Salario: ");
            segundo.salario = double.Parse(Console.ReadLine());
            double smedio = (primeiro.salario + segundo.salario) / 2.0; 

            Console.WriteLine($"Salario medio = {smedio.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
