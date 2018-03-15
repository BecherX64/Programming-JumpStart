using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpStartLearning
{
	public class Animal
	{
		public string MyField = string.Empty;

		public Animal()
		{

		}

		public void MyMethod(int param1, int param2)
		{
			Console.WriteLine("Param1: {0}, Param2: {1}", param1, param2);
		}
		public string Name { get; set; }

		public int Age { get; set; }


	}
	public class Dog : Animal
	{
		public void Hungry(bool IsHungry)
		{
			//to do
			Console.WriteLine("Je hladny: {0}",IsHungry);
		}

	}
	public class Bird : Dog
	{
		public void Sleep(bool IsSpleeping)
		{
			//to do
		}



	}
}