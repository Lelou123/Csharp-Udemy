using System;
using System.Globalization;
using System.IO;
using Fixacao.Entities;

namespace Fixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the path");
            string sourceFilePath = Console.ReadLine();
            StreamReader sr = null;

            try
            {
                string[] lines = File.ReadAllLines(sourceFilePath);
                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                string targetFolderPath = sourceFilePath + @"\out";
                string targetFilePath = targetFolderPath + @"summary.csv";
                Directory.CreateDirectory(targetFolderPath);
                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string line in lines)
                    {

                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Product prod = new Product(name, price, quantity);

                        sw.WriteLine(prod.Name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

                sr = File.OpenText(sourceFilePath);
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
