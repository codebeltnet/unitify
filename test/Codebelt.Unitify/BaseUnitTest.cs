using Codebelt.Extensions.Xunit;
using Xunit;

namespace Codebelt.Unitify
{
    public class BaseUnitTest : Test
    {
        public BaseUnitTest(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void EqualityOperator_ShouldReturnTrueForSameValues()
        {
            var a = new BaseUnit("Cat", "Name", "N");
            var b = new BaseUnit("Cat", "Name", "N");

            Assert.True(a == b);
        }

        [Fact]
        public void InequalityOperator_ShouldReturnTrueForDifferentValues()
        {
            var a = new BaseUnit("Cat", "Name", "N");
            var b = new BaseUnit("Cat", "Other", "O");

            Assert.True(a != b);
        }

        [Fact]
        public void Equals_IBaseUnit_ShouldReturnFalseForNull()
        {
            var unit = new BaseUnit("Cat", "Name", "N");

            Assert.False(unit.Equals((IBaseUnit)null));
        }

        [Fact]
        public void Equals_Object_ShouldReturnTrueForEquivalentIBaseUnit()
        {
            var a = new BaseUnit("Cat", "Name", "N");
            IBaseUnit b = new BaseUnit("Cat", "Name", "N");

            Assert.True(a.Equals((object)b));
        }

        [Fact]
        public void Equals_Object_ShouldReturnFalseForNonBaseUnit()
        {
            var unit = new BaseUnit("Cat", "Name", "N");

            Assert.False(unit.Equals("not a BaseUnit"));
        }

        [Fact]
        public void GetHashCode_ShouldBeEqualForSameValues()
        {
            var a = new BaseUnit("Cat", "Name", "N");
            var b = new BaseUnit("Cat", "Name", "N");

            Assert.Equal(a.GetHashCode(), b.GetHashCode());
        }

        [Fact]
        public void PrefixUnit_Farad_ShouldBeEqualToConvertedMicroFarad()
        {
            var baseUnit = new PrefixUnit(Unit.Farad, 0.000006);
            var convertedBaseUnit = DecimalPrefix.Micro.ToBaseUnit(Unit.Farad, 6);

            var baseUnitMetrics = new MetricPrefixTable(baseUnit);
            var convertedBaseUnitMetrics = new MetricPrefixTable(convertedBaseUnit);

            TestOutput.WriteLine(baseUnitMetrics.ToAggregateString());

            TestOutput.WriteLine("---");

            TestOutput.WriteLine(baseUnitMetrics.ToString());
            TestOutput.WriteLine(convertedBaseUnitMetrics.ToString());

            Assert.Equal(baseUnitMetrics.ToAggregateString(), convertedBaseUnitMetrics.ToAggregateString());
            Assert.Equal(baseUnitMetrics.ToString(), convertedBaseUnitMetrics.ToString());
        }

        [Fact]
        public void PrefixUnit_Watt_ShouldBeEqualToConvertedKiloWatt()
        {
            var wattUnit = UnitFactory.CreateWatt(11745);
            var convertedWattUnit = UnitFactory.CreateWatt(11.745, DecimalPrefix.Kilo); // .ToBaseUnit(wattUnit, 11.745);

            var baseUnitMetrics = new MetricPrefixTable(wattUnit);
            var convertedBaseUnitMetrics = new MetricPrefixTable(convertedWattUnit);

            TestOutput.WriteLine(baseUnitMetrics.ToAggregateString());

            TestOutput.WriteLine("---");
            TestOutput.WriteLine(convertedBaseUnitMetrics.ToAggregateString());

            TestOutput.WriteLine("---");


            TestOutput.WriteLine(baseUnitMetrics.ToString());
            TestOutput.WriteLine(convertedBaseUnitMetrics.ToString());

            Assert.Equal(baseUnitMetrics.ToAggregateString(), convertedBaseUnitMetrics.ToAggregateString());
            Assert.Equal(baseUnitMetrics.ToString(), convertedBaseUnitMetrics.ToString());
        }
    }
}
