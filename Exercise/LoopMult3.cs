using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    class LoopMult3
    {
        public void Loop()
        {
            for (var i = 1; i <= 100; i++)
            {
                if(i%3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
