using System;


namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2022, 01, 20, 10, 40, 23);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
