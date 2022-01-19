using System;
using System.Globalization;
using ExemploInterface.Entities;
using ExemploInterface.Sevices;

namespace ExemploInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:MM) ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:MM) ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine());
            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine());
            
            CarRental carRental = new CarRental(start, finish, new Vehicle(model));
            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());
            
            rentalService.ProcessInvoice(carRental);
            Console.WriteLine("Invoice");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
