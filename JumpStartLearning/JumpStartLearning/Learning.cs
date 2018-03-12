using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpStartLearning
{
	class Learning
	{
		//Variables declaration
		enum Dogs { Rex, Dunco, Kostial }

		static void Main(string[] args)
		{
			//my first code
			/*
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
			*/

			//If statement
			int vall = 2;

			if (vall == 1)
			{
				//todo
			}
			else
			{
				if (vall==2)
				{
					//todo
				}
			}

			//For statement
			for (int i = 0; i < 10; i++)
			{
				//do something
				Console.WriteLine("Number: {0}",i+1);
			}


			//Switch statement
			
			var pes = Dogs.Rex;
			switch (pes)
			{
				case Dogs.Rex:
					//todo
					Console.WriteLine("Dogs: {0}",pes);
					break;
				case Dogs.Dunco:
					//todo
					break;
				case Dogs.Kostial:
					//todo
					break;
				default:
					//todo
					throw new NotSupportedException();
					break;
			}

			//Casting
			//OMG !!!!


			//Strings
			//common string are imutable (constant) - every change to string will create new string object !!!
			//Stringbuilder class
			var MyString = new StringBuilder();
			MyString.Append("Appended text");
			Console.WriteLine("MyString: {0}",MyString);
			//check other options

			//check for regular expressions


			//using Class from another file
			var zver = new Animal();
			var dunco = new Dog();
			
			zver.Name = "Zver";
			zver.Age = 20;
			zver.MyMethod(20, 30);
			Console.WriteLine("Class Animal: {0}: Vek: {1}",zver.Name, zver.Age);

			dunco.Name = "Dunco";
			dunco.Age = 10;
			dunco.Hungry(false);
			dunco.MyMethod(40, 50);
			Console.WriteLine("Class Dog: {0}: vek: {1}",dunco.Name, dunco.Age);

			


		//press any key before exit
		Console.WriteLine("Press any key ..");
			Console.ReadKey(true);
		}
	}
}
