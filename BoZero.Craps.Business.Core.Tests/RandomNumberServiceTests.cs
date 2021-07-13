using BoZero.Craps.Business.Core.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BoZero.Craps.Business.Core.Tests
{
	[TestClass]
	public class RandomNumberServiceTests
	{
		[TestMethod]
		public void TestMethod1()
		{
			var randomNumberService = new RandomNumberService();
			var roll = randomNumberService.GetRandomNumber(6);
			Assert.IsTrue(roll >= 1 && roll <= 6);
		}
	}
}
