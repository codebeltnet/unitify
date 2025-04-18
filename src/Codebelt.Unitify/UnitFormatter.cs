﻿using System;
using Cuemon;

namespace Codebelt.Unitify
{
    /// <summary>
    /// Defines the string formatting of objects having an implementation of <see cref="IUnit"/>.
    /// </summary>
    /// <seealso cref="IFormatProvider" />
    /// <seealso cref="ICustomFormatter" />
    /// <seealso cref="IUnit"/>
    public class UnitFormatter : IFormatProvider, ICustomFormatter
    {
        /// <summary>
        /// Returns an object that provides formatting services for the specified type.
        /// </summary>
        /// <param name="formatType">An object that specifies the type of format object to return.</param>
        /// <returns>An instance of the object specified by <paramref name="formatType"/>, if the <see cref="IFormatProvider"/> implementation can supply that type of object; otherwise, null.</returns>
        public object GetFormat(Type formatType)
        {
            return formatType == typeof(ICustomFormatter) ? this : null;
        }

        /// <summary>
        /// Converts the value of a specified <paramref name="arg"/> to an equivalent string representation using specified <paramref name="format"/> and culture-specific format <paramref name="formatProvider"/>.
        /// </summary>
        /// <param name="format">A format string containing formatting specifications.</param>
        /// <param name="arg">An object that implements the <see cref="IUnit"/> interface.</param>
        /// <param name="formatProvider">An object that supplies format information about <paramref name="arg"/>.</param>
        /// <returns>The string representation of the value of <paramref name="arg"/>, formatted as specified by <paramref name="format"/> and <paramref name="formatProvider"/>.</returns>
        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            Validator.ThrowIfNull(format);
            var formats = format!.Split(' ');
            if (arg is IUnit baseUnit) { return FormatInterpreter(formats, baseUnit, formatProvider); }
            throw new InvalidOperationException($"Object is either null or does not implement {nameof(IUnit)}.");
        }

        private static string FormatInterpreter(string[] formats, IUnit unit, IFormatProvider provider)
        {
            if (formats.Length == 1) { return unit.Value.ToString(unit.FormatOptions.NumberFormat, provider); } // base unit
            var numberFormat = formats[0].Trim();
            var unitFormat = formats[1].Trim();
            var useCompoundFormat = formats[^1].Trim() == "X";
            return string.Format(provider, "{0} {1}", unit.Value.ToString(numberFormat, provider), useCompoundFormat ? $"{unit.Name}" : unitFormat);
        }
    }
}
