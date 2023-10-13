using System;

namespace PizzaShop
{
    class PizzaShop
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Pizza Shop Application!");
 
            Console.WriteLine("What was the value of your order?");
            int value = int.Parse(Console.ReadLine());
            bool delivery = value >= 10;
            bool garlicbread = value > 14;

            if (!delivery) value += 2;

            string output = $"The cost of your pizza is £{value}. ";

            if (garlicbread)
            {
                output += "You will get free delivery and a free garlic bread!";
            } else if (delivery)
            {
                output += "You will get free delivery.";
            }
            
            Console.WriteLine(output);
            
            
        }
    }
}