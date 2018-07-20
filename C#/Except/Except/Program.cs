using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Except
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<double> x = new List<double>();
                x.Add(4);
                x.Add(23);
                x.Add(30);
                x.Add(115);
                x.Add(2500);

                Console.WriteLine("Input a number.");
                double n = Convert.ToDouble(Console.ReadLine());

                foreach (double num in x)
                {
                    if (n==0)
                    {
                        Console.WriteLine("Dvision by zero is not possible.");
                        break;
                    }
                    double divide = num / n;
                    Console.WriteLine(divide);
                }
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Program only accepts numbers.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Program has finished running.");
                Console.ReadLine();
            }
        }
    }
}
