using NUnit.Framework;
using System.Linq;

namespace Tests
{
	public class Tests
	{
		[Test]
		[TestCase("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Eanean sodales justo et Enim ornare, a congue lacus commodo.", 'e')]
		public void Test1(string hayStack, char needle)
		{
			Assert.Pass();
		}
	}
}