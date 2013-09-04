//21. Write a program that reads a string from the console and prints all different letters in the string along
//  with information how many times each letter is found. 


using System;

class CountLetters
{
    static void Main()
    {
        Console.Write("Please enter some text in English: ");
        string text = Console.ReadLine().ToUpper();
        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        int[] counts = new int[alphabet.Length];

        for (int i = 0; i < text.Length; i++)
        {
            int index = alphabet.IndexOf(text[i]);
            if (index != -1)
            {
                counts[index]++;
            }
        }
        Console.WriteLine("Your text contains the following latin letters:");
        for (int i = 0; i < alphabet.Length; i++)
        {
            if (counts[i] > 0)
            {
                Console.WriteLine("{0}-->{1} times.", alphabet[i], counts[i]);
            }
        }

    }
}
