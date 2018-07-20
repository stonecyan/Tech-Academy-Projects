using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number.");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(MathOps.Square(n));
            Console.WriteLine(MathOps.Multiplybyfive(n));
            Console.WriteLine(MathOps.Dividebyten(n));
            Console.ReadLine();
        }
    }
}
