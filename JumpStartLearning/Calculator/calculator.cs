using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{

	public class calculator
	{
		public static void Main()
		{
			//SomeOperation add = Sum;
			char key;
			bool AppStatus = true;
			int Number1, Number2;
			do
			{
				ShowMenu();
				key = Console.ReadKey(true).KeyChar;			
				switch (key)
				{
					case 'a':
						Number1 = GetSomeKeyAsNumber();
						Number2 = GetSomeKeyAsNumber();
						int AddResult = Addition(Number1, Number2);
						Console.WriteLine("Result: {0} + {1} = {2}", Number1, Number2, AddResult);
						break;
					case 's':
						Number1 = GetSomeKeyAsNumber();
						Number2 = GetSomeKeyAsNumber();
						int SubResult = Substraction(Number1, Number2);
						Console.WriteLine("Result: {0} - {1} = {2}", Number1, Number2, SubResult);
						break;
					case 'c':
						Console.Clear();
						break;
					default:
						//Console.WriteLine("no action");
						AppStatus = false;
						break;
				}

			} while (AppStatus);
			Console.WriteLine("Press any key ...");
			Console.ReadKey(true);
		}

		static int Substraction(int i, int j)
		{
			return i - j;
		}

		static int Addition(int i, int j)
		{
			return i + j;
		}

		static int GetSomeKeyAsNumber()
		{
			Console.WriteLine("Enter any number:");
			string _Text = Console.ReadLine();
			Int32.TryParse(_Text, out int _output);
			return _output;
			
		}
		static void ShowMenu()
		{
			//Console.Clear();
			Console.WriteLine("(a)ddition: Press 'a'");
			Console.WriteLine("(s)ubtraction: Press 's'");
			Console.WriteLine("E(x)it: Press 'x'");
		}
	}
}
