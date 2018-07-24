using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person1 = new Employee
            {
                FirstName = "Sample",
                LastName = "Student",
                Id = 1
            };

            Employee person2 = new Employee
            {
                FirstName = "Student",
                LastName = "Sample",
                Id = 2
            };

            person1.SayName();
            person2.SayName();

            bool compare = person1 == person2;
            Console.WriteLine(compare);
            Console.ReadLine();

        }
    }
}
