using System;

namespace HelloWorld
{
	public class Person
	{
		private string _name;
		private int _id;
		
		public void SetName(string name)
		{
			if (!(string.IsNullOrEmpty(name)))
			{
				this._name = name;
			}
			else
			{
				Console.WriteLine("Empty string !!!");
			}
		}

		public string GetName()
		{
			return _name;
		}

		public void SetId(int id)
		{
			if (id >= 0)
			{
				this._id = id;
			}
			else
			{
				Console.WriteLine("Incorect ID: {0}",id);
			}
		}

		public int GetId()
		{
			return _id;
		}

		//with Property style implementation
		private DateTime _birthDate;

		public DateTime BirthDate
		{
			get { return _birthDate; }
			set { _birthDate = value; }
		}

	}

}
