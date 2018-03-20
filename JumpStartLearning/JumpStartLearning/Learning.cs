using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
			Console.WriteLine(letters[1]);


			//define peopleArray
			Member[] peopleArray = new Member[3]
				{
					new Member("Cody","Blackwell"),
					new Member("Raj","Chawada"),
					new Member("Harry","Lipsey"),
				};
			//list all items in peopleArray
			Members peopleList = new Members(peopleArray);
			foreach (Member p in peopleList)
			{
				Console.WriteLine(p.CompanyAffiliation + ":" + p.CV_Info);
			}
			//write 2nd member of object
			Console.WriteLine(peopleArray[1].CompanyAffiliation);


			//Regular expressions
			string pattern = "(Mrs\\.?|Mr\\.?)";
			string[] names =  {"Mr. Fero","Mr. Juro","Mrs. Jana","Ms. Mata"};
			
			//standard loop thought array
			foreach (string name in names)
			{
				Console.WriteLine("Regex replacement: {0}",Regex.Replace(name,pattern,"X"));
			}
			//work with array using index
			int itteration = names.Count();
			for (int i = 0; i < itteration; i++)
			{
				string text = names[i];
				Console.WriteLine("Array of strings: Item: {0} on possition: {1}",text,i);
				Console.WriteLine("Replace using Regex:{0}",Regex.Replace(text,pattern,"X"));
			}

			//working with EventLog
			//simple way
			EventLog eventLog = new EventLog();
			EventLog MyEventLog = eventLog;
			MyEventLog.Source = "Application";
			MyEventLog.WriteEntry("Test mesage", EventLogEntryType.Information, 102, 0);

			//preffered way: register application as Event Log Source
			//EventLog.CreateEventSource(eventSource, "Application");
			//Full implementaion of create "register" event Source: EventLog.CreateEventSource(string EvetnSource, string LogName, string machineName);


			//press any key before exit
			Console.WriteLine("Press any key ..");
			Console.ReadKey(true);
		}
	}
}
