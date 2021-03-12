using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              The high-level purpose of this code is to reverse a string and
              count the number of times a particular character appears.
            */
            string str = "The quick brown fox jumps over the lazy dog.";
            
            // Reverse the characters in the array
            char[] charMessage = str.ToCharArray();
            Array.Reverse(charMessage);

            // and count the o's
            int x = 0;
            
            foreach (char i in charMessage)
            {
                if (i == 'o')
                {
                    x++;
                }
            }

            // Display the reversed string and o count
            Console.WriteLine(charMessage);
            Console.WriteLine($"'o' appears {x} times.");
        }
    }
}
