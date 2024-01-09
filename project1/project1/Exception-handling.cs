//using System;
//namespace project1
//{
//	public class Exception_handling
//	{
//		static void Main(string[] args)
//		{
//			try
//			{
//                Console.Write("Enter a number: ");
//                int numb1 = Convert.ToInt32(Console.ReadLine());
//                Console.Write("Enter another number: ");
//                int numb2 = Convert.ToInt32(Console.ReadLine());

//                Console.WriteLine(numb1 / numb2);
//            }
//            catch (Exception ex)
//            {
//                // all exteption error
//                Console.WriteLine(ex.Message);
//            }
//            catch (DivideByZeroException ex)
//            {
//                // only divide by zero error
//                Console.WriteLine(ex.Message);
//            }
//            catch (FormatException ex)
//            {
//                // only format exception
//                Console.WriteLine(ex.Message);
//            }
//        }
//	}
//}


//short summary: if you use Exception you cannot use (DivideByZeroException,FormatException)
