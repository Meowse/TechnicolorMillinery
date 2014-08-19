using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ConsoleApplication1;

namespace SpreadsheetColumnCalcTest
{
    [TestFixture]

    public class SimpleUnitTesting
    {
        [Test]

        public void computesonecolumn()
        {
            string result = getcolumn("567");
        }
    }
}
