using Cuemon;
using System;

namespace Codebelt.Unitify
{
    /// <summary>
    /// Represents a base unit of measurement, including its category, name, and symbol.
    /// </summary>
    /// <seealso cref="IBaseUnit" />
    public readonly struct BaseUnit : IBaseUnit, IEquatable<IBaseUnit>
    {
        /// <summary>
        /// Determines whether two specified instances of <see cref="BaseUnit"/> are equal.
        /// </summary>
        /// <param name="left">The first <see cref="BaseUnit"/> to compare.</param>
        /// <param name="right">The second <see cref="BaseUnit"/> to compare.</param>
        /// <returns><c>true</c> if the two <see cref="BaseUnit"/> instances are equal; otherwise, <c>false</c>.</returns>
        public static bool operator ==(BaseUnit left, BaseUnit right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Determines whether two specified instances of <see cref="BaseUnit"/> are not equal.
        /// </summary>
        /// <param name="left">The first <see cref="BaseUnit"/> to compare.</param>
        /// <param name="right">The second <see cref="BaseUnit"/> to compare.</param>
        /// <returns><c>true</c> if the two <see cref="BaseUnit"/> instances are not equal; otherwise, <c>false</c>.</returns>
        public static bool operator !=(BaseUnit left, BaseUnit right)
        {
            return !(left == right);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseUnit"/> class.
        /// </summary>
        /// <param name="category">The category of the base unit.</param>
        /// <param name="name">The name of the base unit.</param>
        /// <param name="symbol">The symbol of the base unit.</param>
        public BaseUnit(string category, string name, string symbol)
        {
            Validator.ThrowIfNullOrWhitespace(category);
            Validator.ThrowIfNullOrWhitespace(name);
            Validator.ThrowIfNullOrWhitespace(symbol);

            Category = category;
            Name = name;
            Symbol = symbol;
        }

        /// <summary>
        /// Gets the category of the base unit.
        /// </summary>
        /// <value>The category of the base unit.</value>
        public string Category { get; }

        /// <summary>
        /// Gets the name of the base unit.
        /// </summary>
        /// <value>The name of the base unit.</value>
        public string Name { get; }

        /// <summary>
        /// Gets the symbol of the base unit.
        /// </summary>
        /// <value>The symbol of the base unit.</value>
        public string Symbol { get; }

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns><c>true</c> if the current object is equal to the <paramref name="other"/> parameter; otherwise, <c>false</c>. </returns>
        public bool Equals(IBaseUnit other)
        {
            if (other == null) { return false; }
            return Category.Equals(other.Category, StringComparison.Ordinal) &&
                   Name.Equals(other.Name, StringComparison.Ordinal) &&
                   Symbol.Equals(other.Symbol, StringComparison.Ordinal);
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns><c>true</c> if the specified object is equal to the current object; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if (obj is IBaseUnit otherUnit) { return Equals(otherUnit); }
            return false;
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        public override int GetHashCode()
        {
            return Generate.HashCode32(Category, Name, Symbol);
        }
    }
}
