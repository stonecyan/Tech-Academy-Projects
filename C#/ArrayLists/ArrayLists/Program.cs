using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = new string[] { "My", "name", "is", "Stone", "Yan" };
            int[] array2 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Select an index of the string array from 0-4.");
            int stringindex = Convert.ToInt32(Console.ReadLine());
            if (stringindex>=array1.Length || stringindex<0)
            {
                Console.WriteLine("Selected index does not exist.");
            }
            else
            {
                Console.WriteLine(array1[stringindex]);
            }
            Console.WriteLine("Select another index of the integer array from 0-4.");
            int intindex = Convert.ToInt32(Console.ReadLine());
            if (intindex >= array2.Length||stringindex<0)
            {
                Console.WriteLine("Selected index does not exist.");
            }
            else
            {
                Console.WriteLine(array2[intindex]);
            }
            List<string> array3 = new List<string>();
            array3.Add("Hello!");
            array3.Add("My");
            array3.Add("Name");
            array3.Add("is");
            array3.Add("Stone");

            Console.WriteLine("Select another index of the string List from 0-4");
            int listindex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(array3[listindex]);
            Console.ReadLine();
        }
    }
}
