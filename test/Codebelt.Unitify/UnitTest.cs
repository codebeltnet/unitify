using System;
using Codebelt.Extensions.Xunit;
using Xunit;

namespace Codebelt.Unitify
{
    public class UnitTest : Test
    {
        public UnitTest(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void ImplicitConversion_ShouldReturnCorrectValue()
        {
            var baseUnit = new BaseUnit("Test Category", "Test Name", "T");
            var unit = new TestUnit(baseUnit, 123.45);

            double value = unit;

            Assert.Equal(123.45, value);
        }

        [Fact]
        public void Constructor_ShouldInitializeProperties()
        {
            var baseUnit = new BaseUnit("Test Category", "Test Name", "T");
            var unit = new TestUnit(baseUnit, 123.45);

            Assert.Equal("Test Category", unit.Category);
            Assert.Equal("Test Name", unit.Name);
            Assert.Equal("T", unit.Symbol);
            Assert.Equal(123.45, unit.Value);
        }

        [Fact]
        public void Equals_ShouldReturnTrueForEqualUnits()
        {
            var baseUnit = new BaseUnit("Test Category", "Test Name", "T");
            var unit1 = new TestUnit(baseUnit, 123.45);
            var unit2 = new TestUnit(baseUnit, 123.45);

            Assert.True(unit1.Equals(unit2));
        }

        [Fact]
        public void Equals_ShouldReturnFalseForDifferentUnits()
        {
            var baseUnit1 = new BaseUnit("Test Category", "Test Name", "T");
            var baseUnit2 = new BaseUnit("Test Category", "Test Name", "T");
            var unit1 = new TestUnit(baseUnit1, 123.45);
            var unit2 = new TestUnit(baseUnit2, 543.21);

            Assert.False(unit1.Equals(unit2));
        }

        [Fact]
        public void GetHashCode_ShouldReturnSameHashCodeForEqualUnits()
        {
            var baseUnit = new BaseUnit("Test Category", "Test Name", "T");
            var unit1 = new TestUnit(baseUnit, 123.45);
            var unit2 = new TestUnit(baseUnit, 123.45);

            Assert.Equal(unit1.GetHashCode(), unit2.GetHashCode());
        }

        [Fact]
        public void ToString_ShouldReturnFormattedString()
        {
            var baseUnit = new BaseUnit("Test Category", "Test Name", "T");
            var unit = new TestUnit(baseUnit, 123.45, options =>
            {
                options.Style = NamingStyle.Symbol;
                options.NumberFormat = "0.00";
            });

            var result = unit.ToString();

            Assert.Equal("123.45 T", result);
        }

        [Fact]
        public void Bit_ShouldHaveCorrectProperties()
        {
            Assert.Equal("Data Quantity", Unit.Bit.Category);
            Assert.Equal("bit", Unit.Bit.Name);
            Assert.Equal("b", Unit.Bit.Symbol);
        }

        [Fact]
        public void Byte_ShouldHaveCorrectProperties()
        {
            Assert.Equal("Data Quantity", Unit.Byte.Category);
            Assert.Equal("byte", Unit.Byte.Name);
            Assert.Equal("B", Unit.Byte.Symbol);
        }

        [Fact]
        public void BitPerSecond_ShouldHaveCorrectProperties()
        {
            Assert.Equal("Transmission Rate", Unit.BitPerSecond.Category);
            Assert.Equal("Bit per second", Unit.BitPerSecond.Name);
            Assert.Equal("bit/s", Unit.BitPerSecond.Symbol);
        }

        [Fact]
        public void Ampere_ShouldHaveCorrectProperties()
        {
            Assert.Equal("Electric Current", Unit.Ampere.Category);
            Assert.Equal("Ampere", Unit.Ampere.Name);
            Assert.Equal("A", Unit.Ampere.Symbol);
        }

        [Fact]
        public void Becquerel_ShouldHaveCorrectProperties()
        {
            Assert.Equal("Radioactivity", Unit.Becquerel.Category);
            Assert.Equal("Becquerel", Unit.Becquerel.Name);
            Assert.Equal("Bq", Unit.Becquerel.Symbol);
        }

        [Fact]
        public void Candela_ShouldHaveCorrectProperties()
        {
            Assert.Equal("Luminous Intensity", Unit.Candela.Category);
            Assert.Equal("Candela", Unit.Candela.Name);
            Assert.Equal("cd", Unit.Candela.Symbol);
        }

        [Fact]
        public void Celsius_ShouldHaveCorrectProperties()
        {
            Assert.Equal("Temperature", Unit.Celsius.Category);
            Assert.Equal("Celsius", Unit.Celsius.Name);
            Assert.Equal("°C", Unit.Celsius.Symbol);
        }

        [Fact]
        public void Coulomb_ShouldHaveCorrectProperties()
        {
            Assert.Equal("Electric Charge", Unit.Coulomb.Category);
            Assert.Equal("Coulomb", Unit.Coulomb.Name);
            Assert.Equal("C", Unit.Coulomb.Symbol);
        }

        [Fact]
        public void Farad_ShouldHaveCorrectProperties()
        {
            Assert.Equal("Electric Capacitance", Unit.Farad.Category);
            Assert.Equal("Farad", Unit.Farad.Name);
            Assert.Equal("F", Unit.Farad.Symbol);
        }

        [Fact]
        public void Gray_ShouldHaveCorrectProperties()
        {
            Assert.Equal("Absorbed Dose", Unit.Gray.Category);
            Assert.Equal("Gray", Unit.Gray.Name);
            Assert.Equal("Gy", Unit.Gray.Symbol);
        }

        [Fact]
        public void Henry_ShouldHaveCorrectProperties()
        {
            Assert.Equal("Inductance", Unit.Henry.Category);
            Assert.Equal("Henry", Unit.Henry.Name);
            Assert.Equal("H", Unit.Henry.Symbol);
        }

        [Fact]
        public void Hertz_ShouldHaveCorrectProperties()
        {
            Assert.Equal("Frequency", Unit.Hertz.Category);
            Assert.Equal("Hertz", Unit.Hertz.Name);
            Assert.Equal("Hz", Unit.Hertz.Symbol);
        }

        [Fact]
        public void Joule_ShouldHaveCorrectProperties()
        {
            Assert.Equal("Energy", Unit.Joule.Category);
            Assert.Equal("Joule", Unit.Joule.Name);
            Assert.Equal("J", Unit.Joule.Symbol);
        }

        [Fact]
        public void Kelvin_ShouldHaveCorrectProperties()
        {
            Assert.Equal("Temperature", Unit.Kelvin.Category);
            Assert.Equal("Kelvin", Unit.Kelvin.Name);
            Assert.Equal("K", Unit.Kelvin.Symbol);
        }

        [Fact]
        public void Katal_ShouldHaveCorrectProperties()
        {
            Assert.Equal("Catalytic Activity", Unit.Katal.Category);
            Assert.Equal("Katal", Unit.Katal.Name);
            Assert.Equal("kat", Unit.Katal.Symbol);
        }

        [Fact]
        public void Gram_ShouldHaveCorrectProperties()
        {
            Assert.Equal("Mass", Unit.Gram.Category);
            Assert.Equal("Gram", Unit.Gram.Name);
            Assert.Equal("g", Unit.Gram.Symbol);
        }

        [Fact]
        public void Lumen_ShouldHaveCorrectProperties()
        {
            Assert.Equal("Luminous Flux", Unit.Lumen.Category);
            Assert.Equal("Lumen", Unit.Lumen.Name);
            Assert.Equal("lm", Unit.Lumen.Symbol);
        }

        [Fact]
        public void Lux_ShouldHaveCorrectProperties()
        {
            Assert.Equal("Illuminance", Unit.Lux.Category);
            Assert.Equal("Lux", Unit.Lux.Name);
            Assert.Equal("lx", Unit.Lux.Symbol);
        }

        [Fact]
        public void Meter_ShouldHaveCorrectProperties()
        {
            Assert.Equal("Length", Unit.Meter.Category);
            Assert.Equal("Meter", Unit.Meter.Name);
            Assert.Equal("m", Unit.Meter.Symbol);
        }

        [Fact]
        public void Mole_ShouldHaveCorrectProperties()
        {
            Assert.Equal("Amount of Substance", Unit.Mole.Category);
            Assert.Equal("Mole", Unit.Mole.Name);
            Assert.Equal("mol", Unit.Mole.Symbol);
        }

        [Fact]
        public void Newton_ShouldHaveCorrectProperties()
        {
            Assert.Equal("Force", Unit.Newton.Category);
            Assert.Equal("Newton", Unit.Newton.Name);
            Assert.Equal("N", Unit.Newton.Symbol);
        }

        [Fact]
        public void Ohm_ShouldHaveCorrectProperties()
        {
            Assert.Equal("Electric Resistance", Unit.Ohm.Category);
            Assert.Equal("Ohm", Unit.Ohm.Name);
            Assert.Equal("Ω", Unit.Ohm.Symbol);
        }

        [Fact]
        public void Pascal_ShouldHaveCorrectProperties()
        {
            Assert.Equal("Pressure", Unit.Pascal.Category);
            Assert.Equal("Pascal", Unit.Pascal.Name);
            Assert.Equal("Pa", Unit.Pascal.Symbol);
        }

        [Fact]
        public void Radian_ShouldHaveCorrectProperties()
        {
            Assert.Equal("Plane Angle", Unit.Radian.Category);
            Assert.Equal("Radian", Unit.Radian.Name);
            Assert.Equal("rad", Unit.Radian.Symbol);
        }

        [Fact]
        public void Second_ShouldHaveCorrectProperties()
        {
            Assert.Equal("Time", Unit.Second.Category);
            Assert.Equal("Second", Unit.Second.Name);
            Assert.Equal("s", Unit.Second.Symbol);
        }

        [Fact]
        public void Siemens_ShouldHaveCorrectProperties()
        {
            Assert.Equal("Electric Conductance", Unit.Siemens.Category);
            Assert.Equal("Siemens", Unit.Siemens.Name);
            Assert.Equal("S", Unit.Siemens.Symbol);
        }

        [Fact]
        public void Sievert_ShouldHaveCorrectProperties()
        {
            Assert.Equal("Equivalent Dose", Unit.Sievert.Category);
            Assert.Equal("Sievert", Unit.Sievert.Name);
            Assert.Equal("Sv", Unit.Sievert.Symbol);
        }

        [Fact]
        public void Steradian_ShouldHaveCorrectProperties()
        {
            Assert.Equal("Solid Angle", Unit.Steradian.Category);
            Assert.Equal("Steradian", Unit.Steradian.Name);
            Assert.Equal("sr", Unit.Steradian.Symbol);
        }

        [Fact]
        public void Tesla_ShouldHaveCorrectProperties()
        {
            Assert.Equal("Magnetic Flux Density", Unit.Tesla.Category);
            Assert.Equal("Tesla", Unit.Tesla.Name);
            Assert.Equal("T", Unit.Tesla.Symbol);
        }

        [Fact]
        public void Volt_ShouldHaveCorrectProperties()
        {
            Assert.Equal("Electric Potential", Unit.Volt.Category);
            Assert.Equal("Volt", Unit.Volt.Name);
            Assert.Equal("V", Unit.Volt.Symbol);
        }

        [Fact]
        public void Watt_ShouldHaveCorrectProperties()
        {
            Assert.Equal("Power", Unit.Watt.Category);
            Assert.Equal("Watt", Unit.Watt.Name);
            Assert.Equal("W", Unit.Watt.Symbol);
        }

        [Fact]
        public void Weber_ShouldHaveCorrectProperties()
        {
            Assert.Equal("Magnetic Flux", Unit.Weber.Category);
            Assert.Equal("Weber", Unit.Weber.Name);
            Assert.Equal("Wb", Unit.Weber.Symbol);
        }

        private class TestUnit : Unit
        {
            public TestUnit(IBaseUnit baseUnit, double value, Action<UnitFormatOptions> setup = null)
                : base(baseUnit, value, setup)
            {
            }
        }
    }
}
