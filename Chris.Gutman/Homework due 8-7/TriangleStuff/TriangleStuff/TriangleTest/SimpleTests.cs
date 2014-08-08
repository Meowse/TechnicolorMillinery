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
            Assert.AreEqual("Equilateral", Triangles.getType(1,1,1));
        }

        public void assertallorderings(string expectedtype, long a, long b, long c)
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
