using System;

namespace Estoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();


            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preco: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade em estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Dados do produto: {p.Nome}, {p.Quantidade} unidades, total: R${p.ValorTotalEmEstoque()}");

            Console.WriteLine($"Dados do produto: Tv,   unidades,  total: ");
        }
    }
}
