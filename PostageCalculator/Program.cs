using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the weight in grams: ");
        int weight = int.Parse(Console.ReadLine());

        Console.Write("Enter the dimensions in cm (length, width, thickness): ");
        var dimensions = Console.ReadLine().Split(',')
            .Select(float.Parse)
            .OrderBy(x => x)
            .ToArray();

        float thickness = dimensions[0];
        float width = dimensions[1];
        float length = dimensions[2];

        decimal firstClassPrice = 0;
        decimal secondClassPrice = 0;

        if (weight <= 100 && length <= 24 && width <= 16.5 && thickness <= 5)
        {
            firstClassPrice = 0.95m;
            secondClassPrice = 0.68m;
        }
        else if (weight <= 750 && length <= 35.3 && width <= 25 && thickness <= 2.5)
        {
            if (weight <= 100)
            {
                firstClassPrice = 1.45m;
                secondClassPrice = 1.05m;
            }
            else if (weight <= 250)
            {
                firstClassPrice = 2.05m;
                secondClassPrice = 1.65m;
            }
            else if (weight <= 500)
            {
                firstClassPrice = 2.65m;
                secondClassPrice = 2.15m;
            }
            else
            {
                firstClassPrice = 3.30m;
                secondClassPrice = 2.70m;
            }
        }
        else if (weight <= 2000 && length <= 45 && width <= 35 && thickness <= 16)
        {
            firstClassPrice = 4.45m;
            secondClassPrice = 3.35m;
        }
        else if (weight <= 20000 && length <= 61 && width <= 46 && thickness <= 46)
        {
            if (weight <= 2000)
            {
                firstClassPrice = 6.95m;
                secondClassPrice = 5.35m;
            }
            else if (weight <= 10000)
            {
                firstClassPrice = 7.95m;
                secondClassPrice = 6.95m;
            }
            else
            {
                firstClassPrice = 12.95m;
                secondClassPrice = 10.45m;
            }
        }

        Console.WriteLine($"The cost to send a first class letter is £{firstClassPrice}");
        Console.WriteLine($"The cost to send a second class letter is £{secondClassPrice}");
    }
}