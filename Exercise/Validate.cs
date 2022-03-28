using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class ValidateInt
    {
        public int iEvalate;

        public void Determine()
        {
            Console.WriteLine("Enter value to check Validity: ");
            iEvalate = Convert.ToInt32(Console.ReadLine());

            if (iEvalate <= 0 || iEvalate > 10)
            {
                Console.WriteLine("Invalid");
            }
            else
            {
                Console.WriteLine("Valid");
            }
        }

    }
}
