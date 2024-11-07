using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codebelt.Unitify
{
    /// <summary>
    /// Represents a table of metric unit prefixes, indicating multiples and submultiples of a base unit.
    /// </summary>
    public class MetricPrefixTable : PrefixTable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetricPrefixTable"/> class.
        /// </summary>
        /// <param name="unit">The instance of an object that implements the <see cref="IUnit" /> interface.</param>
        public MetricPrefixTable(IUnit unit) : base(unit)
        {
        }

        /// <summary>
        /// Returns an enumerator that iterates through the multiples and submultiples of the base unit.
        /// </summary>
        /// <returns>An enumerator that can be used to iterate through multiples and submultiples of the base unit.</returns>
        public override IEnumerator<IPrefixUnit> GetEnumerator()
        {
            return DecimalPrefix.MetricPrefixes
                .Select(p => p.ApplyUnit(BaseUnit))
                .OrderBy(p => p.Value)
                .GetEnumerator();
        }

        /// <summary>
        /// Returns a <see cref="string" /> that represents the first prefix greater or equal to one of this instance.
        /// </summary>
        /// <returns>A <see cref="string" /> that represents the first prefix greater or equal to one of this instance.</returns>
        public override string ToString()
        {
            var prefix = this.FirstOrDefault(p => p.Value >= 1);
            return prefix?.ToString() ?? BaseUnit.ToString();
        }

        /// <summary>
        /// Returns an aggregated <see cref="string" /> of all multiple and sub-multiple prefix of this instance.
        /// </summary>
        /// <param name="includeMultiples">if set to <c>true</c> all multiple prefix is included in the aggregate.</param>
        /// <param name="includeSubmultiples">if set to <c>true</c> all submultiple prefix is included in the aggregate.</param>
        /// <param name="includeUnit">if set to <c>true</c> the base unit is included in the aggregate.</param>
        /// <returns>An aggregated <see cref="string" /> of all multiple and sub-multiple prefix of this instance.</returns>
        public string ToAggregateString(bool includeMultiples = true, bool includeSubmultiples = true, bool includeUnit = true)
        {
            var sb = new StringBuilder();

            if (includeMultiples)
            {
                foreach (var prefix in this.Where(p => p.Prefix.Exponent >= 1))
                {
                    sb.AppendLine(prefix.ToString());
                }
            }

            if (includeUnit) { sb.AppendLine(BaseUnit.ToString()); }

            if (includeSubmultiples)
            {
                foreach (var prefix in this.Where(p => p.Prefix.Exponent <= -1))
                {
                    sb.AppendLine(prefix.ToString());
                }
            }

            return sb.ToString();
        }
    }
}
