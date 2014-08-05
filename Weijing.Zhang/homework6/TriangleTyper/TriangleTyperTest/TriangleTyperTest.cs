using NUnit.Framework;

namespace TriangleTyperTest
{
    [TestFixture]
    public class TriangleTyperTest
    {
        TriangleTyper.TriangleTyper triangleTyper = new TriangleTyper.TriangleTyper();

        [Test]
        public void EquilateralTriangle()
        {
            long a = 3;
            long b = 3;
            long c = 3;
            string type = triangleTyper.GetType(a, b, c);
            string expected = "Equilateral";
            Assert.AreEqual(expected, type);
        }

        [Test]
        public void InvalidTriangleNegative()
        {
            long a = -1;
            long b = -1;
            long c = -1;
            string type = triangleTyper.GetType(a, b, c);
            string expected = "NotATriangle";
            Assert.AreEqual(expected, type);
        }

        [Test]
        public void InvalidTriangleZero()
        {
            long a = 0;
            long b = 0;
            long c = 0;
            string type = triangleTyper.GetType(a, b, c);
            string expected = "NotATriangle";
            Assert.AreEqual(expected, type);
        }

        [Test]
        public void InvalidTriangleOutOfRange()
        {
            long a = 1;
            long b = 2;
            long c = 3;
            string type = triangleTyper.GetType(a, b, c);
            string expected = "NotATriangle";
            Assert.AreEqual(expected, type);
        }

        [Test]
        public void IsoscelesTriangle()
        {
            long a = 2;
            long b = 2;
            long c = 3;
            string type = triangleTyper.GetType(a, b, c);
            string expected = "Isosceles";
            Assert.AreEqual(expected, type);
        }

        [Test]
        public void ScaleneTriangle()
        {
            long a = 2;
            long b = 3;
            long c = 4;
            string type = triangleTyper.GetType(a, b, c);
            string expected = "Scalene";
            Assert.AreEqual(expected, type);
        }
    }
}
