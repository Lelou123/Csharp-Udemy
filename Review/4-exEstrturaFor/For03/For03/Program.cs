using System;
using System.Globalization;

namespace For03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero de casos: ");
            int x = int.Parse(Console.ReadLine());

            double media, a, b, c;

            for (int i = 0; i < x; i++)
            {
                string[] val = Console.ReadLine().Split(' ');
                a = double.Parse(val[0]);
                b = double.Parse(val[1]);
                c = double.Parse(val[2]);
                media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }


        }
    }
}
