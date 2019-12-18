using System;
using System.Collections.Generic;

namespace AnagramChecker.Models
{
    public class Program
    {
        static void Main()
        {

            Console.WriteLine("Welcome to the Anagram Tracker!");
            Console.WriteLine("Please enter a word and we will check anagrams.");
            string userInput = Console.ReadLine().ToLower();

            Console.WriteLine("Please enter a list of words, separated by commas: ");
            string stringListWords = Console.ReadLine().ToLower();
            string[] inputList = stringListWords.Split(',');

            List<string> result = Anagram.GetAnagrams(userInput, inputList);
            Console.WriteLine($"Your input word is '{userInput}'.");
            Console.WriteLine($"The following words from your list are anagrams of {userInput}: ");
            foreach(string word in result)
            {
                Console.WriteLine(word);
            }
        }
    }
}