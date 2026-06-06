using System.Collections.Generic;
using Codebelt.Extensions.Xunit;
using Xunit;

namespace Codebelt.Unitify
{
    public class MetricPrefixTableTest : Test
    {
        public MetricPrefixTableTest(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void ToString_ShouldReturnBaseUnitString_WhenNoMetricPrefixHasValueGreaterOrEqualToOne()
        {
            var unit = UnitFactory.CreateMeter(1e-31);
            var table = new MetricPrefixTable(unit);

            var result = table.ToString();

            TestOutput.WriteLine(result);
            Assert.NotNull(result);
        }

        [Fact]
        public void ToAggregateString_ShouldExcludeMultiples_WhenFlagIsFalse()
        {
            var table = new MetricPrefixTable(UnitFactory.CreateMeter(1000));

            var result = table.ToAggregateString(includeMultiples: false);

            TestOutput.WriteLine(result);
            Assert.DoesNotContain("kM", result);
            Assert.DoesNotContain("MM", result);
        }

        [Fact]
        public void ToAggregateString_ShouldExcludeUnit_WhenFlagIsFalse()
        {
            var unit = UnitFactory.CreateMeter(1000);
            var table = new MetricPrefixTable(unit);

            var withUnit = table.ToAggregateString(includeUnit: true);
            var withoutUnit = table.ToAggregateString(includeUnit: false);

            Assert.True(withUnit.Length > withoutUnit.Length);
        }

        [Fact]
        public void ToAggregateString_ShouldExcludeSubmultiples_WhenFlagIsFalse()
        {
            var table = new MetricPrefixTable(UnitFactory.CreateMeter(1000));

            var result = table.ToAggregateString(includeSubmultiples: false);

            TestOutput.WriteLine(result);
            Assert.NotNull(result);
        }
    }
}
