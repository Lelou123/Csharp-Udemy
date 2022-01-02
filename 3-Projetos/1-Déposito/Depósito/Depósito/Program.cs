using System;

namespace Depósito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double quant = 0;

            Console.Write("Entre o numero da conta: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string Nome = Console.ReadLine();
            
            Console.Write("Havera um depósito inciial (s/n)? ");
            string escolha = Console.ReadLine().ToUpper();
            if (escolha == "S" && escolha != "N")
            {
                Console.Write("Valor do depostio inicial: ");
                quant = double.Parse(Console.ReadLine());
            }
            
            Conta p = new Conta(N, Nome, quant);
            
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(p);

            Console.WriteLine();
            Console.Write("Entre um valor para deposito: ");
            quant = double.Parse(Console.ReadLine());
            p.Deposito(quant);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(p);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quant = double.Parse(Console.ReadLine());
            p.Saque(quant);
            
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(p);

        }
    }
}
