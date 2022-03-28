using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    class PascalCase
    {
        public void ConvertToPC()
        {
            Console.WriteLine("Capture a phrase to convert to PascalCase:");
            var phraseString = Console.ReadLine();

            var phraseList = phraseString.Split(' ');
            var count1 = 0;
            var pascal = new StringBuilder();

            if (!string.IsNullOrWhiteSpace(phraseString))
            {
                foreach (var word in phraseList)
                {
                    count1 = 0;
                    foreach (var letter in word)
                    {
                        count1++;

                        pascal.Append(count1 == 1 ? char.ToUpper(letter) : char.ToLower(letter));

                    }

                }

            }

            Console.WriteLine(pascal);
        }
    }
}
