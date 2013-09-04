//13. Write a program that reverses the words in given sentence.
//	Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".


using System;
using System.Collections.Generic;
using System.Text;

class ReverceWordsInASentence
{
    static void Main()
    {
        //The key here is to keep the punctuation - if you have ',' after the fourth word in the original sentance -
        //in the reversed sentance the ',' has to be also after the fourt word. 
        string text = "C# is not C++, not PHP; and not Delphi!";//You could add punctual signs to see their possitions in the reversed sentance
        char[] splitSymbols = { ' ', ',', '-', ';', ':', '?', '.', '!' };
        string punctSigns = new string(splitSymbols);//I will search in this string signs with IndexOf - see line 28
        string[] wordsWithSymbols = text.Split(' ');
        string[] wordsOnly = text.Split(splitSymbols, StringSplitOptions.RemoveEmptyEntries);
        //Create an array for separators between the words - initially all of them will be space
        char[] separatorsBetweenWords = new char[wordsWithSymbols.Length];
        for (int i = 0; i < separatorsBetweenWords.Length; i++)
        {
            separatorsBetweenWords[i] = ' ';
        }
        //Check for punctuational signs
        for (int i = 0; i < wordsWithSymbols.Length; i++)
        {
            string tempor = wordsWithSymbols[i];
            int length = wordsWithSymbols[i].Length;
            char lastChar = tempor[length - 1];
            int index = punctSigns.IndexOf(lastChar);//Check whether last char is punctuational sign
            if (index != -1)
            {
                separatorsBetweenWords[i] = lastChar;//Save the punctuational sign on the right possition
            }
        }

        StringBuilder reversedSentane = new StringBuilder();

        for (int i = wordsOnly.Length - 1; i >= 0; i--)
        {
            reversedSentane.Append(wordsOnly[i]);
            reversedSentane.Append(separatorsBetweenWords[wordsOnly.Length - 1 - i]);
            if (separatorsBetweenWords[wordsOnly.Length - 1 - i]!=' ')
            {
                reversedSentane.Append(" ");
            }
        }

        Console.WriteLine(reversedSentane);
    }
}
