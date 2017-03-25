using System.Collections.Generic;
using System.Reflection;

namespace NETReflectionSearch.Model
{
	public class SearchHeader
	{
		public SearchResult[] Search(IEnumerable<string> directories, IEnumerable<SearchFilter> filters)
		{
			Assembly.LoadFrom("");
			return null;
		}
	}
}
