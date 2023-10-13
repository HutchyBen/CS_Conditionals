using System;

namespace Conditionals
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("First sibling, what is your name?");
 
            string name1 = Console.ReadLine();
 
            Console.WriteLine("Hello " + name1 + ", How old are you?");
 
            int age1 = int.Parse(Console.ReadLine());
 
            Console.WriteLine("Second sibling, what is your name?");
 
            string name2 = Console.ReadLine();
 
            Console.WriteLine("Hello " + name2 + ", How old are you?");
 
            int age2 = int.Parse(Console.ReadLine());   

            if (age1 > age2)
            {
                Console.WriteLine(name1 + " is " + (age1 - age2) + " years older than " + name2);
            }
            else if (age1 < age2)
            {
                Console.WriteLine(name2 + " is " + (age2 - age1) + " years older than " + name1);
            }
            else
            {
                Console.WriteLine(name1 + " and " + name2 + " are the same age");
            }

        }
    }
}