using CalculatorBrain;
using NUnit.Framework;

namespace CalculatorBrainTests
{
    [TestFixture]
    class DefaultBehaviorsTests
    {
        [Test]
        public void ShouldDisplayZeroByDefault()
        {
            var calculator = new Calculator();
            Assert.AreEqual("0", calculator.GetDisplay());
        }

        [Test]
        public void ShouldDisplayZeroAfterClear()
        {
            var calculator = new Calculator();
            calculator.ProvideInput('1');
            calculator.ProvideInput('+');
            calculator.ProvideInput('c');
            Assert.AreEqual("0", calculator.GetDisplay());
        }

    }
}
