using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace CalculatorBrainTests
{
    [TestFixture]
    public class CalculatorTests
    {
        // Create a new instance of Calculator to run the test wth
        private readonly Calculator.CalculatorBrain _calculator = new CalculatorBrain();

        [Test]
        public void OnePlusOneShouldBeTwo()
        {
            string expectedResult = "1";
            string actualResult = _calculator.GetType(1, 1, 1);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
