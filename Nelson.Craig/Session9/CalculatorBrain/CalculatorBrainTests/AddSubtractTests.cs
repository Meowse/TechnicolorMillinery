using NUnit.Framework;
using CalculatorBrain;

namespace CalculatorBrainTests
{
    [TestFixture]
    public class AddSubtractTests
    {
        [Test]
        public void CanSubtractSingleDigitNumbers()
        {
            var calculator = new Calculator();
            calculator.ProvideInput('7');
            Assert.AreEqual("7", calculator.GetDisplay());
            calculator.ProvideInput('-');
            Assert.AreEqual("-", calculator.GetDisplay());
            calculator.ProvideInput('2');
            Assert.AreEqual("2", calculator.GetDisplay());
            calculator.ProvideInput('=');
            Assert.AreEqual("5", calculator.GetDisplay());
        }

        [Test]
        public void CanSubtractMultiDigitNumbers()
        {
            var calculator = new Calculator();
            calculator.ProvideInput('7');
            Assert.AreEqual("7", calculator.GetDisplay());
            calculator.ProvideInput('1');
            Assert.AreEqual("71", calculator.GetDisplay());
            calculator.ProvideInput('-');
            Assert.AreEqual("-", calculator.GetDisplay());
            calculator.ProvideInput('2');
            Assert.AreEqual("2", calculator.GetDisplay());
            calculator.ProvideInput('=');
            Assert.AreEqual("69", calculator.GetDisplay());
        }
        [Test]
        public void ShouldAddSmallSingleDigits()
        {
            var calculator = new Calculator();
            calculator.ProvideInput('1');
            Assert.AreEqual("1", calculator.GetDisplay());
            calculator.ProvideInput('+');
            Assert.AreEqual("+", calculator.GetDisplay());
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
    }
}
