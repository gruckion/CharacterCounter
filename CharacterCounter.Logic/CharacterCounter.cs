using System;

namespace CharacterCounter.Logic
{
	public interface ICharacterCounter
	{
		int CountCharactersInSequence();
	}


	public class CharacterCounter : ICharacterCounter
	{
		public int CountCharactersInSequence()
		{
			throw new NotImplementedException();
		}
	}
}
