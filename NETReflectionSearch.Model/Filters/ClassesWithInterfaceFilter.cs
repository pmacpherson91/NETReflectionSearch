using System;

namespace NETReflectionSearch.Model
{
	public class ClassesWithInterfaceFilter : SearchFilter, ITextFilterWithFlag
	{
		public string InterfaceName
		{
			get { return interfaceName; }
			set { interfaceName = value; }
		}

		string interfaceName = "Interface name (name-only or namespace-qualified)";

		bool IncludeInherited { get; set; }

		internal override bool IsMatch()
		{
			throw new NotImplementedException();
		}

		#region ITextFilterWithFlag

		string ITextFilterWithFlag.Text
		{
			get { return InterfaceName; }
			set { InterfaceName = value; }
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
