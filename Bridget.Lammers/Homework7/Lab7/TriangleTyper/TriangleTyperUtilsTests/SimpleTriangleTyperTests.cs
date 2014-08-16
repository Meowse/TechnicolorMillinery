using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using triangleTyperUtils;

namespace TriangleTyperUtilsTests
{
    [TestFixture]
    public class SimpleTriangleTyperTests
    {
        private readonly TriangleTyperClass _typer = new TriangleTyperClass();

        [Test]
        public void EqualSidesShouldBeEqualateral()
        {
            //TriangleTyperClass typer = new TriangleTyperClass(); //Changed to inline
            //string actualType = _typer.GetTriangleType(1, 1, 1);
            Assert.AreEqual("Equilateral", _typer.GetTriangleType(1, 1, 1));

        }

        [Test]
        public void OnlyTwoSidesEqualShouldBeIsosceles()
        {
            //TriangleTyperClass typer = new TriangleTyperClass();
            //string actualType = _typer.GetTriangleType(2, 2, 3); //Changed to inline
            //Assert.AreEqual("Isosceles", _typer.GetTriangleType(2, 2, 3)); //changed to helper function
            AssertAllOrderings("Isosceles", 2, 2, 3);
            AssertAllOrderings("Isosceles", 12, 8, 8);
        }

        [Test]
        public void TwoSidesEqualTheThirdIsNotTriangle()
        {
            //string actualType = _typer.GetTriangleType(1, 1, 3); //Changed to inline
            //Assert.AreEqual("Not a Triangle", _typer.GetTriangleType(1, 1, 3)); //changed to helper function
            AssertAllOrderings("Not a Triangle", 1, 1, 2);
        }

        [Test]
        public void NoSidesEqualShouldBeScalene()
        {
            //string actualType = _typer.GetTriangleType(2, 3, 4); //Changed to inline
            //Assert.AreEqual("Scalene", _typer.GetTriangleType(2, 3, 4)); //changed to helper function
            AssertAllOrderings("Scalene", 2, 3, 4);
            AssertAllOrderings("Scalene", 3, 4, 5);
        }

        [Test]
        public void AnyZeroLengthSidesAreNotATrangle()
        {
            //string actualType = _typer.GetTriangleType(0, 0, 0); //Changed to inline
            //Assert.AreEqual("Not a Triangle", _typer.GetTriangleType(0, 0, 0)); //changed to helper function
            AssertAllOrderings("Not a Triangle", 0, 0, 0);
        }

        [Test]
        public void TwoSidesDoNotAddUpToTheThirdIsNotATriangle()
        {
            //string actualType = _typer.GetTriangleType(1, 1, 7); //Changed to inline
            //Assert.AreEqual("Not a Triangle", _typer.GetTriangleType(1, 1, 7)); //changed to helper function
            AssertAllOrderings("Not a Triangle", 1, 1, 7);
        }

        [Test]
        public void NegativeSidesAreNotTriangles()
        {
            //string actualType = _typer.GetTriangleType(-3, -3, -3); //Changed to inline
            //Assert.AreEqual("Not a Triangle", _typer.GetTriangleType(-3, -3, -3)); //changed to helper function
            AssertAllOrderings("Not a Triangle", -3, -3, -3);
            AssertAllOrderings("Not a Triangle", -3, -2, 1);
            AssertAllOrderings("Not a Triangle", -3, 4, 5);
            AssertAllOrderings("Not a Triangle", -1, -1, 3);
        }

        [Test]
        public void ShouldHandleMaxLongValues()
        {
            //string actualType = _typer.GetTriangleType(long.MaxValue, long.MaxValue, long.MaxValue); //Changed to inline
            //Assert.AreEqual("Equilateral", _typer.GetTriangleType(long.MaxValue, long.MaxValue, long.MaxValue)); //changed to helper function
            Assert.AreEqual("Equilateral", _typer.GetTriangleType(long.MaxValue, long.MaxValue, long.MaxValue));
            AssertAllOrderings("Isosceles", 1, long.MaxValue, long.MaxValue);
            AssertAllOrderings("Isosceles", long.MaxValue - 1, long.MaxValue, long.MaxValue);
            AssertAllOrderings("Isosceles", long.MaxValue - 1, long.MaxValue - 1, long.MaxValue);
            AssertAllOrderings("Scalene", long.MaxValue, long.MaxValue - 1, 3);
            AssertAllOrderings("Scalene", long.MaxValue, long.MaxValue - 1, long.MaxValue - 2);
            AssertAllOrderings("Not a Triangle", long.MaxValue, 1, 1);
        }

        public void AssertAllOrderings(string expectedtype, long a, long b, long c)
        {
            Assert.AreEqual(expectedtype, _typer.GetTriangleType(a, b, c));
            Assert.AreEqual(expectedtype, _typer.GetTriangleType(a, c, b));
            Assert.AreEqual(expectedtype, _typer.GetTriangleType(b, a, c));
            Assert.AreEqual(expectedtype, _typer.GetTriangleType(b, c, a));
            Assert.AreEqual(expectedtype, _typer.GetTriangleType(c, a, b));
            Assert.AreEqual(expectedtype, _typer.GetTriangleType(c, b, a));
        }
    }
}
