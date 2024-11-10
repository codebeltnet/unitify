using System;
using Cuemon;

namespace Codebelt.Unitify
{
    /// <summary>
    /// Represents the prefix of a unit of measurement.
    /// </summary>
    /// <seealso cref="Unit" />
    /// <seealso cref="IPrefixUnit" />
    public class PrefixUnit : Unit, IPrefixUnit
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrefixUnit"/> class.
        /// </summary>
        /// <param name="unit">The unit of measure to shallow copy to this instance.</param>
        /// <param name="prefix">The prefix to associate with this instance.</param>
        public PrefixUnit(IUnit unit, IPrefix prefix = null) : this(unit, unit?.Value ?? 0, prefix ?? Unitify.Prefix.None)
        {
            FormatOptions = unit?.FormatOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrefixUnit"/> class.
        /// </summary>
        /// <param name="baseUnit">The base unit of measurement.</param>
        /// <param name="value">The value of this unit.</param>
        /// <param name="prefix">The optional prefix to associate with this unit.</param>
        /// <param name="setup">The <see cref="UnitFormatOptions"/> which may be configured.</param>
        public PrefixUnit(IBaseUnit baseUnit, double value, IPrefix prefix = null, Action<UnitFormatOptions> setup = null) : base(baseUnit, Validator.CheckParameter(() =>
        {
            var optionalPrefix = prefix ?? Unitify.Prefix.None;
            return optionalPrefix == Unitify.Prefix.None
                ? value
                : optionalPrefix.ToPrefixValue(value);
        }), setup)
        {
            Prefix = prefix ?? Unitify.Prefix.None;
        }

        /// <summary>
        /// Gets the prefix multiple to this unit.
        /// </summary>
        /// <value>The prefix multiple to this unit.</value>
        public IPrefix Prefix { get; }

        /// <summary>
        /// Returns a <see cref="string" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="string" /> that represents this instance.</returns>
        public override string ToString()
        {
            var formatter = new PrefixUnitFormatter();
            var format = Prefix == Unitify.Prefix.None
                ? $"{FormatOptions.NumberFormat} {Symbol}"
                : $"{FormatOptions.NumberFormat} {Prefix.Symbol}{Symbol}";
            format = FormatOptions.Style == NamingStyle.Compound
                ? $"{format} X"
                : format;
            return formatter.Format(format, this, FormatOptions.FormatProvider);
        }
    }
}
