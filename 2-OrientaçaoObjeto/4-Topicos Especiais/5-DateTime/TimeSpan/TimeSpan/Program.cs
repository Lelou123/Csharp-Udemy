using System;

namespace TimeSpan
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            
            TimeSpan t0 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t0);
            Console.WriteLine(t0.Ticks);
            
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 21);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
        }
    }
}
