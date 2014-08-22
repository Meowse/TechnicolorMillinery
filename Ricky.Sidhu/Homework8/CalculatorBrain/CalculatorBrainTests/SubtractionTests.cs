using CalculatorBrain;
using NUnit.Framework;

namespace CalculatorBrainTests
{
    [TestFixture]
    public class SubtractionTests
    {
        [Test]
        public void CanSubtractSingleDigitNumbers()
        {
            var calculator = new Calculator();
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
            var calculator = new Calculator();
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

      }
}
