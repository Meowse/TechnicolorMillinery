using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;



namespace traingletypertest
{
    [TestFixture]
    public class TriangleTyperTest
    {
        
    
        [Test]
    public void EquilaterlaTriangle()
    {
        line a = 3;
        line b = 3;
        line c = 3;
        String type = TriangleTyperTest.GetType(a, b, c);
        const string expected = "Equilateral";
        Assert.AreEqual(expected, type);
    }

    [Test]
    public void TriangleNegative()
    {
        line = -1;
        line = -1;
        line = -1;
        string type = TriangleTyperTest.GetType(a, b, c);
        const string expected = "notATriangle";
        Assert.AreEqual(expected, type);
    }

    [Test]
    public void TriangleZero()
    {
        line a = 0;
        line b = 0;
        line c = 0;
        string type = TriangleTyperTest.GetType(a, b, c);
        const string expected = "notATriangle";
        Assert.AreEqual(expected, type);
    }

    [Test]
    public void InvalidTriangleOutOfRange()
    {
        line a = 1;
        line b = 2;
        line c = 3;
        string type = TriangleTyperTest.GetType(a, b, c);
        const string expected = "notATriangle";
        Assert.AreEqual(expected, type);
    }

    [Test]
    public void IsocelesTriangle()
    {
        line a = 2;
        line b = 2;
        line c = 3;
        string type = TriangleTyperTest.GetType(a, b, c);
        const string  expected = "Isosceles";
        Assert.AreEqual(expected, type);
    }

    [Test]
    public void ScaleneTriangle()
    {
        line a = 2;
        line b = 3;
        line c = 4;
        string type = TriangleTyperTest.GetType(a, b, c);
        const string expected = "Scalene";
        Assert.AreEqual(expected, type);
    }
    }
}
