using System;
using System.Collections.Generic;

namespace WordCounterLogic
{
    public class RepeatCounter
    {
        public int UserInput(string UserSentence, string DuplicateWord)
        {
            int counter = 0;
            string[] wordDivider = UserSentence.ToLower().Split(new Char [] {',' , ' ', '.' });   
            for(int i = 0; i < wordDivider.Length; i++)
            {
                if(wordDivider[i] == DuplicateWord.ToLower())
                {
                    counter += 1;
                }
            }
            return counter;
        }
    }
}