using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpStartLearning
{
	public class Member
	{
		public Member(string affiliation, string cv)
		{
			this.CompanyAffiliation = affiliation;
			this.CV_Info = cv;
		}

		public string CompanyAffiliation;
		public string CV_Info;

	}

	public class Members : IEnumerable
	{
		private Member[] _members;
		public Members(Member[] mArray)
		{
			_members = new Member[mArray.Length];
			Array.Copy(mArray, _members, mArray.Length);
		}
		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator)GetEnumerator();
		}

		public MemberEnum GetEnumerator()
		{
			return new MemberEnum(_members);
		}
	}

	public class MemberEnum : IEnumerator
	{
		public Member[] _members;

		int position = -1;
		public MemberEnum(Member[] list)
		{
			_members = list;
		}

		public bool MoveNext()
		{
			position++;
			Console.WriteLine("Position: {0}",position);
			return (position < _members.Length);
		}

		public void Reset()
		{
			throw new NotSupportedException("this reset method cannot be called");
		}

		object IEnumerator.Current
		{
			get
			{
				return Current;
			}
		}

		public Member Current
		{
			get
			{
				try
				{
					return _members[position];
				}
				catch (IndexOutOfRangeException)
				{

					throw new InvalidOperationException();
				}
			}
		}
	}

	

}