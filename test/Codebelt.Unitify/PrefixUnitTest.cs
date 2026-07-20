using Codebelt.Extensions.Xunit;
using Xunit;

namespace Codebelt.Unitify;

public class PrefixUnitTest : Test
{
    public PrefixUnitTest(ITestOutputHelper output) : base(output)
    {
    }

    [Fact]
    public void Constructor_WithIUnit_AndNoPrefix_ShouldDefaultToNonePrefix()
    {
        var watt = UnitFactory.CreateWatt(1000);
        var prefixUnit = new PrefixUnit(watt);

        Assert.NotNull(prefixUnit);
        Assert.Equal(Prefix.None, prefixUnit.Prefix);
        Assert.Equal(1000, prefixUnit.Value);
    }

    [Fact]
    public void Constructor_WithIUnit_AndExplicitPrefix_ShouldUsePrefix()
    {
        var gram = UnitFactory.CreateGram(5000);
        var prefixUnit = new PrefixUnit(gram, DecimalPrefix.Kilo);

        Assert.NotNull(prefixUnit);
        Assert.Equal("k", prefixUnit.Prefix.Symbol);
    }

    [Fact]
    public void ToString_WithNonePrefix_ShouldNotIncludePrefixSymbol()
    {
        var unit = UnitFactory.CreateWatt(100);
        var prefixUnit = new PrefixUnit(unit);

        var result = prefixUnit.ToString();

        TestOutput.WriteLine(result);
        Assert.Contains("100", result);
        Assert.Contains("W", result);
    }

    [Fact]
    public void ToString_WithCompoundStyle_ShouldIncludeCompoundName()
    {
        var kilogram = UnitFactory.CreateKilogram(5);
        var result = kilogram.ToString();

        TestOutput.WriteLine(result);
        Assert.Contains("5 kg", result);
    }
}

