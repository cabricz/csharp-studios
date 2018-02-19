using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            Console.WriteLine("Enter a string to analyze");
            string userInput = Console.ReadLine();
            string sample = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                "Nunc accumsan sem ut ligula scelerisque sollicitudin. " +
                "Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. " +
                "Donec sit amet suscipit metus, non lobortis massa. " +
                "Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. " +
                "Donec nec velit non ligula efficitur luctus.";
            string textToAnalyze = "";

            if (userInput == "")
            {
                textToAnalyze = sample;
            }
            else
            {
                textToAnalyze = userInput;
            }

            foreach (char character in textToAnalyze)
            {
                if (!charCount.ContainsKey(character))
                {
                    charCount.Add(character, 1);
                }
                else
                {
                    charCount[character] += 1;
                }
            }

            Console.WriteLine(textToAnalyze);
            foreach (KeyValuePair<char, int> entry in charCount)
            {
                Console.WriteLine("{0}:{1}", entry.Key, entry.Value);
            }

            Console.ReadLine();
        }
    }
}
