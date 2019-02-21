using System;

namespace Chapter2ArraysAndLists.Arrays
{
    public class MultiDimentionalArray
    {
    	int[,] _multiplicationResults = new int[10, 10];
    	
    	public MultiDimentionalArray() { }
    	
    	public static void MultiplicationTable()
    	{
	    	for(int i = 0; i < _multiplicationResults.GetLength(0); i++)
	    	{
	    		for(int j = 0; j < _multiplicationResults.GetLength(1); j++)
	    		{
	    			results[i, j] = (i + 1) * (j + 1);
	    		}
	    	}
    	}
    	
    	public static void MultiplicationTableToDisplay()
    	{
    		Console.WriteLine("MultiplicationTableToDisplay Start!");
    		
    		for(int i; i < _multiplicationResults.GetLength(0); i++)
    		{
    			for(int j; j < _multiplicationResults.GetLength(1); j++)
    			{
    				Console.Write("{0, 4}", );
    			}
    			Console.WriteLine();
    		}
    		
    		Console.WriteLine("MultiplicationTableToDisplay End!");
    	}
    }
}
