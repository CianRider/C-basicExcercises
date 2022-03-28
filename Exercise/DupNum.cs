using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    class DupNum
    {
        public void CheckDup()
        {
            Console.WriteLine("Capture a dash speprated list of Numbers:");
            var numString = Console.ReadLine();

            var numList = numString.Split('-');

            var num = 0;
            var num2 = 0;
            var count1 = 0;
            var count2 = 0;

            var hasDup = false;

            if (!string.IsNullOrWhiteSpace(numString))
            {
                foreach (var number in numList)
                {
                    count1++;

                    num = Convert.ToInt32(number);

                    count2 = 0;

                    foreach (var number2 in numList)
                    {
                        count2++;

                        num2 = Convert.ToInt32(number2);

                        if (num == num2 && count1 != count2)
                        {
                            hasDup = true;
                        }

                    }

                }

                Console.WriteLine(hasDup ? "Duplicate" : "No Duplicates Found");

            }
        }
    }
}
