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
            var _calculator = new Calculator();
            Assert.AreEqual("0", _calculator.GetDisplay());
        }

        [Test]
        public void ShouldDisplayZeroAfterClear()
        {
            var _calculator = new Calculator();
            _calculator.ProvideInput('1');
            _calculator.ProvideInput('+');
            _calculator.ProvideInput('c');
            Assert.AreEqual("0", _calculator.GetDisplay());
        }

        [Test]
        public void ShouldDisplaySingleDigit()
        {
            var _calculator = new Calculator();
            _calculator.ProvideInput('1');
            Assert.AreEqual("1", _calculator.GetDisplay());
        }

        [Test] public void ShouldAddSmallSingleDigits()
        {
            var _calculator = new Calculator();
            _calculator.ProvideInput('1');
            Assert.AreEqual("1", _calculator.GetDisplay());
            _calculator.ProvideInput('+');
            Assert.AreEqual("1", _calculator.GetDisplay());
            _calculator.ProvideInput('2');
            Assert.AreEqual("2", _calculator.GetDisplay());
            _calculator.ProvideInput('=');
            Assert.AreEqual("3", _calculator.GetDisplay());
        }

        [Test]
        public void ShouldAddLargeSingleDigitsIntoDoubleDigits()
        {
            var _calculator = new Calculator();
            _calculator.ProvideInput('9');
            _calculator.ProvideInput('+');
            _calculator.ProvideInput('8');
            _calculator.ProvideInput('=');
            Assert.AreEqual("17", _calculator.GetDisplay());
        }

        [Test]
        public void ShouldAcceptMultiDigitNumbers()
        {
            var _calculator = new Calculator();
            _calculator.ProvideInput('3');
            Assert.AreEqual("3", _calculator.GetDisplay());
            _calculator.ProvideInput('1');
            Assert.AreEqual("31", _calculator.GetDisplay());
        }

        [Test]
        public void CanSubtractSingleDigitNumbers()
        {
            var _calculator = new Calculator();
            _calculator.ProvideInput('7');
            Assert.AreEqual("7", _calculator.GetDisplay());
            _calculator.ProvideInput('-');
            Assert.AreEqual("7", _calculator.GetDisplay());
            _calculator.ProvideInput('2');
            Assert.AreEqual("2", _calculator.GetDisplay());
            _calculator.ProvideInput('=');
            Assert.AreEqual("5", _calculator.GetDisplay());
        }

        [Test]
        public void CanSubtractMultiDigitNumbers()
        {
            var _calculator = new Calculator();
            _calculator.ProvideInput('7');
            Assert.AreEqual("7", _calculator.GetDisplay());
            _calculator.ProvideInput('1');
            Assert.AreEqual("71", _calculator.GetDisplay());
            _calculator.ProvideInput('-');
            Assert.AreEqual("71", _calculator.GetDisplay());
            _calculator.ProvideInput('2');
            Assert.AreEqual("2", _calculator.GetDisplay());
            _calculator.ProvideInput('=');
            Assert.AreEqual("69", _calculator.GetDisplay());
        }

        [Test]
        public void ShouldNotChangeJustBecauseGetDisplayIsCalled()
        {
            var _calculator = new Calculator();
            _calculator.ProvideInput('1');
            Assert.AreEqual("1", _calculator.GetDisplay());
            _calculator.ProvideInput('+');
            Assert.AreEqual("1", _calculator.GetDisplay());
            Assert.AreEqual("1", _calculator.GetDisplay());
            Assert.AreEqual("1", _calculator.GetDisplay());
            _calculator.ProvideInput('2');
            Assert.AreEqual("2", _calculator.GetDisplay());
            Assert.AreEqual("2", _calculator.GetDisplay());
            Assert.AreEqual("2", _calculator.GetDisplay());
            _calculator.ProvideInput('=');
            Assert.AreEqual("3", _calculator.GetDisplay());
            Assert.AreEqual("3", _calculator.GetDisplay());
            Assert.AreEqual("3", _calculator.GetDisplay());                    
        }
    }
}
