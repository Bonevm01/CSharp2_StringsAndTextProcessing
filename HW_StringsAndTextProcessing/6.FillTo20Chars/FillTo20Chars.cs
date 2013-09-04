//6. Write a program that reads from the console a string of maximum 20 characters. 
//  If the length of the string is less than 20, the rest of the characters should be filled with '*'. 
//  Print the result string into the console.

using System;

class FillTo20Chars
{
    static void Main()
    {
        Console.Write("Please enter some text with no more than 20 symbols: ");
        string input = Console.ReadLine();
        int length = input.Length;
        while (length > 20)
        {
            Console.Write("Your input is longer than 20 simbols. Please try again: ");
            input = Console.ReadLine();
            length = input.Length;

        }

        string result = input.PadRight(20, '*');
        Console.WriteLine(result);


    }
}
