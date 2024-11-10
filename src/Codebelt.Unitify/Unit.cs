using Cuemon;
using System;

namespace Codebelt.Unitify
{
    /// <summary>
    /// Represents the base class from which all implementations of a unit of measure should derive.
    /// </summary>
    /// <seealso cref="IUnit" />
    public abstract partial class Unit : IUnit, IEquatable<IUnit>
    {
        /// <summary>
        /// Performs an implicit conversion from <see cref="Unit"/> to <see cref="double"/>.
        /// </summary>
        /// <param name="unit">The <see cref="Unit"/> to convert.</param>
        /// <returns>A <see cref="double"/> that is equivalent to <paramref name="unit"/>.</returns>
        public static implicit operator double(Unit unit)
        {
            return unit.Value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Unit"/> class.
        /// </summary>
        /// <param name="baseUnit">The base unit of measure.</param>
        /// <param name="value">The value of this unit expressed as bytes.</param>
        /// <param name="setup">The <see cref="UnitFormatOptions"/> which may be configured.</param>
        protected Unit(IBaseUnit baseUnit, double value, Action<UnitFormatOptions> setup = null)
        {
            Validator.ThrowIfNull(baseUnit);
            Validator.ThrowIfLowerThan(value, 0, nameof(value));
            Validator.ThrowIfInvalidConfigurator(setup, out var options);

            Category = baseUnit.Category;
            Name = baseUnit.Name;
            Symbol = baseUnit.Symbol;
            Value = value;
            FormatOptions = options;
        }

        /// <summary>
        /// Gets the category of unit.
        /// </summary>
        /// <value>The category of the unit.</value>
        public string Category { get; }

        /// <summary>
        /// Gets the name of this unit.
        /// </summary>
        /// <value>The name of this unit.</value>
        public string Name { get; }

        /// <summary>
        /// Gets the symbol of this unit.
        /// </summary>
        /// <value>The symbol of this unit.</value>
        public string Symbol { get; }

        /// <summary>
        /// Gets the value of this unit expressed as bytes.
        /// </summary>
        /// <value>The value of this unit.</value>
        public double Value { get; }

        /// <summary>
        /// Gets the format options of the unit.
        /// </summary>
        /// <value>The format options of the unit.</value>
        public UnitFormatOptions FormatOptions { get; protected set; }

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns><c>true</c> if the current object is equal to the <paramref name="other"/> parameter; otherwise, <c>false</c>. </returns>
        public virtual bool Equals(IUnit other)
        {
            if (other == null) { return false; }
            return Category.Equals(other.Category, StringComparison.Ordinal) &&
                   Name.Equals(other.Name, StringComparison.Ordinal) &&
                   Symbol.Equals(other.Symbol, StringComparison.Ordinal) &&
                   Value.Equals(other.Value);
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns><c>true</c> if the specified object is equal to the current object; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if (obj is IUnit otherUnit) { return Equals(otherUnit); }
            return false;
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        public override int GetHashCode()
        {
            return Generate.HashCode32(Category, Name, Symbol, Value);
        }

        /// <summary>
        /// Returns a <see cref="string" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="string" /> that represents this instance.</returns>
        public override string ToString()
        {
            var formatter = new UnitFormatter();
            var format = FormatOptions.Style == NamingStyle.Symbol
                ? $"{FormatOptions.NumberFormat} {Symbol}"
                : $"{FormatOptions.NumberFormat} {Name}";
            format = FormatOptions.Style == NamingStyle.Compound
                ? $"{format} X"
                : format;
            return formatter.Format(format, this, FormatOptions.FormatProvider);
        }
    }
}
