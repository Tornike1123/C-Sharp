using System;
namespace project1
{
	public class Array_2D
	{
		static void Main(string[] args)
		{
			int[,] numberGrid =
			{
				{1,2 },
                {3,4 },
                {5,6 },

            };
			foreach (int item in numberGrid)
			{
				Console.WriteLine(item);
			}
			Console.ReadLine();
		}
	}
}

