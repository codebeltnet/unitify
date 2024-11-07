using System;
using Cuemon;

namespace Codebelt.Unitify
{
    /// <summary>
    /// Extension methods for the <see cref="IPrefixUnit"/> interfacce.
    /// </summary>
    public static class PrefixUnitExtensions
    {
        /// <summary>
        /// Converts the value of a <paramref name="unit"/> to its prefix equivalent.
        /// </summary>
        /// <param name="unit">The <see cref="IPrefixUnit"/> to extend.</param>
        /// <returns>A <see cref="double"/> that represents a unit prefix value.</returns>
        public static double ToPrefixValue(this IPrefixUnit unit)
        {
            Validator.ThrowIfNull(unit);
            return unit.Prefix.ToPrefixValue(unit.Value);
        }

        /// <summary>
        /// Converts the value of a <paramref name="unit"/> to its base equivalent.
        /// </summary>
        /// <param name="unit">The <see cref="IPrefixUnit"/> to extend.</param>
        /// <returns>A <see cref="double"/> that represents a unit base value.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="unit"/> cannot be null.
        /// </exception>
        public static double ToBaseValue(this IPrefixUnit unit)
        {
            Validator.ThrowIfNull(unit);
            return unit.Prefix.ToBaseValue(unit.Value);
        }

        /// <summary>
        /// Converts the <paramref name="unit"/> to its base unit equivalent.
        /// </summary>
        /// <param name="unit">The <see cref="IPrefixUnit"/> to extend.</param>
        /// <returns>An <see cref="IUnit"/> that represents the base unit equivalent of the specified <paramref name="unit"/>.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="unit"/> cannot be null.
        /// </exception>
        public static IUnit ToBaseUnit(this IPrefixUnit unit)
        {
            Validator.ThrowIfNull(unit);
            return new PrefixUnit(unit, unit.Prefix.ToBaseValue(unit.Value));
        }

        /// <summary>
        /// Converts the <paramref name="unit"/> to its prefix string representation.
        /// </summary>
        /// <param name="unit">The <see cref="IPrefixUnit"/> to extend.</param>
        /// <returns>A <see cref="string"/> that represents that represents the first prefix greater or equal to one of the specified <paramref name="unit"/>.</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="unit"/> is not a Decimal (10) or Binary (2) prefix.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="unit"/> cannot be null.
        /// </exception>
        public static string ToPrefixString(this IPrefixUnit unit)
        {
            Validator.ThrowIfNull(unit);
            if (unit.Prefix.Base.Equals(0)) { return unit.ToString(); }
            if (unit.Prefix.Base.Equals(10))
            {
                var metric = new MetricPrefixTable(unit);
                return metric.ToString();
            }
            else if (unit.Prefix.Base.Equals(2))
            {
                var data = new DataPrefixTable(unit);
                return data.ToString();
            }
            throw new ArgumentOutOfRangeException(nameof(unit), unit.Prefix.Base, "Only Decimal (10) and Binary (2) is supported for now.");
        }

        /// <summary>
        /// Converts the <paramref name="unit"/> to a <see cref="MetricPrefixTable"/> representation.
        /// </summary>
        /// <param name="unit">The <see cref="IPrefixUnit"/> to extend.</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="unit"/> cannot be null.
        /// </exception>
        public static MetricPrefixTable ToMetricPrefixTable(this IPrefixUnit unit)
        {
            Validator.ThrowIfNull(unit);
            return new MetricPrefixTable(unit);
        }

        /// <summary>
        /// Converts the <paramref name="unit"/> to a <see cref="DataPrefixTable"/> representation.
        /// </summary>
        /// <param name="unit">The <see cref="IPrefixUnit"/> to extend.</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="unit"/> cannot be null.
        /// </exception>
        public static DataPrefixTable ToDataPrefixTable(this IPrefixUnit unit)
        {
            Validator.ThrowIfNull(unit);
            return new DataPrefixTable(unit);
        }
    }
}
