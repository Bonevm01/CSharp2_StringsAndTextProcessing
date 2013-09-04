//18.Write a program for extracting all email addresses from given text. 
//  All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Text.RegularExpressions;

class ExtractEMailAddresses
{
    static void Main()
    {
        //almost copy-paste from Regular expression lecture
        string text = "email адреси:" +
                        "svirka@kaval.com, sladurana@duduk.net, 123--@usa.net, test.test123@en.some-host.12345.com " +
                        ".ala.@bala.com, test@-host.com, user@.test.ru, user@test.ru, alabala@, user@host, @eu.net";

        string pattern = @"\b([a-zA-Z0-9_\-][a-zA-Z0-9_\-\.]{0,49})@(([a-zA-Z0-9][a-zA-Z0-9\-\.]{0,49}\.)+[a-zA-Z]{2,3})\b";
        Match match = Regex.Match(text, pattern);
        while (match.Success)
        {
            Console.WriteLine(match.ToString());
            match = match.NextMatch();
        }


    }
}
