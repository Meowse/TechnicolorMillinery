using CalculatorBrain;
using NUnit.Framework;

namespace CalculatorBrainTests
{
    [TestFixture]
    public class SimpleTests
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
            calculator.ProcessInput('1');
            calculator.ProcessInput('+');
            calculator.ProcessInput('c');
            Assert.AreEqual("0", calculator.GetDisplay());
        }

        [Test]
        public void ShouldDisplaySingleDigit()
        {
            var calculator = new Calculator();
            calculator.ProcessInput('1');
            Assert.AreEqual("1", calculator.GetDisplay());
        }

       

        [Test]
        public void ShouldAcceptMultiDigitNumbers()
        {
            var calculator = new Calculator();
            calculator.ProcessInput('3');
            Assert.AreEqual("3", calculator.GetDisplay());
            calculator.ProcessInput('1');
            Assert.AreEqual("31", calculator.GetDisplay());
        }

       
        [Test]
        public void ShouldNotChangeJustBecauseGetDisplayIsCalled()
        {
            var calculator = new Calculator();
            calculator.ProcessInput('1');
            Assert.AreEqual("1", calculator.GetDisplay());
            calculator.ProcessInput('+');
            Assert.AreEqual("1", calculator.GetDisplay());
            Assert.AreEqual("1", calculator.GetDisplay());
            Assert.AreEqual("1", calculator.GetDisplay());
            calculator.ProcessInput('2');
            Assert.AreEqual("2", calculator.GetDisplay());
            Assert.AreEqual("2", calculator.GetDisplay());
            Assert.AreEqual("2", calculator.GetDisplay());
            calculator.ProcessInput('=');
            Assert.AreEqual("3", calculator.GetDisplay());
            Assert.AreEqual("3", calculator.GetDisplay());
            Assert.AreEqual("3", calculator.GetDisplay());                    
        }
    }
}
