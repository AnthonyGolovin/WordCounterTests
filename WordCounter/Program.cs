using System;
using System.Collections.Generic;
using WordCounterLogic;

namespace WordCounterMain
{
    public class WordCounter
    {
        public static void Main()
        {
            Console.WriteLine("Please enter a sentence");
            string UserScentence = Console.ReadLine();
            
            Console.WriteLine("Enter a word that you would like to find duplicates of");
            string DuplicateScentence = Console.ReadLine();

            RepeatCounter newRepeatCounter = new RepeatCounter();
            int answer = newRepeatCounter.UserScentence(UserScentence, DuplicateWord);
            Console.WriteLine("The word you inputted was found " + answer + " times in your scentence.");
        }
        
    }
}