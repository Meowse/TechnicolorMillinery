using ClassesAndObjectsExample;
using NUnit.Framework;

namespace PersonTest
{
    [TestFixture]
    public class PersonTest
    {
        private Person person = new Person();

        [Test]
        public void ShouldReturnEmptyStringForValuesLessThan7()
        {
            Assert.AreEqual("", person.SomeMethod(-1, -1));
            Assert.AreEqual("", person.SomeMethod(-1, 5));
            Assert.AreEqual("", person.SomeMethod(-1, 6));
            Assert.AreEqual("", person.SomeMethod(27, -1));
            Assert.AreEqual("", person.SomeMethod(27, 5));
            Assert.AreEqual("", person.SomeMethod(27, 6));
        }
    }
}
