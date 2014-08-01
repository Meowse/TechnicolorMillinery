using System.Runtime;
using AutomatedTestingExample;
using NUnit.Framework;

namespace AutomatedTestingExampleTests
{
    [TestFixture]
    public class PersonTests
    {
        [Test]
        public void ShouldSquareItsInput()
        {
            Assert.AreEqual(9, new Person().SquareIt(3));
        }

        [Test]
        public void ShouldReturnPositiveWhenSquaringANegative()
        {
            Assert.AreEqual(16, new Person().SquareIt(-4));
        }

        [Test]
        public void CanRubMyFeet()
        {
        }

        [Test]
        public void ShouldReturnEmptyStringForInputsLessThan7()
        {
            Assert.AreEqual("", new Person().SomeMethod(5, -1000));
            Assert.AreEqual("", new Person().SomeMethod(5, -1));
            Assert.AreEqual("", new Person().SomeMethod(5, 0));
            Assert.AreEqual("", new Person().SomeMethod(5, 5));
            Assert.AreEqual("", new Person().SomeMethod(5, 6));
        }

        [Test]
        public void ShouldReturnArg17ForInput7()
        {
            Assert.AreEqual("arg17", new Person().SomeMethod(5, 7));
        }

        [Test]
        public void ShouldReturnArg18ForInput8()
        {
            Assert.AreEqual("arg18", new Person().SomeMethod(5, 8));
        }

        [Test]
        public void ShouldReturnArg19ForInput9()
        {
            Assert.AreEqual("arg19", new Person().SomeMethod(5, 9));
        }

        [Test]
        public void ShouldReturnOoopsForInputsGreaterThan9()
        {
            Assert.AreEqual("Ooops...", new Person().SomeMethod(5, 10));
            Assert.AreEqual("Ooops...", new Person().SomeMethod(5, 11));
            Assert.AreEqual("Ooops...", new Person().SomeMethod(5, 12));
            Assert.AreEqual("Ooops...", new Person().SomeMethod(5, 22));
            Assert.AreEqual("Ooops...", new Person().SomeMethod(5, 39));
        }
    }
}
