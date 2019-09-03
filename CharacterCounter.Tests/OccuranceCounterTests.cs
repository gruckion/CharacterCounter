using CharacterCounter.Logic;
using NUnit.Framework;
using System.Linq;

namespace Tests
{
	public class OccuranceCounterTests
	{
		private IOccuranceCounter OccuranceCounter;

		[SetUp]
		public void Setup()
		{
			this.OccuranceCounter = new OccuranceCounter();
		}

		[Test]
		[TestCase("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Eanean sodales justo et Enim ornare, a congue lacus commodo.", 'e', 117)]
		public void ShouldReturnCorrectOccuranceCountForCharacterInString(string sequence, char charInterest, int expectedOccurances)
		{
			var occuranceCount = this.OccuranceCounter.CountCharactersInSequence(sequence, charInterest);

			Assert.AreEqual(occuranceCount, expectedOccurances);
		}
	}
}