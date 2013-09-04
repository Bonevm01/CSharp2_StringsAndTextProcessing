//14. A dictionary is stored as a sequence of text lines containing words and their explanations.
//  Write a program that enters a word and translates it by using the dictionary. 

using System;

class Dictionary
{
    static void Main()
    {
        string dictionary = ".NET - platform for applications from Microsoft\n" +
                                "CLR - managed execution environment for .NET\n" +
                                "namespace - hierarchical organization of classes\n" +
                                "C# - a program language developed by Microsoft\n"+
                                "holidays - not working days. The best part of the year.";
        string[] wordsAndExplanations = dictionary.Split('\n');
        string[] words = new string[wordsAndExplanations.Length];
        string[] explanations = new string[wordsAndExplanations.Length];
        for (int i = 0; i < wordsAndExplanations.Length; i++)
        {
            int index = wordsAndExplanations[i].IndexOf("-");
            words[i] = wordsAndExplanations[i].Substring(0, index - 1).ToUpper();
            explanations[i] = wordsAndExplanations[i].Substring(index + 2);
        }
        Console.Write("Please enter a word using latin alphabet: ");
        string input = Console.ReadLine().ToUpper();

        //Check if this word is part of the dictionary
        bool isPart = false;
        int wordIndex = -1;
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i]==input)
            {
                isPart = true;
                wordIndex = i;
                break;
            }
        }
        //Print the result
        if (isPart)
        {
            Console.WriteLine(explanations[wordIndex]);
        }
        else
        {
            Console.WriteLine("This word is not part of the dictionary yet. Please try again later.");
        }
    }
}
