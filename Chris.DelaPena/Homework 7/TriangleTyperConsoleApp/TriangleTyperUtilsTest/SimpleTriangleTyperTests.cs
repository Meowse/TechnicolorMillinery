using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleTyperUtils;


//select all code, ctrl+alt+forward slash for multicomment
namespace TriangleTyperUtilsTest
{
    [TestFixture]
    public class SimpleTriangleTyperTests
    {
        // create _typer to remove need to create "var typer = new TriangleTyper(); for each Test
        private readonly TriangleTyper _typer = new TriangleTyper();

        //create helper function for all orderings to avoid creating multiple permutations
        private void AssertAllOrderings(String expectedType, long a, long b, long c)
        {
            Assert.AreEqual(expectedType, _typer.GetTriangleType(a, b, c));
            Assert.AreEqual(expectedType, _typer.GetTriangleType(a, c, b));
            Assert.AreEqual(expectedType, _typer.GetTriangleType(b, a, c));
            Assert.AreEqual(expectedType, _typer.GetTriangleType(b, c, a));
            Assert.AreEqual(expectedType, _typer.GetTriangleType(c, a, b));
            Assert.AreEqual(expectedType, _typer.GetTriangleType(c, b, a));
        }

        [Test]
        public void EqualSidesShouldBeEquilateral()
        {
            //making a variable named triangle typer, use resharper alt+enter, creates "using" TriangleTyperUtils
           //var typer = new TriangleTyper(); removed by _typer
            //Create GetTriangleType in typer, ctrl+enter, puts in TriangleTyper class. Create a variable called actualType. Call typer.GetTriangleType and place result in actualType
            //inline actualType by getting rid of it in Assert.AreEqual
            //string actualType = _typer.GetTriangleType(1, 1, 1);
            //Check if expected value and actual value match. If Assert.AreEqual is true (see if values are equal), keep going. If false, stop.
            Assert.AreEqual("Equilateral", _typer.GetTriangleType(1, 1, 1));
        }

        [Test]
        public void OnlyTwoSidesEqualShouldBeIsoscoles()
        {
            //var typer = new TriangleTyper();
            //string actualType = _typer.GetTriangleType(1, 7, 7)
            //Assert.AreEqual("Isoscoles", actualType);
           //inline to get rid of actualType
//            Assert.AreEqual("Isoscoles", _typer.GetTriangleType(1, 7, 7));
//            Assert.AreEqual("Isoscoles", _typer.GetTriangleType(7, 1, 7));
//            Assert.AreEqual("Isoscoles", _typer.GetTriangleType(7, 7, 1));
            AssertAllOrderings("Isoscoles", 1, 7, 7);

            //Make sure not equilateral
            //actualType = _typer.GetTriangleType(7, 7, 7);
            //right click on actual type, go to refactor, inline
            //Assert.AreNotEqual("Isoscoles", actualType);
            Assert.AreNotEqual("Isoscoles", _typer.GetTriangleType(7, 7, 7));
        }

        [Test]
        public void TwoSidesEqualTheThirdIsNotATriangle()
        {
           // var typer = new TriangleTyper();
            //string actualType = typer.GetTriangleType(1, 2, 2);
            //Assert.AreEqual("NotATriangle", actualType);
            AssertAllOrderings("NotATriangle", 1, 1, 2);
            //Assert.AreEqual("NotATriangle", _typer.GetTriangleType(1, 1, 2));
            //Assert.AreEqual("NotATriangle", _typer.GetTriangleType(1, 2, 1));
            //Assert.AreEqual("NotATriangle", _typer.GetTriangleType(2, 1, 1));
            //try 1, 2, 3 combination
            //instead of doing multiple permutations, just do AssertAllOrderings
            AssertAllOrderings("NotATriangle", 1, 2, 3);
            //Assert.AreEqual("NotATriangle", _typer.GetTriangleType(1, 2, 3));
            //Assert.AreEqual("NotATriangle", _typer.GetTriangleType(1, 3, 2));
            //Assert.AreEqual("NotATriangle", _typer.GetTriangleType(2, 1, 3));
            //Assert.AreEqual("NotATriangle", _typer.GetTriangleType(2, 3, 1));
            //Assert.AreEqual("NotATriangle", _typer.GetTriangleType(3, 1, 2));
            //Assert.AreEqual("NotATriangle", _typer.GetTriangleType(3, 2, 1));
        }

        [Test]
        public void ThreeDifferentSidesShouldBeScalene()
        {
            AssertAllOrderings("Scalene", 2, 3, 4);
            AssertAllOrderings("Scalene", 3, 4, 5);
            //Assert.AreEqual("Scalene", _typer.GetTriangleType(2, 3, 4));
            //Assert.AreEqual("Scalene", _typer.GetTriangleType(3, 4, 5));
        }

        [Test]
        //place <= in TriangleTyper
        public void TwoSidesDoNotAddUpToTheThirdIsNotATriangle()
        {
            AssertAllOrderings("NotATriangle", 1, 1, 7);
        }

        [Test]
        public void AnyZeroLengthSidesAreNotTriangles()
        {
            AssertAllOrderings("NotATriangle", 0, 2, 3);
            AssertAllOrderings("NotATriangle", 0, 0, 0);
        }

        [Test]
        public void NegativeSidesAreNotTriangles()
        {
            //come up with all cases of negative numbers?
            AssertAllOrderings("NotATriangle", -3, -3, -3);
        }

        //Test for max long
        [Test]
        //should be public, not private
        public void ShouldHandleMaxLongValues()
        {
            //why doesn't c# use arithmetic overflow checking? right click on project TriangleTyperUtils, properties, advanced, build tab, advanced button, check for arithmetic overflow/underflow
            Assert.AreEqual("Equilateral", _typer.GetTriangleType(long.MaxValue, long.MaxValue, long.MaxValue));
//            AssertAllOrderings("Isoscoles", 1, long.MaxValue, long.MaxValue);
//            AssertAllOrderings("Isoscoles" long.MaxValue - 1, long.MaxValue, long.MaxValue);
//            AssertAllOrderings("Isoscoles" long.MaxValue - 1, long.MaxValue - 1, long.MaxValue);
//            AssertAllOrderings("Scalene" long.MaxValue, long.MaxValue - 1, 3);
//            AssertAllOrderings("Scalene" long.MaxValue, long.MaxValue - 1, long.MaxValue - 2);
//            AssertAllOrderings("NotATriangle", long.MaxValue, 1, 1);
        }
    }
}
//Right click on TriangleTyperUtilsTests and "run unit tests"