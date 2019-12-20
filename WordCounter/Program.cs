using System;
using System.Collections.Generic;
using WordCounterLogic;

namespace WordCounterMain
{
    public class WordCounter
    {
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Please enter a sentence");
            string UserSentence = Console.ReadLine();
            
            Console.WriteLine("Enter a word that you would like to find duplicates of");
            string DuplicateWord = Console.ReadLine();

            RepeatCounter newRepeatCounter = new RepeatCounter();
            int answer = newRepeatCounter.UserInput(UserSentence, DuplicateWord);
            Console.WriteLine("The word you inputted was found " + answer + " times in your scentence.");
        }
        
    }
}