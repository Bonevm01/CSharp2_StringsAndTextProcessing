//20. Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

using System;
using System.Text.RegularExpressions;

class ExtractPalindromes
{
    static void Main()
    {
        string text = "Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. Display them in the standard date format for Canada." +
                        "Write a program that extracts from a given text all palindromes, e.g. \"ABBA\", \"lamal\", \"exe\"." + 
                        "pop; dot? gbg, 909;777g777 ";
        
        string pattern = @"\b[A-Za-z]{3,}\b";
        Match match = Regex.Match(text, pattern);
        Console.WriteLine("Palindromes in your text are:");

        while (match.Success)
        {
            bool isPalindromes = true;
            string tempor = match.ToString();
            for (int i = 0; i < tempor.Length/2; i++)
            {
                if (tempor[i]!=tempor[tempor.Length-1-i])
                {
                    isPalindromes = false;
                    break;
                }
            }
            if (isPalindromes)
            {
                Console.WriteLine(tempor);
            }
            match = match.NextMatch();
        }

    }
}
