using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    class Factor
    {
        public int factorvalue;
        public long i = 1;

        
        public void CalcFactor()
        {
            Console.Write("Input value to calculate: ");
            factorvalue = Convert.ToInt32(Console.ReadLine());
            for (var f = factorvalue; f > 0; f--)
            {
                i *= f;
            }
            Console.WriteLine("{0}! = {1}", factorvalue, i);
        }
        
    }
}
