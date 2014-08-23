using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculatorBrainGuts;
using NUnit.Framework;

namespace CalculatorBrainTests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void ShouldDisplayZeroByDefault()
        {
            var calculator = new CalculatorBrainGuts.CalculatorBrain();
            Assert.AreEqual("0", calculator.GetDisplay());
        }

        [Test]
        public void ShouldDisplayZeroAfterClear()
        {
            var calculator = new CalculatorBrainGuts.CalculatorBrain();
            calculator.ProvideInput('1');
            calculator.ProvideInput('+');
            calculator.ProvideInput('c');
            Assert.AreEqual("0", calculator.GetDisplay());
        }

        [Test]
        public void ShouldDisplaySingleDigit()
        {
            var calculator = new CalculatorBrainGuts.CalculatorBrain();
            calculator.ProvideInput('1');
            Assert.AreEqual("1", calculator.GetDisplay());
        }

        [Test]
        public void ShouldAddSmallSingleDigits()
        {
            var calculator = new CalculatorBrainGuts.CalculatorBrain();
            calculator.ProvideInput('1');
            Assert.AreEqual("1", calculator.GetDisplay());

            calculator.ProvideInput('+');
            Assert.AreEqual("+", calculator.GetDisplay());

            calculator.ProvideInput('2');
            Assert.AreEqual("2", calculator.GetDisplay());

            calculator.ProvideInput('=');
            Assert.AreEqual("=", calculator.GetDisplay());

            calculator.ProvideInput('3');
            Assert.AreEqual("3", calculator.GetDisplay());
        }

        [Test]
        public void ShouldAddLargeSingleDigitsIntoDoubleDigits()
        {
            var calculator = new CalculatorBrainGuts.CalculatorBrain();
            calculator.ProvideInput('9');
            calculator.ProvideInput('+');
            calculator.ProvideInput('8');
            calculator.ProvideInput('=');
            Assert.AreEqual("17", calculator.GetDisplay());
        }

        [Test]
        public void ShouldAcceptMultiDigitNumbers()
        {
            var calculator = new CalculatorBrainGuts.CalculatorBrain();
            calculator.ProvideInput('3');
            Assert.AreEqual("3", calculator.GetDisplay());

            calculator.ProvideInput('1');
            Assert.AreEqual("31", calculator.GetDisplay());
        }

        [Test]
        public void CanSubtractSingleDigitNumbers()
        {
            var calculator = new CalculatorBrainGuts.CalculatorBrain();
            calculator.ProvideInput('7');
            Assert.AreEqual("7", calculator.GetDisplay());

            calculator.ProvideInput('-');
            Assert.AreEqual("7", calculator.GetDisplay());

            calculator.ProvideInput('2');
            Assert.AreEqual("2", calculator.GetDisplay());

            calculator.ProvideInput('=');
            Assert.AreEqual("5", calculator.GetDisplay());
        }

        [Test]
        public void CanSubtractMultiDigitNumbers()
        {
            var calculator = new CalculatorBrainGuts.CalculatorBrain();
            calculator.ProvideInput('7');
            Assert.AreEqual("7", calculator.GetDisplay());

            calculator.ProvideInput('1');
            Assert.AreEqual("71", calculator.GetDisplay());

            calculator.ProvideInput('-');
            Assert.AreEqual("71", calculator.GetDisplay());

            calculator.ProvideInput('2');
            Assert.AreEqual("2", calculator.GetDisplay());

            calculator.ProvideInput('=');
            Assert.AreEqual("69", calculator.GetDisplay());
        }

        [Test]
        public void ShouldNotChangeJustBecauseGetDisplayIsCalled()
        {
            var calculator = new CalculatorBrainGuts.CalculatorBrain();
            calculator.ProvideInput('1');
            Assert.AreEqual("1", calculator.GetDisplay());

            calculator.ProvideInput('+');
            Assert.AreEqual("1", calculator.GetDisplay());
            Assert.AreEqual("1", calculator.GetDisplay());
            Assert.AreEqual("1", calculator.GetDisplay());

            calculator.ProvideInput('2');
            Assert.AreEqual("2", calculator.GetDisplay());
            Assert.AreEqual("2", calculator.GetDisplay());
            Assert.AreEqual("2", calculator.GetDisplay());

            calculator.ProvideInput('=');
            Assert.AreEqual("3", calculator.GetDisplay());
            Assert.AreEqual("3", calculator.GetDisplay());
            Assert.AreEqual("3", calculator.GetDisplay());
        }
    }
}
