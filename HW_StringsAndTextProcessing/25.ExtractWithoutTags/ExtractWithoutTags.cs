//25.Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags. 


using System;
using System.Text.RegularExpressions;

class ExtractWithoutTags
{
    static void Main()
    {
        string text = "<html>" +
        "<head><title>News</title></head>" +
        "<body><p><a href=\"http://academy.telerik.com\">Telerik" +
        "Academy</a>aims to provide free real-world practical" +
        "training for young people who want to turn into" +
        "skillful .NET software engineers.</p></body>" +
        "</html>";

        string pattern = @">[^<]+</";
        Match match = Regex.Match(text, pattern);
        while (match.Success)
        {
            string tempor = match.ToString();
            tempor = tempor.Remove(tempor.Length - 2, 2);
            tempor = tempor.Remove(0, 1);
            Console.WriteLine(tempor);
            match = match.NextMatch();
        }
    }
}