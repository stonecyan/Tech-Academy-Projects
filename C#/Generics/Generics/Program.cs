using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> person = new Employee<string>();
            person.Things = new List<string>();
            person.Things.Add("Computer");
            person.Things.Add("Pen");
            person.Things.Add("Notebook");
            person.Things.Add("ID Badge");

            Employee<int> numbers = new Employee<int>();
            numbers.Things = new List<int>();
            numbers.Things.Add(1);
            numbers.Things.Add(2);
            numbers.Things.Add(3);
            numbers.Things.Add(4);

            foreach (string thing in person.Things)
            {
                Console.WriteLine(thing);
            }

            foreach (int n in numbers.Things)
            {
                Console.WriteLine(n);
            }

            Console.ReadLine();

        }
    }
}
