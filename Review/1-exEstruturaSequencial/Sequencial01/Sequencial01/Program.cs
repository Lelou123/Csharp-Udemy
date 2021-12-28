using System;

namespace Sequencial01
{
    public class Program
    { 
        public static void Main (string[] args)
        {
            Console.WriteLine("Digite dois numeros inteiros: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int soma = a + b;
            Console.WriteLine($"Soma = {soma}");
        }
            
    }
}

