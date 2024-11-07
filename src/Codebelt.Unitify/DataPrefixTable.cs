using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cuemon;

namespace Codebelt.Unitify
{
    /// <summary>
    /// Represents a table of both binary and metric prefixes for units of measure, optimized for data quantity and transmission measurement standards.
    /// </summary>
    /// <seealso cref="PrefixTable" />
    public class DataPrefixTable : PrefixTable
    {
        /// <summary>
        /// The default number format used for displaying values related to <see cref="DataPrefixTable"/>.
        /// </summary>
        public const string DefaultNumberFormat = "#,##0.##";

        /// <summary>
        /// Creates a new instance of <see cref="DataPrefixTable"/> initialized with <paramref name="value"/>.
        /// </summary>
        /// <param name="value">The <see cref="double"/> to convert.</param>
        /// <param name="setup">The <see cref="UnitFormatOptions"/> which may be configured.</param>
        /// <returns>A <see cref="DataPrefixTable"/> that is equivalent to <paramref name="value"/> with a base unit of <see cref="Unit.Bit"/>.</returns>
        public static DataPrefixTable CreateBitTableFromBytes(double value, Action<UnitFormatOptions> setup = null)
        {
            Validator.ThrowIfLowerThan(value, 0, nameof(value));
            return CreateBitTableFromBits(BinaryPrefix.ConvertBytesToBits(value), setup);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DataPrefixTable"/> initialized with <paramref name="value"/>.
        /// </summary>
        /// <param name="value">The <see cref="double"/> to convert.</param>
        /// <param name="setup">The <see cref="UnitFormatOptions"/> which may be configured.</param>
        /// <returns>A <see cref="DataPrefixTable"/> that is equivalent to <paramref name="value"/> with a base unit of <see cref="Unit.Bit"/>.</returns>
        public static DataPrefixTable CreateBitTableFromBits(double value, Action<UnitFormatOptions> setup = null)
        {
            Validator.ThrowIfLowerThan(value, 0, nameof(value));
            return new DataPrefixTable(UnitFactory.CreateBit(value, Prefix.None, setup ?? (o => o.NumberFormat = DefaultNumberFormat)));
        }

        /// <summary>
        /// Creates a new instance of <see cref="DataPrefixTable"/> initialized with <paramref name="value"/>.
        /// </summary>
        /// <param name="value">The <see cref="double"/> to convert.</param>
        /// <param name="setup">The <see cref="UnitFormatOptions"/> which may be configured.</param>
        /// <returns>A <see cref="DataPrefixTable"/> that is equivalent to <paramref name="value"/> with a base unit of <see cref="Unit.Byte"/>.</returns>
        public static DataPrefixTable CreateByteTableFromBits(double value, Action<UnitFormatOptions> setup = null)
        {
            Validator.ThrowIfLowerThan(value, 0, nameof(value));
            return CreateByteTableFromBytes(BinaryPrefix.ConvertBitsToBytes(value), setup);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DataPrefixTable"/> initialized with <paramref name="value"/>.
        /// </summary>
        /// <param name="value">The <see cref="double"/> to convert.</param>
        /// <param name="setup">The <see cref="UnitFormatOptions"/> which may be configured.</param>
        /// <returns>A <see cref="DataPrefixTable"/> that is equivalent to <paramref name="value"/> with a base unit of <see cref="Unit.Byte"/>.</returns>
        public static DataPrefixTable CreateByteTableFromBytes(double value, Action<UnitFormatOptions> setup = null)
        {
            Validator.ThrowIfLowerThan(value, 0, nameof(value));
            return new DataPrefixTable(UnitFactory.CreateByte(value, Prefix.None, setup ?? (o => o.NumberFormat = DefaultNumberFormat)));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPrefixTable"/> class.
        /// </summary>
        /// <param name="unit">The instance of an object that implements the <see cref="IUnit"/> interface.</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="unit"/> cannot be null.
        /// </exception>
        public DataPrefixTable(IUnit unit) : base(unit)
        {
            Validator.ThrowIfFalse(Unit.Bit.Equals(unit) ||
                                   Unit.Byte.Equals(unit) ||
                                   Unit.BitPerSecond.Equals(unit), nameof(unit), $"Value is not in a valid state; {nameof(unit)} must be in the Data category.");
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection of prefixes.
        /// </summary>
        /// <returns>An enumerator that can be used to iterate through the collection of prefixes.</returns>
        public override IEnumerator<IPrefixUnit> GetEnumerator()
        {
            return DecimalPrefix.MetricPrefixes
                .Where(p => p.Exponent is >= 3 and <= 15)
                .Select(p => p.ApplyUnit(BaseUnit))
                .Concat(BinaryPrefix.BinaryPrefixes
                    .Where(p => p.Exponent is >= 10 and <= 50)
                    .Select(p => p.ApplyUnit(BaseUnit)))
                .OrderBy(p => p.Value)
                .GetEnumerator();
        }

        /// <summary>
        /// Returns a <see cref="string" /> that represents the largest multiple prefix of this instance.
        /// </summary>
        /// <returns>A <see cref="string" /> that represents the largest multiple prefix of this instance.</returns>
        /// <remarks>Evaluates the largest multiple prefix that is greater or equal to 1 and returns it formatted as <see cref="PrefixStyle.Binary"/>.</remarks>
        public override string ToString()
        {
            return ToString(PrefixStyle.Binary);
        }

        /// <summary>
        /// Returns a <see cref="string" /> that represents the largest multiple prefix of this instance.
        /// </summary>
        /// <param name="prefixStyle">The preferred unit prefix style for formatting.</param>
        /// <returns>A <see cref="string" /> that represents the largest multiple prefix of this instance.</returns>
        /// <remarks>Evaluates the largest metric-multiple prefix that is greater or equal to 1 and returns it formatted as either <see cref="PrefixStyle.Binary" /> or <see cref="PrefixStyle.Decimal" />.</remarks>
        public string ToString(PrefixStyle prefixStyle)
        {
            IPrefixUnit prefix = null;
            if (prefixStyle == PrefixStyle.Binary)
            {
                prefix = this.FirstOrDefault(p => p.Value >= 1 && p.Prefix is BinaryPrefix);
            }
            else if (prefixStyle == PrefixStyle.Decimal)
            {
                prefix = this.FirstOrDefault(p => p.Value >= 1 && p.Prefix is DecimalPrefix);
            }

            return prefix?.ToString() ?? BaseUnit.ToString();
        }

        /// <summary>
        /// Returns an aggregated <see cref="string" /> of all multiple prefixes of this instance.
        /// </summary>
        /// <param name="includeBinary">If set to <c>true</c>, includes all binary-multiple prefixes in the aggregate.</param>
        /// <param name="includeDecimal">If set to <c>true</c>, includes all metric-multiple prefixes in the aggregate.</param>
        /// <param name="includeUnit">If set to <c>true</c>, includes the base unit in the aggregate.</param>
        /// <returns>An aggregated <see cref="string" /> of all multiple prefixes of this instance.</returns>
        public string ToAggregateString(bool includeBinary = true, bool includeDecimal = true, bool includeUnit = true)
        {
            var sb = new StringBuilder();

            if (includeBinary)
            {
                foreach (var prefix in this.Where(p => p.Prefix is BinaryPrefix))
                {
                    sb.AppendLine(prefix.ToString());
                }
            }

            if (includeUnit) { sb.AppendLine(BaseUnit.ToString()); }

            if (includeDecimal)
            {
                foreach (var prefix in this.Where(p => p.Prefix is DecimalPrefix))
                {
                    sb.AppendLine(prefix.ToString());
                }
            }

            return sb.ToString();
        }
    }
}
