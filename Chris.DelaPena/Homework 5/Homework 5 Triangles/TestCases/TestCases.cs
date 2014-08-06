using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCases
{
    [TestFixture]
    public class TestCases
    {
        TriangleTyper.TriangleTyper triangleTyper = new TriangleTyper.GetType();

        [Test]
        public void Equilateral()
        {
            int sides[] = {1, 1, 1}
            string type = triangleTyper.GetType(sides[]);
            string matches = "Equilateral";
            Assert.AreEqual(type, matches);
        }

        [Test]
        public void NotATriangle()
        {
            int sides[] = {-1, -1, -1}
            string type = triangleTyper.GetType(sides[]);
            string matches = "NotATriangle";
            Assert.AreEqual(type, matches);
        }

        [Test]
        public void NotATriangle()
        {
            int sides[] = {0, 0, 0}
            string type = triangleTyper.GetType(sides[]);
            string matches = "NotATriangle";
            Assert.AreEqual(type, matches);
        }
    } 
}
