using System;
using System.Globalization;
using exec1_formacorreta.Entities;

namespace exec1_formacorreta {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string carmodel = Console.ReadLine();

            Console.WriteLine("Pickup (dd/MM/yyyy HH:mm): ");
            string pickup = Console.ReadLine();
            DateTime datepickup = DateTime.ParseExact(pickup, "dd/MM/yyyy HH:mm", CultureInfo.CurrentCulture);

            Console.WriteLine("Return (dd/MM/yyyy HH:mm): ");
            string retarn = Console.ReadLine();
            DateTime datereturn = DateTime.ParseExact(retarn, "dd/MM/yyyy HH:mm", CultureInfo.CurrentCulture);

            CarRental carRental = new CarRental(datepickup, datereturn, new Vehicle(carmodel));

            Console.WriteLine("Enter price per hour: ");
            double pricehour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Enter price per Day: ");
            double priceday = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
    }
}
