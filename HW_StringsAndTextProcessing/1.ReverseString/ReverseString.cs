//2. Write a program that reads a string, reverses it and prints the result at the console.
//  Example: "sample"  "elpmas".


using System;


class ReverseString
{
    static void Main()
    {
        Console.Write("Please enter a word: ");
        string input = Console.ReadLine();
        char[] output = new char[input.Length];
        for (int i = input.Length-1, j=0; i >= 0; i--, j++)
        {
            output[j] = input[i];
        }

        string print = new string(output);

        Console.WriteLine("The reversed word is: {0}.", print);
    }
}
