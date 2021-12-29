
// Alterando ifs por switch

using System;
using System.Globalization;

namespace Condicional05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o codigo do item e quantidade desejada: ");
            string obj = Console.ReadLine();
            string[] item = obj.Split(' ');
            int cod = int.Parse(item[0]);
            int quant = int.Parse(item[1]);

            double preco = 0;
            switch (cod)
            {
                case 1:
                    preco = 4.00;
                    break;
                case 2:
                    preco = 4.50;
                    break ;
                case 3:
                    preco = 5.00;
                    break;
                case 4:
                    preco = 2.00;
                    break;
                case 5:
                    preco = 1.50;
                    break;

                    
            }
            double total = preco * quant;
            Console.WriteLine($"Total: R${total.ToString("F2", CultureInfo.InvariantCulture)} ");


        }
    }
}
