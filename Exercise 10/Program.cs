using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Matthew T Baker
 * CST - 117
 * August 12, 2019
 * Dominga Gardner
 */
namespace Exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = "Don't be late, teatime will not wait!";
            String inputTwo = "Don b la(te), teatim will no wai(t)!";
            Console.WriteLine(input);
            Console.WriteLine("There are " + countTE(input) + " words that end in 't' or 'e'.");
            Console.WriteLine("");
            Console.WriteLine(inputTwo);
            Console.WriteLine("There are " + countTE(inputTwo) + " words that end in 't' or 'e'.");
        }
        //Splits string to array of words, splits words to array of characters, checks last array index for 'e' or 't', count++ if 'e' or 't' is last index.
        public static int countTE(String str)
        {
            int count = 0;
            char[] delimiterChars = { ' ', ',', '-', '!', ':', ')', '(' };
            String[] split = str.Split(delimiterChars);
            
            for (int i = 0; i < split.Length; i++)
            {
                String word = split[i].ToLower();
                int length = word.Length - 1;
                if (length == 0)
                {
                    if (word == "e" || word == "t")
                    {
                        count++;
                    }
                }
                else if (length > 0)
                {
                    char[] lastLetter = word.ToCharArray();
                    int wordLentgh = lastLetter.Length - 1;
                    if (lastLetter[wordLentgh] == 'e' || lastLetter[wordLentgh] == 't')
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
