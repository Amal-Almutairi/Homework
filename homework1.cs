using System;
using System.Collections.Generic;

namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            string tweets = "@Twitter# some Tweets belong in #the #drafts";
            Tokenizer(tweets);
        }
        static string Tokenizer(string tweet)
        {
            List<string> word = new List<string>();

            foreach (var item in tweet.Split(' '))
            {
                if (item.StartsWith("#") || item.StartsWith("@"))
                {
                    word.Add(item);
                }

            }
            foreach (var item in word)
            {
                Console.WriteLine(item);
            }

            int i = 0;
            int counterH = 0;
            int counterU = 0;
            var totalHash = 0;
            var totalusers = 0;
            var tweets = ' ';
            while (i<tweet.Length){

                if (tweet[i] == '#')
                {
                    counterH++;
                    totalHash = +counterH;   
                }else if (tweet[i] == '@')
                {
                    counterU++;
                    totalusers = +counterU;
                }

                i++;
            }
            Console.WriteLine("the number of # is {0}", totalHash);
            Console.WriteLine("the number of users is {0}", totalusers);
            return tweet;
        }
    }
}
