using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Algo_EI_TextSortLinq
{
    public static class LinqTextSort
    {
        public static List<string> wordList = new List<string>();


        public static void readWordList()
        {
            using (var reader = new StreamReader("words.txt"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    wordList.Add(line);
                }
            }
        }


        public static void sortReverse()
        {
            for (int i = wordList.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(wordList[i]);
            }
        }


        public static void zWords()
        {
            var lowerCase =
                from z in wordList
                where z.StartsWith("z")
                select z;

            foreach (var lcz in lowerCase)
            {
                Console.WriteLine(lcz);
            }

            var upperCase =
                from Z in wordList
                where Z.StartsWith("Z")
                select Z;

            foreach (var UCZ in upperCase)
            {
                Console.WriteLine(UCZ);
            }
        }


        public static void HEwords()
        {
            for (int i = 0; i <= wordList.Count - 1; i++)
            {
                if((wordList[i].StartsWith("h") || wordList[i].StartsWith("H")) && wordList[i].Substring(1).StartsWith("e"))
                {
                    Console.WriteLine(wordList[i]);
                }
            }
            /* //I tried with linq but it only returns 2 words 
            var heChars = new HashSet<char>("he"); // Construct white-list set

            var heWords = from word in wordList
                          where heChars.SetEquals(word) // Word must be set-equal with white-list
                          select word;
            var startsWITHh =
               from h in heWords
               where h.StartsWith("h")
               select h;

            foreach (var he in startsWITHh)
            {
                Console.WriteLine(he);
            }

            var HeChars = new HashSet<char>("He"); // Construct white-list set

            var HeWords = from word in wordList
                          where HeChars.SetEquals(word) // Word must be set-equal with white-list
                          select word;
            var startsWithH =
               from H in HeWords
               where H.StartsWith("h")
               select H;

            foreach (var He in startsWithH)
            {
                Console.WriteLine(He);
            }
            */
        }


        public static void secondLetterE()
        {
            for (int i = 0; i <= wordList.Count - 1; i++)
            {
                if (wordList[i].Substring(1).StartsWith("e"))
                {
                    Console.WriteLine(wordList[i]);
                }
            }
        }


    }
}