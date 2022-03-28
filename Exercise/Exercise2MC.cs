using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    class Exercise2MC
    {
        public void Exercise2()
        {
            Console.WriteLine("Please Select Which Function you wish to run:");
            Console.WriteLine("Loop Display multiples of 3 = 1");
            Console.WriteLine("Sum Loop = 2");
            Console.WriteLine("Determine Factor of input value = 3");
            Console.WriteLine("Guessing Game = 4");
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
                    Console.WriteLine("Initiating Multiples of 3 loop");
                    var Loop = new LoopMult3();
                    Loop.Loop();
                    break;
                case 2:
                    Console.WriteLine("Initiating Sum Loop");
                    var Sum = new SumLoop();
                    Sum.Sum();
                    break;
                case 3:
                    Console.WriteLine("Initiate Factor Calculation");
                    var Factor = new Factor();
                    Factor.CalcFactor();
                    break;
                case 4:
                    Console.WriteLine("Initiating Guessing Game");
                    var guess = new Guess();
                    guess.Game();
                    break;
                case 5:
                    Console.WriteLine("Initiating Max value loop");
                    var maxLoop = new MaxLoop();
                    maxLoop.MaxCheck();
                    break;
                default:
                    Console.WriteLine("How did you get here!");
                    break;

            }
            Console.WriteLine("");
        }
    }
}

