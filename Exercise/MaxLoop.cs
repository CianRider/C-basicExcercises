using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    class MaxLoop
    {
        public string numberString;
        public void MaxCheck()
        {
            Console.Write("Input comma seperated value list of numbers to determine max value: ");
            numberString = Console.ReadLine();
            var i = 0;
            string hold = "";
            foreach (var character in numberString)
            {
                if(character == ',')
                {
                    i = Math.Max(i, Convert.ToInt32(hold));
                    hold = "";
                    continue;
                }
                else
                {
                    hold = hold + character;
                }
                
            } 

            i = Math.Max(i, Convert.ToInt32(hold));

            Console.WriteLine("Max in provided string: {0}", i);
        }
    }
}
