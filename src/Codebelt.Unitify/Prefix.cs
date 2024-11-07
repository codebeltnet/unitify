using System;
using System.Globalization;

namespace Codebelt.Unitify
{
    /// <summary>
    /// Represents the base class from which all implementations of unit prefix that can can be expressed as either a multiple or a submultiple should derive.
    /// </summary>
    /// <seealso cref="IPrefix" />
    public abstract class Prefix : IPrefix
    {
        /// <summary>
        /// Defines a prefix multiple of none (0).
        /// </summary>
        public static readonly IPrefix None = new ZeroPrefix();

        /// <summary>
        /// Initializes a new instance of the <see cref="Prefix"/> class.
        /// </summary>
        /// <param name="name">The name of the binary unit.</param>
        /// <param name="symbol">The symbol of the unit prefix.</param>
        /// <param name="base">The number to be raised to a power.</param>
        /// <param name="exponent">The number that specifies a power.</param>
        protected Prefix(string name, string symbol, double @base, double exponent)
        {
            Name = name;
            Symbol = symbol;
            Base = @base;
            Multiplier = Math.Pow(@base, exponent);
            Exponent = exponent;
        }

        /// <summary>
        /// Gets the name of the unit prefix.
        /// </summary>
        /// <value>The name of the unit prefix.</value>
        public string Name { get; }

        /// <summary>
        /// Gets the symbol of the unit prefix.
        /// </summary>
        /// <value>The symbol of the unit prefix.</value>
        public string Symbol { get; }

        /// <summary>
        /// Gets the unit prefix multiplier.
        /// </summary>
        /// <value>The unit prefix multiplier.</value>
        public double Multiplier { get; }

        /// <summary>
        /// Gets the number to be raised of the unit prefix.
        /// </summary>
        /// <value>The number to be raised of the unit prefix.</value>
        public double Base { get; }

        /// <summary>
        /// Gets the exponent of the unit prefix.
        /// </summary>
        /// <value>The exponent of the unit prefix.</value>
        public double Exponent { get; }

        /// <summary>
        /// Converts the unit base <paramref name="value"/> to a unit prefix value.
        /// </summary>
        /// <param name="value">The value of the base unit.</param>
        /// <returns>A <see cref="double"/> that represents a unit prefix value.</returns>
        public double ToPrefixValue(double value)
        {
            return value / Multiplier;
        }

        /// <summary>
        /// Converts the unit <paramref name="prefixValue"/> back to a unit base value.
        /// </summary>
        /// <param name="prefixValue">The value of the unit prefix.</param>
        /// <returns>A <see cref="double"/> that represents a unit base value.</returns>
        public double ToBaseValue(double prefixValue)
        {
            return prefixValue * Multiplier;
        }

        /// <summary>
        /// Returns a <see cref="string" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="string" /> that represents this instance.</returns>
        public override string ToString()
        {
            return string.Create(CultureInfo.InvariantCulture, $"{Name} ({Symbol}) {Base}^{Math.Log(Multiplier, Base)}");
        }
    }
}
