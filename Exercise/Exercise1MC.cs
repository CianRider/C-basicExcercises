using System;

namespace Exercise
{
    class Exercise1MC
    {
        public void Exercise1()
        {
            Console.WriteLine("Please Select Which Function you wish to run:");
            Console.WriteLine("Validate Integer = 1");
            Console.WriteLine("Display Maximum = 2");
            Console.WriteLine("Determine Picture Orientation = 3");
            Console.WriteLine("Test Speed Camera = 4");
            int iFunction;
            iFunction = Convert.ToInt32(Console.ReadLine());

            if(iFunction <= 0 || iFunction > 4)
            {
                Console.WriteLine("Invalid Function Selected. Ending Program.");
                return;
            }

            switch(iFunction)
            {
                case 1:
                    Console.WriteLine("Initiating Integer Validation");
                    var Valid = new ValidateInt();
                    Valid.Determine();
                break;
                case 2:
                    Console.WriteLine("Initiating Max Number Comparison");
                    var max = new Max();
                    max.Capture();
                break;
                case 3:
                    Console.WriteLine("Initiate Picture Orientation");
                    var orient = new Orientation();
                    orient.PortLan();
                    break;
                case 4:
                    Console.WriteLine("Initiating Speed Camera Logic");
                    var Speeding = new SpeedCamera();
                    Speeding.CheckPoints();
                    break;
                default:
                    Console.WriteLine("How did you get here!");
                    break;

            }
            Console.WriteLine("");
        }
    }
}
