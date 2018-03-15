using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpStartFiles
{
	public class ClString
	{
		public ClString()
		{

		}

		public string StrAppend(string SourceString, string DestinationString)
		{
			//update to follow method string and inside it will do with StringBuilder and return string
			StringBuilder _SourceString = new StringBuilder();
			_SourceString = _SourceString.Append(SourceString);
			_SourceString = _SourceString.Append(DestinationString);
			return _SourceString.ToString();

		}

	}


}