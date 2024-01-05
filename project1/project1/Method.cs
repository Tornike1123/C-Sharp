namespace project1
{
class Method
	{
		static void Main (string[] args)
		{
			//Call the method
			Console.WriteLine(cube(5));

			SayHi(11, "toko");
            SayHi(12, "gio");
            SayHi(14, "ragac");

            Console.ReadLine();
		
		}

		//method
		static void SayHi(int num, string str)
		{
			Console.WriteLine("hello " + num + " " + str);
		}


		//return statement
		static int cube(int numb)
		{
			int result = numb * numb * numb;
			return result;
		}
	}
}

