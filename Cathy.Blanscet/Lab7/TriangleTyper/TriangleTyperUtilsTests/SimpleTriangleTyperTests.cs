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
            //TriangleTyperClass typer = new TriangleTyperClass();
            //string actualType = _typer.GetTriangleType(1, 1, 1);
            Assert.AreEqual("Equilateral", _typer.GetTriangleType(1, 1, 1));
        }

        [Test]
        public void OnlyTwoSidesEqualShouldBeIsosceles()
        {
            //TriangleTyperClass typer = new TriangleTyperClass();
            //string actualType = _typer.GetTriangleType(2, 2, 3);
            Assert.AreEqual("Isosceles", _typer.GetTriangleType(2, 2, 3));
        }

        [Test]
        public void TwoSidesEqualTheThirdIsNotTriangle()
        {
            //string actualType = _typer.GetTriangleType(1, 2, 3);
            Assert.AreEqual("Not a Triangle", _typer.GetTriangleType(1, 2, 3));
        }

        [Test]
        public void NoSidesEqualShouldBeScalene()
        {
            //string actualType = _typer.GetTriangleType(2, 3, 4);
            Assert.AreEqual("Scalene", _typer.GetTriangleType(2, 3, 4));
        }

        [Test]
        public void AnyZeroLengthSidesAreNotATrangle()
        {
            //string actualType = _typer.GetTriangleType(0, 0, 0);
            Assert.AreEqual("Not a Triangle", _typer.GetTriangleType(0, 0, 0));
        }

        public void AssertAllOrderings(string expectedtype, long a, long b, long c)
        {

        }
    }
}
