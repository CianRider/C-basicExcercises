using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class Orientation
    {
        public int Value1;
        public int Value2;

        public void PortLan()
        {
            Console.WriteLine("Please capture 2 numbers to determine the Orientation:");
            Console.Write("Width: ");
            Value1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Height: ");
            Value2 = Convert.ToInt32(Console.ReadLine());
            if(Value1 == Value2)
            {
                Console.WriteLine("Image is a square.");
            }
            else
            { 
                Console.WriteLine("The Picture Orientation is {0}", (Value1 < Value2) ? "Portrait" : "Landscape");
            }
        }
    }
}
