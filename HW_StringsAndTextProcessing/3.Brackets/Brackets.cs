//3. Write a program to check if in a given expression the brackets are put correctly.
//  Example of correct expression: ((a+b)/5-d).
//  Example of incorrect expression: )(a+b)).


using System;
using System.Collections.Generic;

class Brackets
{
    static void Main()
    {
        Console.Write("Please enter an expression including openning and closing brackets: ");
        string input = Console.ReadLine();

        List<int> openBrack = new List<int>();
        List<int> closBrack = new List<int>();
        //Find possitions of openning brackets
        int index = -1;
        while (true)
        {
            index = input.IndexOf('(', index + 1);
            if (index == -1)
            {
                break;
            }

            openBrack.Add(index);
        }
        //Find possitions of closing brackets
        int index2 = -1;
        while (true)
        {
            index2 = input.IndexOf(')', index2 + 1);
            if (index2 == -1)
            {
                break;
            }

            closBrack.Add(index2);
        }
        //Transform Lists to Arrays
        int[] openBrackets = openBrack.ToArray();
        int[] closingBrackets = closBrack.ToArray();
        //New array in which I plan to save 1 and -1 to the possitions of openning and closing brackets
        int[] result = new int[input.Length];

        if (openBrack.Count == 0 && closBrack.Count == 0)
        {
            Console.WriteLine("Your expression doesn't contain any brackets.");
        }
        else
        {
            if (openBrack.Count != closBrack.Count)
            {
                Console.WriteLine("Incorrect expression - the numbers of opening and closing brackets are not equal.");
            }
            else
            {
                //Save 1 to the possitions of oppening brackets
                for (int j = 0; j < openBrackets.Length; j++)
                {
                    result[openBrackets[j]] = 1;
                }
                //save -1 to the possitions of closing brackets
                for (int j = 0; j < closingBrackets.Length; j++)
                {
                    result[closingBrackets[j]] = -1;
                }
                //check the order of brackets
                int tempSum = 0;
                for (int j = 0; j < result.Length; j++)
                {
                    tempSum += result[j];
                    if (tempSum < 0) //More closing  than openning brackest to the current possition
                    {
                        Console.WriteLine("Incorrect expression - incorrect order of brackets.");
                        break;
                    }
                }
                if (tempSum == 0)
                {
                    Console.WriteLine("Correct expression.");
                }
            }
        }
    }


}

