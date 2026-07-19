using System.Collections;
using System.Collections.Generic;
using Codebelt.Extensions.Xunit;
using Xunit;

namespace Codebelt.Unitify
{
    public class PrefixTableTest : Test
    {
        public PrefixTableTest(ITestOutputHelper output) : base(output)
        {
        }

        private sealed class SimplePrefixTable : PrefixTable
        {
            public SimplePrefixTable(IUnit unit) : base(unit)
            {
            }

            public override IEnumerator<IPrefixUnit> GetEnumerator()
            {
                return DecimalPrefix.MetricPrefixes
                    .GetEnumerator() is { } e
                    ? YieldPrefixUnits(e)
                    : GetEmptyEnumerator();
            }

            private IEnumerator<IPrefixUnit> YieldPrefixUnits(IEnumerator<DecimalPrefix> e)
            {
                while (e.MoveNext())
                {
                    yield return e.Current.ToPrefixUnit(BaseUnit);
                }
            }

            private static IEnumerator<IPrefixUnit> GetEmptyEnumerator()
            {
                yield break;
            }
        }

        private sealed class PlainUnit : IUnit
        {
            public PlainUnit(string category, string name, string symbol, double value)
            {
                Category = category;
                Name = name;
                Symbol = symbol;
                Value = value;
                FormatOptions = new UnitFormatOptions();
            }

            public string Category { get; }
            public string Name { get; }
            public string Symbol { get; }
            public double Value { get; }
            public UnitFormatOptions FormatOptions { get; }
        }

        [Fact]
        public void ImplicitConversionToDouble_ShouldReturnBaseUnitValue()
        {
            var table = DataPrefixTable.CreateByteTableFromBytes(512);

            double value = table;

            Assert.Equal(512, value);
        }

        [Fact]
        public void ToString_ShouldReturnBaseUnitString()
        {
            var unit = UnitFactory.CreateWatt(1000);
            var table = new SimplePrefixTable(unit);

            var result = table.ToString();

            TestOutput.WriteLine(result);
            Assert.NotNull(result);
            Assert.Contains("1,000", result);
        }

        [Fact]
        public void Equals_IUnit_ShouldReturnTrueForSameBaseUnit()
        {
            var unit = UnitFactory.CreateWatt(1000);
            var table = new MetricPrefixTable(unit);

            Assert.True(table.Equals(unit));
        }

        [Fact]
        public void Equals_IUnit_ShouldReturnFalseForDifferentUnit()
        {
            var unit1 = UnitFactory.CreateWatt(1000);
            var unit2 = UnitFactory.CreateWatt(2000);
            var table = new MetricPrefixTable(unit1);

            Assert.False(table.Equals(unit2));
        }

        [Fact]
        public void Equals_Object_ShouldReturnTrueForEqualPrefixTable()
        {
            var unit = UnitFactory.CreateWatt(1000);
            var table1 = new MetricPrefixTable(unit);
            var table2 = new MetricPrefixTable(unit);

            Assert.True(table1.Equals((object)table2));
        }

        [Fact]
        public void Equals_Object_ShouldReturnFalseForDifferentPrefixTable()
        {
            var unit1 = UnitFactory.CreateWatt(1000);
            var unit2 = UnitFactory.CreateWatt(2000);
            var table1 = new MetricPrefixTable(unit1);
            var table2 = new MetricPrefixTable(unit2);

            Assert.False(table1.Equals((object)table2));
        }

        [Fact]
        public void Equals_Object_ShouldReturnFalseForNull()
        {
            var unit = UnitFactory.CreateWatt(1000);
            var table = new MetricPrefixTable(unit);

            Assert.False(table.Equals(null));
        }

        [Fact]
        public void GetHashCode_ShouldReturnSameHashCodeForEqualTables()
        {
            var unit = UnitFactory.CreateWatt(1000);
            var table1 = new MetricPrefixTable(unit);
            var table2 = new MetricPrefixTable(unit);

            Assert.Equal(table1.GetHashCode(), table2.GetHashCode());
        }

        [Fact]
        public void NonGenericGetEnumerator_ShouldEnumerateItems()
        {
            var unit = UnitFactory.CreateWatt(1000);
            var table = new MetricPrefixTable(unit);

            var count = 0;
            foreach (var item in (IEnumerable)table)
            {
                Assert.IsAssignableFrom<IPrefixUnit>(item);
                count++;
            }

            Assert.True(count > 0);
        }

        [Fact]
        public void Constructor_WithIPrefixUnit_ShouldUseBaseUnit()
        {
            var prefixUnit = UnitFactory.CreateKilogram(5);
            var table = new MetricPrefixTable(prefixUnit);

            Assert.NotNull(table.BaseUnit);
            Assert.Equal(5000, table.BaseUnit.Value);
        }

        [Fact]
        public void Constructor_WithPlainIUnit_ShouldUseUnitDirectly()
        {
            var plainUnit = new PlainUnit("Length", "Meter", "m", 42);
            var table = new SimplePrefixTable(plainUnit);

            Assert.NotNull(table.BaseUnit);
            Assert.Equal(42, table.BaseUnit.Value);
        }

        [Fact]
        public void Equals_Object_ShouldReturnFalseWhenBaseUnitsValuesDiffer()
        {
            var unit1 = UnitFactory.CreateWatt(1000);
            var unit2 = UnitFactory.CreateWatt(2000);
            var table1 = new MetricPrefixTable(unit1);
            var table2 = new MetricPrefixTable(unit2);

            var result = table1.Equals((object)table2);

            Assert.False(result);
        }

        [Fact]
        public void Equals_Object_ShouldReturnFalseForNonPrefixTableObject()
        {
            var unit = UnitFactory.CreateWatt(1000);
            var table = new MetricPrefixTable(unit);

            Assert.False(table.Equals("not a prefix table"));
            Assert.False(table.Equals(42));
        }
    }
}
