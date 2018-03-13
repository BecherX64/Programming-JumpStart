using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{

	public class Calculator
	{
		public static void Main()
		{
			char key;
			bool AppStatus = true;
			int Number1, Number2;
			int Result;

			do
			{
				ShowMenu();
				key = Console.ReadKey(true).KeyChar;			
				switch (key)
				{
					case 'a':
						//add numbers
						Number1 = GetSomeKeyAsNumber();
						Number2 = GetSomeKeyAsNumber();
						Result = Addition(Number1, Number2);
						Console.WriteLine("Result: {0} + {1} = {2}", Number1, Number2, Result);
						break;
					case 's':
						//substract numbers
						Number1 = GetSomeKeyAsNumber();
						Number2 = GetSomeKeyAsNumber();
						Result = Substraction(Number1, Number2);
						Console.WriteLine("Result: {0} - {1} = {2}", Number1, Number2, Result);
						break;
					case 'm':
						//multiply numbers
						Number1 = GetSomeKeyAsNumber();
						Number2 = GetSomeKeyAsNumber();
						Result = Multiply(Number1, Number2);
						Console.WriteLine("Result: {0} - {1} = {2}", Number1, Number2, Result);
						break;
					case 'c':
						//clear console
						Console.Clear();
						break;
					case 'x':
						//exit application
						AppStatus = false;
						break;
					default:
						//no action
						break;
				}

			} while (AppStatus);
			Console.WriteLine("Press any key ...");
			Console.ReadKey(true);
		}

		private static int Multiply(int i, int j)
		{
			return i * j;
		}

		private static int Substraction(int i, int j)
		{
			return i - j;
		}

		private static int Addition(int i, int j)
		{
			return i + j;
		}

		private static int GetSomeKeyAsNumber()
		{
			Console.WriteLine("Enter any number:");
			string _Text = Console.ReadLine();
			Int32.TryParse(_Text, out int _output);
			return _output;
			
		}
		private static void ShowMenu()
		{
			//Console.Clear();
			Console.WriteLine("(a)ddition: Press 'a'");
			Console.WriteLine("(s)ubtraction: Press 's'");
			Console.WriteLine("(m)ultiply: Press 'm'");
			Console.WriteLine("(c)lear screen: Press 'c'");
			Console.WriteLine("e(x)it: Press 'x'");
		}
	}

}
