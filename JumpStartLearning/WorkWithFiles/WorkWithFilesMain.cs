using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithFiles
{
	class WorkWithFilesMain
	{
		static void Main(string[] args)
		{
			string inputFile = "C:\\DataFolder\\Downloads\\TestShare\\BigFile.txt";
			string outputFile = "C:\\DataFolder\\Downloads\\TestShare\\BigFileOut.txt";
			int numberOfBytes = 1024;
			long readFrom = 0;
			long totalBytesWritten = 0;
			long totalInputFileLenght = 0;
			bool endOfFile = false;
			


			//Definitly xxx is great name for variable
			var xxx = new WorkWithFilesMain();

			//check if input file exist
			if (File.Exists(inputFile))
			{
				Console.WriteLine("InputFile: {0}", inputFile);
				totalInputFileLenght = new FileInfo(inputFile).Length;
			}
			else
			{
				Console.WriteLine("Input File not found: {0}", inputFile);
			}

			//check if output file exists
			if (File.Exists(outputFile))
			{
				Console.WriteLine("OutputFile Exits: {0}", outputFile);
				Console.WriteLine("Removing Output File: {0}", outputFile);
				//Delete existing output file
				try
				{
					File.Delete(outputFile);
					Console.WriteLine("File Deteted succesfully: {0}",outputFile);
				}
				catch (Exception ex)
				{

					Console.WriteLine("Detele file failed: {0}",ex.Message); ;
				}
			}
			else
			{
				Console.WriteLine("Output File not found: {0}", outputFile);
			}
			Console.WriteLine("NumberOfBytes: {0}", numberOfBytes);
			Console.WriteLine("Copy from: {0}",readFrom);
			Console.WriteLine("Press any key to start copy: {0} to: {1} bytes: {2}", inputFile, outputFile, numberOfBytes);
			Console.ReadKey(false);

			//copy input file into output file
			do
			{
				//check end of file
				if (readFrom + numberOfBytes >= totalInputFileLenght)
				{
					numberOfBytes = (int)(totalInputFileLenght - readFrom);
					//Console.WriteLine("MyCopy:({0}, {1}, {2}, {3})",inputFile,outputFile,numberOfBytes,readFrom);
					totalBytesWritten += xxx.MyCopy(inputFile, outputFile, numberOfBytes, readFrom);
					//xxx.MyCopy(inputFile, outputFile, numberOfBytes, readFrom);
					endOfFile = true;
				}
				else
				{
					//Console.WriteLine("MyCopy:({0}, {1}, {2}, {3})", inputFile, outputFile, numberOfBytes, readFrom);
					//xxx.MyCopy(inputFile, outputFile, numberOfBytes, readFrom);
					totalBytesWritten += xxx.MyCopy(inputFile, outputFile, numberOfBytes, readFrom);
					readFrom += numberOfBytes;
				}
			} while (!(endOfFile));

			Console.WriteLine("Total Bytes Written: {0}",totalBytesWritten);
			Console.ReadKey(false);
		}


		private int MyCopy(string _inputFile, string _outputFile, int _numberOfBytes, long _readFrom)
		{

			//total bytes write 
			int _bytesWrite = 0;
		
			byte[] readBuffer = new byte[_numberOfBytes];

			//read data to byte array
			using (FileStream fsRead = new FileStream(_inputFile, FileMode.Open, FileAccess.Read, FileShare.Read))
			{
				try
				{
					fsRead.Seek(_readFrom, SeekOrigin.Begin);
					fsRead.Read(readBuffer, 0, _numberOfBytes);
					Console.WriteLine("OK: Read from file: {0} - Bytes: {1}",_inputFile,_numberOfBytes);
				}
				catch (Exception ex)
				{
					Console.WriteLine("Exception: {0}",ex.Message);
				}
			}

			//write data from byte array
			using (FileStream fsWrite = new FileStream(_outputFile, FileMode.Append, FileAccess.Write, FileShare.None))
			{
				try
				{
					fsWrite.Write(readBuffer, 0, _numberOfBytes);
					Console.WriteLine("OK: Write to file: {0} - Bytes: {1}",_outputFile,_numberOfBytes);
					_bytesWrite = _numberOfBytes;
				}
				catch (Exception ex)
				{
					Console.WriteLine("Exception: {0}",ex.Message); ;
				}
			}
			//return how many bytes was written
			return _bytesWrite;
		}

	}
}
