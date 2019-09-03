namespace CharacterCounter.Logic
{
    using System;
    using System.Linq;

	public interface IOccuranceCounter
	{
		int CountCharactersInSequence<T>(T sequence, char charOfInterest) where T : IConvertible;
	}

	public class OccuranceCounter : IOccuranceCounter
	{
		public int CountCharactersInSequence<T>(T sequence, char charOfInterest) where T : IConvertible
		{
			return sequence.ToString().Count(c => c == charOfInterest);
		}
	}
}
