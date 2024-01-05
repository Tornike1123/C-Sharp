namespace project1
{
class Method
	{
		static void Main (string[] args)
		{
			SayHi(11, "toko");
            SayHi(12, "gio");
            SayHi(14, "ragac");

            Console.ReadLine();
		}
		static void SayHi(int num, string str)
		{
			Console.WriteLine("hello " + num + " " + str);
		}
	}
}

