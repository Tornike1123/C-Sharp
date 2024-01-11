
using System;
namespace project1
{
	public class Static_attribut
	{
		static void Main(string[] args)
		{
			Song holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(holiday.getSongCount());
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
			Console.WriteLine(Song.songCount);
	
            Console.ReadLine();
		}
	}
}

