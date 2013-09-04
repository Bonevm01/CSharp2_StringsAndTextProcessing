//23. Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
//  Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".


using System;
using System.Text;

class ReplaceSeries
{
    static void Main()
    {
        string text = "aaaaaabbbccccdeeeeeefghiiiiiiiiiiiiiiiiiijkllllllllllll";
        StringBuilder newText = new StringBuilder();
        newText.Append(text[0]);
        for (int i = 1; i < text.Length; i++)
        {
            if (text[i]!=text[i-1])
            {
                newText.Append(text[i]);
            }
        }
        Console.WriteLine(newText.ToString());
    }
}

