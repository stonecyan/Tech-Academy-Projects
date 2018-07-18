using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package_Shipping
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("What is your package weight?");
            double weight = Convert.ToDouble(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
                
            }
            Console.WriteLine("What is the package width?");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the package height?");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the package length?");
            double length = Convert.ToDouble(Console.ReadLine());
            double total = width + height + length;
            if (total > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            double quote = total * weight/100;
            Console.WriteLine("Your estimated total for shipping the package is: $" + quote);
            Console.ReadLine();
        }
    }
}
