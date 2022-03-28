using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    class CTesting
    {
        public string number;
        public void CTest()
        {            
            Console.WriteLine("Capture a 5-Digit integer:");
            number = Console.ReadLine();

            var i1 = 0;
            var i2 = 0;

            foreach (var digit in number)
            {
                if (i1 == 0)
                {
                    i1 = Convert.ToInt32(digit);
                }

                i2 = Convert.ToInt32(digit);

            }

            Console.WriteLine("This value is {0}", i1 > i2);

        }

    }
}
