using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var newPers = new Person();
            newPers.FirstName = "Cian";
            newPers.LastName  = "Moloney";
            newPers.Introduce();

        }
    }
    
}

