using System;

namespace ParkingSensors
{
    class ParkingSensors
    {
        static void Main()
        {
            Console.WriteLine("Parking Sensors Application");
 
            Console.WriteLine("Is the car in reverse? Press Y for yes or N for no.");
            string isInReverse = Console.ReadLine();
            double emptySpaceBehindCar = float.Parse(Console.ReadLine());

            if (isInReverse!.ToUpper() == "Y" && emptySpaceBehindCar <= 1.5f)
            {
                Console.WriteLine("beep, beep, beep");
            }


        }
    }
}