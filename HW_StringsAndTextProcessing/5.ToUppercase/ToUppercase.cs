//5. You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and 
//  </upcase> to uppercase. The tags cannot be nested. 

using System;

class ToUppercase
{
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

        string result = "";
            result = result+text;
        int length = result.Length;
        while (true)
        {
            int indexFrom = -1;
            int indexTo = -1;
            indexFrom = result.IndexOf("<upcase>", indexFrom + 1);
            indexTo = result.IndexOf("</upcase>", indexTo + 1);
            if (indexFrom == -1 && indexTo == -1)
            {
                break;
            }
            string subText = result.Substring(indexFrom + 8, indexTo - indexFrom - 8);
            result = result.Replace(subText, subText.ToUpper());
            result = result.Remove(indexTo, 9);
            result = result.Remove(indexFrom, 8);
            length = result.Length;
        }

        Console.WriteLine(result);
    }
}
