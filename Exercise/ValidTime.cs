using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    class ValidTime
    {
        public void CheckTime()
        {
            Console.WriteLine("Input a time in the 24 hour time format:");
            var timeString = Console.ReadLine();

            var timeList = timeString.Split(':');

            var isValid = false;

            if (!string.IsNullOrWhiteSpace(timeString))
            {

                var num = Convert.ToInt32(timeList[0]);
                var num2 = Convert.ToInt32(timeList[1]);

                isValid = (num >= 0 && num < 24) && (num2 >= 0 && num2 < 60);

            }

            Console.WriteLine(isValid ? "Valid Time Value" : "Invalid Time Given");
        }
    }
}
