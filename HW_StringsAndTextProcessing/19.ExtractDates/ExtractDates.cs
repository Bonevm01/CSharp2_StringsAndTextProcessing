//19. Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. 
//  Display them in the standard date format for Canada.


using System;
using System.Globalization;
using System.Threading;

class ExtractDates
{
    static void Main()
    {
        string text = "Христо Стоичков е роден на 08.02.1966г. в град Пловдив. Стефка Костадинова е родена на 25.03.1965 г. в Пловдив. Санстефанският мирен договор е подписан на 03.03.1878. На 01.01.2007г България стана член на Европейския съюз.";
        char[] separators = { ' ', ',', '-', ';', ':', '!', '?' };//etc.
        string[] parts = text.Split(separators);

        foreach (string word in parts)
        {
            string newWord = "";
            if (word[word.Length - 1] == '.')//Remove dots if it is at the end of a sentance or ends with "г."
            {
                newWord = word.Substring(0, word.Length - 1);
            }
            else
            {
                newWord = word;
            }
            if (newWord[newWord.Length - 1] == 'г')
            {
                newWord = newWord.Substring(0, newWord.Length - 1);
            }

            try
            {

                DateTime isDate = DateTime.ParseExact(newWord, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                Console.WriteLine(isDate.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
            }
            catch (Exception)
            {
            }
        }

    }
}

