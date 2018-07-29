using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What is your age?");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age<1)
                {
                    throw new ArgumentOutOfRangeException();
                }
                int yearborn = DateTime.Now.Year - age;
                Console.WriteLine(yearborn);
                Console.ReadLine();
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Please enter your real age.");
                Console.ReadLine();
            }
            catch(Exception)
            {
                Console.WriteLine("An error occurred.");
                Console.ReadLine();
            }

        }
    }
}
