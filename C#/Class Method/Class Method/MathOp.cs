using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method
{
    class MathOp
    {
        public void Math(int n)
        {
            int num = n / 2;
            Console.WriteLine(num);
        }

        public static void Multiply(int x1, out int dbl, out int tpl)
        {
            dbl = 2*x1;
            tpl = 3*x1;

        }
        
        public static void Multiply(int x1,int x2=2, out int mult)
        {
            mult = x1 * x2;
        }
    }

}
