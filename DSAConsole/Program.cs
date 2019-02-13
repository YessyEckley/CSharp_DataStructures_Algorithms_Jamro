using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Chapter2ArraysAndLists.Arrays;

namespace DSAConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is an out
            Console.WriteLine("Hello World!");

            var singleDimentionalArray = new SingleDimentionalArray();
            var months = singleDimentionalArray.MonthNames();
            Console.WriteLine(singleDimentionalArray.ArrayToString(months));
            var temp = new string[12];
        }
    }
}
