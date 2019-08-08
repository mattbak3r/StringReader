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
            Console.WriteLine(input);
            Console.WriteLine("There are " + countTE(input) + " words that end in 't' or 'e'.");
        }
        public static int countTE(String str)
        {
            int count = 0;
            char[] delimiterChars = { ' ', ',', '-', '!', ':' };
            String[] split = str.Split(delimiterChars);
            for (int i = 0; i < split.Length; i++)
            {
                String word = split[i].ToLower();
                int length = word.Length - 1;
                if (length > 0)
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
