using System;
using System.Globalization;

namespace Media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notas aluno = new Notas();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as tres notas do aluno: ");
            aluno.Primeira = double.Parse(Console.ReadLine());
            aluno.Segunda = double.Parse(Console.ReadLine());
            aluno.Terceira = double.Parse(Console.ReadLine());
            Console.WriteLine();
            
            Console.WriteLine($"Nota Final = {aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}");
            
            if (aluno.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                
                Console.WriteLine("FALTARAM: " + aluno.Resultado().ToString("F2", CultureInfo.InvariantCulture) + " Pontos");
            }
        }
    }
}
