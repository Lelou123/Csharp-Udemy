using System;
using System.Linq;

namespace IntroductionLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //define the data source
            int[] numbers = new int[] {2, 3, 4, 5}; 
            
            //define query expression
            var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);
            foreach(int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
