using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee person1 = new Employee() { FirstName = "Joe", LastName = "Biden", Id = 1};
            Employee person2 = new Employee() { FirstName = "Joe" , LastName = "Montana", Id= 2};
            Employee person3 = new Employee() { FirstName = "Donald", LastName = "Trump", Id = 3};
            Employee person4 = new Employee() { FirstName = "Barrack", LastName = "Obama", Id =4};
            Employee person5 = new Employee() { FirstName = "George", LastName = "Bush", Id =5};
            Employee person6 = new Employee() { FirstName = "Bill", LastName = "Clinton", Id =6};
            Employee person7 = new Employee() { FirstName = "Ronald", LastName = "Reagan", Id =7};
            Employee person8 = new Employee() { FirstName = "Jimmy", LastName = "Carter", Id =8};
            Employee person9 = new Employee() { FirstName = "Gerald", LastName = "Ford", Id =9};
            Employee person10 = new Employee() { FirstName = "Richard", LastName = "Nixon", Id =10};


            List<Employee> employees = new List<Employee>() { person1, person2, person3, person4, person5, person6, person7, person8, person9, person10 };


            //Finding Joes using foreach loop

            //List<Employee> joes = new List<Employee>();
            //foreach (Employee e in employees)
            //{
            //    if (e.FirstName == "Joe")
            //    {
            //        joes.Add(e);
            //    }   
            //}

            //foreach (Employee x in joes)
            //{ Console.WriteLine(x.FirstName); }

            //Finding Joes using lambda

            var joes = employees.Where(x => x.FirstName == "Joe");

            foreach (Employee x in joes)
            {
                Console.WriteLine(x.FirstName);
            }
        
            Console.ReadLine();
        }
    }
}
