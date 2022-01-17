using FixacaoEx.Entities;
using System;
using System.Globalization;
using FixacaoEx.Entities.Exceptions;

namespace FixacaoEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Numbe: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());
                
                Account account = new Account(number, holder, initialBalance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double withdrawAmount = double.Parse(Console.ReadLine());
                account.Withdraw(withdrawAmount);
                Console.WriteLine("New Balance: " + account.Balance.ToString("F2",CultureInfo.InvariantCulture));

            }
            catch (FormatException e)
            {
                Console.WriteLine("Erroe in format" + e.Message);
            }
            catch(DomainException e)
            {
                Console.WriteLine("Error in reservation " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error! " + e.Message);
            }
            
        }
    }
}
