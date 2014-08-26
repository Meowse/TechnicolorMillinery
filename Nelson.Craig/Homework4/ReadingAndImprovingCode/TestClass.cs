using System;
using NUnit.Framework;

namespace ReadingAndImprovingCode
{
    [TestFixture]
    class TestClass
    {
        [Test]
        public void SomeMethodArg2LessThanSix()
        {
            var exampleclass = new ExampleClass();
            Assert.AreEqual(string.Empty, exampleclass.SomeMethod(2, 2));
            Assert.AreEqual(string.Empty, exampleclass.SomeMethod(10, 2));
            Assert.AreEqual(string.Empty, exampleclass.SomeMethod(22, 2));
        }
        [Test]
        public void SomeOtherMethodArg2LessThanSix()
        {
            var exampleclass = new ExampleClass();
            Assert.AreEqual(string.Empty, exampleclass.SomeOtherMethod(2, 2));
            Assert.AreEqual(string.Empty, exampleclass.SomeOtherMethod(10, 2));
            Assert.AreEqual(string.Empty, exampleclass.SomeOtherMethod(22, 2));
        }
        [Test]
        public void SomeOtherMethodArg2GreaterThanSix()
        {
            var exampleclass = new ExampleClass();
            Assert.AreEqual("arg18", exampleclass.SomeOtherMethod(2, 8));
            Assert.AreEqual("arg18", exampleclass.SomeOtherMethod(10, 8));
            Assert.AreEqual("arg18", exampleclass.SomeOtherMethod(22, 8));
        }
        [Test]
        public void SomeMethodArg2GreaterThanSix()
        {
            var exampleclass = new ExampleClass();
            Assert.AreEqual("arg18", exampleclass.SomeMethod(2, 8));
            Assert.AreEqual("arg18", exampleclass.SomeMethod(10, 8));
            Assert.AreEqual("arg18", exampleclass.SomeMethod(22, 8));
        }
        [Test]
        public void SomeMethodLargeNumbers()
        {
            var exampleclass = new ExampleClass();
            Assert.AreEqual("Ooops...", exampleclass.SomeMethod(100, 100));
            Assert.AreEqual(string.Empty, exampleclass.SomeMethod(100, 2));
            Assert.AreEqual("Ooops...", exampleclass.SomeMethod(2, 100));
        }
        [Test]
        public void SomeOtherMethodLargeNumbers()
        {
            var exampleclass = new ExampleClass();
            Assert.AreEqual("Ooops...", exampleclass.SomeOtherMethod(100, 100));
            Assert.AreEqual(string.Empty, exampleclass.SomeOtherMethod(100, 2));
            Assert.AreEqual("Ooops...", exampleclass.SomeOtherMethod(2, 100));
        }
    }
}
