using System;
using NUnit.Framework;
using TriangleTyperUtils;

namespace TriangleTyper2Test
{
    [TestFixture]
    public class FirstTriangleTyperTests
    {
        // Each test must start with [Test]

        // Create a new instance of TriangleTyper to run the test wth
        private readonly TriangleTyper _typer = new TriangleTyper("first one");
//        private readonly TriangleTyper _otherTyper = new TriangleTyper("second one");


        [Test]
        public void EqualSidesShouldBeEquilateral()
        {
//            Console.WriteLine("Id of _otherTyper is: " + _otherTyper.Id);
//
//            Car myMazerati = new SportsCar("Mazerati", "Toospensive", 1993);
//            Car yourMazerati = new SportsCar("Mazerati", "Toospensive", 2001);
//
//            List<Car> myCars = new List<Car>
//            {
//                new SportsCar("Mazerati", "Toospensive", 1993),
//                new Van("Chevrolet", "Astro", 1964),
//                new SUV("GMC", "SubarWasteOfMoneyuu", 2010)
//            };


            string expectedType = "Equilateral";
//            string actualType1 = TriangleTyper.StaticGetType(1, 1, 1);
            string actualType = _typer.GetType(1, 1, 1);
            Assert.AreEqual(expectedType, actualType);
        }
    }
}
