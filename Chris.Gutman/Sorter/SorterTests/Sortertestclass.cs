using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Sorter;

namespace SorterTests
{
    
    [TestFixture]
    public class Sortertestclass
    {
        SortUtility sorter = new SortUtility();
        [Test]
        public void Shouldsort8()
        {
            int[] values = {3, 2, 1, 0};
            int[] actual = {0, 1, 2, 3};
            sorter.Sort(values);
            Assert.AreEqual(actual,  values);
        }
    }
}
