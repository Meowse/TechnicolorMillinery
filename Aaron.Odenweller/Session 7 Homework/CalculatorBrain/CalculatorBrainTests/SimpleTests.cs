using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CalculatorBrain;
using NUnit.Framework;

namespace CalculatorBrainTests
{
    [TestFixture]
    public class SimpleTests
    {
        [Test]
        public void ShouldDisplayZeroByDefault()
        {
            var aCalculator = new Calculator(0);
            Assert.AreEqual("0", aCalculator.GetDisplay(aCalculator));
        }

        [Test]
        public void ShouldDisplayZeroAfterClear()
        {
            var aCalculator = new Calculator(0);
            aCalculator.setNumber("1");
            aCalculator.SetDisplay(aCalculator.getNumber().ToString());
            aCalculator.setOperation("+");
            aCalculator.PerformOperation("1");
            aCalculator.setOperation("c");
            aCalculator.PerformOperation("c");
            Assert.AreEqual("0", aCalculator.GetDisplay(aCalculator));
        }

        [Test]
        public void ShouldDisplaySingleDigit()
        {
            var aCalculator = new Calculator(0);
            aCalculator.setNumber("1");
            aCalculator.ClearDisplay();
            aCalculator.SetDisplay(aCalculator.getNumber().ToString());
            Assert.AreEqual("1", aCalculator.GetDisplay(aCalculator));
        }

        [Test]
        public void ShouldAddSmallSingleDigits()
        {
            var aCalculator = new Calculator(0);
            aCalculator.setNumber("1");
            Assert.AreEqual("1", aCalculator.getNumber().ToString());
            aCalculator.setOperation("+");
            aCalculator.PerformOperation("2");
            Assert.AreEqual("3", aCalculator.getNumber().ToString());

        }

        [Test]
        public void ShouldAddLargeSingleDigitsIntoDoubleDigits()
        {
            var aCalculator = new Calculator(0);
            aCalculator.setNumber("9");
            Assert.AreEqual("9", aCalculator.getNumber().ToString());
            aCalculator.setOperation("+");
            aCalculator.PerformOperation("8");
            Assert.AreEqual("17", aCalculator.getNumber().ToString());
        }

        [Test]
        public void ShouldAcceptMultiDigitNumbers()
        {
            var aCalculator = new Calculator(0);
            aCalculator.ClearDisplay();
            aCalculator.setNumber("901");
            aCalculator.SetDisplay(aCalculator.getNumber().ToString());
            Assert.AreEqual("901", aCalculator.GetDisplay(aCalculator).ToString());
        }

        [Test]
        public void CanSubtractSingleDigitNumbers()
        {
            var aCalculator = new Calculator(0);
            aCalculator.setNumber("9");
            Assert.AreEqual("9", aCalculator.getNumber().ToString());
            aCalculator.setOperation("-");
            aCalculator.PerformOperation("3");
            Assert.AreEqual("6", aCalculator.getNumber().ToString());
        }

        [Test]
        public void CanSubtractMultiDigitNumbers()
        {
            var aCalculator = new Calculator(0);
            aCalculator.setNumber("100");
            Assert.AreEqual("100", aCalculator.getNumber().ToString());
            aCalculator.setOperation("-");
            aCalculator.PerformOperation("45");
            Assert.AreEqual("55", aCalculator.getNumber().ToString());
        }

        [Test]
        public void ShouldNotChangeJustBecauseGetDisplayIsCalled()
        {
            var aCalculator = new Calculator(0);
            aCalculator.ClearDisplay();
            aCalculator.setNumber("901");
            aCalculator.SetDisplay(aCalculator.getNumber().ToString());
            Assert.AreEqual("901", aCalculator.GetDisplay(aCalculator).ToString());
            Assert.AreEqual("901", aCalculator.GetDisplay(aCalculator).ToString());
            Assert.AreEqual("901", aCalculator.GetDisplay(aCalculator).ToString());
            aCalculator.setNumber("5");
            aCalculator.ClearDisplay();
            aCalculator.SetDisplay(aCalculator.getNumber().ToString());
            Assert.AreEqual("5", aCalculator.GetDisplay(aCalculator).ToString());
            Assert.AreEqual("5", aCalculator.GetDisplay(aCalculator).ToString());
            Assert.AreEqual("5", aCalculator.GetDisplay(aCalculator).ToString());
            aCalculator.setNumber("10");
            aCalculator.ClearDisplay();
            aCalculator.SetDisplay(aCalculator.getNumber().ToString());
            Assert.AreEqual("10", aCalculator.GetDisplay(aCalculator).ToString());
            Assert.AreEqual("10", aCalculator.GetDisplay(aCalculator).ToString());
            Assert.AreEqual("10", aCalculator.GetDisplay(aCalculator).ToString());
        }
    }
}
