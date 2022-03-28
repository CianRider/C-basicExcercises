using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    class Excercise4MC
    {
        public void Exercise4()
        {
            Console.WriteLine("Please Select Which Function you wish to run:");
            Console.WriteLine("Check list of Number Consecutive = 1");
            Console.WriteLine("Check list of Number for Duplicate = 2");
            Console.WriteLine("Validate Time = 3");
            Console.WriteLine("Convert Phrase to Pascal Calse = 4");
            Console.WriteLine("Count the number of vowels in a word = 5");
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
                    Console.WriteLine("Initiating Consecutive Numbers Check");
                    var consec = new ConsecNum();
                    consec.CheckConsec();
                    break;
                case 2:
                    Console.WriteLine("Initiating Duplicate Numbers Check");
                    var dup = new DupNum();
                    dup.CheckDup();
                    break;
                case 3:
                    Console.WriteLine("Initiating Time Validation");
                    var time = new ValidTime();
                    time.CheckTime();
                    break;
                case 4:
                    Console.WriteLine("Initiating Pascal Case Conversion");
                    var pas = new PascalCase();
                    pas.ConvertToPC();
                    break;
                case 5:
                    Console.WriteLine("Initiating Vowel Count");
                    var Cnt = new VowelCount();
                    Cnt.Count();
                    break;
                default:
                    Console.WriteLine("How did you get here!");
                    break;

            }
            Console.WriteLine("");
        }
    }
}
