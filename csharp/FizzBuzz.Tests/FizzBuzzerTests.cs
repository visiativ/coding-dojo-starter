using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace FizzBuzz.Tests
{
	/// <summary>
	/// Classe contenant les tests unitaires pour la classe FizzBuzzer.
	/// </summary>
    [TestClass]
    public class FizzBuzzerTests
    {
        [TestMethod]
        public void FizzBuzz_ShouldNot_ReturnsNull()
        {
            // Arrange
            FizzBuzzer fizzBuzzer = new FizzBuzzer();
			int entry = 1;

			// Act
			string actual = fizzBuzzer.FizzBuzz(entry);

			// Assert
			Assert.IsNotNull(actual);
        }
    }
}
