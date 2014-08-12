using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleTyperUtils;

namespace TriangleTyperUtilsTest
{
    [TestFixture]
    public class SimpleTriangleTyperTests
    {
        [Test]
        public void EqualSidesShouldBeEquilateral()
        {
            //making a triangle typer, use resharper alt+enter, creates "using" TriangleTyperUtils
            var typer = new TriangleTyper();
            //Create GetTriangleType in typer, ctrl+enter, puts in TriangleTyper class
            string actualType = typer.GetTriangleType(1, 1, 1);
            //Check if expected value and actual value match
            Assert.AreEqual("Equilateral", actualType);

        }
    }
}
//Right click on TriangleTyperUtilsTests and "run unit tests"