using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Math_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer.");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another integer. This is optional, so enter \"None\" if you do not want to enter an integer. ");
            string n2 = Console.ReadLine();
            if (n2 == "None")
            {
                Console.WriteLine(Math.Add(n1));
            }
            else
            {
                int n22 = Convert.ToInt32(n2);
                Console.WriteLine(Math.Add(n1, n22));
            }
            Console.ReadLine();
        }
    }
}
