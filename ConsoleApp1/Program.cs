using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1

{
    class Program
    {
        static void Main(string[] args)
        {
            Program a = new Program();
            Console.WriteLine("the longest word is : ");
            Console.WriteLine(a.MyFunctionA("Ada Lovelace wrote the first algorithm designed for processing by an Analytical Engine."));
        }

       
        public String MyFunctionA(string input)
        {
            //Write a C# program to find the longest word in a string.
            string[] words = input.Split(' ');
            int wordarrayLength = words.Length;
            String longestword = words[0];
            int[] wordsLength = new int[words.Length];
            for (int s = 0; s < words.Length; s++)
            {
                wordsLength[s] = words[s].Length;
            }
            // loop post condition: we now jave array wordsLength which contains the lengths of each word

            string currentWord = words[0];
            string nextWord;

            for (int y = 0; y < words.Length - 1; y++)
            {
                currentWord = words[y];

                nextWord = words[y + 1];
                if (words[y + 1].Equals(words[y]))
                {
                    longestword = words[y + 1];
                }

                // TODO :Use an IF Statement to make sure thet variable longestWord is always set to the Longest Word in the input string
            }
            return longestword;

        }


    }
}