using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class SpeedCamera
    {
        public int speedLimit;
        public int travelSpeed;

        public void CheckPoints()
        {
            Console.Write("Capture the speed limit of the area: ");
            speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.Write("Capture the speed traveled: ");
            travelSpeed = Convert.ToInt32(Console.ReadLine());

            var difference = travelSpeed - speedLimit;

            if(difference <= 0)
            {
                Console.WriteLine("Travel speed OK");
            }
            else
            {
                var points = Math.Round(Convert.ToDecimal(difference / 5));

                Console.WriteLine("Total Points Accumulated: {0}", (points < 1) ? 1 : points);

                if(points > 12)
                {
                    Console.WriteLine("License Suspended");
                }
            }

        } 

    }
}
