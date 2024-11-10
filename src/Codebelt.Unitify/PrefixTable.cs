using System;
using System.Collections;
using System.Collections.Generic;
using Cuemon;

namespace Codebelt.Unitify
{
    /// <summary>
    /// Represents a table of unit prefixes, indicating multiples or submultiples of a base unit.
    /// </summary>
    /// <seealso cref="IEquatable{IUnit}" />
    /// <seealso cref="IEnumerable{IPrefixUnit}"/>
    public abstract class PrefixTable : IEquatable<IUnit>, IEnumerable<IPrefixUnit>
    {
        /// <summary>
        /// Performs an implicit conversion from <see cref="PrefixTable"/> to <see cref="double"/>.
        /// </summary>
        /// <param name="mt">The <see cref="PrefixTable"/> to convert.</param>
        /// <returns>A <see cref="double"/> that is equivalent to <paramref name="mt"/>.</returns>
        public static implicit operator double(PrefixTable mt)
        {
            return mt.BaseUnit.Value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrefixTable"/> class.
        /// </summary>
        /// <param name="unit">The instance of an object that implements the <see cref="IUnit"/> interface.</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="unit"/> cannot be null.
        /// </exception>
        protected PrefixTable(IUnit unit)
        {
            Validator.ThrowIfNull(unit);
            BaseUnit = unit is IPrefixUnit pu &&
                       !pu.Prefix.Base.Equals(0)
                ? pu.ToBaseUnit()
                : unit;
        }

        /// <summary>
        /// Gets the base unit of this table.
        /// </summary>
        /// <value>The base unit of this table.</value>
        public IUnit BaseUnit { get; }

        /// <summary>
        /// Returns a <see cref="string" /> that represents largest metric-multiple prefix of this instance.
        /// </summary>
        /// <returns>A <see cref="string" /> that represents largest metric-multiple prefix of this instance.</returns>
        /// <remarks>Evaluates the largest metric-multiple prefix that is greater or equal to 1 and returns that as either <see cref="PrefixStyle.Binary"/> or <see cref="PrefixStyle.Decimal"/> formatted.</remarks>
        public override string ToString()
        {
            return BaseUnit.ToString();
        }

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns><c>true</c> if the current object is equal to the <paramref name="other"/> parameter; otherwise, <c>false</c>. </returns>
        public virtual bool Equals(IUnit other)
        {
            return BaseUnit.Equals(other);
        }

        /// <summary>
        /// Determines whether the specified <see cref="object" /> is equal to this instance.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns><c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            return obj is PrefixTable mt && BaseUnit.Equals(mt.BaseUnit);
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        public override int GetHashCode()
        {
            return BaseUnit.GetHashCode();
        }

        /// <summary>
        /// Returns an enumerator that iterates through the multiples and/or submultiples of the base unit.
        /// </summary>
        /// <returns>An enumerator that can be used to iterate through multiples and/or submultiples of the base unit.</returns>
        public abstract IEnumerator<IPrefixUnit> GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
