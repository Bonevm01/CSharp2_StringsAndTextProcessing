//24. Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;

class SortListOfWords
{
    static void Main()
    {
        string text = "word letter mail ground floor apple ball table chair";
        string[] words = text.Split(' ');
        Array.Sort(words);
        foreach (var item in words)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
