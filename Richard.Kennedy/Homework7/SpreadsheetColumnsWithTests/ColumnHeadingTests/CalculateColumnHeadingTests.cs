using NUnit.Framework;
using SpreadsheetColumns;

namespace ColumnHeadingTests
{
    [TestFixture]
    public class CalculateColumnHeadingTests
    {
        [Test]
        public void ShouldReturnAForOne()
        {
            Assert.AreEqual("A", CalculateColumnLetter.GetColumnHeading(1));
        }

        [Test]
        public void ShouldReturnZFor26()
        {
            Assert.AreEqual("Z", CalculateColumnLetter.GetColumnHeading(26));
        }

        [Test]
        public void ShouldReturnAAFor27()
        {
            Assert.AreEqual("AA", CalculateColumnLetter.GetColumnHeading(27));
        }

    }
}
