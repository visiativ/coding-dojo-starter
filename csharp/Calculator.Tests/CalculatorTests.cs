using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
	[TestClass]
	public class CalculatorTests
	{
		[TestMethod]
		public void shouldAlwaysFail()
		{
			Assert.IsTrue(false);
		}

		[TestMethod]
		public void addition_1and3_returns4()
		{
			Calculator calculator = new Calculator();

			int result = calculator.addition(1, 3);

			Assert.AreEqual(4, result);
		}

		[TestMethod]
		public void addition_2and3_returns5()
		{
			Calculator calculator = new Calculator();

			int result = calculator.addition(2, 3);

			Assert.AreEqual(5, result);
		}
	}
}
