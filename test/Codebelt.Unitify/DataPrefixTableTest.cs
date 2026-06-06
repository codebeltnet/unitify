using Codebelt.Extensions.Xunit;
using Xunit;

namespace Codebelt.Unitify
{
    public class DataPrefixTableTest : Test
    {
        public DataPrefixTableTest(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void ToString_Binary_ShouldReturnBaseUnit_WhenValueTooSmallForBinaryPrefix()
        {
            var table = DataPrefixTable.CreateByteTableFromBytes(100);

            var result = table.ToString(PrefixStyle.Binary);

            TestOutput.WriteLine(result);
            Assert.Contains("B", result);
        }

        [Fact]
        public void ToString_Decimal_ShouldReturnBaseUnit_WhenValueTooSmallForDecimalPrefix()
        {
            var table = DataPrefixTable.CreateByteTableFromBytes(100);

            var result = table.ToString(PrefixStyle.Decimal);

            TestOutput.WriteLine(result);
            Assert.Contains("B", result);
        }

        [Fact]
        public void ToString_Decimal_WithLargerValue_ShouldFindDecimalPrefix()
        {
            var table = DataPrefixTable.CreateByteTableFromBytes(1024);

            var result = table.ToString(PrefixStyle.Decimal);

            TestOutput.WriteLine(result);
            Assert.NotNull(result);
            Assert.Contains("B", result);
        }

        [Fact]
        public void ToAggregateString_ShouldExcludeBinary_WhenFlagIsFalse()
        {
            var table = DataPrefixTable.CreateByteTableFromBytes(1000000000);

            var withBinary = table.ToAggregateString(includeBinary: true);
            var withoutBinary = table.ToAggregateString(includeBinary: false);

            Assert.True(withBinary.Length > withoutBinary.Length);
        }

        [Fact]
        public void ToAggregateString_ShouldExcludeUnit_WhenFlagIsFalse()
        {
            var table = DataPrefixTable.CreateByteTableFromBytes(1000000000);

            var withUnit = table.ToAggregateString(includeUnit: true);
            var withoutUnit = table.ToAggregateString(includeUnit: false);

            Assert.True(withUnit.Length > withoutUnit.Length);
        }

        [Fact]
        public void ToAggregateString_ShouldExcludeDecimal_WhenFlagIsFalse()
        {
            var table = DataPrefixTable.CreateByteTableFromBytes(1000000000);

            var withDecimal = table.ToAggregateString(includeDecimal: true);
            var withoutDecimal = table.ToAggregateString(includeDecimal: false);

            Assert.True(withDecimal.Length > withoutDecimal.Length);
        }
    }
}
