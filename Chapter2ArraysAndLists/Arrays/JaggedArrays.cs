using System;

namespace Chapter2ArraysAndLists.Arrays
{
    public class JaggedArrays
    {
        public static void Errata()
        {
            int[][] numbers = {
                new int[] { 9, 5, -9 },
                new int[] { 0, -3, 12, 51, -3 },
                null,
                new int[] { 54 }
            };

            int number = numbers[1][2];
            Console.WriteLine(number);
            Console.WriteLine(numbers[1][3] = 50);
        }
    }
}