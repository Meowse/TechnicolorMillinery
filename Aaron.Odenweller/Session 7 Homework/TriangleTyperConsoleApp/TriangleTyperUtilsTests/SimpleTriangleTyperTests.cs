using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleTyperUtils;

namespace TriangleTyperUtilsTests
{
    [TestFixture]
    public class SimpleTriangleTyperTests
    {
//        [Test]
//        public void TriviallyFails()
//        {
//            Assert.AreEqual(2, 2, "Two and two should have been equal");
//            Assert.AreEqual("A", "A", "Two strings that are the same should be equal");
//            Assert.AreEqual(3, 4, "Three and four should be equal, really!");
//        }

//        [Test]
//        public void TriviallyPasses()
//        {
//            Assert.AreEqual(1, 1);
//            Assert.AreEqual(3, 3);
//            Assert.AreEqual("a", "a");
//            Assert.AreEqual(13.7, 13.7);
//            Assert.AreEqual("Hello World".ToLower(), "hello world");
//            Assert.AreEqual("Hello", "Hello World".Substring(0, 5));
//        }

        private readonly TriangleTyper _typer = new TriangleTyper();

        [Test]
        public void EqualSidesShouldBeEquilateral()
        {
            string expectedType = "Equilateral";
            string actualType = _typer.GetTriangleType(1, 1, 1);
            Assert.AreEqual(expectedType, actualType);
        }

        [Test]
        public void OnlyTwoSidesEqualShouldBeIsosceles()
        {
            AssertAllOrderings("Isosceles", 1, 7, 7);
            AssertAllOrderings("Isosceles", 7, 7, 12);
            //            Assert.AreEqual("Isosceles", _typer.GetTriangleType(1, 7, 7));
//            Assert.AreEqual("Isosceles", _typer.GetTriangleType(7, 1, 7));
//            Assert.AreEqual("Isosceles", _typer.GetTriangleType(7, 7, 1));
        }

        [Test]
        public void ThreeSidesEqualShouldNotBeIsosceles()
        {
            Assert.AreNotEqual("Isosceles", _typer.GetTriangleType(7, 7, 7));
        }

        [Test]
        public void TwoSidesEqualTheThirdIsNotATriangle()
        {
            AssertAllOrderings("NotATriangle", 1, 1, 2);
//            Assert.AreEqual("NotATriangle", _typer.GetTriangleType(1, 1, 2));
//            Assert.AreEqual("NotATriangle", _typer.GetTriangleType(1, 2, 1));
//            Assert.AreEqual("NotATriangle", _typer.GetTriangleType(2, 1, 1));

            AssertAllOrderings("NotATriangle", 1, 2, 3);
//            Assert.AreEqual("NotATriangle", _typer.GetTriangleType(1, 2, 3));
//            Assert.AreEqual("NotATriangle", _typer.GetTriangleType(1, 3, 2));
//            Assert.AreEqual("NotATriangle", _typer.GetTriangleType(2, 1, 3));
//            Assert.AreEqual("NotATriangle", _typer.GetTriangleType(2, 3, 1));
//            Assert.AreEqual("NotATriangle", _typer.GetTriangleType(3, 1, 2));
//            Assert.AreEqual("NotATriangle", _typer.GetTriangleType(3, 2, 1));
        }

        [Test]
        public void TwoSidesDoNotAddUpToTheThirdIsNotATriangle()
        {
            AssertAllOrderings("NotATriangle", 1, 1, 7);
        }

        [Test]
        public void ThreeDifferentSidesShouldBeScalene()
        {
            AssertAllOrderings("Scalene", 2, 3, 4);
            AssertAllOrderings("Scalene", 3, 4, 5);

//            Assert.AreEqual("Scalene", _typer.GetTriangleType(2, 3, 4));
//            Assert.AreEqual("Scalene", _typer.GetTriangleType(2, 4, 3));
//            Assert.AreEqual("Scalene", _typer.GetTriangleType(3, 2, 4));
//            Assert.AreEqual("Scalene", _typer.GetTriangleType(3, 4, 2));
//            Assert.AreEqual("Scalene", _typer.GetTriangleType(4, 2, 3));
//            Assert.AreEqual("Scalene", _typer.GetTriangleType(4, 3, 2));

//            Assert.AreEqual("Scalene", _typer.GetTriangleType(3, 4, 5));
//            Assert.AreEqual("Scalene", _typer.GetTriangleType(3, 5, 4));
//            Assert.AreEqual("Scalene", _typer.GetTriangleType(4, 3, 5));
//            Assert.AreEqual("Scalene", _typer.GetTriangleType(4, 5, 3));
//            Assert.AreEqual("Scalene", _typer.GetTriangleType(5, 3, 4));
//            Assert.AreEqual("Scalene", _typer.GetTriangleType(5, 4, 3));
        }

        [Test]
        public void AnyZeroLengthSidesAreNotTriangles()
        {
            AssertAllOrderings("NotATriangle", 0, 2, 3);
            AssertAllOrderings("NotATriangle", 0, 0, 3);
            AssertAllOrderings("NotATriangle", 0, 0, 0);
        }

        [Test]
        public void NegativeSidesAreNotTriangles()
        {
            AssertAllOrderings("NotATriangle", -3, -3, -3);
            AssertAllOrderings("NotATriangle", -3, -2, 1);
            AssertAllOrderings("NotATriangle", -3, 4, 5);
            AssertAllOrderings("NotATriangle", -1, -1, 3);
        }

        [Test]
        public void ShouldHandleMaxLongValues()
        {
            Assert.AreEqual("Equilateral", _typer.GetTriangleType(long.MaxValue, long.MaxValue, long.MaxValue));
            AssertAllOrderings("Isosceles", 1, long.MaxValue, long.MaxValue); // Change Back to Isosceles
            AssertAllOrderings("Isosceles", long.MaxValue - 1, long.MaxValue, long.MaxValue);
            AssertAllOrderings("Isosceles", long.MaxValue - 1, long.MaxValue - 1, long.MaxValue);
            AssertAllOrderings("Scalene", long.MaxValue, long.MaxValue - 1, 3);
            AssertAllOrderings("Scalene", long.MaxValue, long.MaxValue - 1, long.MaxValue - 2);
            AssertAllOrderings("NotATriangle", long.MaxValue, 1, 1);
        }

        private void AssertAllOrderings(String expectedType, long a, long b, long c)
        {
            Assert.AreEqual(expectedType, _typer.GetTriangleType(a, b, c));
            Assert.AreEqual(expectedType, _typer.GetTriangleType(a, c, b));
            Assert.AreEqual(expectedType, _typer.GetTriangleType(b, a, c));
            Assert.AreEqual(expectedType, _typer.GetTriangleType(b, c, a));
            Assert.AreEqual(expectedType, _typer.GetTriangleType(c, a, b));
            Assert.AreEqual(expectedType, _typer.GetTriangleType(c, b, a));
        }
    }
}
