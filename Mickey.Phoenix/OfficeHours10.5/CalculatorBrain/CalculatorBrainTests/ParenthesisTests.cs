using CalculatorBrain;
using NUnit.Framework;

namespace CalculatorBrainTests
{
    [TestFixture]
    class ParenthesisTests
    {
        [Test]
        public void ShouldDoCalculationsInsideParenthesesFirst()
        {
            var calculator = new Calculator();
            calculator.ProvideInput('2');
            Assert.AreEqual("2", calculator.GetDisplay());
            calculator.ProvideInput('*');
            Assert.AreEqual("2", calculator.GetDisplay());
            calculator.ProvideInput('(');
            Assert.AreEqual("0", calculator.GetDisplay());
            calculator.ProvideInput('3');
            Assert.AreEqual("3", calculator.GetDisplay());
            calculator.ProvideInput('+');
            Assert.AreEqual("3", calculator.GetDisplay());
            calculator.ProvideInput('4');
            Assert.AreEqual("4", calculator.GetDisplay());
            calculator.ProvideInput(')');
            Assert.AreEqual("7", calculator.GetDisplay());
            calculator.ProvideInput('=');
            Assert.AreEqual("14", calculator.GetDisplay());
        }

        [Test]
        public void ShouldHandleNestedParentheses()
        {
            var calculator = new Calculator();
            calculator.ProvideInput('2');
            calculator.ProvideInput('*');
            calculator.ProvideInput('(');
            calculator.ProvideInput('(');
            calculator.ProvideInput('1');
            calculator.ProvideInput('+');
            calculator.ProvideInput('3');
            calculator.ProvideInput(')');
            calculator.ProvideInput('*');
            calculator.ProvideInput('5');
            calculator.ProvideInput(')');
            calculator.ProvideInput('=');
            Assert.AreEqual("40", calculator.GetDisplay());
        }
    }
}
