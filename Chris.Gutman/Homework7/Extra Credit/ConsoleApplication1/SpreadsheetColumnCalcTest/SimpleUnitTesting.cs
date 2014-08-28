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
 //           Assert.AreEqual("", ssCalculator.getcolumn(0));
            Assert.AreEqual("J", ssCalculator.getcolumn(10));
        }



        [Test]

        public void handlesotherstuff()
        {
            Assert.AreEqual("AA",ssCalculator.getcolumn(27));
            Assert.AreEqual("AB", ssCalculator.getcolumn(28));
            Assert.AreEqual("AZ", ssCalculator.getcolumn(52));
            Assert.AreEqual("BA", ssCalculator.getcolumn(53));
        }

        [Test]

        public void handlesalmosteverything()
        {
            Int64 n = 0;
            Int64 n0 = 0;
            Int64 m;
            while (n0 < 17000)
            {             
                n0 = n0 + 1;
                n = n0;
                string mystring = "";
                while (n != 0)
                {
                    m = (n-1)%26;
                    n = (n - m)/26;
                    mystring = ((char)(m + 65)).ToString()+ mystring;
                }
                Assert.AreEqual(mystring, ssCalculator.getcolumn(n0));
            }
        }
        [Test]

        public void Handlesmaxinput()
        {
            // the expected value is 19*511758 + 14*18954 + 16*702 + 26*26 + 9 = 9999999   ~ "SNPZI"
            Assert.AreEqual("SNPZI", ssCalculator.getcolumn(9999999));

        }
    }
}
