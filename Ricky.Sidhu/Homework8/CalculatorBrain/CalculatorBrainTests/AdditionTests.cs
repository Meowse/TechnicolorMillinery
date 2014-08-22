using CalculatorBrain;
using NUnit.Framework;

namespace CalculatorBrainTests
{
    [TestFixture]
    class AdditionTests
    {
        [Test]
        public void ShouldAddSmallSingleDigits()
        {
            var calculator = new Calculator();
            calculator.ProvideInput('1');
            Assert.AreEqual("1", calculator.GetDisplay());
            calculator.ProvideInput('+');
            Assert.AreEqual("1", calculator.GetDisplay());
            calculator.ProvideInput('2');
            Assert.AreEqual("2", calculator.GetDisplay());
            calculator.ProvideInput('=');
            Assert.AreEqual("3", calculator.GetDisplay());
        }
        
        [Test]
        public void ShouldAddLargeSingleDigitsIntoDoubleDigits()
        {
            var calculator = new Calculator();
            calculator.ProvideInput('9');
            calculator.ProvideInput('+');
            calculator.ProvideInput('8');
            calculator.ProvideInput('=');
            Assert.AreEqual("17", calculator.GetDisplay());
        }
       
        [Test]
        public void ShouldAcceptMultiDigitNumbers()
        {
            var calculator = new Calculator();
            calculator.ProvideInput('3');
            Assert.AreEqual("3", calculator.GetDisplay());
            calculator.ProvideInput('1');
            Assert.AreEqual("31", calculator.GetDisplay());
        }
        [Test]
        public void ShouldNotChangeJustBecauseGetDisplayIsCalled()
        {
            var calculator = new Calculator();
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
