﻿using System;
using System.Collections.Generic;
using FixacaoEx.Entities;
namespace FixacaoEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char choose = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Name: ");
                string prodName = Console.ReadLine();
                Console.Write("Price: ");
                double prodPrice = double.Parse(Console.ReadLine());
                if(choose == 'i')
                {
                    Console.Write("Customs Fee: ");
                    double Fee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(prodName, prodPrice, Fee));
                }
                else if (choose == 'u')
                {
                    Console.Write("Manufactured date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(prodName, prodPrice, date));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product p in list)
            {
                Console.WriteLine(p.priceTag());
            }
        }
    }
}
