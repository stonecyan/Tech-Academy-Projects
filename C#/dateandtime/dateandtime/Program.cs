using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dateandtime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Enter a number.");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(DateTime.Now.AddHours(n));
            Console.ReadLine();
        }
    }
}
