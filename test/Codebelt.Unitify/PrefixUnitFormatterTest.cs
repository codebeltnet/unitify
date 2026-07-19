using System;
using Codebelt.Extensions.Xunit;
using Xunit;

namespace Codebelt.Unitify
{
    public class PrefixUnitFormatterTest : Test
    {
        public PrefixUnitFormatterTest(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void GetFormat_ShouldReturnSelfForICustomFormatter()
        {
            var formatter = new PrefixUnitFormatter();
            var result = formatter.GetFormat(typeof(System.ICustomFormatter));
            Assert.Same(formatter, result);
        }

        [Fact]
        public void GetFormat_ShouldReturnNullForOtherType()
        {
            var formatter = new PrefixUnitFormatter();
            var result = formatter.GetFormat(typeof(string));
            Assert.Null(result);
        }

        [Fact]
        public void Format_ShouldThrowInvalidOperationException_WhenArgIsNotIPrefixUnit()
        {
            var formatter = new PrefixUnitFormatter();
            Assert.Throws<InvalidOperationException>(() => formatter.Format("N0 W", "not a unit", null));
        }

        [Fact]
        public void Format_ShouldFormatPositiveValueWithPositiveExponent()
        {
            var unit = UnitFactory.CreateKilogram(5);
            var formatter = new PrefixUnitFormatter();

            var result = formatter.Format("#,##0 kg", unit, System.Globalization.CultureInfo.InvariantCulture);

            TestOutput.WriteLine(result);
            Assert.Contains("5", result);
        }

        [Fact]
        public void Format_ShouldSetPrefixValueToZero_WhenExponentIsPositiveAndValueIsNegative()
        {
            var formatter = new PrefixUnitFormatter();
            var prefix = DecimalPrefix.Kilo;
            var unit = new TestPrefixUnitWithNegativeValue(prefix);

            var result = formatter.Format("N2 kW", unit, System.Globalization.CultureInfo.InvariantCulture);

            TestOutput.WriteLine(result);
            Assert.Contains("0", result);
        }

        [Fact]
        public void Format_ShouldUseCompoundFormat_WhenFormatEndsWithX()
        {
            var unit = UnitFactory.CreateKilogram(5);
            var formatter = new PrefixUnitFormatter();

            var result = formatter.Format("N0 kg X", unit, System.Globalization.CultureInfo.InvariantCulture);

            TestOutput.WriteLine(result);
            Assert.Contains("kilo", result);
            Assert.Contains("Gram", result);
        }

        private sealed class TestPrefixUnitWithNegativeValue : IPrefixUnit
        {
            public TestPrefixUnitWithNegativeValue(IPrefix prefix)
            {
                Prefix = prefix;
                Value = -1;
            }

            public double Value { get; }
            public IPrefix Prefix { get; }
            public string Category => "Power";
            public string Name => "Watt";
            public string Symbol => "W";
            public UnitFormatOptions FormatOptions => new UnitFormatOptions();
        }
    }
}
