using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangeTester;

namespace TriangeTesterTest
{
    public class Class1
    {
        [Test]
        public void AnyNonPositiveIntegerLengthSidesAreNotTriangles()
        {
            string expectedType = "Not a triangle";
            string actualType = Program.triangleCheck(new [] {0L, 0L, 0L});
            Assert.AreEqual(expectedType, actualType);
        }
    }
}
