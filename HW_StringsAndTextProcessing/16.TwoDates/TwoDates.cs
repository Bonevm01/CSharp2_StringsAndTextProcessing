//16. Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

using System;
using System.Globalization;
using System.Threading;

class TwoDates
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Please enter a date in format DD.MM.YYYY: ");
        string userInput = Console.ReadLine();
        DateTime firstDate = DateTime.ParseExact(userInput, "dd.MM.yyyy", CultureInfo.InvariantCulture);
        Console.Write("Please enter another date in format DD.MM.YYYY: ");
        userInput = Console.ReadLine();
        DateTime secondDate = DateTime.ParseExact(userInput, "dd.MM.yyyy", CultureInfo.InvariantCulture);

        int compare = firstDate.CompareTo(secondDate);
        
        DateTime startDate = firstDate;
        DateTime endDate = secondDate;

        if (compare == 1)
        {
            startDate = secondDate;
            endDate = firstDate;
        }
        else if (compare == 0)
        {
            Console.WriteLine("Two dates are equal.");
        }
        int interval = 0;
        while (startDate != endDate)
        {
            interval++;
            startDate = startDate.AddDays(1);
        }
        if (interval > 0)
        {
            Console.WriteLine("There are {0} days between your dates.", interval);
        }

    }
}
