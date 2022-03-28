using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    class Exercise3MC
    {
        public void Exercise3()
        {
            Console.WriteLine("Please Select Which Function you wish to run:");
            Console.WriteLine("Construct like list = 1");
            Console.WriteLine("Reverse name = 2");
            Console.WriteLine("Unique Number Check = 3");
            Console.WriteLine("Capture Numbers, Display Uniques = 4");
            Console.WriteLine("Determine Max of input value string = 5");
            int iFunction;
            iFunction = Convert.ToInt32(Console.ReadLine());

            if (iFunction <= 0 || iFunction > 5)
            {
                Console.WriteLine("Invalid Function Selected. Ending Program.");
                return;
            }

            switch (iFunction)
            {
                case 1:
                    Console.WriteLine("Initiating like list");
                    var like = new LikeList();
                    like.BuildAndDisp();
                    break;
                case 2:
                    Console.WriteLine("Initiating Name reverse");
                    var rev = new RevName();
                    rev.Reverse();
                    break;
                case 3:
                    Console.WriteLine("Initiate Check for Unique Numbers");
                    var Uni = new UniqueNums();
                    Uni.DetUni();
                    break;
                case 4:
                    Console.WriteLine("Initiating Number Capture");
                    var Cap = new UniqueCapture();
                    Cap.CapUni();
                    break;
                case 5:
                    Console.WriteLine("Initiating Max value loop");
                    var Min = new MinCheck();
                    Min.Min();
                    break;
                default:
                    Console.WriteLine("How did you get here!");
                    break;

            }
            Console.WriteLine("");
        }
    }
}
