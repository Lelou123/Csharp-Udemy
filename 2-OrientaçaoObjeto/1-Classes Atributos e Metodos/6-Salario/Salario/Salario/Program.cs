using System;

namespace Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario pessoa = new Funcionario();

            Console.Write("Nome: ");
            pessoa.Nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            pessoa.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            pessoa.imposto = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Funcionario: {pessoa}");
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double porc = double.Parse(Console.ReadLine());
            pessoa.AumentarSalario(porc);

            Console.WriteLine($"Dados atualizados: {pessoa}");
        }
    }
}
