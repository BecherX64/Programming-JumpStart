using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{

	class HelloWorldMain
	{
		static void Main(string[] args)
		{

			//Changing Console text Color
			ConsoleColor CurrentColor, NewConsoleColor;
			CurrentColor = Console.ForegroundColor;
			NewConsoleColor = ConsoleColor.Red;

			Console.WriteLine("Hello World in color: {0}", CurrentColor);
			CurrentColor = Console.ForegroundColor;
			NewConsoleColor = ConsoleColor.Red;
			Console.ForegroundColor = NewConsoleColor;
			Console.WriteLine("Some text with color: {0}", NewConsoleColor);
			Console.ForegroundColor = CurrentColor;


			//Fun with Person Class
			string[] arrayOfPersons = new string[] { "Jozo", "Palo", "Juraj", "Jano" };
			int index = 0;
			var today = DateTime.Now;
			

			var people = new List<Person>();

			foreach (var person in arrayOfPersons)
			{
				Console.WriteLine(person);
				var personToAdd = new Person();
				personToAdd.SetName(person);
				personToAdd.SetId(index++);
				personToAdd.BirthDate = (today.AddYears(0 - index));
				

				people.Add(personToAdd);
			}

			
			var query1 = from p in people
						 where p.GetId() == 2
						 select p;
			Console.WriteLine("query1.count(): {0}", query1.Count());
			foreach (var item in query1)
			{
				Console.WriteLine("ID: {0} - Name: {1} - Birthday: {2:MM/dd/yyyy}", item.GetId(), item.GetName(), item.BirthDate);
			}


			
			var query2 = from p in people
						 where p.GetName().ToString().StartsWith("J")
						 select p;
			Console.WriteLine("query2.count(): {0}", query2.Count());
			foreach (var item in query2)
			{
				Console.WriteLine("ID: {0} - Name: {1} - Birthday: {2:MM/dd/yyyy}", item.GetId(), item.GetName(), item.BirthDate);
			}


			var query3 = from p in people
						 where p.BirthDate.Year == 2016
						 select new
						 {
							 name = p.GetName(),
							 birthday = p.BirthDate
						 };

			Console.WriteLine("query3.count(): {0}",query3.Count());
			foreach (var item in query3)
			{
				Console.WriteLine("Name: {0} - BirthDate: {1: yyyy}",item.name, item.birthday);
			}


			Console.WriteLine("Listing List<Person>");
			foreach (var item in people)
			{
				Console.WriteLine("ID: {0} - Name: {1} - Birthday: {2:MM/dd/yyyy}", item.GetId(),item.GetName(),item.BirthDate);
			}


			//TODO - Save to file



			//end of program
			Console.WriteLine("Press any key ...");
			Console.ReadKey(false);


		}

		#region Method and Functions
		public void funWithFiles()
		{
			//Fun with Curent Dir
			string newCurrentDir = "C:\\DataFolder\\Downloads\\TestShare";
			var currentDir = Directory.GetCurrentDirectory();

			Console.WriteLine("Current Dir: {0}", currentDir);
			Directory.SetCurrentDirectory(newCurrentDir);
			Console.WriteLine("New Current Dir: {0}", Directory.GetCurrentDirectory());

			//Create new file (overwrite)
			string myFileName = (Directory.GetCurrentDirectory() + "\\MyFile.txt");
			var newFile = File.Create(myFileName);
			Console.WriteLine("Created file lenght: {0}", newFile.Length);
			newFile.Close();

			Console.WriteLine("Press any key ...");
			Console.ReadKey(false);


			//Append text to new file
			var myFile = File.AppendText(myFileName);
			myFile.WriteLine("Just some new line");
			myFile.WriteLine("Current Dir: {0}", Directory.GetCurrentDirectory());
			myFile.Close();

		}

		#endregion


	}

}
