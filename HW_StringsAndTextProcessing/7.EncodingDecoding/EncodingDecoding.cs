//7. Write a program that encodes and decodes a string using given encryption key (cipher). 
//  The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or) 
//  operation over the first letter of the string with the first of the key, the second – with the second, etc. 
//  When the last key character is reached, the next is the first

using System;

class EncodingDecoding
{
    static void Main()
    {
        string text = "Write a program that encodes.";
        Console.WriteLine("The original text is: {0}", text);
        Console.Write("Please write an encription key: ");
        string encrKey = Console.ReadLine();
        int length = encrKey.Length;
        //Encoding
        string result = "";
        int index = 0;
        for (int i = 0; i < text.Length; i++)
        {
            result += (char)(text[i] ^ encrKey[index%length]);
        }

        Console.WriteLine("The encoded text looks: {0}.", result);
        //Decoding
        index = 0;
        string result2 = "";
        for (int i = 0; i < text.Length; i++)
        {
            result2 += (char)(result[i] ^ encrKey[index % length]);
        }
        Console.WriteLine("The decoded text looks: {0}.", result2);
    }
}
