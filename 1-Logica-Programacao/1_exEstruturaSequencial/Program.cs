using System;
using System.Globalization;

namespace _1_exEstruturaSequencial
{
    class Program
    {

        static void Main (string[] Args)
       {
           /*
        Exercicio 1

            Console.WriteLine("Entre dois numeros: ");
            int x  =  int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int soma = x + y;
            System.Console.WriteLine($"SOMA = {soma}");

          
           System.Console.WriteLine("Digite o valor do raio");
           
           double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           
           double pi = 3.14159;
           double area = pi * Math.Pow(raio, 2);

           System.Console.WriteLine("A = " + area.ToString("F4", CultureInfo.InvariantCulture));
        
        Exercicio 3:
            
            System.Console.WriteLine("Digite quatro valores inteiros: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int diferenca = a * b - c * d;

            System.Console.WriteLine($"DIFERENCA = {diferenca}");

        Exercicio 4:
            

            System.Console.WriteLine("Digite o numero do funcionario, horas trabalhadas e o valor da hora");
            int number = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double perHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salary = perHour * hours;

            System.Console.WriteLine($"NUMBER = {number}");
            System.Console.WriteLine("SALARY = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));
        Exercicio 5:
            
            System.Console.WriteLine("Entre as informacoes das peças: ");
            int Cod1, Cod2, num1, num2;
            double uni1, uni2;

            string[] prod1 = Console.ReadLine().Split(" ");
            Cod1 = int.Parse(prod1[0]);
            num1 = int.Parse(prod1[1]);
            uni1 = int.Parse(prod1[2]);

            System.Console.WriteLine();
            System.Console.WriteLine("Entre as informacoes da segunda peça: ");
            string[] prod2 = Console.ReadLine().Split(" ");
            Cod2 = int.Parse(prod2[0]);
            num2 = int.Parse(prod2[1]);
            uni2 = int.Parse(prod2[2]);

            double total = (num1 * uni1) + (num2 * uni2);

            System.Console.WriteLine("VALOR A PAGAR = R$" + total.ToString("F2", CultureInfo.InvariantCulture));
        Exercicio 5:
            */
            System.Console.WriteLine("Entre com os valores: ");

            string[] valores = Console.ReadLine().Split(" ");

            double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double c = double.Parse(valores[2], CultureInfo.InvariantCulture);
            
            double areaTri = (a * c )/ 2;
            double areaCirc = 3.14159 * c * c; 
            double areaTrapezio = ((a + b) * c) / 2;

            double areaQuad = Math.Pow(b, 2);
            double areaReta = a * b;

            System.Console.WriteLine("TRIANGULO: " +  areaTri.ToString("F4", CultureInfo.InvariantCulture));
            System.Console.WriteLine("CIRCULO: " + areaCirc.ToString("F4", CultureInfo.InvariantCulture));
            System.Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F4", CultureInfo.InvariantCulture));
            System.Console.WriteLine("QUADRADO: " + areaQuad.ToString("F4", CultureInfo.InvariantCulture));
            System.Console.WriteLine("RETANGULO: " + areaReta.ToString("F4", CultureInfo.InvariantCulture));
       
       }
    }
}
