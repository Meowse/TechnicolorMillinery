using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TriangeTesterTest
{
    public class Class1
    {
        private readonly TriangleTyper _typer = new TriangleTyper();

        [Test]
        public void AnyNonPositiveIntegerLengthSidesAreNotTriangles()
        {
            string expectedType = "Not a triangle";
            string actualType = _typer.triangleCheck(0, 0, 0);
            Assert.AreEqual(expectedType, actualType);
        }
    }
}
