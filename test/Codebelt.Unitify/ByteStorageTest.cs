using System;
using Codebelt.Extensions.Xunit;
using Xunit;

namespace Codebelt.Unitify
{
    public class ByteStorageTest : Test
    {
        public ByteStorageTest(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void ByteStorage_UseSymbol_ShouldConvertOneBillionBytesToBinaryAndMetricPrefixToStringRepresentation()
        {
            var x = DataPrefixTable.CreateByteTableFromBytes(1000000000);

            TestOutput.WriteLine(x.ToAggregateString());

            Assert.Equal("0 PiB", x.PebiOrDefault().ToString());
            Assert.Equal("0 TiB", x.TebiOrDefault().ToString());
            Assert.Equal("0.93 GiB", x.GibiOrDefault().ToString());
            Assert.Equal("953.67 MiB", x.MebiOrDefault().ToString());
            Assert.Equal("976,562.5 KiB", x.KibiOrDefault().ToString());

            Assert.Equal("0 PB", x.PetaOrDefault().ToString());
            Assert.Equal("0 TB", x.TeraOrDefault().ToString());
            Assert.Equal("1 GB", x.GigaOrDefault().ToString());
            Assert.Equal("1,000 MB", x.MegaOrDefault().ToString());
            Assert.Equal("1,000,000 kB", x.KiloOrDefault().ToString());

            Assert.Equal("1,000,000,000 B", x.BaseUnit.ToString());
        }

        [Fact]
        public void ByteStorage_UseCompound_ShouldConvertOneBillionBytesToBinaryAndMetricPrefixToStringRepresentation()
        {
            var x = DataPrefixTable.CreateByteTableFromBytes(1000000000, o =>
            {
                o.NumberFormat = DataPrefixTable.DefaultNumberFormat;
                o.Style = NamingStyle.Compound;
            });

            TestOutput.WriteLine(x.ToAggregateString());

            Assert.Equal("0 pebibyte", x.PebiOrDefault().ToString());
            Assert.Equal("0 tebibyte", x.TebiOrDefault().ToString());
            Assert.Equal("0.93 gibibyte", x.GibiOrDefault().ToString());
            Assert.Equal("953.67 mebibyte", x.MebiOrDefault().ToString());
            Assert.Equal("976,562.5 kibibyte", x.KibiOrDefault().ToString());

            Assert.Equal("0 petabyte", x.PetaOrDefault().ToString());
            Assert.Equal("0 terabyte", x.TeraOrDefault().ToString());
            Assert.Equal("1 gigabyte", x.GigaOrDefault().ToString());
            Assert.Equal("1,000 megabyte", x.MegaOrDefault().ToString());
            Assert.Equal("1,000,000 kilobyte", x.KiloOrDefault().ToString());

            Assert.Equal("1,000,000,000 byte", x.BaseUnit.ToString());
        }

        [Fact]
        public void FromBits_ShouldConvertBitsToBytes()
        {
            // Arrange
            double bits = 8000; // 1000 bytes

            // Act
            var result = DataPrefixTable.CreateByteTableFromBits(bits);

            // Assert
            Assert.Equal(1000, result.BaseUnit.Value);
        }

        [Fact]
        public void FromBits_ShouldHandleLessThanOneByte()
        {
            // Arrange
            double bits = 4; // Less than one byte

            // Act
            var result = DataPrefixTable.CreateByteTableFromBits(bits);

            // Assert
            Assert.Equal(1, result.BaseUnit.Value); // Should be set to one byte
        }

        [Fact]
        public void FromBytes_ShouldInitializeWithBytes()
        {
            // Arrange
            double bytes = 1000;

            // Act
            var result = DataPrefixTable.CreateByteTableFromBytes(bytes);

            // Assert
            Assert.Equal(1000, result.BaseUnit.Value);
        }

        [Fact]
        public void FromBytes_ShouldThrowIfBytesIsNegative()
        {
            // Arrange
            double bytes = -1;

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => DataPrefixTable.CreateByteTableFromBytes(bytes));
        }
    }
}
