namespace CharacterCounter.Logic
{
	using System.Linq;

	public interface IOccuranceCounter
	{
		int CountCharactersInSequence<T>(T sequence, char charOfInterest);
	}

	public class OccuranceCounter : IOccuranceCounter
	{
		public int CountCharactersInSequence<T>(T sequence, char charOfInterest)
		{
			return sequence.ToString().Count(c => c == charOfInterest);
		}
	}
}
