using System;
using System.Collections.Generic;
using System.Linq;

namespace NETReflectionSearch.Model
{
	public class SearchFilterProvider
	{
		public string[] FilterDescriptions => filterDescriptions ?? (filterDescriptions = AllFilterInfos.Keys.ToArray());
		string[] filterDescriptions;

		public SearchFilter CreateNewFilterFromDescription(string description) => AllFilterInfos[description]();

		IReadOnlyDictionary<string, Func<SearchFilter>> AllFilterInfos => allFilterInfos ?? (allFilterInfos = GetAllFilterInfos());
		IReadOnlyDictionary<string, Func<SearchFilter>> allFilterInfos;

		IReadOnlyDictionary<string, Func<SearchFilter>> GetAllFilterInfos()
		{
			return new Dictionary<string, Func<SearchFilter>>
			{
				{ "Subclasses of...", () => new SubclassFilter() },
				{ "Classes that apply the Interface...", () => new ClassesWithInterfaceFilter() },
				{ "Classes with Attribute...", () => new ClassesWithAttributeFilter() },
				{ "Members with Attribute...", () => new MembersWithAttributeFilter() },
				{ "Overrides of Member...", () => new OverriddenMembersFilter() }
			};
		}
	}
}
