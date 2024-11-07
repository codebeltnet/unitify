using System;
using Codebelt.Extensions.Xunit;
using Codebelt.Unitify;
using Xunit;
using Xunit.Abstractions;

namespace Unitify
{
    public class BitStorageTest : Test
    {
        public BitStorageTest(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void BitStorage_ShouldBeEqualWithAFactorOfEight()
        {
            var x = DataPrefixTable.CreateBitTableFromBytes(1000000000);
            var y = DataPrefixTable.CreateBitTableFromBits(8000000000);
            Assert.Equal(x, y);
        }

        [Fact]
        public void BitStorage_UseSymbol_ShouldConvertOneBillionBitsToBinaryAndMetricPrefixToStringRepresentation()
        {
            var x = DataPrefixTable.CreateBitTableFromBits(1000000000);

            TestOutput.WriteLine(x.ToAggregateString());

            TestOutput.WriteLine(x.ToString());

            Assert.Equal("0 Pib", x.PebiOrDefault().ToString());
            Assert.Equal("0 Tib", x.TebiOrDefault().ToString());
            Assert.Equal("0.93 Gib", x.GibiOrDefault().ToString());
            Assert.Equal("953.67 Mib", x.MebiOrDefault().ToString());
            Assert.Equal("976,562.5 Kib", x.KibiOrDefault().ToString());

            Assert.Equal("0 Pb", x.PetaOrDefault().ToString());
            Assert.Equal("0 Tb", x.TeraOrDefault().ToString());
            Assert.Equal("1 Gb", x.GigaOrDefault().ToString());
            Assert.Equal("1,000 Mb", x.MegaOrDefault().ToString());
            Assert.Equal("1,000,000 kb", x.KiloOrDefault().ToString());

            Assert.Equal("1,000,000,000 b", x.BaseUnit.ToString());
        }

        [Fact]
        public void BitStorage_UseCompound_ShouldConvertOneBillionBitsToBinaryAndMetricPrefixToStringRepresentation()
        {
            var x = DataPrefixTable.CreateBitTableFromBits(1000000000, o =>
            {
                o.NumberFormat = DataPrefixTable.DefaultNumberFormat;
                o.Style = NamingStyle.Compound;
            });

            TestOutput.WriteLine(x.ToAggregateString());

            Assert.Equal("0 pebibit", x.PebiOrDefault().ToString());
            Assert.Equal("0 tebibit", x.TebiOrDefault().ToString());
            Assert.Equal("0.93 gibibit", x.GibiOrDefault().ToString());
            Assert.Equal("953.67 mebibit", x.MebiOrDefault().ToString());
            Assert.Equal("976,562.5 kibibit", x.KibiOrDefault().ToString());

            Assert.Equal("0 petabit", x.PetaOrDefault().ToString());
            Assert.Equal("0 terabit", x.TeraOrDefault().ToString());
            Assert.Equal("1 gigabit", x.GigaOrDefault().ToString());
            Assert.Equal("1,000 megabit", x.MegaOrDefault().ToString());
            Assert.Equal("1,000,000 kilobit", x.KiloOrDefault().ToString());

            Assert.Equal("1,000,000,000 bit", x.BaseUnit.ToString());
        }

        [Fact]
        public void BitStorage_UseCompound_ShouldConvertOneBillionBitsToBinaryAndMetricPrefixDoubleRepresentation()
        {
            var bs = DataPrefixTable.CreateBitTableFromBits(1000000000, o =>
            {
                o.Style = NamingStyle.Compound;
            });

            Assert.Equal(1000000000, (double)bs);
            Assert.Equal(1000000, bs.KiloOrDefault().Value);
            Assert.Equal(1000, bs.MegaOrDefault().Value);
            Assert.Equal(1, bs.GigaOrDefault().Value);
            Assert.Equal(0.001, bs.TeraOrDefault().Value);
            Assert.Equal(1E-06, bs.PetaOrDefault().Value);
            Assert.Equal(976562.5, bs.KibiOrDefault().Value);
            Assert.Equal(953.67431640625, bs.MebiOrDefault().Value);
            Assert.Equal(0.93132257461547852, bs.GibiOrDefault().Value);
            Assert.Equal(0.00090949470177292824, bs.TebiOrDefault().Value);
            Assert.Equal(8.8817841970012523E-07, bs.PebiOrDefault().Value);
            Assert.Equal("1 gigabit", bs.ToString(PrefixStyle.Decimal));

            TestOutput.WriteLine(bs.ToString());
        }

        [Fact]
        public void FromBits_ShouldConvertBitsToBytes()
        {
            var byteStorage = DataPrefixTable.CreateByteTableFromBits(8000);
            Assert.Equal(1000, byteStorage.BaseUnit.Value);
        }

        [Fact]
        public void FromBits_ShouldUseMinimumByteUnit()
        {
            var byteStorage = DataPrefixTable.CreateByteTableFromBits(4);
            Assert.Equal(1, byteStorage.BaseUnit.Value);
        }

        [Fact]
        public void FromBytes_ShouldInitializeWithBytes()
        {
            var byteStorage = DataPrefixTable.CreateByteTableFromBytes(1000);
            Assert.Equal(1000, byteStorage.BaseUnit.Value);
        }

        [Fact]
        public void FromBytes_ShouldThrowIfBytesIsNegative()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => DataPrefixTable.CreateBitTableFromBytes(-1));
        }
    }
}
