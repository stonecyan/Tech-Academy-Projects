using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number.");
            string n = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Stone\Desktop\log.txt", n);
        }
    }
}
