using System;
using System.IO;
using System.Collections.Generic;
using InterfaceComparable.Entities;

namespace InterfaceComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"K:\in.csv";
            //string spath = @"K:\inout.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    //File.Create(spath);
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee e in list)
                    {
                        Console.WriteLine(e);
                    }
                }
            }
            catch (IOException e)
            {

                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
