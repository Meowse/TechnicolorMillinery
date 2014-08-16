using System;
using NUnit.Framework;
using TriangleTyperUtils;

namespace TriangleTyper2Test
{
    [TestFixture]
    public class FirstTriangleTyperTests
    {
        // Each test must start with [Test]

        // Create a new instance of TriangleTyper to run the test wth
        private readonly TriangleTyper _typer = new TriangleTyper();

        /* “equilateral” = all 3 sides are the same length
           “isosceles” = 2 sides are the same length, and the third is different
           “scalene” = all 3 sides are different lengths.
            * 
            * 1,1,1 Equalateral
            * 1,2,2 Isosoles
            * 1,2,3 NotATriangle
            * 1,1,2 NotATriangle
            * 3,4,5 Scalene
          */

        [Test]
        public void EqualSidesShouldBeEquilateral()
        {
            string expectedType = "Equilateral";
            string actualType = _typer.GetType(1, 1, 1);

            Assert.AreEqual(expectedType, actualType);
        }

        [Test]
        public void MinusSidesShouldBeNotATriangle()
        {
            string expectedType = "NotATriangle";
            string actualType = _typer.GetType(-1, 5, 6);

            Assert.AreEqual(expectedType, actualType);
        }

        [Test]
        public void EqualSidesShouldBeScalene()
        {
            string expectedType = "Scalene";
            string actualType = _typer.GetType(3, 4, 5);

            Assert.AreEqual(expectedType, actualType);
        }

        public void ThousandsShouldBeIsosoles()
        {
            string expectedType = "Isosoles";
            string actualType = _typer.GetType(5000, 6000, 6000);

            Assert.AreEqual(expectedType, actualType);
        }

        public void UnequalSidesShouldBeIsosoles()
        {
            string expectedType = "Isosoles";
            string actualType = _typer.GetType(1, 2, 2);

            Assert.AreEqual(expectedType, actualType);
        }
    }
}
