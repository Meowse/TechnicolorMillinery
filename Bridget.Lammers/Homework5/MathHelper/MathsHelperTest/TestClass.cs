using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathHelper;
using NUnit.Framework;

namespace MathsHelperTest
{
    [TestFixture]
    public class TestClass
    {
        [TestCase]
        public void AddTest()
        {
            MathsHelper helper = new MathsHelper();
            int result = helper.Add(20, 10);
            Assert.AreEqual(30, result);
        }

        [TestCase]
        public void SubtractTest()
        {
            MathsHelper helper = new MathsHelper();
            int result = helper.Subtract(20, 10);
            Assert.AreEqual(10, result);
        }
    }
}
