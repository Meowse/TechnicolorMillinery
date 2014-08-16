using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SpreadsheetTests
{
    [TestFixture]

    public class AllTheTests
    {
        [Test]
        public void ShouldReturnA()
        {
            var calculator = new CalculatorBrainGuts.CalculatorBrain();
            Assert.AreEqual("A", calculator.GetDisplay());
        }  
    }
}
