using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleStuff;

namespace TriangleTest
{
    [TestFixture]
    public class SimpleTests
    {
        private static TriangleTyper Triangles = new TriangleTyper();

        [Test]

        public void EqualSidesShouldBeEquilateral()
        {
            Assertallorderings("Equilateral", 1,1,1);
        }
        [Test]

        public void AnyZeroLengthSidesImpliesNotATriangle()
        {
            Assertallorderings("NotATriangle", 0,1,2);
            Assertallorderings("NotATriangle", 0,7,7);
            Assertallorderings("NotATriangle",0,0,5);
            Assert.AreEqual("NotATriangle", Triangles.getType(0,0,0));
           
        }

        [Test]

        public void AnyNegativeSidesImpliesNotATriangle()
        {
            Assertallorderings("NotATriangle", -1, 0, 1);
            Assertallorderings("NotATriangle", -1, 2, 3);
            Assertallorderings("NotATriangle", -1, 7, 7);
        }

        public void Assertallorderings(string expectedtype, long a, long b, long c)
        {
            Assert.AreEqual(expectedtype, Triangles.getType(a, b, c));
            Assert.AreEqual(expectedtype, Triangles.getType(a, c, b));
            Assert.AreEqual(expectedtype, Triangles.getType(b, a, c));
            Assert.AreEqual(expectedtype, Triangles.getType(b, c, a));
            Assert.AreEqual(expectedtype, Triangles.getType(c, a, b));
            Assert.AreEqual(expectedtype, Triangles.getType(c, b, a));

        }
    }
}
