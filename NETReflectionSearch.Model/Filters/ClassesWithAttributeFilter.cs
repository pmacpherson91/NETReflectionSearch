using System;

namespace NETReflectionSearch.Model
{
	public class ClassesWithAttributeFilter : SearchFilter, ITextFilterWithFlag
	{
		public string AttributeName
		{
			get { return attributeName; }
			set { attributeName = value; }
		}

		string attributeName = "Attribute name (name-only or namespace-qualified)";

		bool IncludeInherited { get; set; }

		internal override bool IsMatch(Type searchType)
		{
			throw new NotImplementedException();
		}

		#region ITextFilterWithFlag

		string ITextFilterWithFlag.Text
		{
			get { return AttributeName; }
			set { AttributeName = value; }
		}

		bool ITextFilterWithFlag.Flag
		{
			get { return IncludeInherited; }
			set { IncludeInherited = value; }
		}

		string ITextFilterWithFlag.FlagDescription => "Include inherited";

		#endregion
	}
}
