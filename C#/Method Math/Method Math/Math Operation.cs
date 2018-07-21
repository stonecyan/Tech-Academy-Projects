using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Math
{
    class Math_Operation
    {
        public static int Math(int n)
        {
            int square = n * n;
            return square;
        }
        public static double Math(double n)
        {
            double mult_ten = n * 10;
            return mult_ten;

        }
        public static int Math(string n)
        {
            int convert = Convert.ToInt32(n);
            int div_10 = convert / 10;
            return div_10;
        }

    }
}
