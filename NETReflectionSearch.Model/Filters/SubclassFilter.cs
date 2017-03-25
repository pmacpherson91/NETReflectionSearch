using System;

namespace NETReflectionSearch.Model
{
	public class SubclassFilter : SearchFilter, ITextFilterWithFlag
	{
		public string ParentClassName
		{
			get { return parentClassName; }
			set { parentClassName = value; }
		}

		string parentClassName = "Parent class name (name-only or namespace-qualified)";

		bool ImmediateSubclassesOnly { get; set; }

		internal override bool IsMatch(Type searchType)
		{
			throw new NotImplementedException();
		}

		#region ITextFilterWithFlag

		string ITextFilterWithFlag.Text
		{
			get { return ParentClassName; }
			set { ParentClassName = value; }
		}

		bool ITextFilterWithFlag.Flag
		{
			get { return ImmediateSubclassesOnly; }
			set { ImmediateSubclassesOnly = value; }
		}

		string ITextFilterWithFlag.FlagDescription => "Immediate subclasses only";

		#endregion
	}
}
