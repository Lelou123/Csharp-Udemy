using System;

namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto("Tv", 100.00, 1);

            p.Nome = "TV Full HD";
            //p.Preco = 1000.0;

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco.ToString("F2"));
        }
    }
}
