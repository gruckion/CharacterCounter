namespace Tests
{
	using CharacterCounter.Logic;
	using NUnit.Framework;

	public class OccuranceCounterTests
	{
		private IOccuranceCounter OccuranceCounter;

		[SetUp]
		public void Setup()
		{
			this.OccuranceCounter = new OccuranceCounter();
		}

		[Test]
		[TestCase("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Eanean sodales justo et Enim ornare, a congue lacus commodo.", 'e', 10)]
		[TestCase("17272838119191929838299111", '1', 8)]
		public void ShouldReturnCorrectOccuranceCountForCharacterInString(
			string sequence, char charOfInterest, int expectedOccurances)
		{
			var occuranceCount = this.OccuranceCounter.CountCharactersInSequence(sequence, charOfInterest);

			Assert.AreEqual(occuranceCount, expectedOccurances);
		}
	}
}
