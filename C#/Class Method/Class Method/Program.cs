using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOp x = new MathOp();
            Console.WriteLine("Enter an integer.");
            int number = Convert.ToInt32(Console.ReadLine());
            x.Math(number);


            int dbl=0;
            int tpl=0;
            MathOp.Multiply(4, out dbl, out tpl);
            Console.WriteLine(dbl);
            Console.WriteLine(tpl);
            Console.ReadLine();

            int mult = 0;
        }
    }
}
