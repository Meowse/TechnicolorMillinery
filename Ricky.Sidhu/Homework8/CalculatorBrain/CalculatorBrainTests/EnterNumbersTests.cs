using CalculatorBrain;
using NUnit.Framework;

namespace CalculatorBrainTests
{
    [TestFixture]
    class EnterNumbersTests
    {
        [Test]
        public void ShouldDisplaySingleDigit()
        {
            var calculator = new Calculator();
            calculator.ProvideInput('1');
            Assert.AreEqual("1", calculator.GetDisplay());
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
        public void ShouldAcceptDecimaltNumbers()
        {
            var calculator = new Calculator();
            calculator.ProvideInput('3');
            Assert.AreEqual("3", calculator.GetDisplay());
            calculator.ProvideInput('1');
            Assert.AreEqual("31", calculator.GetDisplay());
            calculator.ProvideInput('.');
            Assert.AreEqual("31", calculator.GetDisplay());
            calculator.ProvideInput('7');
            Assert.AreEqual("31.7", calculator.GetDisplay());
        }
        [Test]
        public void ShouldIgnoreLeadingZeroes()
        {
            var calculator = new Calculator();
            calculator.ProvideInput('0');
            Assert.AreEqual("0", calculator.GetDisplay());
            calculator.ProvideInput('0');
            Assert.AreEqual("0", calculator.GetDisplay());
            calculator.ProvideInput('3');
            Assert.AreEqual("3", calculator.GetDisplay());
            calculator.ProvideInput('0');
            Assert.AreEqual("30", calculator.GetDisplay());
        }
        [Test]
        public void ShouldIgnoreDecimalPointsAfterTheFirst()
        {
            var calculator = new Calculator();
            calculator.ProvideInput('3');
            Assert.AreEqual("3", calculator.GetDisplay());
            calculator.ProvideInput('.');
            Assert.AreEqual("3", calculator.GetDisplay());
            calculator.ProvideInput('1');
            Assert.AreEqual("3.1", calculator.GetDisplay());
            calculator.ProvideInput('.');
            Assert.AreEqual("3.1", calculator.GetDisplay());
            calculator.ProvideInput('7');
            Assert.AreEqual("3.17", calculator.GetDisplay());
        }
      }
}
