using System;
using System.Globalization;
namespace DataHora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2022, 1, 11);
            DateTime d2 = new DateTime(2022, 1, 11, 10, 1, 1);
            DateTime d3 = new DateTime(2022, 1, 11, 10, 1, 1, 500);
            
            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);

            DateTime d7 = DateTime.Parse("2022-01-11 10:30:23");
            Console.WriteLine(d7);
            DateTime d8 = DateTime.Parse("21/01/2022 10:30:23");
            Console.WriteLine(d8);

            DateTime d9 = DateTime.ParseExact("2022-01-13 10:40:50", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d9);
        }
    }
}
