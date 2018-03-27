using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			ConsoleColor CurrentColor, NewConsoleColor;
			CurrentColor = Console.ForegroundColor;
			NewConsoleColor = ConsoleColor.Red;

			Console.WriteLine("Hello World in color: {0}",CurrentColor);
			CurrentColor = Console.ForegroundColor;
			NewConsoleColor = ConsoleColor.Red;
			Console.ForegroundColor = NewConsoleColor;
			Console.WriteLine("Some text with color: {0}",NewConsoleColor);
			Console.ForegroundColor = CurrentColor;


			float number1 = 2.35f;
			float number2 = (float)2.35;
			byte number3 = 2;
			

		}
	}
}
