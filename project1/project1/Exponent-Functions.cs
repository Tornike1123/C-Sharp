using System;
namespace project1
{
	public class Exponent_Functions
	{
		static void Main(string[] args)
		{
			Console.WriteLine(GetPow(3,3));
			Console.ReadLine();
		}


		static int GetPow(int baseNum, int powerNum)
		{
			int result = 1;

			for (int i = 0; i < powerNum; i++)
			{
				result = result * baseNum;
			}

			return result;
		}


	}
}

