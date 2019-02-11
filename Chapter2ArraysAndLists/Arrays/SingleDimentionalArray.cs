using System;
using System.Globalization;

namespace Chapter2ArraysAndLists.Arrays
{
    public class SingleDimentionalArray
    {
        public static void MonthNames()
        {
            var months = new string[12];
            for (int month = 1; month <= 12; month++)
            {
                var firstDay = new DateTime(DateTime.Now.Year, month, 1);
                var name = firstDay.ToString("MMMM", CultureInfo.CreateSpecificCulture("en"));
                months[month - 1] = name;
            }

            foreach (var month in months)
            {
                Console.WriteLine($"-> {month}");
            }
        } 
    }
}
