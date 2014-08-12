using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleTyperUtils;

namespace TriangleTyperUtilsTests
{
    [TextFixture]
    public class TriangleTyperTests
    {
        private readonly TriangleTyper _typer = new TriangleTyper();

        [Test]
        public void ShouldReturnEquilateralForThreeEqualSides()
        {
            Assert.AreEqual("Equilateral", _typer.GetTriangleType(1, 1, 1));
        }
    }
}
