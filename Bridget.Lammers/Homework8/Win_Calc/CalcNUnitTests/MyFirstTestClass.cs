using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace CalcNUnitTests
{
    [TestFixture]
    public class MyFirstTestClass
    {

        //[Test]
        //public void ShouldDisplayZeroByDefault()
        //{
        //    var calculator = new Calculator();
        //    Assert.AreEqual("0", calculator.GetDisplay());
        //}

        //[Test]
        //public void ShouldDisplayZeroAfterClear()
        //{
        //    var calculator = new Calculator();
        //    calculator.ProcessInput('1');
       //     calculator.ProcessInput('+');
        //    calculator.ProcessInput('c');
        //    Assert.AreEqual("0", calculator.GetDisplay());
        //}


        public void Test_Add()
        {
            // Define the values to be used during the test execution.  
            int a = 10;
            int b = 20;
            int expectedTotal = (a + b);

            // Instantiate the calculator.  
            Calculator calculator = new Calculator();

            // Call the Add funcionality from the Calculator object.  
            int actualTotal = calculator.Add(a, b);

            // Check if the total obtained is correct.  
            Assert.AreEqual(expectedTotal, actualTotal, "The Add functionality is not working correctly.");
        }  

        [Test]
        public void PositiveTest()
        {
            int x = 7;
            int y = 7;
            Assert.AreEqual(x,y);


        }

        [Test]
        public void NegativeTest()
        {
            if (true)
                Assert.Fail("This failed, Oh No!");
        }


        [Test, ExpectedException(typeof (NotSupportedException))]
        public void ExpectedExceptionTest()
        {
            throw new NotSupportedException();

        }


        [Test, Ignore]
        public void NotImplementedException()
        {
            throw new NotImplementedException();


        }

    }
}
