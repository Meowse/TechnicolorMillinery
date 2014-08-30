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
            calculator.ProcessInput('7');
            Assert.AreEqual("7", calculator.GetDisplay());
            calculator.ProcessInput('-');
            Assert.AreEqual("-", calculator.GetDisplay());
            calculator.ProcessInput('2');
            Assert.AreEqual("2", calculator.GetDisplay());
            calculator.ProcessInput('=');
            Assert.AreEqual("5", calculator.GetDisplay());
        }

        [Test]
        public void CanSubtractMultiDigitNumbers()
        {
            var calculator = new Calculator();
            calculator.ProcessInput('7');
            Assert.AreEqual("7", calculator.GetDisplay());
            calculator.ProcessInput('1');
            Assert.AreEqual("71", calculator.GetDisplay());
            calculator.ProcessInput('-');
            Assert.AreEqual("-", calculator.GetDisplay());
            calculator.ProcessInput('2');
            Assert.AreEqual("2", calculator.GetDisplay());
            calculator.ProcessInput('=');
            Assert.AreEqual("69", calculator.GetDisplay());
        }
        [Test]
        public void ShouldAddSmallSingleDigits()
        {
            var calculator = new Calculator();
            calculator.ProcessInput('1');
            Assert.AreEqual("1", calculator.GetDisplay());
            calculator.ProcessInput('+');
            Assert.AreEqual("+", calculator.GetDisplay());
            calculator.ProcessInput('2');
            Assert.AreEqual("2", calculator.GetDisplay());
            calculator.ProcessInput('=');
            Assert.AreEqual("3", calculator.GetDisplay());
        }

        [Test]
        public void ShouldAddLargeSingleDigitsIntoDoubleDigits()
        {
            var calculator = new Calculator();
            calculator.ProcessInput('9');
            calculator.ProcessInput('+');
            calculator.ProcessInput('8');
            calculator.ProcessInput('=');
            Assert.AreEqual("17", calculator.GetDisplay());
        }
    }
}
