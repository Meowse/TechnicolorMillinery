using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Sorter;

namespace SortTests
{
    [TestFixture]
    public class SortingTests
    {
        private Sorter.SortUtility _sorter = new SortUtility();

        [Test]
        public void CanSortSingleElementList()
        {
            int[] values = {5};
            int[] sorted = {5};
            _sorter.Sort(values);
            Assert.AreEqual(sorted,values);
        }

        [Test]
        public void CanSortDoubleElementList()
        {
            int[] values = {10, 1};
            int[] sorted = {1, 10};
            _sorter.Sort(values);
            Assert.AreEqual(sorted,values);
        }

        [Test]
        public void CanSortTripleElementList()
        {
            int[] values = {4, 10, 12, 6};
            int[] sorted = {4, 6, 10, 12};
            _sorter.Sort(values);
            Assert.AreEqual(sorted,values);
        }
    }
}
