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
            calculator.ProcessInput('1');
            calculator.ProcessInput('+');
            calculator.ProcessInput('c');
            Assert.AreEqual("0", calculator.GetDisplay());
        }

        // numbers tests
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
        public void ShouldIgnoreLeadingZeroes()
        {
            var calculator = new Calculator();
            calculator.ProcessInput('0');
            Assert.AreEqual("0", calculator.GetDisplay());
            calculator.ProcessInput('0');
            Assert.AreEqual("0", calculator.GetDisplay());
            calculator.ProcessInput('3');
            Assert.AreEqual("3", calculator.GetDisplay());
            calculator.ProcessInput('0');
            Assert.AreEqual("30", calculator.GetDisplay());
        }

        [Test]
        public void ShouldAcceptDecimalNumbers()
        {
            var calculator = new Calculator();
            calculator.ProcessInput('3');
            Assert.AreEqual("3", calculator.GetDisplay());
            calculator.ProcessInput('1');
            Assert.AreEqual("31", calculator.GetDisplay());
            calculator.ProcessInput('.');
            Assert.AreEqual("31.", calculator.GetDisplay());  
            calculator.ProcessInput('7');
            Assert.AreEqual("31.7", calculator.GetDisplay());
        }

        [Test]
        public void ShouldIgnoreDecimalPointsAfterTheFirst()
        {
            var calculator = new Calculator();
            calculator.ProcessInput('3');
            Assert.AreEqual("3", calculator.GetDisplay());
            calculator.ProcessInput('.');
            Assert.AreEqual("3.", calculator.GetDisplay());   // need to put the decimal in now 
            calculator.ProcessInput('1');
            Assert.AreEqual("3.1", calculator.GetDisplay());
            calculator.ProcessInput('.');
            Assert.AreEqual("3.1", calculator.GetDisplay());
            calculator.ProcessInput('7');
            Assert.AreEqual("3.17", calculator.GetDisplay());
        }




        // addition tests
        [Test]
        public void ShouldAddSmallSingleDigits()
        {
            var calculator = new Calculator();
            calculator.ProcessInput('1');
            Assert.AreEqual("1", calculator.GetDisplay());
            calculator.ProcessInput('+');
            Assert.AreEqual("1", calculator.GetDisplay());
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

        // Subtraction Tests
        [Test]
        public void CanSubtractSingleDigitNumbers()
        {
            var calculator = new Calculator();
            calculator.ProcessInput('7');
            Assert.AreEqual("7", calculator.GetDisplay());
            calculator.ProcessInput('-');
            Assert.AreEqual("7", calculator.GetDisplay());
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
            Assert.AreEqual("71", calculator.GetDisplay());
            calculator.ProcessInput('2');
            Assert.AreEqual("2", calculator.GetDisplay());
            calculator.ProcessInput('=');
            Assert.AreEqual("69", calculator.GetDisplay());
        }

        [Test]
        public void ShouldClearEverything()
        {
            var calculator = new Calculator();
            calculator.ProcessInput('1');
            Assert.AreEqual("1", calculator.GetDisplay());
            calculator.ProcessInput('+');
            Assert.AreEqual("1", calculator.GetDisplay());
            calculator.ProcessInput('2');
            Assert.AreEqual("2", calculator.GetDisplay());
            calculator.ProcessInput('=');
            Assert.AreEqual("3", calculator.GetDisplay());
            calculator.ProcessInput('c');
            Assert.AreEqual("0", calculator.GetDisplay());
            calculator.ProcessInput('1');
            Assert.AreEqual("1", calculator.GetDisplay());
            calculator.ProcessInput('+');
            Assert.AreEqual("1", calculator.GetDisplay());
            calculator.ProcessInput('2');
            Assert.AreEqual("2", calculator.GetDisplay());
            calculator.ProcessInput('=');
            Assert.AreEqual("3", calculator.GetDisplay());
        }

        [Test]
        public void ShouldDoMultipleSequentialCalculations()
        {
            var calculator = new Calculator();
            calculator.ProcessInput('1');
            Assert.AreEqual("1", calculator.GetDisplay());
            calculator.ProcessInput('+');
            Assert.AreEqual("1", calculator.GetDisplay());
            calculator.ProcessInput('2');
            Assert.AreEqual("2", calculator.GetDisplay());
            calculator.ProcessInput('=');
            Assert.AreEqual("3", calculator.GetDisplay());
            calculator.ProcessInput('4');
            Assert.AreEqual("4", calculator.GetDisplay());
            calculator.ProcessInput('+');
            Assert.AreEqual("4", calculator.GetDisplay());
            calculator.ProcessInput('5');
            Assert.AreEqual("5", calculator.GetDisplay());
            calculator.ProcessInput('=');
            Assert.AreEqual("9", calculator.GetDisplay());
        }

        [Test]
        public void ShouldDoMultipleSequentialCalculationsBetter()
        {
            AssertCalculatorInteraction(new object[]
            {
                // First operation
                '1', "1",
                '+', "1",
                '2', "2",
                '=', "3",
                // Second operation
                '4', "4",
                '+', "4",
                '5', "5",
                '=', "9",
            });
        }

        private void AssertCalculatorInteraction(object[] testSpecification)
        {
            throw new System.NotImplementedException();
        }
    }
}
