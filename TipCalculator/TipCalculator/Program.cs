using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TipCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double tipRate = 0.18;
            double billTotal = 0;

            if (args.Length == 0 || !Double.TryParse(args[0], out billTotal))
            {
                Console.WriteLine("Please use :TipCalculator total");
                Console.ReadLine();





            }
            double tip = billTotal * tipRate;
            Console.WriteLine();
            Console.WriteLine($"Your bill total is:\t {billTotal,8:c}");
            Console.WriteLine($"Your tip total/rate:\t{tip,8:c} ({tipRate:p1})");
            Console.WriteLine(("").PadRight(24, '-'));
            Console.WriteLine($"Grand Total:\t{billTotal + tip, 8:c}");
            Console.ReadLine();

            #region formattingCurrency
            /*            Console.WriteLine("(C) Currency:....{0:C}", 50); // This willl display a currency
                        Console.WriteLine("(P) Percentage:....{0:P}", 50); // this will display a percentage
                        double val = 34343.34;
                        Console.WriteLine(val.ToString("C", CultureInfo.CreateSpecificCulture("en-GB"))); // Displays in British pounds
                        Console.ReadLine(); */
            #endregion

        }
    }
}
