//4. Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).


using System;

class CountSubstring
{
    static void Main()
    {
        string text = "We are living in an yellow submarine. We don't have anything else.".ToUpper() +
        "Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days".ToUpper();
        string target = "in".ToUpper();

        int count = 0;
        int index = -1;
        
        while (true)
        {
            index = text.IndexOf(target, index + 1);
            if (index == -1)
            {
                break;
            }
            count++;
        }

        Console.WriteLine(count);
    }
}
