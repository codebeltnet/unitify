using System;
using Codebelt.Extensions.Xunit;
using Xunit;

namespace Codebelt.Unitify
{
    public class UnitFormatterTest : Test
    {
        public UnitFormatterTest(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void GetFormat_ShouldReturnSelfForICustomFormatter()
        {
            var formatter = new UnitFormatter();
            var result = formatter.GetFormat(typeof(System.ICustomFormatter));
            Assert.Same(formatter, result);
        }

        [Fact]
        public void GetFormat_ShouldReturnNullForOtherType()
        {
            var formatter = new UnitFormatter();
            var result = formatter.GetFormat(typeof(string));
            Assert.Null(result);
        }

        [Fact]
        public void Format_ShouldThrowInvalidOperationException_WhenArgIsNotIUnit()
        {
            var formatter = new UnitFormatter();
            Assert.Throws<InvalidOperationException>(() => formatter.Format("N0 W", "not a unit", null));
        }

        [Fact]
        public void Format_ShouldReturnNumberOnly_WhenFormatHasOneToken()
        {
            var unit = UnitFactory.CreateWatt(1500);
            var formatter = new UnitFormatter();

            var result = formatter.Format("N0", unit, System.Globalization.CultureInfo.InvariantCulture);

            TestOutput.WriteLine(result);
            Assert.Equal("1,500", result);
        }

        [Fact]
        public void Format_ShouldReturnFormattedString_WhenFormatHasTwoTokens()
        {
            var unit = UnitFactory.CreateWatt(1500);
            var formatter = new UnitFormatter();

            var result = formatter.Format("N0 W", unit, System.Globalization.CultureInfo.InvariantCulture);

            TestOutput.WriteLine(result);
            Assert.Equal("1,500 W", result);
        }

        [Fact]
        public void Format_ShouldUseCompoundFormat_WhenFormatEndsWithX()
        {
            var unit = UnitFactory.CreateWatt(1500);
            var formatter = new UnitFormatter();

            var result = formatter.Format("N0 W X", unit, System.Globalization.CultureInfo.InvariantCulture);

            TestOutput.WriteLine(result);
            Assert.Contains("Watt", result);
        }
    }
}
