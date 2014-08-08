using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace TriangleType2Test
{
    [TestFixture]
    public class SimpleTriangleTypeTests
    {

        private readonly TriangleTyper2 _expectedResults = new TriangleTyper2();

        [Test]
        public void EqualSidesEquilateral()
        {

            _expectedResults;
            Assert.AreEqual('Equilateral', _expectedResults);
        }


    }
}
