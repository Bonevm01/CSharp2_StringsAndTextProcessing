//17. Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
//  and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

using System;
using System.Globalization;
using System.Threading;

class AddHours
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        Console.Write("Please enter a date in format D.M.YYYY hours:minutes:seconds ");
        string userInput = Console.ReadLine();
        DateTime myDate = DateTime.ParseExact(userInput, "d.M.yyyy h:m:ss", CultureInfo.InvariantCulture);
        myDate = myDate.AddHours(6.5);
        Console.Write("after 6 hours and 30 minutes the it will be: {0}. ", myDate);
        Console.WriteLine("Then the day of the week will be {0}", myDate.DayOfWeek);
    }
}
