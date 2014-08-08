using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleTyperUtils;

namespace TriangleTyperUtilsTests
{
    [TestFixture]
    public class SimpleTriangleTyperTests
    {
        [Test]
        public static void EqualSidesShouldBeEquilateral()
        {
            //var aTyper = new TriangleTyper();
            string actualType = TriangleTyper.GetTriangleType(3, 3, 3);
            Assert.AreEqual("Equilateral", actualType);  //Assert.AreEqual... this method will "pass" when the two paramters match and fails when they don't
        }

        [Test]
        public static void NotATriagle()
        {
            //TriangleTyper aTyper = new TriangleTyper();
            string actualType = TriangleTyper.GetTriangleType(-1, -1, -1);
            Assert.AreEqual("NotATriangle", actualType);
        }

        [Test]
        public static void IsoscelesTest()
        {
            //TriangleTyper aTyper = new TriangleTyper();
            string actualType = TriangleTyper.GetTriangleType(2, 2, 3);
            Assert.AreEqual("Isosceles", actualType);
        }

        [Test]
        public static void ScaleneTest()
        {
            //TriangleTyper aTyper = new TriangleTyper();
            string actualType = TriangleTyper.GetTriangleType(2, 4, 3);
            Assert.AreEqual("Scalene", actualType);
        }
    }
}
