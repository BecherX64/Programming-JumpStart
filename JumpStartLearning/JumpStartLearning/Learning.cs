using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpStartLearning
{
	class Learning
	{
		static void Main(string[] args)
		{
		    bool AppStatus = true;
			char key;
			Console.WriteLine("I am good");
			
			do
			{	
				key = Console.ReadKey(true).KeyChar;
				Console.WriteLine();
				Console.WriteLine("You typed:{0}", key);

				if (key.Equals('x') )	
				{
					AppStatus = false;
				}
			} while (AppStatus);
			Console.WriteLine("Press any key ..");
			Console.ReadKey(true);
		}
	}
}
