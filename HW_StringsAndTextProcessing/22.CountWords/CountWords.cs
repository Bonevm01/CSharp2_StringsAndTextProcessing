//22.Write a program that reads a string from the console and lists all different words in the string 
//  along with information how many times each word is found.

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class CountWords
{
    static void Main()
    {
        //You could change the text on the next rows to see different result
        string input = "Write a program that encodes and decodes a string using given encryption key (cipher)." +
            "The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or)" +
            "operation over the first letter of the string with the first of the key, the second – with the second, etc." +
            "When the last key character is reached, the next is the first.";
        
        //Identify different words in the text (case insensitive)
        string pattern = @"\b[A-Za-z]+\b";
        List<string> words = new List<string>();
        Match match = Regex.Match(input.ToUpper(), pattern);
        while (match.Success)
        {
            string tempor = match.ToString();
            bool newWord = true;
            foreach (string word in words)
            {
                if (word == tempor)
                {
                    newWord = false;
                    break;
                }
            }
            if (newWord)
            {
                words.Add(tempor);
            }
            match = match.NextMatch();
        }

        //Count words in the text
        string[] diffWords = words.ToArray();
        Array.Sort(diffWords);
        int[] count = new int[diffWords.Length];

        Match newMatch = Regex.Match(input.ToUpper(), pattern);
        while (newMatch.Success)
        {
            string temp = newMatch.ToString();
            int index = Array.IndexOf(diffWords, temp);
            count[index]++;
            newMatch = newMatch.NextMatch();
        }

        //Output
        Console.WriteLine("The words in your text are:");
        for (int i = 0; i < diffWords.Length; i++)
        {
            Console.WriteLine("{0} ---> {1} times.", diffWords[i], count[i]);
        }
    }
}
