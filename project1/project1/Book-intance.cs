using System;
namespace project1
{
	public class Book_intance
	{
		static void Main(string[] args)
		{
			Book hp = new Book();
			hp.title = "Harry Potter";
			hp.author = "JK ROWLING";
			hp.pages = 400;
			Console.WriteLine(hp.title);
			

            Book hobbit = new Book();
            hobbit.title = "Hobbit";
            hobbit.author = "Tolkin";
            hobbit.pages = 700;
            Console.WriteLine(hobbit.title);


            Console.ReadLine();
        }
	
	}
}

