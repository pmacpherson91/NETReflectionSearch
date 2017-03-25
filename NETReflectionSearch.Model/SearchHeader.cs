using Mono.Cecil;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace NETReflectionSearch.Model
{
	public class SearchHeader
	{
		public List<SearchResult> Search(IEnumerable<string> directories, bool isRecursive, IEnumerable<SearchFilter> filters)
		{
			return new List<SearchResult>
			{
				new SearchResult("assembly 1", "file 1"),
				new SearchResult("assembly 2", "file 2"),
				new SearchResult("assembly 3", "file 3"),
				new SearchResult("assembly 4", "file 4")
			};
			//var results = new List<SearchResult>();

			//foreach (var directory in directories)
			//{
			//	var assemblyFiles = Directory.GetFiles(directory, "*.dll");

			//	foreach (var assemblyFile in assemblyFiles)
			//	{
			//		var assembly = Assembly.LoadFrom(assemblyFile);

			//		foreach (var assemblyType in assembly.GetTypes().Where(assemblyType => filters.All(filter => filter.IsMatch(assemblyType))))
			//		{
			//			var readerParams = new ReaderParameters { ReadSymbols = true };
			//			var assemblyDefinition = AssemblyDefinition.ReadAssembly(assemblyFile.ToLower().Replace(".dll", ".pdb"), readerParams);
			//			var fileName = assemblyDefinition.MainModule.GetType(assemblyType.FullName).Module.FileName;
			//			results.Add(new SearchResult(assemblyType.FullName, fileName));
			//		}
			//	}
			//}

			//return results;
		}
	}
}
