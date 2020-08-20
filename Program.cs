using System;

namespace SplittingASentenceIntoIndividualWords
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = "I like cheese. Lots!";

            char[] delimiters = { ',', '!', '.', ' ' };
            // split on all the delimiters and remove any empty ones
            string[] words = s.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            // loop through all the elements
            for (int i = 0; i < words.Length; i++)
            {
                // print the word at element index i
                Console.WriteLine(words[i]);
            }
        }
    }
}