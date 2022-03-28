using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    class VowelCount
    {
        public void Count()
        {
            var vowels = "aeiou";
            var vowelTot = 0;

            Console.WriteLine("Capture a word to count vowels of:");
            var countWord = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(countWord))
            {
                foreach (var letter in countWord.Replace(" ", ""))
                {
                    if (vowels.IndexOf(char.ToLower(letter)) > -1)
                    {
                        vowelTot++;
                    }
                }

            }

            Console.WriteLine("Total number of vowels in provided word: {0}", vowelTot);

        }
    }
}
