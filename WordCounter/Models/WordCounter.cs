using System;
using System.Collections.Generic;

namespace WordCounterLogic
{
    public class RepeatCounter
    {
        public int counter;

        public int UserInput(string UserSentence, string DuplicateWord)
        {
            string[] wordDivider = UserSentence.Split(" ");
            for(int i = 0; i < wordDivider.Length; i++)
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