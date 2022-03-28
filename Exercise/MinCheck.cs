using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    class MinCheck
    {
        public void Min()
        {
            Console.Write("Input comma seperated value list of numbers to determine max value: ");
            var numberString = Console.ReadLine();
            var i = 0;
            string hold = "";
            var Small = new List<int>();

            foreach (var character in numberString)
            {
                if (character == ',')
                {
                    i++;
                    Small.Add(Convert.ToInt32(hold));
                    hold = "";
                }
                else
                {
                    hold = hold + character;
                }


            }

            if (i < 4)
            {
                Console.WriteLine("Invalid List Provided");
            }
            else
            {
                Small.Add(Convert.ToInt32(hold));

                Small.Sort();

                var Shrink = Small.ToArray();

                Array.Resize(ref Shrink, 3);

                Console.WriteLine();
                Console.WriteLine("Provided list sorted and made to display 3 smallest input numbers below: ");
                foreach (var num in Shrink)
                    Console.WriteLine(num);

            }
        }
    }
}
