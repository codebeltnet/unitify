using System;
using Codebelt.Extensions.Xunit;
using Codebelt.Unitify;
using Xunit;
using Xunit.Abstractions;

namespace Unitify
{
    public class PrefixUnitExtensionsTest : Test
    {
        public PrefixUnitExtensionsTest(ITestOutputHelper output) : base(output)
        {
        }

        private class TestPrefix : IPrefix
        {
            public string Name { get; set; }
            public string Symbol { get; set; }
            public double Multiplier { get; set; }
            public double Base { get; set; }
            public double Exponent { get; set; }

            public double ToPrefixValue(double value) => value * Multiplier;
            public double ToBaseValue(double prefixValue) => prefixValue / Multiplier;
        }

        private class TestPrefixUnit : IPrefixUnit
        {
            public double Value { get; set; }
            public IPrefix Prefix { get; set; }
            public string Category { get; set; }
            public string Name { get; set; }
            public string Symbol { get; set; }
            public UnitFormatOptions FormatOptions { get; set; }
        }

        [Fact]
        public void ToPrefixValue_ShouldConvertToPrefixValue()
        {
            var prefix = new TestPrefix { Multiplier = 1000 };
            var unit = new TestPrefixUnit { Value = 1, Prefix = prefix };

            var result = unit.ToPrefixValue();

            Assert.Equal(1000, result);
        }

        [Fact]
        public void ToBaseValue_ShouldConvertToBaseValue()
        {
            var prefix = new TestPrefix { Multiplier = 1000 };
            var unit = new TestPrefixUnit { Value = 1000, Prefix = prefix };

            var result = unit.ToBaseValue();

            Assert.Equal(1, result);
        }

        [Fact]
        public void ToBaseUnit_ShouldConvertToBaseUnit()
        {
            var prefix = new TestPrefix { Multiplier = 1000 };
            var unit = new TestPrefixUnit { Value = 1000, Prefix = prefix };

            var result = unit.ToBaseUnit();

            Assert.Equal(1, result.Value);
            Assert.Equal(unit.Category, result.Category);
            Assert.Equal(unit.Name, result.Name);
            Assert.Equal(unit.Symbol, result.Symbol);
        }

        [Fact]
        public void ToPrefixString_ShouldConvertToPrefixString()
        {
            var prefix = new TestPrefix { Base = 10, Multiplier = 1000 };
            var unit = new TestPrefixUnit { Value = 1000, Prefix = prefix };

            var result = unit.ToPrefixString();

            Assert.NotNull(result);
        }

        [Fact]
        public void ToPrefixString_ShouldThrowArgumentOutOfRangeException()
        {
            var prefix = new TestPrefix { Base = 5 };
            var unit = new TestPrefixUnit { Value = 1000, Prefix = prefix };

            Assert.Throws<ArgumentOutOfRangeException>(() => unit.ToPrefixString());
        }
    }
}
