using System;
using System.Collections.Generic;
namespace Funcionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registred? ");
            int n = int.Parse(Console.ReadLine());
            List<Employees> list = new List<Employees>();
            
            for(int i = 0; i <n; i++)
            {
                Console.WriteLine($"Employee: #{i+1} ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());

                list.Add(new Employees(id, name, salary));

                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int increaseId = int.Parse(Console.ReadLine());
            Employees emp = list.Find(x => x.Id == increaseId);
            
            if(emp != null)
            {
                Console.Write("Enter the percentage: ");
                double per  = double.Parse(Console.ReadLine());
                emp.IncreaseSalary(per);
            }
            else Console.WriteLine("This id does not exist!");
            Console.WriteLine("Updated list of employees: ");
            foreach (Employees obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
