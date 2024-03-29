namespace Tests
{
    using CharacterCounter.Logic;
    using NUnit.Framework;
    using System;

    public class OccuranceCounterTests
    {
        private IOccuranceCounter OccuranceCounter;

        [SetUp]
        public void Setup()
        {
            this.OccuranceCounter = new OccuranceCounter();
        }

        [TestCase("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Eanean sodales justo et Enim ornare, a congue lacus commodo.", 'e', 10)]
        [TestCase("17272838119191929838299111", '1', 8)]
        [TestCase(7 + 5, '1', 1)]
        public void ShouldReturnCorrectOccuranceCountForCharacterInString<T>(
            T sequence, char charOfInterest, int expectedOccurances) where T : IConvertible
        {
            var occuranceCount = this.OccuranceCounter.CountCharactersInSequence(
                sequence, charOfInterest);

            Assert.AreEqual(occuranceCount, expectedOccurances);
        }
    }
}
