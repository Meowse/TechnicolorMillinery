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
        public var Calculator = new Calculator();
        [Test]
        public void ShouldDisplayZeroByDefault()
        {
            Assert.AreEqual("0", Calculator.GetDisplay());
        }

        [Test]
        public void ShouldDisplayZeroAfterClear()
        {
            Calculator.ProvideInput('1');
            Calculator.ProvideInput('+');
            Calculator.ProvideInput('c');
            Assert.AreEqual("0", Calculator.GetDisplay());
        }

        [Test]
        public void ShouldDisplaySingleDigit()
        {
            Calculator.ProvideInput('1');
            Assert.AreEqual("1", Calculator.GetDisplay());
        }

        [Test] public void ShouldAddSmallSingleDigits()
        {
            
            Calculator.ProvideInput('1');
            Assert.AreEqual("1", Calculator.GetDisplay());
            Calculator.ProvideInput('+');
            Assert.AreEqual("1", Calculator.GetDisplay());
            Calculator.ProvideInput('2');
            Assert.AreEqual("2", Calculator.GetDisplay());
            Calculator.ProvideInput('=');
            Assert.AreEqual("3", Calculator.GetDisplay());
        }

        [Test]
        public void ShouldAddLargeSingleDigitsIntoDoubleDigits()
        {
            Calculator.ProvideInput('9');
            Calculator.ProvideInput('+');
            Calculator.ProvideInput('8');
            Calculator.ProvideInput('=');
            Assert.AreEqual("17", Calculator.GetDisplay());
        }

        [Test]
        public void ShouldAcceptMultiDigitNumbers()
        {
            Calculator.ProvideInput('3');
            Assert.AreEqual("3", Calculator.GetDisplay());
            Calculator.ProvideInput('1');
            Assert.AreEqual("31", Calculator.GetDisplay());
        }

        [Test]
        public void CanSubtractSingleDigitNumbers()
        {
            Calculator.ProvideInput('7');
            Assert.AreEqual("7", Calculator.GetDisplay());
            Calculator.ProvideInput('-');
            Assert.AreEqual("7", Calculator.GetDisplay());
            Calculator.ProvideInput('2');
            Assert.AreEqual("2", Calculator.GetDisplay());
            Calculator.ProvideInput('=');
            Assert.AreEqual("5", Calculator.GetDisplay());
        }

        [Test]
        public void CanSubtractMultiDigitNumbers()
        {
            Calculator.ProvideInput('7');
            Assert.AreEqual("7", Calculator.GetDisplay());
            Calculator.ProvideInput('1');
            Assert.AreEqual("71", Calculator.GetDisplay());
            Calculator.ProvideInput('-');
            Assert.AreEqual("71", Calculator.GetDisplay());
            Calculator.ProvideInput('2');
            Assert.AreEqual("2", Calculator.GetDisplay());
            Calculator.ProvideInput('=');
            Assert.AreEqual("69", Calculator.GetDisplay());
        }

        [Test]
        public void ShouldNotChangeJustBecauseGetDisplayIsCalled()
        {
            Calculator.ProvideInput('1');
            Assert.AreEqual("1", Calculator.GetDisplay());
            Calculator.ProvideInput('+');
            Assert.AreEqual("1", Calculator.GetDisplay());
            Assert.AreEqual("1", Calculator.GetDisplay());
            Assert.AreEqual("1", Calculator.GetDisplay());
            Calculator.ProvideInput('2');
            Assert.AreEqual("2", Calculator.GetDisplay());
            Assert.AreEqual("2", Calculator.GetDisplay());
            Assert.AreEqual("2", Calculator.GetDisplay());
            Calculator.ProvideInput('=');
            Assert.AreEqual("3", Calculator.GetDisplay());
            Assert.AreEqual("3", Calculator.GetDisplay());
            Assert.AreEqual("3", Calculator.GetDisplay());                    
        }
    }
}
