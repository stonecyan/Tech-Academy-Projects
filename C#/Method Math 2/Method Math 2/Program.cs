using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Math_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOp mathop = new MathOp();
            mathop.Math(4, 2);
            mathop.Math(n1: 4, n2: 2);
            Console.ReadLine();
        }
    }
}
