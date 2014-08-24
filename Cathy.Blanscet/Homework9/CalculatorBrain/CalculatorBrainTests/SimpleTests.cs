using CalculatorBrain;
using NUnit.Framework;

namespace CalculatorBrainTests
{
    [TestFixture]
    public class SimpleTests
    {
        // default number tests
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

        // numbers tests
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
        public void ShouldAcceptDecimalNumbers()
        {
            var calculator = new Calculator();
            calculator.ProvideInput('3');
            Assert.AreEqual("3", calculator.GetDisplay());
            calculator.ProvideInput('1');
            Assert.AreEqual("31", calculator.GetDisplay());
            calculator.ProvideInput('.');
            Assert.AreEqual("31.", calculator.GetDisplay());  
            calculator.ProvideInput('7');
            Assert.AreEqual("31.7", calculator.GetDisplay());
        }

        [Test]
        public void ShouldIgnoreDecimalPointsAfterTheFirst()
        {
            var calculator = new Calculator();
            calculator.ProvideInput('3');
            Assert.AreEqual("3", calculator.GetDisplay());
            calculator.ProvideInput('.');
            Assert.AreEqual("3.", calculator.GetDisplay());   // need to put the decimal in now 
            calculator.ProvideInput('1');
            Assert.AreEqual("3.1", calculator.GetDisplay());
            calculator.ProvideInput('.');
            Assert.AreEqual("3.1", calculator.GetDisplay());
            calculator.ProvideInput('7');
            Assert.AreEqual("3.17", calculator.GetDisplay());
        }




        // addition tests
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

        // Subtraction Tests
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

        [Test]
        public void ShouldDoMultipleSequentialCalculations()
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
            calculator.ProvideInput('4');
            Assert.AreEqual("4", calculator.GetDisplay());
            calculator.ProvideInput('+');
            Assert.AreEqual("4", calculator.GetDisplay());
            calculator.ProvideInput('5');
            Assert.AreEqual("5", calculator.GetDisplay());
            calculator.ProvideInput('=');
            Assert.AreEqual("9", calculator.GetDisplay());
        }

        [Test]
        public void ShouldDoMultipleCalculations()
        {
            var calculator = new Calculator();
            calculator.ProvideInput('1');
            Assert.AreEqual("1", calculator.GetDisplay());
            calculator.ProvideInput('+');
            Assert.AreEqual("1", calculator.GetDisplay());
            calculator.ProvideInput('1');
            Assert.AreEqual("1", calculator.GetDisplay());
            calculator.ProvideInput('+');
            Assert.AreEqual("2", calculator.GetDisplay());
            calculator.ProvideInput('1');
            Assert.AreEqual("1", calculator.GetDisplay());
            calculator.ProvideInput('*');
            Assert.AreEqual("3", calculator.GetDisplay());
            calculator.ProvideInput('3');
            Assert.AreEqual("3", calculator.GetDisplay());
            calculator.ProvideInput('=');
            Assert.AreEqual("9", calculator.GetDisplay());
        }
    }
}
