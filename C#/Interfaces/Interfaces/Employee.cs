using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Employee:Person, IQuittable
    {
        public override void SayName()
        {
            base.SayName();
        }

        public void Quit(IQuittable employee)
        {
            Console.WriteLine("Employee Quits.");
        }

    }
}
