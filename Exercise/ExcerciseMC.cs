using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    class ExcerciseMC
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Select Exercise to run:");
            Console.WriteLine("Exercise 5.1 = 1");
            Console.WriteLine("Exercise 5.2 = 2");
            Console.WriteLine("Exercise 6   = 3");
            Console.WriteLine("Exercise 8   = 4");
            Console.WriteLine("Testing      = 5");

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
                    Console.WriteLine("Initiating Excersises Section 5.1");
                    var Exersise1 = new Exercise1MC();
                    Exersise1.Exercise1();
                    break;
                case 2:
                    Console.WriteLine("Initiating Excersises Section 5.2");
                    var Exersise2 = new Exercise2MC();
                    Exersise2.Exercise2();
                    break;
                case 3:
                    Console.WriteLine("Initiating Excersises Section 6");
                    var Exersise3 = new Exercise3MC();
                    Exersise3.Exercise3();
                    break;
                case 4:
                    Console.WriteLine("Initiating Excersises Section 8");
                    var Exersise4 = new Excercise4MC();
                    Exersise4.Exercise4();
                    break;
                case 5:
                    Console.WriteLine("Initiating Excersises Section 8");
                    var CTesting = new CTesting();
                    CTesting.CTest();
                    break;
            }
        }
    }
}
