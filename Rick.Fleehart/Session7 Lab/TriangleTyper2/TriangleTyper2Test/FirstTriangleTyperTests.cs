using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TriangleTyperUtils;

namespace TriangleTyper2Test
{
    [TestFixture]
    public class FirstTriangleTyperTests
    {
        // Each test must start with [Test]

        // Create a new instance of TriangleTyper to run the test wth
        private readonly TriangleTyper _typer = new TriangleTyper();


        [Test]
        public void EqualSidesShouldBeEquilateral()
        {
            string expectedType = "Equilateral";
            string actualType = _typer.GetType(1, 1, 1);
            Assert.AreEqual(expectedType, actualType);
        }


    }
}
