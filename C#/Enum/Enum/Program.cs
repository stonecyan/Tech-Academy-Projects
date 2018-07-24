using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Enter the current day of the week.");
                string current = Console.ReadLine();
                int daynumber = 0;
                if (current == "Monday")
                {
                    daynumber = 1;

                }
                else if (current == "Tuesday")
                {
                    daynumber = 2;
                }
                else if (current == "Wednesday")
                {
                    daynumber = 3;
                }
                else if (current == "Thursday")
                {
                    daynumber = 4;
                }
                else if (current == "Friday")
                {
                    daynumber = 5;
                }
                else if (current == "Saturday")
                {
                    daynumber = 6;
                }
                else if (current == "Sunday")
                {
                    daynumber = 0;
                }
                else
                {
                    throw new ArgumentException(); 
                }

                D d = (D)daynumber;
                Console.WriteLine(d);
                Console.ReadLine();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }


        }
    }
}
