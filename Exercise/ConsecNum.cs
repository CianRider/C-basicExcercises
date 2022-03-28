using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    class ConsecNum
    {
        public void CheckConsec()
        {
            Console.WriteLine("Capture a dash speprated list of Numbers:");
            var numString = Console.ReadLine();

            var numList = numString.Split('-');

            var num   = 0;
            var num2  = 0;
            var count = 0;

            var isConsec = false;
            var isLess   = false;
            var isGreat  = false;

            foreach (var number in numList)
            {
                count++;

                if(count == 1)
                {
                    num = Convert.ToInt32(number);
                } 
                else
                {
                    num2 = Convert.ToInt32(number);

                    if (num > num2 || isLess)
                    {
                        num2++;
                        if(num == num2)
                        {
                            isConsec = true;
                            num = Convert.ToInt32(number);
                            isLess = true;
                        }
                        else
                        {
                            isConsec = false;
                            break;
                        }
                    }
                    else if ((num < num2 || isGreat))
                    {
                        num2--;
                        if (num == num2)
                        {
                            isConsec = true;
                            num = Convert.ToInt32(number);
                            isGreat = true;
                        }
                        else
                        {
                            isConsec = false;
                            break;
                        }
                    }
                }

            }

            Console.WriteLine(isConsec ? "Consecutive" : "Not Consecutive");

        }
    }
}
