using System;

namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto("Tv", 100.00, 1);

            p.Nome = "TV Full HD";


            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco.ToString("F2"));
        }
    }
}
