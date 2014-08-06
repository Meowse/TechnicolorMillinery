using NUnit.Framework;
using TriangleTyper;

namespace TriangleTyperTests
{
    [TestFixture]
    public class Class1
    {
        private TriangleTyper.Typer _typer = new TriangleTyper.Typer();

        [Test]
        public void CanTypeIsoscelesTriangles()
        {
            string expected = "Isosceles";
            string triangleType = _typer.GetType(3,3,2);
            Assert.AreEqual(expected, triangleType);
        }

        [Test]
        public void CanTypeEquilateralTriangles()
        {
            string expected = "Equilateral";
            string triangleType = _typer.GetType(3,3,3);
            Assert.AreEqual(expected, triangleType);
        }

        [Test]
        public void CanTypeScaleneTriangles()
        {
            
            string expected = "Scalene";
            string triangleType = _typer.GetType(3,2,1);
            Assert.AreEqual(expected, triangleType);
        }

        [Test]
        public void CanNotTypeNegativeSides()
        {
            string expected = "";
            string triangleType = _typer.GetType(-1, 2, 2);
            Assert.AreEqual(expected, triangleType);
        }

        [Test]
        public void CanNotTypeZeroLengthSide()
        {
            string expected = "";
            string triangleType = _typer.GetType(0, 0, 0);
            Assert.AreEqual(expected, triangleType  );
        }

    }
}
