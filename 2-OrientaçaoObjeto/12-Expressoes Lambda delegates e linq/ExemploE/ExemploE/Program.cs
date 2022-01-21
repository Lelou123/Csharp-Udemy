using System;
using System.Globalization;
using System.Collections.Generic;
using ExemploE.Entities;
using System.IO;
using System.Linq;
namespace ExemploE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full path file: ");
            string path = Console.ReadLine();

            List<Product> products = new List<Product>();

            using(StreamReader sr = File.OpenText(path))
            {
                while(!sr.EndOfStream)
                {
                    string[] p = sr.ReadLine().Split(',');
                    string name = p[0];
                    double price = Double.Parse(p[1], CultureInfo.InvariantCulture);
                    products.Add(new Product(name, price));

                }
            }
            var avg = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average price: " + avg.ToString("F2", CultureInfo.InvariantCulture));
            var names = products.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p=> p.Name);
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
