using System;

namespace Math_Operations
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input a number.");
            double num = Convert.ToDouble(Console.ReadLine());
            double mult = num * 50;
            Console.WriteLine("Your number times 50 is "+mult);
            Console.WriteLine("Input another number.");
            double numb = Convert.ToDouble(Console.ReadLine());
            double add = numb + 25;
            Console.WriteLine("Your number plus 25 is " + add);
            Console.WriteLine("Input another number.");
            double numbe = Convert.ToDouble(Console.ReadLine());
            double divide = numbe / 12.5;
            Console.WriteLine("Your number divided by 12.5 is " + divide);
            Console.WriteLine("Input another number.");
            double number = Convert.ToDouble(Console.ReadLine());
            bool compare = number > 50;
            Console.WriteLine(compare);
            Console.WriteLine("Input another number.");
            double n = Convert.ToDouble(Console.ReadLine());
            double remainder = n % 7;
            Console.WriteLine("The remainder of your number divided by 7 is " + remainder);




        }
    }
}
