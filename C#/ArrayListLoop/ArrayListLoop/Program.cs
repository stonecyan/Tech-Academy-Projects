using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            //1,4//
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            string[] array1 = new string[] { " went to the store.", " went to the library.", " ran a marathon.", " ate a burger." };
            for (int i=0; i<array1.Length; i++)
            {
                array1[i] = name + array1[i];
                Console.WriteLine(array1[i]);
            }


            ////Infinite loop//
            ////for (int i=0;i<10;i-- )
            ////{
            //    Console.WriteLine("This is an infinite loop.");
            ////}

            //5//
            Console.WriteLine("Give me a number.");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }

            //6,7,8//
            List<string> list1 = new List<string>();
            List<string> found = new List<string>();
            list1.Add("panda");
            list1.Add("tiger");
            list1.Add("penguin");
            list1.Add("giraffe");
            list1.Add("elephant");
            list1.Add("dolphin");
            list1.Add("hippo");
            Console.WriteLine("What animal are you looking for?");
            string animal = Console.ReadLine();
            int j = 0;
            foreach (string a in list1)
            {
                
                if (a==animal)
                {
                    Console.WriteLine("There are " + animal + "s at index "+j);
                    found.Add(animal);
                    break;
                }
                j = j + 1;


            }
            if (found.Count == 0)
            {
                Console.WriteLine("There are no " + animal + "s.");
            }

            //9,10//

            List<string> guests = new List<string>();
            List<string> party = new List<string>();
            guests.Add("John");
            guests.Add("Steve");
            guests.Add("Mike");
            guests.Add("Alex");
            guests.Add("Will");
            guests.Add("John");
            guests.Add("Chris");
            guests.Add("Randy");
            guests.Add("Jamal");
            guests.Add("Tim");

            Console.WriteLine("Who is on the guest list?");
            string guest = Console.ReadLine();
            int k = 0;

            foreach (string g in guests)
            {
                if (g==guest)
                {
                    Console.WriteLine(guest + "is coming to the party, and is at index" + k);
                    party.Add(guest);
                }
                k = k + 1;

               
            }
            if (party.Count == 0)
            {
                Console.WriteLine("Guest is not found.");
            }



            //11//
            List<string> favcolor = new List<string>();
            favcolor.Add("red");
            favcolor.Add("blue");
            favcolor.Add("green");
            favcolor.Add("yellow");
            favcolor.Add("red");
            favcolor.Add("green");
            favcolor.Add("yellow");
            favcolor.Add("blue");
            favcolor.Add("blue");
            int b = 0;
            int r = 0;
            int gr = 0;
            int y = 0;

            foreach(string c in favcolor)
            {
                if(c=="blue")
                {
                    b = b + 1;
                    Console.WriteLine("The color blue has appeared " + b + " times.");
                    
                }
                if(c=="red")
                {
                    r = r + 1;
                    Console.WriteLine("The color red has appeared " + r + " times.");
                }
                if(c=="yellow")
                {
                    y = y + 1;
                    Console.WriteLine("The color yellow has appeared " + y + " times.");
                }
                if(c=="green")
                {
                    gr = gr + 1;
                    Console.WriteLine("The color green has appeared " + gr + " times.");
                }
            }
            Console.ReadLine();
        }
    }
}
