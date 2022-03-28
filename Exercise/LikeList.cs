using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    class LikeList
    {
        public void BuildAndDisp()
        {
            var names = new List<string>();

            Console.WriteLine("Add names of people who liked your post:");
            var name = "";
            while(true)
            {
                name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    break;
                }

                names.Add(name);

            }
            name.Replace

            if (names.Count == 1)
            {
                Console.WriteLine("Your post was liked by {0}", names[0]);
            }
            else if (names.Count == 2)
            {
                Console.WriteLine("Your post was liked by {0} and {1}", names[0], names[1]);
            }
            else
            {
                Console.WriteLine("Your post was liked by {0}, {1} and {2} other {3}", names[0], names[1], names.Count - 2, (names.Count - 2) == 1 ? "person." : "people." );
            }
        }
    }
}
