using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Income_Comparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1:");
            Console.WriteLine("What is your hourly rate?");
            double rate1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many hours do you work a week?");
            double hour1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Person 2:");
            Console.WriteLine("What is your hourly rate?");
            double rate2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many hours do you work a week?");
            double hour2 = Convert.ToDouble(Console.ReadLine());
            double salary1 = rate1 * hour1 * 52;
            double salary2 = rate2 * hour2 * 52;
            bool compare = salary1 > salary2;
            Console.WriteLine("Annual Salary of Person 1: "+salary1);
            Console.WriteLine("Annual Salary of Person 2: " + salary2);
            Console.WriteLine("Does Person 1 make more money than person 2? " + compare);
            Console.ReadLine();
            

        }
    }
}
