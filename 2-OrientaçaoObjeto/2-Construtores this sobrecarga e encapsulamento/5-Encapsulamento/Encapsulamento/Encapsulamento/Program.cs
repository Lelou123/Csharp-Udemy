using System;

namespace Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
                
            Produto p  = new Produto("Tv", 100.00, 1);
            
            p.SetNome("TV Full HD") ;

            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco().ToString("F2"));
        }
    }
}
