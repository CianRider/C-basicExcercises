﻿using System;

namespace HelloWorld
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine(string.Format("My name is {0} {1}", FirstName, LastName));
        }
    }
}
