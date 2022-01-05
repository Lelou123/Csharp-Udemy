
using System;

namespace Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maira", "jerferson", "Rodrigo" };
            foreach (string ve in vect)
            {
                Console.WriteLine(ve);
            }
        }
    }
}
