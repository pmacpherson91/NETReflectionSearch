namespace NETReflectionSearch.Model
{
	public class SearchResult
	{
		public SearchResult(string assemblyName, string sourceFile)
		{
			AssemblyName = assemblyName;
			SourceFile = sourceFile;
		}

		public string AssemblyName { get; }
		public string SourceFile { get; }
	}
}
