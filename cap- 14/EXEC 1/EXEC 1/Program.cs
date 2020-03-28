using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EXEC_1 {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");

            Console.Write("Car model: ");
            string carmodel = Console.ReadLine();

            Console.WriteLine("Pickup (dd/MM/yyyy hh:mm): ");
            string pickup = Console.ReadLine();
            DateTime datepickup = DateTime.ParseExact(pickup, "dd/MM/yyyy HH:mm", CultureInfo.CurrentCulture);

            Console.WriteLine("Return (dd/MM/yyyy hh:mm): ");
            string retarn = Console.ReadLine();
            DateTime datereturn = DateTime.ParseExact(retarn, "dd/MM/yyyy HH:mm", CultureInfo.CurrentCulture);

            Console.WriteLine("Enter price per hour: ");
            double pricehour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Enter price per Day: ");
            double priceday = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            TimeSpan duration = datereturn.Subtract(datepickup);
            double total,basic,tax;
            

            if(duration.Days<1 && duration.Hours<12)
            {
                basic = (duration.Minutes>0)?(duration.Hours+1)*pricehour : duration.Hours * pricehour;
                Console.WriteLine("INVOICE:");
                Console.Write("Basic Payment: ");
                Console.WriteLine(basic.ToString("F2",CultureInfo.InvariantCulture));
                tax =(basic < 100) ? basic*0.2 : basic*0.15;                
                Console.WriteLine("tax: "+tax.ToString("F2", CultureInfo.InvariantCulture));
                total = basic + tax;
                Console.WriteLine("total payment: "+ total.ToString("F2", CultureInfo.InvariantCulture));
            }else if (duration.Days < 1 && duration.Hours > 12)
            {
                basic = priceday;
                Console.WriteLine("INVOICE:");
                Console.Write("Basic Payment: ");
                Console.WriteLine(basic.ToString("F2", CultureInfo.InvariantCulture));
                tax = (basic < 100) ? basic * 0.2 : basic * 0.15;
                Console.WriteLine("tax: " + tax.ToString("F2", CultureInfo.InvariantCulture));
                total = basic + tax;
                Console.WriteLine("Total Payment: " + total.ToString("F2", CultureInfo.InvariantCulture));
            }else if(duration.Days >= 1)
            {
                basic = (duration.Hours>0)?priceday*(duration.Days+1):(duration.Minutes>0)?(priceday*duration.Days+1):priceday*duration.Days;
                Console.WriteLine("INVOICE:");
                Console.Write("Basic Payment: ");
                Console.WriteLine(basic.ToString("F2", CultureInfo.InvariantCulture));
                tax = (basic < 100) ? basic * 0.2 : basic * 0.15;
                Console.WriteLine("tax: " + tax.ToString("F2", CultureInfo.InvariantCulture));
                total = basic + tax;
                Console.WriteLine("Total Payment: " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.WriteLine(duration.Days);
            Console.ReadKey();
        }
    }
}
