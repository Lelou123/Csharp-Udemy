using System;
using System.Globalization;

namespace For04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de casos: ");
            int n = int.Parse(Console.ReadLine());

            int a, b, divisao;
            for (int i = 0; i < n; i++)
            {
                string[] val = Console.ReadLine().Split(' ');
                a = int.Parse(val[0]);
                b = int.Parse(val[1]);
                if (b == 0)
                {
                    Console.WriteLine("Divisao impossivel");
                }
                else
                {
                    divisao = a / b;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
                
            }
        }
    }
}
