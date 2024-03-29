﻿//9. We are given a string containing a list of forbidden words and a text containing some of these words.
//  Write a program that replaces the forbidden words with asterisks. 

using System;

class ForbiddenWords
{
    static void Main()
    {
        string text = "Microsoft announced its next generation PHP \ncompiler today. It is based on .NET Framework 4.0 \n"+
            "and is implemented as a dynamic language in CLR.";
        string[] forbiddenWords = {"PHP","CLR","Microsoft" };
        for (int i = 0; i < forbiddenWords.Length; i++)
        {
            text = text.Replace(forbiddenWords[i], new string('*', forbiddenWords[i].Length));
        }
        Console.WriteLine(text);
    }
}
