using System;

namespace _3_exEstruturaRepetitiva
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Entre A senha!");
            int senha = int.Parse(Console.ReadLine());
           
            while(senha != 2003)
            {
                System.Console.WriteLine("Senha incorreta!");
                senha = int.Parse(Console.ReadLine());
            }

            System.Console.WriteLine("Acesso permitido");

        Exercicio 2  
            System.Console.WriteLine("Insira dois valores: ");
            string[] plano = Console.ReadLine().Split(" ");
            int x = int.Parse(plano[0]);
            int y = int.Parse(plano[1]);
            
            while(x != 0 || y != 0)
            {
                if(x > 0 && y > 0)
                {
                    System.Console.WriteLine("Primeiro");
                }else if(x < 0 && y > 0 )
                {
                    System.Console.WriteLine("Segundo");
                }
                else if(x < 0 && y < 0 )
                {
                    System.Console.WriteLine("Terceiro");
                }
                else if(x > 0 && y < 0 )
                {
                    System.Console.WriteLine("Segundo");
                }
                 plano = Console.ReadLine().Split(" ");
                 x = int.Parse(plano[0]);
                 y = int.Parse(plano[1]);
            }
            Exercicio 3   */

                System.Console.WriteLine("digite o tipo de combustivel");

                int alcool, gasolina, diesel, codigo;

                codigo = int.Parse(Console.ReadLine());
                alcool = 0;
                gasolina = 0;
                diesel = 0;
                
                while (codigo != 4)
                {
                    if(codigo >=1 && codigo <=4)
                    {
                        switch (codigo)
                        {
                            case 1: 
                                alcool++;
                                break;
                            case 2:
                                gasolina++;
                                break;
                            case 3:
                                diesel++;
                                break;
                            case 4: 
                                

                            default:
                            break;
                        }
                    }
                    else{System.Console.WriteLine("Muito obrigado");}
                    codigo = int.Parse(Console.ReadLine());
                }
                
                System.Console.WriteLine("Alcool: " + alcool );
                System.Console.WriteLine("Gasolinda: " + gasolina);
                System.Console.WriteLine("Diesel: " + diesel);


        }
    }
}
