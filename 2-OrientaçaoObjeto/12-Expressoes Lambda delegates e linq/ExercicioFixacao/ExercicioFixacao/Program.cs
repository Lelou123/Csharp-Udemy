using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using ExercicioFixacao.Entities;
using System.Globalization;

namespace ExercicioFixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            Console.Write("Enter salary: ");
            double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> list = new List<Employee>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] val = sr.ReadLine().Split(',');
                        string name = val[0];
                        string email = val[1];
                        double salary = double.Parse(val[2], CultureInfo.InvariantCulture);
                        list.Add(new Employee(name, email, salary));
                    }
                    var emails = list.Where(obj => obj.Salary > limit).OrderBy(obj => obj.Email).Select(obj => obj.Email);

                    var sum = list.Where(obj => obj.Name[0] == 'M').Sum(obj => obj.Salary);

                    Console.WriteLine("Email of people whose salary is more than " + limit.ToString("F2", CultureInfo.InvariantCulture));
                    foreach (string email in emails)
                    {
                        Console.WriteLine(email);
                    }

                    Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));
                }
            }
            catch (IOException e)
            {

                Console.WriteLine("An error ocurredo " + e.Message); ;
            }


        }
    }
}
