using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Number n = new Number();
            n.Amount = 45.3;
            Console.WriteLine(n.Amount);
            Console.ReadLine();
        }
    }
}
