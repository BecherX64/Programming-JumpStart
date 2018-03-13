﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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


			//LINQ - query and method syntax
			var data = Enumerable.Range(1, 50);

			var method = //IEnumerable<string>
				data.Where(item => item % 2 == 0)
				.Select(item => item.ToString());

			var query = //IEnumerable<string>
				from item in data
				where item % 2 == 0
				select item.ToString();

			//Debugger.Break();

			//cerate new object projection 
			var projection =
				from item in data
				select new
				{
					Even = (item % 2 == 0),
					Odd = !(item % 2 == 0),
					Value = item,
				};

			//write out all items from 'projection'
			foreach (var item in projection)
			{
				Console.WriteLine(item.Value);
			}


			//new array of letters
			var letters = new[] { "A", "C", "B", "D", "Q" };
			//sort ascending
			var sortAsc =
				from item in letters
				orderby item ascending
				select item;
			//sort descending
			var sortDesc =
				letters.OrderByDescending(item => item);
			//other tricks
			var distinct = letters.Distinct(); //remove duplicates
			var first = letters.First();
			var firstOr = letters.FirstOrDefault();
			var last = letters.Last();


		//press any key before exit
		Console.WriteLine("Press any key ..");
			Console.ReadKey(true);
		}
	}
}
