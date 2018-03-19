using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace JumpStartFiles
{
	class FunWithFiles
	{
		static void Main(string[] args)
		{
			//variable definition
			StringBuilder SomeString = new StringBuilder();
			StringBuilder SomeStringToPlay = new StringBuilder();

			string SourceString = "X", DestinationString = "";
			int iteration = 10;


			//Fun with StringBuilder

			//define StopWatch
			Stopwatch sw = new Stopwatch();

			//define new ClString object
			var objStrBuilder = new ClString();
			sw.Start();
			for (int i = 0; i < iteration; i++)
			{
				//display progess in %
				/*
				if (i % 100 == 0)
				{
					Console.Write("{0:p2}",(double)i/iteration);
				}
				*/
				DestinationString = objStrBuilder.StrAppend(DestinationString, SourceString);
			}

			sw.Stop();
			Console.WriteLine();
			//Console.WriteLine("SomeString: {0}", DestinationString);
			Console.WriteLine("Elapsed time using StringBuilder Method: {0:n10}", sw.Elapsed.TotalSeconds);
			Console.WriteLine("Number of objects: {0}", DestinationString.Length);


			//reset SB strings
			SomeString.Clear();
			SomeStringToPlay.Clear();


			//stopwatch for classis string operation
			sw.Reset();
			sw.Start();
			DestinationString = "";
			for (int i = 0; i < iteration; i++)
			{
				DestinationString += SourceString;
			}
			sw.Stop();
			Console.WriteLine("Elapsed time using classic string operation: {0:n10}", sw.Elapsed.TotalSeconds);
			Console.WriteLine("Number of objects: {0}", DestinationString.Length);

			//stopwatch for string with StringBuilder
			sw.Reset();
			sw.Start();
			DestinationString = "";
			for (int i = 0; i < iteration; i++)
			{
				SomeString.Append("X");
			}
			DestinationString = SomeString.ToString();
			sw.Stop();
			Console.WriteLine("Elepsed time using StringBuilder: {0:n10}", sw.Elapsed.TotalSeconds);
			Console.WriteLine("Number of objects: {0}", DestinationString.Length);

			//fun with StringBuilder
			SomeStringToPlay.AppendFormat("Some text {0}. Next text will be on new line: \n {1}", "StringBuilder", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
			SomeStringToPlay.AppendLine();
			SomeStringToPlay.AppendLine("New line with text");
			SomeStringToPlay.Append("\n");
			SomeStringToPlay.Append("end of game");

			//normal string operations
			Console.WriteLine("End presseent:{0}", SomeStringToPlay.ToString().Contains("end"));
			//SomeStringToPlay - show on console
			Console.WriteLine(SomeStringToPlay);

			//Empty string
			SomeStringToPlay.Clear();

			//Add some text to play with
			SomeStringToPlay.AppendLine("This is text to plat with");

			//Replace 'e' by 'E'
			SomeStringToPlay.Replace("e", "E");

			//SomeStringToPlay - show on console
			Console.WriteLine("Replace 'e' by 'E': {0}", SomeStringToPlay);

			//Replace 'plat' by 'play'
			SomeStringToPlay.Replace("plat", "play");

			//SomeStringToPlay - show on console
			Console.WriteLine("'plat' by 'play': {0}", SomeStringToPlay);

			//Numbers
			double BigNumber = 23132156464.1534564;
			Console.WriteLine("Exponatial - E2: {0:E2}", BigNumber);
			Console.WriteLine("Exponatial - E4: {0:E4}", BigNumber);


			//fun with files

			var objDir = new ClFile();
			//get current dir
			string path = objDir.ShowCurrentPath().ToString();
			Console.WriteLine("DIR 1:{0}", path);
			Console.WriteLine("DIR 2:{0}", objDir.ShowCurrentPath());

			//get all subdirs
			var MyDir = Directory.GetCurrentDirectory();
			var CurrentDir = "C:\\DataFolder\\Downloads";


			if (Directory.Exists(CurrentDir))
			{
				var DirList = Directory.GetDirectories(CurrentDir);
				var FileList = Directory.GetFiles(CurrentDir);

				/*foreach (var DirItem in DirList)
				{
					Console.WriteLine("DIR: {0}", DirItem);
				}*/
				Console.WriteLine("Number of DIRS: {0}", DirList.Count());
				Console.WriteLine("Number of FILES:{0}", FileList.Count());

				//work with all dirs - enum type
				foreach (var _dir in DirList)
				{
					var MyDirInfo = new DirectoryInfo(_dir);

					//List only Dirs with Extension
					if (!(MyDirInfo.Extension.Length == 0))
					{
						Console.WriteLine("Name: {0}", MyDirInfo.Name);
						Console.WriteLine("FullName: {0}", MyDirInfo.FullName);
						Console.WriteLine("Extension: {0}", MyDirInfo.Extension);
					}
				}
				//work with all files - enum type
				long TotalSize = 0;
				foreach (var _file in FileList)
				{
					var MyFileInfo = new FileInfo(_file);

					//List only *.exe files
					if ((MyFileInfo.Extension == ".exe"))
					{
						Console.WriteLine("File in DIR:{0}", MyFileInfo.DirectoryName);
						Console.WriteLine("Name: {0}", MyFileInfo.Name);
						Console.WriteLine("FullName: {0}", MyFileInfo.FullName);
						Console.WriteLine("Extension: {0}", MyFileInfo.Extension);
						Console.WriteLine("Lenght: {0:N}", MyFileInfo.Length);
						TotalSize += MyFileInfo.Length;
					}
				}
				Console.WriteLine("Number of files: {0:D5}, Total Size of files: {1:N}", FileList.Count(), TotalSize);

				//Lambda try
				var LambdaFiles = FileList.Where(item => item.Contains(".exe")).Select(item => item.ToString());
				foreach (var _file in LambdaFiles)
				{
					Console.WriteLine("Lambda Files: {0}", _file);
				}


			}
			else
			{
				Console.WriteLine("DIR: {0} dont exist", CurrentDir);
			}

			
			//press any key
			Console.WriteLine("press any key ...");
			Console.ReadKey(true);

		}





		//functions and methods of FunWithFiles Class to be added 
		//example of method
		private string MyMethod(string text)
		{
			//todo
			return text;
		}

		/* implement this piece of code
		static String BytesToString(long byteCount)
		{
			string[] suf = { "B", "KB", "MB", "GB", "TB", "PB", "EB" }; //Longs run out around EB
			if (byteCount == 0)
				return "0" + suf[0];
			long bytes = Math.Abs(byteCount);
			int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
			double num = Math.Round(bytes / Math.Pow(1024, place), 1);
			return (Math.Sign(byteCount) * num).ToString() + suf[place];
		}
		*/



	}

}
