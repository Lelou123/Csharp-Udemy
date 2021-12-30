using System;
using System.Globalization;

namespace _4_exEstruturaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Digite um valor inteiro!");
            int X = int.Parse(Console.ReadLine());
            System.Console.WriteLine();

            for(int i = 0; i <=X; i++)
            {
                if(i % 2 != 0){
                    System.Console.WriteLine(i);
                }
            }
        
        Exercicio2
            
            System.Console.WriteLine("Digite um valor N");
            int N = int.Parse(Console.ReadLine());
            int dentro = 0;
            int fora = 0;

            for(int i = 0; i< N; i++)
            {
                int X = int.Parse(Console.ReadLine());
                
                if(X >= 10 && X<= 20)
                {
                    dentro++;
                }else
                {
                    fora++;
                }
            }
            System.Console.WriteLine(dentro + " dentro");
            System.Console.WriteLine(fora + " fora");
        
        Exercicio3*/
            
            System.Console.WriteLine("Digite um valor N");
            int N = int.Parse(Console.ReadLine());
            
            

            for(int i = 0; i< N; i++)
            {
                string[] valores = Console.ReadLine().Split(" ");
                double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                
            }
            
        }
    }
}
