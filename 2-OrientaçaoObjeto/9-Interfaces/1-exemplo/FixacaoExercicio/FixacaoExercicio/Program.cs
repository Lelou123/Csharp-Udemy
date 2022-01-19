using System;
using System.Globalization;
using FixacaoExercicio.Entities;
using FixacaoExercicio.Services;

namespace FixacaoExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract Value: ");
            double contractValue = double.Parse(Console.ReadLine());
            Console.Write("Enter the number of installments: ");
            int months = int.Parse(Console.ReadLine());
            
            Contract contract = new Contract(number, date, contractValue);
            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(contract, months); 

            Console.WriteLine("Installments");
            foreach (Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }

        }
    }
}
