using System;
using System.Collections.Generic;

namespace WordCounterLogic
{
    public class WordCounter
    {
        public int counter;

        public int UserInput(string UserSentence, string DuplicateWord)
        {
            string[] wordDivider = UserSentence.Split(" ");
            for(int i = 0; i < wordDivider; i++)
            {
                if(wordDivider[i] == DuplicateWord)
                {
                    counter += 1;
                }
            }
            return counter;
        }
    }
}