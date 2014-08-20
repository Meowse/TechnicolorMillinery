using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ConsoleApplication1;

namespace SpreadsheetColumnCalcTest
{
    [TestFixture]

    public class SimpleUnitTesting
    {
        [Test]

        public void Handlesonedigit()
        {
            Assert.AreEqual("C",ssCalculator.getcolumn(3));
            Assert.AreEqual("Z", ssCalculator.getcolumn(26));
            Assert.AreEqual("", ssCalculator.getcolumn(0));
            Assert.AreEqual("J", ssCalculator.getcolumn(10));
        }

        [Test]

        public void Handlesmaxinput()
        {
            Assert.AreEqual("UVXWI",ssCalculator.getcolumn(9999999));    
        }

        [Test]

        public void handlesotherstuff()
        {
            Assert.AreEqual("AA",ssCalculator.getcolumn(27));
            Assert.AreEqual("AB", ssCalculator.getcolumn(28));
            Assert.AreEqual("AZ", ssCalculator.getcolumn(52));
            Assert.AreEqual("BA", ssCalculator.getcolumn(53));
        }

    }
}
