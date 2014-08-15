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
        public Calculator Calculator = new Calculator();
        [Test]
        public void ShouldDisplayZeroByDefault()
        {
            Assert.AreEqual("0", CalculatorBrain.Calculator.GetDisplay());
        }

        [Test]
        public void ShouldDisplayZeroAfterClear()
        {
            CalculatorBrain.Calculator.ProvideInput('1');
            CalculatorBrain.Calculator.ProvideInput('+');
            CalculatorBrain.Calculator.ProvideInput('c');
            Assert.AreEqual("0", CalculatorBrain.Calculator.GetDisplay());
        }

        [Test]
        public void ShouldDisplaySingleDigit()
        {
            CalculatorBrain.Calculator.ProvideInput('1');
            Assert.AreEqual("1", CalculatorBrain.Calculator.GetDisplay());
        }

        [Test] public void ShouldAddSmallSingleDigits()
        {
            
            CalculatorBrain.Calculator.ProvideInput('1');
            Assert.AreEqual("1", CalculatorBrain.Calculator.GetDisplay());
            CalculatorBrain.Calculator.ProvideInput('+');
            Assert.AreEqual("1", CalculatorBrain.Calculator.GetDisplay());
            CalculatorBrain.Calculator.ProvideInput('2');
            Assert.AreEqual("2", CalculatorBrain.Calculator.GetDisplay());
            CalculatorBrain.Calculator.ProvideInput('=');
            Assert.AreEqual("3", CalculatorBrain.Calculator.GetDisplay());
        }

        [Test]
        public void ShouldAddLargeSingleDigitsIntoDoubleDigits()
        {
            CalculatorBrain.Calculator.ProvideInput('9');
            CalculatorBrain.Calculator.ProvideInput('+');
            CalculatorBrain.Calculator.ProvideInput('8');
            CalculatorBrain.Calculator.ProvideInput('=');
            Assert.AreEqual("17", CalculatorBrain.Calculator.GetDisplay());
        }

        [Test]
        public void ShouldAcceptMultiDigitNumbers()
        {
            CalculatorBrain.Calculator.ProvideInput('3');
            Assert.AreEqual("3", CalculatorBrain.Calculator.GetDisplay());
            CalculatorBrain.Calculator.ProvideInput('1');
            Assert.AreEqual("31", CalculatorBrain.Calculator.GetDisplay());
        }

        [Test]
        public void CanSubtractSingleDigitNumbers()
        {
            CalculatorBrain.Calculator.ProvideInput('7');
            Assert.AreEqual("7", CalculatorBrain.Calculator.GetDisplay());
            CalculatorBrain.Calculator.ProvideInput('-');
            Assert.AreEqual("7", CalculatorBrain.Calculator.GetDisplay());
            CalculatorBrain.Calculator.ProvideInput('2');
            Assert.AreEqual("2", CalculatorBrain.Calculator.GetDisplay());
            CalculatorBrain.Calculator.ProvideInput('=');
            Assert.AreEqual("5", CalculatorBrain.Calculator.GetDisplay());
        }

        [Test]
        public void CanSubtractMultiDigitNumbers()
        {
            CalculatorBrain.Calculator.ProvideInput('7');
            Assert.AreEqual("7", CalculatorBrain.Calculator.GetDisplay());
            CalculatorBrain.Calculator.ProvideInput('1');
            Assert.AreEqual("71", CalculatorBrain.Calculator.GetDisplay());
            CalculatorBrain.Calculator.ProvideInput('-');
            Assert.AreEqual("71", CalculatorBrain.Calculator.GetDisplay());
            CalculatorBrain.Calculator.ProvideInput('2');
            Assert.AreEqual("2", CalculatorBrain.Calculator.GetDisplay());
            CalculatorBrain.Calculator.ProvideInput('=');
            Assert.AreEqual("69", CalculatorBrain.Calculator.GetDisplay());
        }

        [Test]
        public void ShouldNotChangeJustBecauseGetDisplayIsCalled()
        {
            CalculatorBrain.Calculator.ProvideInput('1');
            Assert.AreEqual("1", CalculatorBrain.Calculator.GetDisplay());
            CalculatorBrain.Calculator.ProvideInput('+');
            Assert.AreEqual("1", CalculatorBrain.Calculator.GetDisplay());
            Assert.AreEqual("1", CalculatorBrain.Calculator.GetDisplay());
            Assert.AreEqual("1", CalculatorBrain.Calculator.GetDisplay());
            CalculatorBrain.Calculator.ProvideInput('2');
            Assert.AreEqual("2", CalculatorBrain.Calculator.GetDisplay());
            Assert.AreEqual("2", CalculatorBrain.Calculator.GetDisplay());
            Assert.AreEqual("2", CalculatorBrain.Calculator.GetDisplay());
            CalculatorBrain.Calculator.ProvideInput('=');
            Assert.AreEqual("3", CalculatorBrain.Calculator.GetDisplay());
            Assert.AreEqual("3", CalculatorBrain.Calculator.GetDisplay());
            Assert.AreEqual("3", CalculatorBrain.Calculator.GetDisplay());                    
        }
    }
}
