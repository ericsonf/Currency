using NUnit.Framework;

namespace Currency.Test
{
    public class Tests
    {
        private FormatCurrency _fc;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _fc = new FormatCurrency();
        }

        [Test]
        [TestCase("0.53", ExpectedResult = 0.53)]
        [TestCase("0,53", ExpectedResult = 0.53)]
        [TestCase("1", ExpectedResult = 1.00)]
        [TestCase("1.53", ExpectedResult = 1.53)]
        [TestCase("1,53", ExpectedResult = 1.53)]
        [TestCase("15.37", ExpectedResult = 15.37)]
        [TestCase("15,37", ExpectedResult = 15.37)]
        [TestCase("158.37", ExpectedResult = 158.37)]
        [TestCase("158,37", ExpectedResult = 158.37)]
        [TestCase("1,587.37", ExpectedResult = 1587.37)]
        [TestCase("1.587,37", ExpectedResult = 1587.37)]
        [TestCase("14,587.37", ExpectedResult = 14587.37)]
        [TestCase("14.587,37", ExpectedResult = 14587.37)]
        [TestCase("14587.37", ExpectedResult = 14587.37)]
        [TestCase("14587,37", ExpectedResult = 14587.37)]
        public decimal ValidateGetValue(string value)
        {
            return _fc.GetValue(value);
        }
    }
}