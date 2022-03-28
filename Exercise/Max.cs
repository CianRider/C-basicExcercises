using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class Max
    {
        public int Value1;
        public int Value2;

        public void Capture()
        {
            Console.WriteLine("Please capture 2 numbers to determine the maximum:");
            Console.Write("First: ");
            Value1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second: ");
            Value2 = Convert.ToInt32(Console.ReadLine());
            if(Value1 == Value2)
            {
                Console.WriteLine("Values are the same. Max value is {0}", Value1);
            }
            else
            {
                Console.WriteLine("The Max value is {0}", Math.Max(Value1, Value2));
            }
            
        }
    }
}
