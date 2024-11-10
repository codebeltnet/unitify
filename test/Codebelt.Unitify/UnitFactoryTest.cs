using Codebelt.Extensions.Xunit;
using Xunit;
using Xunit.Abstractions;

namespace Codebelt.Unitify
{
    public class UnitFactoryTest : Test
    {
        public UnitFactoryTest(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void CreateCustomUnit_ShouldReturnCorrectUnit()
        {
            var unit = UnitFactory.CreateUnit("Custom Category", "Custom Name", "CN", 100, null);

            Assert.Equal("Custom Category", unit.Category);
            Assert.Equal("Custom Name", unit.Name);
            Assert.Equal("CN", unit.Symbol);
            Assert.Equal(100, unit.Value);
            Assert.Equal("100 CN", unit.ToString());
        }

        [Fact]
        public void CreateBit_ShouldReturnCorrectUnit()
        {
            var unit = UnitFactory.CreateBit(100);

            Assert.Equal("Data Quantity", unit.Category);
            Assert.Equal("bit", unit.Name);
            Assert.Equal("b", unit.Symbol);
            Assert.Equal(100, unit.Value);
            Assert.Equal("100 b", unit.ToString());
        }

        [Fact]
        public void CreateByte_ShouldReturnCorrectUnit()
        {
            var unit = UnitFactory.CreateByte(100);

            Assert.Equal("Data Quantity", unit.Category);
            Assert.Equal("byte", unit.Name);
            Assert.Equal("B", unit.Symbol);
            Assert.Equal(100, unit.Value);
            Assert.Equal("100 B", unit.ToString());
        }

        [Fact]
        public void CreateByteFromPrefix_ShouldReturnCorrectUnit()
        {
            var fileSize = 3812840313;
            var unit = UnitFactory.CreateByte(fileSize);
            var data = unit.ToDataPrefixTable();

            Assert.Equal("""
                         0.000003 PiB
                         0.003468 TiB
                         3.550984 GiB
                         3,636.207879 MiB
                         3,723,476.868164 KiB
                         3,812,840,313 B
                         0.000004 PB
                         0.003813 TB
                         3.81284 GB
                         3,812.840313 MB
                         3,812,840.313 kB
                         
                         """.ReplaceLineEndings(), data.ToAggregateString());

            Assert.Equal("3.81284 GB", data.ToString(PrefixStyle.Decimal));
        }

        [Fact]
        public void CreateBitPerSecond_ShouldReturnCorrectUnit()
        {
            var unit = UnitFactory.CreateBitPerSecond(100);

            Assert.Equal("Transmission Rate", unit.Category);
            Assert.Equal("Bit per second", unit.Name);
            Assert.Equal("bit/s", unit.Symbol);
            Assert.Equal(100, unit.Value);
            Assert.Equal("100 bit/s", unit.ToString());
        }

        [Fact]
        public void CreateBitPerSecondFromPrefix_ShouldReturnCorrectUnit()
        {
            var fileSize = 6412840313;
            var seconds = 9.7;
            var transferRate = UnitFactory.CreateBitPerSecond(fileSize / seconds);
            var data = transferRate.ToDataPrefixTable();

            Assert.Equal("""
                         0.000001 Pibit/s
                         0.000601 Tibit/s
                         0.615714 Gibit/s
                         630.490835 Mibit/s
                         645,622.615275 Kibit/s
                         661,117,558.041237 bit/s
                         0.000001 Pbit/s
                         0.000661 Tbit/s
                         0.661118 Gbit/s
                         661.117558 Mbit/s
                         661,117.558041 kbit/s

                         """.ReplaceLineEndings(), data.ToAggregateString());

            Assert.Equal("661.117558 Mbit/s", data.ToString(PrefixStyle.Decimal));
        }

        [Fact]
        public void CreateAmpere_ShouldReturnCorrectUnit()
        {
            var unit = UnitFactory.CreateAmpere(100);

            Assert.Equal("Electric Current", unit.Category);
            Assert.Equal("Ampere", unit.Name);
            Assert.Equal("A", unit.Symbol);
            Assert.Equal(100, unit.Value);
            Assert.Equal("100 A", unit.ToString());
        }

        [Fact]
        public void CreateBecquerel_ShouldReturnCorrectUnit()
        {
            var unit = UnitFactory.CreateBecquerel(100);

            Assert.Equal("Radioactivity", unit.Category);
            Assert.Equal("Becquerel", unit.Name);
            Assert.Equal("Bq", unit.Symbol);
            Assert.Equal(100, unit.Value);
            Assert.Equal("100 Bq", unit.ToString());
        }

        [Fact]
        public void CreateCandela_ShouldReturnCorrectUnit()
        {
            var unit = UnitFactory.CreateCandela(100);

            Assert.Equal("Luminous Intensity", unit.Category);
            Assert.Equal("Candela", unit.Name);
            Assert.Equal("cd", unit.Symbol);
            Assert.Equal(100, unit.Value);
            Assert.Equal("100 cd", unit.ToString());
        }

        [Fact]
        public void CreateCelsius_ShouldReturnCorrectUnit()
        {
            var unit = UnitFactory.CreateCelsius(100);

            Assert.Equal("Temperature", unit.Category);
            Assert.Equal("Celsius", unit.Name);
            Assert.Equal("°C", unit.Symbol);
            Assert.Equal(100, unit.Value);
            Assert.Equal("100 °C", unit.ToString());
        }

        [Fact]
        public void CreateCoulomb_ShouldReturnCorrectUnit()
        {
            var unit = UnitFactory.CreateCoulomb(100);

            Assert.Equal("Electric Charge", unit.Category);
            Assert.Equal("Coulomb", unit.Name);
            Assert.Equal("C", unit.Symbol);
            Assert.Equal(100, unit.Value);
            Assert.Equal("100 C", unit.ToString());
        }

        [Fact]
        public void CreateFarad_ShouldReturnCorrectUnit()
        {
            var unit = UnitFactory.CreateFarad(100);

            Assert.Equal("Electric Capacitance", unit.Category);
            Assert.Equal("Farad", unit.Name);
            Assert.Equal("F", unit.Symbol);
            Assert.Equal(100, unit.Value);
            Assert.Equal("100 F", unit.ToString());
        }

        [Fact]
        public void CreateSixMicroFaradFromPrefix_ShouldReturnCorrectUnit()
        {
            var unit = UnitFactory.CreateFarad(6, DecimalPrefix.Micro);

            Assert.Equal("Electric Capacitance", unit.Category);
            Assert.Equal("Farad", unit.Name);
            Assert.Equal("F", unit.Symbol);
            Assert.Equal(6, unit.Value);
            Assert.Equal("6 μF", unit.ToString());
        }

        [Fact]
        public void CreateSixMicroFaradFromBase_ShouldReturnCorrectUnit()
        {
            var unit = UnitFactory.CreateFarad(0.000006);

            Assert.Equal("Electric Capacitance", unit.Category);
            Assert.Equal("Farad", unit.Name);
            Assert.Equal("F", unit.Symbol);
            Assert.Equal(0.000006, unit.Value);
            Assert.Equal("0.000006 F", unit.ToString());
        }

        [Fact]
        public void CreateGray_ShouldReturnCorrectUnit()
        {
            var unit = UnitFactory.CreateGray(100);

            Assert.Equal("Absorbed Dose", unit.Category);
            Assert.Equal("Gray", unit.Name);
            Assert.Equal("Gy", unit.Symbol);
            Assert.Equal(100, unit.Value);
            Assert.Equal("100 Gy", unit.ToString());
        }

        [Fact]
        public void CreateHenry_ShouldReturnCorrectUnit()
        {
            var unit = UnitFactory.CreateHenry(100);

            Assert.Equal("Inductance", unit.Category);
            Assert.Equal("Henry", unit.Name);
            Assert.Equal("H", unit.Symbol);
            Assert.Equal(100, unit.Value);
            Assert.Equal("100 H", unit.ToString());
        }

        [Fact]
        public void CreateHertz_ShouldReturnCorrectUnit()
        {
            var unit = UnitFactory.CreateHertz(100);

            Assert.Equal("Frequency", unit.Category);
            Assert.Equal("Hertz", unit.Name);
            Assert.Equal("Hz", unit.Symbol);
            Assert.Equal(100, unit.Value);
            Assert.Equal("100 Hz", unit.ToString());
        }

        [Fact]
        public void CreateJoule_ShouldReturnCorrectUnit()
        {
            var unit = UnitFactory.CreateJoule(100);

            Assert.Equal("Energy", unit.Category);
            Assert.Equal("Joule", unit.Name);
            Assert.Equal("J", unit.Symbol);
            Assert.Equal(100, unit.Value);
            Assert.Equal("100 J", unit.ToString());
        }

        [Fact]
        public void CreateKelvin_ShouldReturnCorrectUnit()
        {
            var unit = UnitFactory.CreateKelvin(100);

            Assert.Equal("Temperature", unit.Category);
            Assert.Equal("Kelvin", unit.Name);
            Assert.Equal("K", unit.Symbol);
            Assert.Equal(100, unit.Value);
            Assert.Equal("100 K", unit.ToString());
        }

        [Fact]
        public void CreateKatal_ShouldReturnCorrectUnit()
        {
            var unit = UnitFactory.CreateKatal(100);

            Assert.Equal("Catalytic Activity", unit.Category);
            Assert.Equal("Katal", unit.Name);
            Assert.Equal("kat", unit.Symbol);
            Assert.Equal(100, unit.Value);
            Assert.Equal("100 kat", unit.ToString());
        }

        [Fact]
        public void CreateGram_ShouldReturnCorrectUnit()
        {
            var unit = UnitFactory.CreateGram(100);

            Assert.Equal("Mass", unit.Category);
            Assert.Equal("Gram", unit.Name);
            Assert.Equal("g", unit.Symbol);
            Assert.Equal(100, unit.Value);
            Assert.Equal("100 g", unit.ToString());
        }

        [Fact]
        public void CreateKilogram_ShouldReturnCorrectUnit()
        {
            var unit = UnitFactory.CreateKilogram(100); // 100 kg
            Assert.Equal("Mass", unit.Category);
            Assert.Equal("Gram", unit.Name);
            Assert.Equal("g", unit.Symbol);
            Assert.Equal("k", unit.Prefix.Symbol);
            Assert.Equal("kilo", unit.Prefix.Name);
            Assert.Equal(100000, unit.ToBaseValue()); // 100 kg == 100000 g
            Assert.Equal(100, unit.Value); // 100000 g == 100 kg
            Assert.Equal("100 kg", unit.ToString());
        }

        [Fact]
        public void CreateLumen_ShouldReturnCorrectUnit()
        {
            var unit = UnitFactory.CreateLumen(100);

            Assert.Equal("Luminous Flux", unit.Category);
            Assert.Equal("Lumen", unit.Name);
            Assert.Equal("lm", unit.Symbol);
            Assert.Equal(100, unit.Value);
            Assert.Equal("100 lm", unit.ToString());
        }

        [Fact]
        public void CreateLux_ShouldReturnCorrectUnit()
        {
            var unit = UnitFactory.CreateLux(100);

            Assert.Equal("Illuminance", unit.Category);
            Assert.Equal("Lux", unit.Name);
            Assert.Equal("lx", unit.Symbol);
            Assert.Equal(100, unit.Value);
            Assert.Equal("100 lx", unit.ToString());
        }

        [Fact]
        public void CreateMeter_ShouldReturnCorrectUnit()
        {
            var unit = UnitFactory.CreateMeter(100);

            Assert.Equal("Length", unit.Category);
            Assert.Equal("Meter", unit.Name);
            Assert.Equal("m", unit.Symbol);
            Assert.Equal(100, unit.Value);
            Assert.Equal("100 m", unit.ToString());
        }

        [Fact]
        public void CreateMole_ShouldReturnCorrectUnit()
        {
            var unit = UnitFactory.CreateMole(100);

            Assert.Equal("Amount of Substance", unit.Category);
            Assert.Equal("Mole", unit.Name);
            Assert.Equal("mol", unit.Symbol);
            Assert.Equal(100, unit.Value);
            Assert.Equal("100 mol", unit.ToString());
        }

        [Fact]
        public void CreateNewton_ShouldReturnCorrectUnit()
        {
            var unit = UnitFactory.CreateNewton(100);

            Assert.Equal("Force", unit.Category);
            Assert.Equal("Newton", unit.Name);
            Assert.Equal("N", unit.Symbol);
            Assert.Equal(100, unit.Value);
            Assert.Equal("100 N", unit.ToString());
        }

        [Fact]
        public void CreateOhm_ShouldReturnCorrectUnit()
        {
            var unit = UnitFactory.CreateOhm(100);

            Assert.Equal("Electric Resistance", unit.Category);
            Assert.Equal("Ohm", unit.Name);
            Assert.Equal("Ω", unit.Symbol);
            Assert.Equal(100, unit.Value);
            Assert.Equal("100 Ω", unit.ToString());
        }

        [Fact]
        public void CreatePascal_ShouldReturnCorrectUnit()
        {
            var unit = UnitFactory.CreatePascal(100);

            Assert.Equal("Pressure", unit.Category);
            Assert.Equal("Pascal", unit.Name);
            Assert.Equal("Pa", unit.Symbol);
            Assert.Equal(100, unit.Value);
            Assert.Equal("100 Pa", unit.ToString());
        }

        [Fact]
        public void CreateRadian_ShouldReturnCorrectUnit()
        {
            var unit = UnitFactory.CreateRadian(100);

            Assert.Equal("Plane Angle", unit.Category);
            Assert.Equal("Radian", unit.Name);
            Assert.Equal("rad", unit.Symbol);
            Assert.Equal(100, unit.Value);
            Assert.Equal("100 rad", unit.ToString());
        }

        [Fact]
        public void CreateSecond_ShouldReturnCorrectUnit()
        {
            var unit = UnitFactory.CreateSecond(100);

            Assert.Equal("Time", unit.Category);
            Assert.Equal("Second", unit.Name);
            Assert.Equal("s", unit.Symbol);
            Assert.Equal(100, unit.Value);
            Assert.Equal("100 s", unit.ToString());
        }

        [Fact]
        public void CreateSiemens_ShouldReturnCorrectUnit()
        {
            var unit = UnitFactory.CreateSiemens(100);

            Assert.Equal("Electric Conductance", unit.Category);
            Assert.Equal("Siemens", unit.Name);
            Assert.Equal("S", unit.Symbol);
            Assert.Equal(100, unit.Value);
            Assert.Equal("100 S", unit.ToString());
        }

        [Fact]
        public void CreateSievert_ShouldReturnCorrectUnit()
        {
            var unit = UnitFactory.CreateSievert(100);

            Assert.Equal("Equivalent Dose", unit.Category);
            Assert.Equal("Sievert", unit.Name);
            Assert.Equal("Sv", unit.Symbol);
            Assert.Equal(100, unit.Value);
            Assert.Equal("100 Sv", unit.ToString());
        }

        [Fact]
        public void CreateSteradian_ShouldReturnCorrectUnit()
        {
            var unit = UnitFactory.CreateSteradian(100);

            Assert.Equal("Solid Angle", unit.Category);
            Assert.Equal("Steradian", unit.Name);
            Assert.Equal("sr", unit.Symbol);
            Assert.Equal(100, unit.Value);
            Assert.Equal("100 sr", unit.ToString());
        }

        [Fact]
        public void CreateTesla_ShouldReturnCorrectUnit()
        {
            var unit = UnitFactory.CreateTesla(100);

            Assert.Equal("Magnetic Flux Density", unit.Category);
            Assert.Equal("Tesla", unit.Name);
            Assert.Equal("T", unit.Symbol);
            Assert.Equal(100, unit.Value);
            Assert.Equal("100 T", unit.ToString());
        }

        [Fact]
        public void CreateVolt_ShouldReturnCorrectUnit()
        {
            var unit = UnitFactory.CreateVolt(100);

            Assert.Equal("Electric Potential", unit.Category);
            Assert.Equal("Volt", unit.Name);
            Assert.Equal("V", unit.Symbol);
            Assert.Equal(100, unit.Value);
            Assert.Equal("100 V", unit.ToString());
        }

        [Fact]
        public void CreateWatt_ShouldReturnCorrectUnit()
        {
            var unit = UnitFactory.CreateWatt(100);

            Assert.Equal("Power", unit.Category);
            Assert.Equal("Watt", unit.Name);
            Assert.Equal("W", unit.Symbol);
            Assert.Equal(100, unit.Value);
            Assert.Equal("100 W", unit.ToString());
        }

        [Fact]
        public void CreateWeber_ShouldReturnCorrectUnit()
        {
            var unit = UnitFactory.CreateWeber(100);

            Assert.Equal("Magnetic Flux", unit.Category);
            Assert.Equal("Weber", unit.Name);
            Assert.Equal("Wb", unit.Symbol);
            Assert.Equal(100, unit.Value);
            Assert.Equal("100 Wb", unit.ToString());
        }
    }
}
