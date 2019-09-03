namespace CharacterCounter.Logic
{
	using System.Linq;

	public interface IOccuranceCounter
	{
		int CountCharactersInSequence(string sequence, char charOfInterest);
	}

	public class OccuranceCounter : IOccuranceCounter
	{
		public int CountCharactersInSequence(string sequence, char charOfInterest)
		{
			return sequence.Count(c => c == charOfInterest);
		}
	}
}
