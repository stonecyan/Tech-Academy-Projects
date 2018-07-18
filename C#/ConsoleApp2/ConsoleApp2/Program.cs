using System;
    class String
    {
        static void Main(string[] args)
        {
        string string1 = "My name";
        string string2 = " is";
        string string3 = " Stone";
        string combined = string1 + string2 + string3;
        Console.WriteLine(combined);
        string upper = string3.ToUpper();
        Console.WriteLine(upper);

        System.Text.StringBuilder sb = new System.Text.StringBuilder();
    
        sb.Append("It matters not how strait the gate, ");
        sb.Append("It matters not how strait the gate, ");
        sb.Append("I am the master of my fate, ");
        sb.Append("I am the captain of my soul. ");
        Console.WriteLine(sb);
        Console.ReadLine();
        }
    }