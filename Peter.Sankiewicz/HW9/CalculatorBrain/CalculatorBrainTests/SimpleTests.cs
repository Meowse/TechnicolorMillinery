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


        [Test]
        public void ShouldIgnoreDecimalPointsAfterTheFirstBetter()
        {
            AssertCalculatorInteraction(new object[]
            {
                // First operation
                '3', "3",
                '.', "3.",
                '1', "3.1",
                '.', "3.1",
                '7', "3.17"
            });
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
        public void NotGettingAwayWithAnything()
        {
            var calculator = new Calculator();
            calculator.ProcessInput('1');
            Assert.AreEqual("1", calculator.GetDisplay());
            calculator.ProcessInput('+');
            Assert.AreEqual("1", calculator.GetDisplay());
            calculator.ProcessInput('7');
            Assert.AreEqual("7", calculator.GetDisplay());
            calculator.ProcessInput('=');
            Assert.AreEqual("8", calculator.GetDisplay());
        }

        [Test]
        public void GettingAwayWithSomething()
        {
            AssertCalculatorInteraction(new object[]
            {
                '1', "1",
                '+', "1",
                '7', "7",
                '=', "8"
            });
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

        // Test helper methods are great:
        //     They make your tests easier to write,
        //     easier to maintain, and
        //     easier to read (by hiding irrelevant details
        //     and making the meaningful parts more visible)
        //
        // Test helper methods are awful:
        //     They make it harder for someone new to the
        //         project to understand the test's intent,
        //     easier to have bugs creep into your tests,
        //     and harder to go directly to the line that has
        //        the problem.
        /**
         * testSpecification is an array containing alternating chars (inputs
         * to the calculator) and strings (expected display values for the
         * calculator after each input).
         */
        private void AssertCalculatorInteraction(object[] testSpecification)
        {
            // validate testSpecification and convert it into a list of TestExpectations.
            //     each TestExpectation is a pair of a char and a string
            //     
            // loop through the list of TestExpectations.  For each one:
            //     take its character and call calculator.ProcessInput(theCharacter)
            //     take its string and assert that it matches the calculator's 
            //         output

            // string myStr = "Hello";
            // myStr += " World";
            // myStr will be "Hello World".

            // foo = foo + something;
            // foo += something;

            // bar = bar - somethingElse;
            // bar -= somethingElse;

            // int size = (int)(object)"2";

            // for (int i = 1; i <= 16; i *= 2)
            // {
            //     Console.WriteLine(i);
            // }

            // for (int i = 0; i < testSpecification.Length; i++)
            // for (int i = 0; i < testSpecification.Length; i += 1)
            // for (int i = 0; i < testSpecification.Length; i = i + 1)

            if (testSpecification.Length%2 != 0)
            {
                Assert.Fail("INVALID TEST: odd-length test specification");
            }

            var calculator = new Calculator();

            //for (int i = 0; i < (testSpecification.Length - 2); i += 2)
            for (int i = 0; i < testSpecification.Length; i += 2)
            {
                var input = (char)testSpecification[i];
                var expectedDisplay = (string)testSpecification[i + 1];
                calculator.ProcessInput(input);

                string errorMessage = string.Format(
                    "Unexpected result after input \"{0}\" (zero-based input #{1})",
                    input,
                    (i / 2));

                Assert.AreEqual(
                    expectedDisplay,
                    calculator.GetDisplay(),
                    errorMessage);
            }
        }
    }
}
