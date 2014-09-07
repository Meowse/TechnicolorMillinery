using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorBrain;
using NUnit.Framework;

namespace CalculatorBrainTests
{
    [TestFixture]
    class DecimalTests
    {
        [Test]
        public void ShouldDisplayDecimalPoint()
        {
            var calculator = new Calculator();
            calculator.ProvideInput('1');
            Assert.AreEqual("1", calculator.GetDisplay());
            calculator.ProvideInput('.');
            Assert.AreEqual("1.", calculator.GetDisplay());
        }

        [Test]
        public void ShouldIgnoreDecimalPointsAfterTheFirst()
        {
            var calculator = new Calculator();
            calculator.ProvideInput('1');
            calculator.ProvideInput('.');
            calculator.ProvideInput('.');
            Assert.AreEqual("1.", calculator.GetDisplay());
        }

        [Test]
        public void ShouldAcceptDecimalPointsAfterEquals()
        {
            var calculator = new Calculator();
            calculator.ProvideInput('1');
            Assert.AreEqual("1", calculator.GetDisplay());
            calculator.ProvideInput('+');
            Assert.AreEqual("1", calculator.GetDisplay());
            calculator.ProvideInput('.');
            Assert.AreEqual("0.", calculator.GetDisplay());
            calculator.ProvideInput('2');
            Assert.AreEqual("0.2", calculator.GetDisplay());
            calculator.ProvideInput('=');
            Assert.AreEqual("1.2", calculator.GetDisplay());
        }
    }
}
