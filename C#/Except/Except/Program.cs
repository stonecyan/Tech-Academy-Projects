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
                List<int> x = new List<int>();
                x.Add(4);
                x.Add(23);
                x.Add(30);
                x.Add(115);
                x.Add(2500);

                Console.WriteLine("Input a number.");
                int n = Convert.ToInt32(Console.ReadLine());

                foreach (int num in x)
                {
                    int divide = num / n;
                    Console.WriteLine(divide);
                }
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Program only accepts numbers.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divsion by zero is not possible.");
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
