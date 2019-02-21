using System;
using System.Text;

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

			public static void GameMapDisplay()
			{
				TerrainEnum[,] map =
				{
					{TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS},
					{TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS},
					{TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS},
					{TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS},
					{TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.WALL, TerrainEnum.WALL, TerrainEnum.WALL},
					{TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.WALL, TerrainEnum.SAND, TerrainEnum.SAND},
					{TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.WALL, TerrainEnum.SAND, TerrainEnum.SAND},
					{TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WALL, TerrainEnum.SAND, TerrainEnum.SAND},
					{TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WALL, TerrainEnum.SAND, TerrainEnum.SAND},
					{TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WALL, TerrainEnum.WATER, TerrainEnum.WATER},
					{TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WALL, TerrainEnum.WATER, TerrainEnum.WATER},
				};

				Console.OutputEncoding = UTF8Encoding.UTF8;
				
				for(int row = 0; row < map.GetLength(0); row++)
				{
					for(int column = 0; column < map.GetLength(1); column++)
					{
						Console.ForegroundColor = map[row, column].GetColor();
						Console.Write(map[row, column].GetChar() + " ");
					}
					Console.WriteLine();
				}
				
				Console.ForegroundColor = ConsoleColor.Gray;
			}
    }
}
