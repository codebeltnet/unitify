using Codebelt.Extensions.Xunit;
using Xunit;

namespace Codebelt.Unitify
{
    /// <summary>
    /// Tests for all <see cref="PrefixTableExtensions"/> extension methods.
    /// </summary>
    public class PrefixTableExtensionsTest : Test
    {
        public PrefixTableExtensionsTest(ITestOutputHelper output) : base(output)
        {
        }

        private static MetricPrefixTable CreateMetricTableWithValue(double value)
        {
            return new MetricPrefixTable(UnitFactory.CreateMeter(value));
        }

        [Fact]
        public void QuectoOrDefault_ShouldReturnPrefixOrNull()
        {
            var table = CreateMetricTableWithValue(1);
            var result = table.QuectoOrDefault();
            Assert.True(result == null || result.Prefix.Symbol == DecimalPrefix.Quecto.Symbol);
        }

        [Fact]
        public void RontoOrDefault_ShouldReturnPrefixOrNull()
        {
            var table = CreateMetricTableWithValue(1);
            var result = table.RontoOrDefault();
            Assert.True(result == null || result.Prefix.Symbol == DecimalPrefix.Ronto.Symbol);
        }

        [Fact]
        public void YoctoOrDefault_ShouldReturnPrefixOrNull()
        {
            var table = CreateMetricTableWithValue(1);
            var result = table.YoctoOrDefault();
            Assert.True(result == null || result.Prefix.Symbol == DecimalPrefix.Yocto.Symbol);
        }

        [Fact]
        public void ZeptoOrDefault_ShouldReturnPrefixOrNull()
        {
            var table = CreateMetricTableWithValue(1);
            var result = table.ZeptoOrDefault();
            Assert.True(result == null || result.Prefix.Symbol == DecimalPrefix.Zepto.Symbol);
        }

        [Fact]
        public void AttoOrDefault_ShouldReturnPrefixOrNull()
        {
            var table = CreateMetricTableWithValue(1);
            var result = table.AttoOrDefault();
            Assert.True(result == null || result.Prefix.Symbol == DecimalPrefix.Atto.Symbol);
        }

        [Fact]
        public void FemtoOrDefault_ShouldReturnPrefixOrNull()
        {
            var table = CreateMetricTableWithValue(1);
            var result = table.FemtoOrDefault();
            Assert.True(result == null || result.Prefix.Symbol == DecimalPrefix.Femto.Symbol);
        }

        [Fact]
        public void PicoOrDefault_ShouldReturnPrefixOrNull()
        {
            var table = CreateMetricTableWithValue(1);
            var result = table.PicoOrDefault();
            Assert.True(result == null || result.Prefix.Symbol == DecimalPrefix.Pico.Symbol);
        }

        [Fact]
        public void NanoOrDefault_ShouldReturnPrefixOrNull()
        {
            var table = CreateMetricTableWithValue(1);
            var result = table.NanoOrDefault();
            Assert.True(result == null || result.Prefix.Symbol == DecimalPrefix.Nano.Symbol);
        }

        [Fact]
        public void MicroOrDefault_ShouldReturnPrefixOrNull()
        {
            var table = CreateMetricTableWithValue(1);
            var result = table.MicroOrDefault();
            Assert.True(result == null || result.Prefix.Symbol == DecimalPrefix.Micro.Symbol);
        }

        [Fact]
        public void MilliOrDefault_ShouldReturnPrefixOrNull()
        {
            var table = CreateMetricTableWithValue(1);
            var result = table.MilliOrDefault();
            Assert.True(result == null || result.Prefix.Symbol == DecimalPrefix.Milli.Symbol);
        }

        [Fact]
        public void CentiOrDefault_ShouldReturnPrefixOrNull()
        {
            var table = CreateMetricTableWithValue(1);
            var result = table.CentiOrDefault();
            Assert.True(result == null || result.Prefix.Symbol == DecimalPrefix.Centi.Symbol);
        }

        [Fact]
        public void DeciOrDefault_ShouldReturnPrefixOrNull()
        {
            var table = CreateMetricTableWithValue(1);
            var result = table.DeciOrDefault();
            Assert.True(result == null || result.Prefix.Symbol == DecimalPrefix.Deci.Symbol);
        }

        [Fact]
        public void DecaOrDefault_ShouldReturnPrefixOrNull()
        {
            var table = CreateMetricTableWithValue(1);
            var result = table.DecaOrDefault();
            Assert.True(result == null || result.Prefix.Symbol == DecimalPrefix.Deca.Symbol);
        }

        [Fact]
        public void HectoOrDefault_ShouldReturnPrefixOrNull()
        {
            var table = CreateMetricTableWithValue(1);
            var result = table.HectoOrDefault();
            Assert.True(result == null || result.Prefix.Symbol == DecimalPrefix.Hecto.Symbol);
        }

        [Fact]
        public void KiloOrDefault_ShouldReturnMatchingPrefix()
        {
            var table = CreateMetricTableWithValue(1000);
            var result = table.KiloOrDefault();
            Assert.NotNull(result);
            Assert.Equal(DecimalPrefix.Kilo.Symbol, result.Prefix.Symbol);
        }

        [Fact]
        public void MegaOrDefault_ShouldReturnMatchingPrefix()
        {
            var table = CreateMetricTableWithValue(1000000);
            var result = table.MegaOrDefault();
            Assert.NotNull(result);
            Assert.Equal(DecimalPrefix.Mega.Symbol, result.Prefix.Symbol);
        }

        [Fact]
        public void GigaOrDefault_ShouldReturnMatchingPrefix()
        {
            var table = CreateMetricTableWithValue(1e9);
            var result = table.GigaOrDefault();
            Assert.NotNull(result);
            Assert.Equal(DecimalPrefix.Giga.Symbol, result.Prefix.Symbol);
        }

        [Fact]
        public void TeraOrDefault_ShouldReturnMatchingPrefix()
        {
            var table = CreateMetricTableWithValue(1e12);
            var result = table.TeraOrDefault();
            Assert.NotNull(result);
            Assert.Equal(DecimalPrefix.Tera.Symbol, result.Prefix.Symbol);
        }

        [Fact]
        public void PetaOrDefault_ShouldReturnMatchingPrefix()
        {
            var table = CreateMetricTableWithValue(1e15);
            var result = table.PetaOrDefault();
            Assert.NotNull(result);
            Assert.Equal(DecimalPrefix.Peta.Symbol, result.Prefix.Symbol);
        }

        [Fact]
        public void ExaOrDefault_ShouldReturnPrefixOrNull()
        {
            var table = CreateMetricTableWithValue(1e18);
            var result = table.ExaOrDefault();
            Assert.True(result == null || result.Prefix.Symbol == DecimalPrefix.Exa.Symbol);
        }

        [Fact]
        public void ZettaOrDefault_ShouldReturnPrefixOrNull()
        {
            var table = CreateMetricTableWithValue(1e21);
            var result = table.ZettaOrDefault();
            Assert.True(result == null || result.Prefix.Symbol == DecimalPrefix.Zetta.Symbol);
        }

        [Fact]
        public void YottaOrDefault_ShouldReturnPrefixOrNull()
        {
            var table = CreateMetricTableWithValue(1e24);
            var result = table.YottaOrDefault();
            Assert.True(result == null || result.Prefix.Symbol == DecimalPrefix.Yotta.Symbol);
        }

        [Fact]
        public void RonnaOrDefault_ShouldReturnPrefixOrNull()
        {
            var table = CreateMetricTableWithValue(1e27);
            var result = table.RonnaOrDefault();
            Assert.True(result == null || result.Prefix.Symbol == DecimalPrefix.Ronna.Symbol);
        }

        [Fact]
        public void QuettaOrDefault_ShouldReturnPrefixOrNull()
        {
            var table = CreateMetricTableWithValue(1e30);
            var result = table.QuettaOrDefault();
            Assert.True(result == null || result.Prefix.Symbol == DecimalPrefix.Quetta.Symbol);
        }

        [Fact]
        public void KibiOrDefault_ShouldReturnMatchingPrefixFromDataTable()
        {
            var table = DataPrefixTable.CreateByteTableFromBytes(1024);
            var result = table.KibiOrDefault();
            Assert.NotNull(result);
            Assert.Equal(BinaryPrefix.Kibi.Symbol, result.Prefix.Symbol);
        }

        [Fact]
        public void MebiOrDefault_ShouldReturnMatchingPrefixFromDataTable()
        {
            var table = DataPrefixTable.CreateByteTableFromBytes(1024 * 1024);
            var result = table.MebiOrDefault();
            Assert.NotNull(result);
            Assert.Equal(BinaryPrefix.Mebi.Symbol, result.Prefix.Symbol);
        }

        [Fact]
        public void GibiOrDefault_ShouldReturnMatchingPrefixFromDataTable()
        {
            var table = DataPrefixTable.CreateByteTableFromBytes(1024L * 1024 * 1024);
            var result = table.GibiOrDefault();
            Assert.NotNull(result);
            Assert.Equal(BinaryPrefix.Gibi.Symbol, result.Prefix.Symbol);
        }

        [Fact]
        public void TebiOrDefault_ShouldReturnMatchingPrefixFromDataTable()
        {
            var table = DataPrefixTable.CreateByteTableFromBytes(1024L * 1024 * 1024 * 1024);
            var result = table.TebiOrDefault();
            Assert.NotNull(result);
            Assert.Equal(BinaryPrefix.Tebi.Symbol, result.Prefix.Symbol);
        }

        [Fact]
        public void PebiOrDefault_ShouldReturnMatchingPrefixFromDataTable()
        {
            var table = DataPrefixTable.CreateByteTableFromBytes(1024L * 1024 * 1024 * 1024 * 1024);
            var result = table.PebiOrDefault();
            Assert.NotNull(result);
            Assert.Equal(BinaryPrefix.Pebi.Symbol, result.Prefix.Symbol);
        }

        [Fact]
        public void ExbiOrDefault_ShouldReturnNullFromDataTable()
        {
            var table = DataPrefixTable.CreateByteTableFromBytes(1000000000);
            var result = table.ExbiOrDefault();
            Assert.Null(result);
        }

        [Fact]
        public void ZebiOrDefault_ShouldReturnNullFromDataTable()
        {
            var table = DataPrefixTable.CreateByteTableFromBytes(1000000000);
            var result = table.ZebiOrDefault();
            Assert.Null(result);
        }

        [Fact]
        public void YobiOrDefault_ShouldReturnNullFromDataTable()
        {
            var table = DataPrefixTable.CreateByteTableFromBytes(1000000000);
            var result = table.YobiOrDefault();
            Assert.Null(result);
        }

        [Fact]
        public void RobiOrDefault_ShouldReturnNullFromDataTable()
        {
            var table = DataPrefixTable.CreateByteTableFromBytes(1000000000);
            var result = table.RobiOrDefault();
            Assert.Null(result);
        }

        [Fact]
        public void QuebiOrDefault_ShouldReturnNullFromDataTable()
        {
            var table = DataPrefixTable.CreateByteTableFromBytes(1000000000);
            var result = table.QuebiOrDefault();
            Assert.Null(result);
        }
    }
}
