using System;

namespace NETReflectionSearch.Model
{
	public class MembersWithAttributeFilter : SearchFilter, ITextFilter
	{
		public string AttributeName
		{
			get { return attributeName; }
			set { attributeName = value; }
		}

		string attributeName = "Attribute name (name-only or namespace-qualified)";

		internal override bool IsMatch()
		{
			throw new NotImplementedException();
		}

		#region ITextFilter

		string ITextFilter.Text
		{
			get { return AttributeName; }
			set { AttributeName = value; }
		}

		#endregion
	}
}
