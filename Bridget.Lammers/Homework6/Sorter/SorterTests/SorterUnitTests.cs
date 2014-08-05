using NUnit.Framework;
using Sorter;

namespace SorterTests
{
    [TestFixture]
    public class SorterUnitTests
    {
        SortUtility sorter = new SortUtility();

        [Test]
        public void CanSortSingleElementList()
        {
            int[] values = {3};
            int[] sorted = {3};
            sorter.Sort(values);
            Assert.AreEqual(sorted, values);
        }

        [Test]
        public void CanSortDoubleElementList()
        {
            int[] values = { 4, 3 };
            int[] sorted = { 3, 4 };
            sorter.Sort(values);
            Assert.AreEqual(sorted, values);
        }

        [Test]
        public void CanSortTripleElementList()
        {
            int[] values = { 4, 3, 2 };
            int[] sorted = { 2, 3, 4 };
            sorter.Sort(values);
            Assert.AreEqual(sorted, values);
        }
    }
}
