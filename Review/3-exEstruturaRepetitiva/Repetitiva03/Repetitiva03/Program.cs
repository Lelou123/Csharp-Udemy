using System;

namespace Repetitiva03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual combustivel deseja? ");
            int tipo = int.Parse(Console.ReadLine());
            int Alc = 0, Gaso = 0, Di = 0;

            while (tipo != 4)
            {
                switch (tipo)
                {
                    case 1:
                        Alc += 1;
                        break;
                    case 2:
                        Gaso += 1;
                        break;
                    case 3:
                        Di += 1;
                        break;
                    case 4:
                        break;
                }

                tipo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine($"Alcool: {Alc}");
            Console.WriteLine($"Gasolina: {Gaso}");
            Console.WriteLine($"Diesel: {Di}");

        }
    }
}
