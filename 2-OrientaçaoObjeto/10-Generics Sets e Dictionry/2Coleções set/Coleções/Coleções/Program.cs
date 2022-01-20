using System;
using System.IO;
using System.Collections.Generic;
using Coleções.Entities;
namespace Coleções
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecords> set = new HashSet<LogRecords>();
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        
                        string[] line = sr.ReadLine().Split(" ");
                        string name = line[0];
                        DateTime intant = DateTime.Parse(line[1]);
                        set.Add(new LogRecords { Username = name, Instant = intant });
                        
                    }
                    Console.WriteLine("Total users: " + set.Count);
                }
            }
            catch (IOException e)
            {

                throw new IOException("Error:  " + e.Message);
            }
        }
    }
}
