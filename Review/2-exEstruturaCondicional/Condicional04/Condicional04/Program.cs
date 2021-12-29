using System;

namespace Condicional04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a hora inicial e final de um jogo: ");
            string horas = Console.ReadLine();
            string[] h = horas.Split(' ');
            int horainicio = int.Parse(h[0]);
            int horafinal = int.Parse(h[1]);

            int tempo;
            if (horafinal > horainicio)
            {
                tempo = horafinal - horainicio;  
            }
            else tempo = 24 - horainicio + horafinal;
            Console.WriteLine($"O JOGO DUROU {tempo} HORA(s)!");

        }
    }
}
