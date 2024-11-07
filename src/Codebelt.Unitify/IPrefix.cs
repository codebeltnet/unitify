namespace Codebelt.Unitify
{
    /// <summary>
    /// Defines a unit prefix that can can be expressed as a either a multiple or a submultiple of the unit of measurement.
    /// </summary>
    /// <seealso cref="Prefix"/>
    public interface IPrefix
    {
        /// <summary>
        /// Gets the name of the unit prefix.
        /// </summary>
        /// <value>The name of the unit prefix.</value>
        string Name { get; }

        /// <summary>
        /// Gets the symbol of the unit prefix.
        /// </summary>
        /// <value>The symbol of the unit prefix.</value>
        string Symbol { get; }

        /// <summary>
        /// Gets the unit prefix multiplier.
        /// </summary>
        /// <value>The unit prefix multiplier.</value>
        double Multiplier { get; }

        /// <summary>
        /// Gets the number to be raised of the unit prefix.
        /// </summary>
        /// <value>The number to be raised of the unit prefix.</value>
        double Base { get; }

        /// <summary>
        /// Gets the exponent of the unit prefix.
        /// </summary>
        /// <value>The exponent of the unit prefix.</value>
        double Exponent { get; }

        /// <summary>
        /// Converts the unit base <paramref name="value"/> to a unit prefix value.
        /// </summary>
        /// <param name="value">The value of the base unit.</param>
        /// <returns>A <see cref="double"/> that represents a unit prefix value.</returns>
        double ToPrefixValue(double value);

        /// <summary>
        /// Converts the <paramref name="prefixValue"/> back to a unit base value.
        /// </summary>
        /// <param name="prefixValue">The value of the unit prefix.</param>
        /// <returns>A <see cref="double"/> that represents a unit base value.</returns>
        double ToBaseValue(double prefixValue);
    }
}
