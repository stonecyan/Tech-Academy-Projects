using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Statement
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Count to what number?");
            int number = Convert.ToInt32(Console.ReadLine());
            int n = 1;
            while (n!=number+1)
            {
                Console.WriteLine(n);
                n = n + 1;
            }


            Console.WriteLine("Count down from what number?");
            int num = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine(num);
                num = num - 1;
            }
            while (num > 0);
            Console.ReadLine();
        }
    }
}
