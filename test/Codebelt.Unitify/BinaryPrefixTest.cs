using System;
using Codebelt.Extensions.Xunit;
using Xunit;
using Xunit.Abstractions;

namespace Codebelt.Unitify
{
    public class BinaryPrefixTest : Test
    {
        public BinaryPrefixTest(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void BinaryPrefix_ShouldVerifyMultiplePrefixConstants()
        {
            Assert.Equal(BinaryPrefix.Kibi.Multiplier, Math.Pow(2, 10));
            Assert.Equal(BinaryPrefix.Mebi.Multiplier, Math.Pow(2, 20));
            Assert.Equal(BinaryPrefix.Gibi.Multiplier, Math.Pow(2, 30));
            Assert.Equal(BinaryPrefix.Tebi.Multiplier, Math.Pow(2, 40));
            Assert.Equal(BinaryPrefix.Pebi.Multiplier, Math.Pow(2, 50));
            Assert.Equal(BinaryPrefix.Exbi.Multiplier, Math.Pow(2, 60));
            Assert.Equal(BinaryPrefix.Zebi.Multiplier, Math.Pow(2, 70));
            Assert.Equal(BinaryPrefix.Yobi.Multiplier, Math.Pow(2, 80));
        }
    }
}
