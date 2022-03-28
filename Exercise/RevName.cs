using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    class RevName
    {
        public void Reverse()
        {
            Console.Write("Input a name to reverse: ");
            var name = Console.ReadLine();
            var nameArr = new string[name.Length];
            var i = 0;
            var nameRev = "";

            foreach (var character in name)
            {
                nameArr[i] = Convert.ToString(character);
                i++;
            }

            Array.Reverse(nameArr);

            foreach(var revChar in nameArr)
            {
                nameRev = nameRev + revChar;
            }

            Console.WriteLine("The input name reversed is: {0}", nameRev);

        }
    }
}
