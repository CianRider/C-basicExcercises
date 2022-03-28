using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    class UniqueCapture
    {
        public void CapUni()
        {
            string value;
            var Unique = new List<int>();
            int i;

            Console.WriteLine("Input numbers. When done input 'Quit'");
            while (true)
            {
                value = Console.ReadLine();

                if(value == "Quit")
                {
                    break;
                }

                i = Convert.ToInt32(value);

                if (Unique.IndexOf(i) == -1)
                {
                    Unique.Add(i);
                }
            }

            Console.WriteLine();

            Console.WriteLine("Uniques of captured numbers: ");
            foreach (var n in Unique)
                Console.WriteLine(n);

        }
    }
}
