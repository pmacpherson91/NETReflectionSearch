using System;

namespace NETReflectionSearch.Model
{
	public abstract class SearchFilter
	{
		internal abstract bool IsMatch(Type searchType);
	}
}
