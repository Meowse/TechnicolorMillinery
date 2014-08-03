using NUnit.Framework;
using Sorter;

namespace SorterTest
{

    // below copied from Mickey then modified.
        [TestFixture]
        public class SorterUnitTests
        {
            private SortUtility Sorter = new SortUtility();

            [Test]
            public void CanSortSingleElementList()
            {
                int[] values = {3};
                int[] sorted = {3};
                Sorter.Sort(values);
                Assert.AreEqual(sorted, values);
            }

            [Test]
            public void CanSortDoubleElementList()
            {
                int[] values = {4, 3};
                int[] sorted = {3, 4};
                Sorter.Sort(values);
                Assert.AreEqual(sorted, values);
            }

            [Test]
            public void CanSortTripleElementList()
            {
                int[] values = {4, 3, 2};
                int[] sorted = {2, 3, 4};
                Sorter.Sort(values);
                Assert.AreEqual(sorted, values);
            }

            [Test]
            // don't think this is reaaly needed since we can do three above
            public void CanSortQuadElementList()
            {
                int[] values = {4, 3, 2};
                int[] sorted = {2, 3, 4};
                Sorter.Sort(values);
                Assert.AreEqual(sorted, values);
            }
        }
    }

