//8. Write a program that extracts from a given text all sentences containing given word.
//		Example: The word is "in". 


using System;

class ExtractSentencesByWord
{
    static void Main()
    {
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight."+
            " So we are drinking all the day. We will move out of it in 5 days. In August I am having holidays";
        string[] sentences = text.Split('.');
        string key = "in".ToLower();
        for (int i = 0; i < sentences.Length; i++)
        {
            string temporary = sentences[i].ToLower();
            string[] words = temporary.Split(' ', ',', ';', '-', ':');
            for (int j = 0; j < words.Length; j++)
            {
                if (words[j] ==key)
                {
                    Console.WriteLine(sentences[i].Trim() + ".");
                    break;
                }
            }
        }
    }
}
