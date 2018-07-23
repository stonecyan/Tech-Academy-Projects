using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overload
{
    public class Employee : Person
    {
        public int Id { get; set; }

        public override void SayName()
        {
            base.SayName();
        }

        public static bool operator==  (Employee lhs, Employee rhs)
        {
            bool status = lhs == rhs;
            return status;
        }

        public static bool operator!=(Employee lhs, Employee rhs)
        {
            bool status = lhs == rhs;
            return status;
        }
        
    }
}
