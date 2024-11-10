using System;
using Codebelt.Extensions.Xunit;
using Xunit;
using Xunit.Abstractions;

namespace Codebelt.Unitify
{
    public class DecimalPrefixTest : Test
    {
        public DecimalPrefixTest(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void DecimalPrefix_ShouldVerifyMultiplePrefixConstants()
        {
            Assert.Equal(DecimalPrefix.Deca.Multiplier, Math.Pow(10, 1));
            Assert.Equal(DecimalPrefix.Hecto.Multiplier, Math.Pow(10, 2));
            Assert.Equal(DecimalPrefix.Kilo.Multiplier, Math.Pow(10, 3));
            Assert.Equal(DecimalPrefix.Mega.Multiplier, Math.Pow(10, 6));
            Assert.Equal(DecimalPrefix.Giga.Multiplier, Math.Pow(10, 9));
            Assert.Equal(DecimalPrefix.Tera.Multiplier, Math.Pow(10, 12));
            Assert.Equal(DecimalPrefix.Peta.Multiplier, Math.Pow(10, 15));
            Assert.Equal(DecimalPrefix.Exa.Multiplier, Math.Pow(10, 18));
            Assert.Equal(DecimalPrefix.Zetta.Multiplier, Math.Pow(10, 21));
            Assert.Equal(DecimalPrefix.Yotta.Multiplier, Math.Pow(10, 24));
            Assert.Equal(DecimalPrefix.Ronna.Multiplier, Math.Pow(10, 27));
            Assert.Equal(DecimalPrefix.Quetta.Multiplier, Math.Pow(10, 30));
        }

        [Fact]
        public void DecimalPrefix_ShouldVerifySubMultiplePrefixConstants()
        {
            Assert.Equal(DecimalPrefix.Deci.Multiplier, Math.Pow(10, -1));
            Assert.Equal(DecimalPrefix.Centi.Multiplier, Math.Pow(10, -2));
            Assert.Equal(DecimalPrefix.Milli.Multiplier, Math.Pow(10, -3));
            Assert.Equal(DecimalPrefix.Micro.Multiplier, Math.Pow(10, -6));
            Assert.Equal(DecimalPrefix.Nano.Multiplier, Math.Pow(10, -9));
            Assert.Equal(DecimalPrefix.Pico.Multiplier, Math.Pow(10, -12));
            Assert.Equal(DecimalPrefix.Femto.Multiplier, Math.Pow(10, -15));
            Assert.Equal(DecimalPrefix.Atto.Multiplier, Math.Pow(10, -18));
            Assert.Equal(DecimalPrefix.Zepto.Multiplier, Math.Pow(10, -21));
            Assert.Equal(DecimalPrefix.Yocto.Multiplier, Math.Pow(10, -24));
            Assert.Equal(DecimalPrefix.Ronto.Multiplier, Math.Pow(10, -27));
            Assert.Equal(DecimalPrefix.Quecto.Multiplier, Math.Pow(10, -30));
        }
    }
}
