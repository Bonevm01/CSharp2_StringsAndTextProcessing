//11. Write a program that reads a number and prints it as a decimal number, hexadecimal number,
//  percentage and in scientific notation. Format the output aligned right in 15 symbols.

using System;

class FormatingANumber
{
    static void Main()
    {
        int input = 158;//You could change the literal to see different results

        string decimalNumber = string.Format("{0:F2}", input).PadLeft(15,'0');
        Console.WriteLine(decimalNumber);
        string hexadecNumber = string.Format("{0:X4}", input).PadLeft(15, '0');
        Console.WriteLine(hexadecNumber);
        string percentNumber = string.Format("{0:P2}", input).PadLeft(15, '0');
        Console.WriteLine(percentNumber);
        string scientNumber = string.Format("{0:e2}", input).PadLeft(15, '0');
        Console.WriteLine(scientNumber);
    }
}
