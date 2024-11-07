using System;

namespace Codebelt.Unitify
{
    /// <summary>
    /// Defines a unit of measure that is used as a standard for measurement of the same kind of quantity.
    /// </summary>
    /// <seealso cref="IEquatable{IUnit}" />
    public interface IUnit : IBaseUnit
    {
        /// <summary>
        /// Gets the base value of the unit.
        /// </summary>
        /// <value>The base value of the unit.</value>
        double Value { get; }

        /// <summary>
        /// Gets the format options of the unit.
        /// </summary>
        /// <value>The format options of the unit.</value>
        UnitFormatOptions FormatOptions { get; }
    }
}
