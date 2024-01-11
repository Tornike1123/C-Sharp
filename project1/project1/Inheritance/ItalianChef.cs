using System;
namespace project1.Inheritance
{
	public class ItalianChef : Chef
	{
		public override void MakeSpecialDish()
		{
			Console.WriteLine("the chef makes chicken parm");
		}

        public void MakePasta()
        {
            Console.WriteLine("the chef makes Pasta");
        }
    }
}

