using System;
using System.Globalization;
using System.Collections.Generic;
using MetodosAbstratosFixacao.Entities;

namespace MetodosAbstratosFixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double annualIncome = double.Parse(Console.ReadLine());
                
                if(ch == 'i')
                {
                    Console.Write("Health Expenditures: ");
                    double healthEx = double.Parse(Console.ReadLine());
                    list.Add(new Individual(name, annualIncome, healthEx));
                }
                else if (ch == 'c')
                {
                    Console.Write("Number of employees: ");
                    int nEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, annualIncome, nEmployees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            foreach (TaxPayer taxPayer in list)
            {
                Console.WriteLine(taxPayer);
            }
            Console.WriteLine();
            double sum = 0;
            foreach(TaxPayer tax in list)
            {
                sum += tax.Tax();
            }
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
