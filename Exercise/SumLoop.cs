using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    class SumLoop
    {
        public int i = 0;
        public string input;

        public void Sum()
        {
            Console.WriteLine("Input integers to sum or 'ok' to display total");
            while (true)
            {
                input = Console.ReadLine();
                if(input == "ok")
                {
                    break;
                }

                i = i + Convert.ToInt32(input);
            }

            Console.WriteLine("Total sum: {0}", i);
        }
    }
}
