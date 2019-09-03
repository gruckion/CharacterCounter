using System;

namespace CharacterCounter.Logic
{
	public interface IOccuranceCounter
	{
		int CountCharactersInSequence(string sequence, char charInterest);
	}

	public class OccuranceCounter : IOccuranceCounter
	{
		public int CountCharactersInSequence(string sequence, char charInterest)
		{
			return sequence.Length;
		}
	}
}
