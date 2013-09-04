//10. Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. 

using System;
using System.Text;

class StringToUnicode
{
    static void Main()
    {
        string input = "Hi!";
        StringBuilder output = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            int letter = input[i];
            string unicodeLetter = string.Format("\\u{0:X4}",letter);
            output.Append(unicodeLetter);
        }
        
        Console.WriteLine(output.ToString());
        
    }
}
