namespace NETReflectionSearch.Model
{
	public interface ITextFilterWithFlag
	{
		string Text { get; set; }
		bool Flag { get; set; }
		string FlagDescription { get; }
	}
}
