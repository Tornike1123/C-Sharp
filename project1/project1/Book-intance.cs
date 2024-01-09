using System;
namespace project1
{
	public class Book_intance
	{
		static void Main(string[] args)
		{
			Book hp = new Book("Harry Potter", "JK ROWLING", 400);
			Console.WriteLine(hp.title);
			

            Book hobbit = new Book("Hobbit", "Tolkin", 700);
            Console.WriteLine(hobbit.title);


            Console.ReadLine();
        }
	
	}
}

