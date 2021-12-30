using System;
using System.Globalization;

namespace _2_exEstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Digite um numero inteiro: ");

            int num = int.Parse(Console.ReadLine());

            if (num < 0 )
            {
                System.Console.WriteLine("Negativo!");
            }else 
            {
                System.Console.WriteLine("Nao negativo: ");
            }
        Exercicio2

            System.Console.WriteLine("Digite um numero inteiro: ");

            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0){
                System.Console.WriteLine("PAR");
            }else{
                System.Console.WriteLine("IMPAR");
            }
        Exercicio3

            System.Console.WriteLine("Digite dois valores inteiros: ");

            string[] valores = Console.ReadLine().Split(" ");
            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);

            if(a % b == 0 || b % a == 0)
            {
                System.Console.WriteLine("Sao multiplos ");
            }else  {
                System.Console.WriteLine("Nao sao multiplos ");
            }
        Exercicio4


            System.Console.WriteLine("Entre dois numeros na mesma linha: ");
            string valores = Console.ReadLine();
            string [] vet = valores.Split (" ");
            int horaInicial = int.Parse(vet[0]);
            int horaFinal = int.Parse(vet[1]);
            
            int duracao;
            if(horaInicial < horaFinal )
            {
                duracao = horaFinal - horaInicial;
            }else{
                duracao = 24 - horaInicial + horaFinal;
            }

            System.Console.WriteLine($"O jogo durou: {duracao} horas ");

            Exercicio5*/

            string[] dados = Console.ReadLine().Split(" ");
            int codigo = int.Parse(dados[0]);
            int quant = int.Parse(dados[1]);

            double total;
            if (codigo == 1) {
                total = quant * 4.0;
            }
            else if (codigo == 2) {
                total = quant * 4.5;
            }
            else if (codigo == 3) {
                total = quant * 5.0;
            }
            else if (codigo == 4) {
                total = quant * 2.0;
            }
            else {
                total = quant * 1.5;
            }

            System.Console.WriteLine($"Total: R$" + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
