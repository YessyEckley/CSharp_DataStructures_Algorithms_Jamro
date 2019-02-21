using System;

namespace Chapter2ArraysAndLists.Arrays
{
    public class MultiDimentionalArray
    {
    	public static int[,] MultiplicationResults = new int[10, 10];
    	//_gameMap = new [11, 10];
    	
    	public MultiDimentionalArray() { }
    	
    	public static void MultiplicationTable()
    	{
	    	for(int i = 0; i < MultiplicationResults.GetLength(0); i++)
	    	{
	    		for(int j = 0; j < MultiplicationResults.GetLength(1); j++)
	    		{
	    			MultiplicationResults[i, j] = (i + 1) * (j + 1);
	    		}
	    	}
    	}
    	
    	public static void MultiplicationTableToDisplay()
    	{
    		Console.WriteLine("MultiplicationTableToDisplay Start!");
    		
    		for(int i  = 0; i < MultiplicationResults.GetLength(0); i++)
    		{
    			for(int j  = 0; j < MultiplicationResults.GetLength(1); j++)
    			{
    				Console.Write("{0, 4}", MultiplicationResults[i, j]);
    			}
    			Console.WriteLine();
    		}
    		
    		Console.WriteLine("MultiplicationTableToDisplay End!");
    	}
    }
}
