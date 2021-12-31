
using System;

namespace Pessoas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoas primeira = new Pessoas();
            Pessoas Segunda = new Pessoas();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            primeira.nome = Console.ReadLine();
            Console.Write("Idade: ");
            primeira.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            Segunda.nome = Console.ReadLine();
            Console.Write("Idade: ");
            Segunda.idade = int.Parse(Console.ReadLine());

            if (primeira.idade > Segunda.idade) Console.WriteLine($"Pessoa mais velha {primeira.nome}");
            else Console.WriteLine($"Pessoa mais velha {Segunda.nome}");
        }
    }
}
