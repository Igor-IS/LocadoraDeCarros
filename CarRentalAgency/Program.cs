using CarRentalAgency.Entities;
using CarRentalAgency.Services;
using System;
using System.Globalization;

namespace CarRentalAgency
{
    class Program
    {
        static void Main(string[] args)
        {
            string model = GetModelVehicle();
            var carModel = new Vehicle(model);

            DateTime start = GetStartDate();
            DateTime finish = GetFinishDate();

            try
            {
                var carRental = new CarRental(start, finish, carModel);
                double hour = GetPricePerHour();
                double day = GetPricePerDay();
                var rentalService = new RentalService(hour, day, new BrazilTaxService());
                rentalService.ProcessInvoice(carRental);
                Console.WriteLine("Invoice: \n" + carRental.Invoice);
            }
            catch (FormatException error)
            {
                Console.WriteLine("Error" + error.Message);
            }
            catch (Exception error)
            {
                Console.WriteLine("Unexpected error" + error.Message);
            }
        }

        static string GetModelVehicle()
        {
            Console.Write("What model: ");
            string model = Console.ReadLine().ToUpper();
            return (string)model;
        }

        static DateTime GetStartDate()
        {
            Console.Write("Start date: ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            return start;
        }

        static DateTime GetFinishDate()
        {
            Console.Write("Finish Date: ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            return finish;
        }

        static double GetPricePerHour()
        {
            Console.Write("Enter price per hour: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            return price;
        }

        static double GetPricePerDay()
        {
            Console.Write("Enter price per day: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            return price;
        }
    }
}
