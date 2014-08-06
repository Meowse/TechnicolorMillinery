using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sorter;

namespace SorterTests
{
    [TestFixture]
    public class SorterUnitTests
    {
        private readonly SortUtility _sorter = new SortUtility();

        [Test]
        public void CanSortSingleElementList()
        {
            AssertSorted(new[] { 3 }, new[] { 3 });
        }

        [Test]
        public void CanSortDoubleElementList()
        {
            AssertSorted(new[] { 4, 3 }, new[] { 3, 4 });
        }

        [Test]
        public void CanSortThreeElementLists()
        {
            AssertSorted(new[] { 2, 3, 4 }, new[] { 2, 3, 4 });
            AssertSorted(new[] { 2, 4, 3 }, new[] { 2, 3, 4 });
            AssertSorted(new[] { 3, 2, 4 }, new[] { 2, 3, 4 });
            AssertSorted(new[] { 3, 4, 2 }, new[] { 2, 3, 4 });
            AssertSorted(new[] { 4, 2, 3 }, new[] { 2, 3, 4 });
            AssertSorted(new[] { 4, 4, 2 }, new[] { 2, 3, 4 });
        }

        [Test]
        public void CanSortAllFourElementLists()
        {
            AssertSorted(new[] { 1, 2, 3, 4 }, new[] { 1, 2, 3, 4 });
            AssertSorted(new[] { 1, 2, 4, 3 }, new[] { 1, 2, 3, 4 });
            AssertSorted(new[] { 1, 3, 2, 4 }, new[] { 1, 2, 3, 4 });
            AssertSorted(new[] { 1, 3, 4, 2 }, new[] { 1, 2, 3, 4 });
            AssertSorted(new[] { 1, 4, 2, 3 }, new[] { 1, 2, 3, 4 });
            AssertSorted(new[] { 1, 4, 3, 2 }, new[] { 1, 2, 3, 4 });
            AssertSorted(new[] { 2, 1, 3, 4 }, new[] { 1, 2, 3, 4 });
            AssertSorted(new[] { 2, 1, 4, 3 }, new[] { 1, 2, 3, 4 });
            AssertSorted(new[] { 2, 3, 1, 4 }, new[] { 1, 2, 3, 4 });
            AssertSorted(new[] { 2, 3, 4, 1 }, new[] { 1, 2, 3, 4 });
            AssertSorted(new[] { 2, 4, 1, 3 }, new[] { 1, 2, 3, 4 });
            AssertSorted(new[] { 2, 4, 3, 1 }, new[] { 1, 2, 3, 4 });
            AssertSorted(new[] { 3, 1, 2, 4 }, new[] { 1, 2, 3, 4 });
            AssertSorted(new[] { 3, 1, 4, 2 }, new[] { 1, 2, 3, 4 });
            AssertSorted(new[] { 3, 2, 1, 4 }, new[] { 1, 2, 3, 4 });
            AssertSorted(new[] { 3, 2, 4, 1 }, new[] { 1, 2, 3, 4 });
            AssertSorted(new[] { 3, 4, 1, 2 }, new[] { 1, 2, 3, 4 });
            AssertSorted(new[] { 3, 4, 2, 1 }, new[] { 1, 2, 3, 4 });
            AssertSorted(new[] { 4, 1, 2, 3 }, new[] { 1, 2, 3, 4 });
            AssertSorted(new[] { 4, 1, 3, 2 }, new[] { 1, 2, 3, 4 });
            AssertSorted(new[] { 4, 2, 1, 3 }, new[] { 1, 2, 3, 4 });
            AssertSorted(new[] { 4, 2, 3, 1 }, new[] { 1, 2, 3, 4 });
            AssertSorted(new[] { 4, 3, 1, 2 }, new[] { 1, 2, 3, 4 });
            AssertSorted(new[] { 4, 3, 2, 1 }, new[] { 1, 2, 3, 4 });
        }

        [Test]
        public void CanSortReverseOrderFourElementList()
        {
            AssertSorted(new[] { 5, 4, 3, 2 }, new[] { 2, 3, 4, 5 });
        }

        [Test]
        public void CanSortMostlySortedTripleElementList()
        {
            AssertSorted(new[] { 2, 4, 3 }, new[] { 2, 3, 4 });
        }

        [Test]
        public void CanSortTripleElementList()
        {
            AssertSorted(new[] { 4, 3, 2 }, new[] { 2, 3, 4 });
        }

        // Asserts that the given "values", when sorted, will match "sorted".
        private void AssertSorted(int[] values, int[] sorted)
        {
            string original = ForDisplay(values);

            _sorter.Sort(values);
            Assert.AreEqual(sorted, values,
                string.Format(
                    "Original: {0} Expected: {1} Actual: {2}",
                    original,
                    ForDisplay(sorted),
                    ForDisplay(values)));
        }

        private string ForDisplay(int[] values)
        {
            return "[" + String.Join(", ", values) + "]";
        }
    }
}
