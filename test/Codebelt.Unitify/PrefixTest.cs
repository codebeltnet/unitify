using Codebelt.Extensions.Xunit;
using Xunit;

namespace Codebelt.Unitify
{
    public class PrefixTest : Test
    {
        public PrefixTest(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void ToString_ShouldReturnFormattedStringForDecimalPrefix()
        {
            var prefix = DecimalPrefix.Kilo;

            var result = prefix.ToString();

            TestOutput.WriteLine(result);
            Assert.Contains("kilo", result);
            Assert.Contains("(k)", result);
            Assert.Contains("10^", result);
        }

        [Fact]
        public void ToString_ShouldReturnFormattedStringForBinaryPrefix()
        {
            var prefix = BinaryPrefix.Kibi;

            var result = prefix.ToString();

            TestOutput.WriteLine(result);
            Assert.Contains("kibi", result);
            Assert.Contains("(Ki)", result);
            Assert.Contains("2^", result);
        }

        [Fact]
        public void ToString_ShouldReturnFormattedStringForSubmultiplePrefix()
        {
            var prefix = DecimalPrefix.Milli;

            var result = prefix.ToString();

            TestOutput.WriteLine(result);
            Assert.Contains("milli", result);
            Assert.Contains("(m)", result);
            Assert.Contains("10^", result);
        }
    }
}
