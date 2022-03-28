using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    class UniqueNums
    {
        public void DetUni()
        {
            var value = 0;
            var Unique = new List<int>();

            Console.WriteLine("Please input 5 unique numbers.");
            for (var i = 1; i <= 5; i++)
            {
                Console.Write("{0}: ", i);
                value = Convert.ToInt32(Console.ReadLine());

                if (Unique.IndexOf(value) > -1)
                {
                    Console.WriteLine("Value already exists on list. Please Capture a unique");
                    i--;
                    continue;
                }
                else
                {
                    Unique.Add(value);
                }
            }

            Unique.Sort();

            Console.WriteLine();

            Console.WriteLine("Captured numbers sorted: ");
            foreach(var n in Unique)
                Console.WriteLine(n);

        }
    }
}
