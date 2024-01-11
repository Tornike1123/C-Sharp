using System;
namespace project1.Inheritance
{
	public class Program
	{
		static void Main(string[] args)
		{
			Chef chef = new Chef();
			chef.MakeChicken();

			ItalianChef italianChef = new ItalianChef();
			italianChef.MakePasta();

			Console.ReadLine();
		}
	}
}

