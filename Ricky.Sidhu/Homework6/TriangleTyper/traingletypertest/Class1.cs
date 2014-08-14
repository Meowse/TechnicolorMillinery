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
        Line a = 3;
        Line b = 3;
        Line c = 3;
        String type = TriangleTyperTest.GetTraingleType(a, b, c);
        const string expected = "Equilateral";
        Assert.AreEqual(expected, type);
    }

    [Test]
    public void TriangleNegative()
    {
        line = -1;
        line = -1;
        line = -1;
        var traingleType = TriangleTyperTest.GetTraingleType(a, b, c);
        string type = traingleType;
        const string expected = "notATriangle";
        Assert.AreEqual(expected, type);
    }

    [Test]
    public void TriangleZero()
    {
        Line a = 0;
        Line b = 0;
        Line c = 0;
        string type = TriangleTyperTest.GetTraingleType(a, b, c);
        const string expected = "notATriangle";
        Assert.AreEqual(expected, type);
    }

    [Test]
    public void InvalidTriangleOutOfRange()
    {
        Line a = 1;
        Line b = 2;
        Line c = 3;
        string type = TriangleTyperTest.GetTraingleType(a, b, c);
        const string expected = "notATriangle";
        Assert.AreEqual(expected, type);
    }

    [Test]
    public void IsocelesTriangle()
    {
        Line a = 2;
        Line b = 2;
        Line c = 3;
        string type = TriangleTyperTest.GetTraingleType(a, b, c);
        const string  expected = "Isosceles";
        Assert.AreEqual(expected, type);
    }

    [Test]
    public void ScaleneTriangle()
    {
        Line a = 2;
        Line b = 3;
        Line c = 4;
        string type = TriangleTyperTest.GetTraingleType(a, b, c);
        const string expected = "Scalene";
        Assert.AreEqual(expected, type);
    }

    public static string GetTraingleType(Line a, Line b, Line c)
    {
        return "Equilateral";
    }

    public int line { get; set; }
    }
}
