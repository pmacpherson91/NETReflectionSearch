using System;

namespace NETReflectionSearch.Model
{
	public class OverriddenMembersFilter : SearchFilter, ITextFilter
	{
		public string MemberName
		{
			get { return memberName; }
			set { memberName = value; }
		}

		string memberName = "Member name (name-only or namespace-qualified)";

		internal override bool IsMatch(Type searchType)
		{
			throw new NotImplementedException();
		}

		#region ITextFilter

		string ITextFilter.Text
		{
			get { return MemberName; }
			set { MemberName = value; }
		}

		#endregion
	}
}
