using System;
using System.Linq;
using Codebelt.Extensions.Xunit;
using Xunit;

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
            Assert.Equal(BinaryPrefix.Robi.Multiplier, Math.Pow(2, 90));
            Assert.Equal(BinaryPrefix.Quebi.Multiplier, Math.Pow(2, 100));
        }

        [Fact]
        public void BinaryPrefix_ShouldContainAllPrefixesInOrder()
        {
            var prefixes = BinaryPrefix.BinaryPrefixes.ToList();
            Assert.Equal(10, prefixes.Count);
            Assert.Equal("Ki", prefixes[0].Symbol);
            Assert.Equal("Mi", prefixes[1].Symbol);
            Assert.Equal("Gi", prefixes[2].Symbol);
            Assert.Equal("Ti", prefixes[3].Symbol);
            Assert.Equal("Pi", prefixes[4].Symbol);
            Assert.Equal("Ei", prefixes[5].Symbol);
            Assert.Equal("Zi", prefixes[6].Symbol);
            Assert.Equal("Yi", prefixes[7].Symbol);
            Assert.Equal("Ri", prefixes[8].Symbol);
            Assert.Equal("Qi", prefixes[9].Symbol);
        }
    }
}
