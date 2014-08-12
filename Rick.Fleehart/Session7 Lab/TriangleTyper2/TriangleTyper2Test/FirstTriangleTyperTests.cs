using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace TriangleTyper2Test
{
    [TestFixture]
    public class FirstTriangleTyperTests
    {
        // Each test must start with [Test]

        // Create a new instance of TriagleTyper2 to run the test wth
        public Program.GetType Typer = new GetType();


        [Test]
        public void EqualSidesShouldBeEquilateral()
        {
            string expectedType = "Equilateral";
            string actualType = Typer.GetType(1, 1, 1);
            Assert.AreEqual(expectedType, actualType);
        }


    }
}
