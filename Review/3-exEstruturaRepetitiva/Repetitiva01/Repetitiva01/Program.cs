using System;

namespace Repetitiva01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com uma senha: ");
            int senha = int.Parse(Console.ReadLine());
            int acesso = 2245;

            if (senha != acesso) 
            { 

                while (senha != acesso)
                {
                    Console.WriteLine("Senha invalida");
                    senha = int.Parse(Console.ReadLine());
                    
                }
            } 
            Console.WriteLine("Acesso Permitido!");
            
        }
    }
}
