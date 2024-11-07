using System;
using Cuemon;

namespace Codebelt.Unitify
{
    /// <summary>
    /// Extension methods for the <see cref="IPrefix"/> interface.
    /// </summary>
    public static class PrefixExtensions
    {
        /// <summary>
        /// Converts the specified <see cref="IPrefix"/> to an <see cref="IUnit"/> implementation equivalent.
        /// </summary>
        /// <param name="multiple">The <see cref="IPrefix"/> to extend.</param>
        /// <param name="unit">The unit of measurement that is used as a standard for measurement of the same kind of quantity.</param>
        /// <returns>An <see cref="IPrefixUnit"/> implementation.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="unit"/> is null.
        /// </exception>
        public static IPrefixUnit ApplyUnit(this IPrefix multiple, IUnit unit)
        {
            Validator.ThrowIfNull(unit);
            return new PrefixUnit(unit, multiple);
        }

        /// <summary>
        /// Converts the specified <see cref="IPrefix"/> to a base unit.
        /// </summary>
        /// <param name="multiple">The <see cref="IPrefix"/> to extend.</param>
        /// <param name="baseUnit">The base unit of measurement.</param>
        /// <param name="value">The value of the base unit.</param>
        /// <returns>An <see cref="IUnit"/> implementation.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="multiple"/> is null -or-
        /// <paramref name="baseUnit"/> is null.
        /// </exception>
        public static IUnit ToBaseUnit(this IPrefix multiple, IBaseUnit baseUnit, double value)
        {
            Validator.ThrowIfNull(multiple);
            Validator.ThrowIfNull(baseUnit);
            return new PrefixUnit(baseUnit, multiple.ToBaseValue(value));
        }
    }
}
