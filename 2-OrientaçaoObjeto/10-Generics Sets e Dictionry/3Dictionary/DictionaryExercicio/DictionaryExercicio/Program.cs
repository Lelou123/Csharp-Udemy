using System;
using System.IO;
using System.Collections.Generic;

namespace DictionaryExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while(!(sr.EndOfStream))
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string candidate = line[0];
                        int numberVotes = int.Parse(line[1]);
                        
                        if (dictionary.ContainsKey(candidate))
                        {
                            dictionary[candidate] += numberVotes;
                        }
                        else
                        {
                            dictionary[candidate] = numberVotes;
                        }
                    }
                    foreach (var item in dictionary)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                    
                }
            }
            catch (IOException e)
            {

                throw new ArgumentException ("Error:  " + e.Message);
            }
        }
    }
}
