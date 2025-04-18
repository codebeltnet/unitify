﻿using System;
using System.Collections.Generic;
using Cuemon;

namespace Codebelt.Unitify
{
    /// <summary>
    /// Defines a binary unit prefix for multiples of measurement for data that refers strictly to powers of 2. This class cannot be inherited.
    /// </summary>
    /// <seealso cref="Prefix" />
    public sealed class BinaryPrefix : Prefix
    {
        /// <summary>
        /// Defines how many bits is needed for one byte.
        /// </summary>
        public const int BitsPerByte = 8;

        /// <summary>
        /// Defines how many bits is needed for one nibble (one hexadecimal digit).
        /// </summary>
        public const int BitsPerNibble = BitsPerByte / 2;

        /// <summary>
        /// Converts a value in bits to bytes.
        /// </summary>
        /// <param name="bits">The value in bits to convert.</param>
        /// <returns>The equivalent value in bytes.</returns>
        public static double ConvertBitsToBytes(double bits)
        {
            if (bits < BitsPerByte) { bits = BitsPerByte; }
            return bits / BitsPerByte;
        }

        /// <summary>
        /// Converts a value in bytes to bits.
        /// </summary>
        /// <param name="bytes">The value in bytes to convert.</param>
        /// <returns>The equivalent value in bits.</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="bytes"/> is less than 0.
        /// </exception>
        public static double ConvertBytesToBits(double bytes)
        {
            Validator.ThrowIfLowerThan(bytes, 0, nameof(bytes));
            return Math.Ceiling(bytes * BitsPerByte);
        }

        private static readonly Lazy<IEnumerable<BinaryPrefix>> LazyPrefixes = new(() =>
        {
            var list = new List<BinaryPrefix>()
            {
                Exbi,
                Gibi,
                Kibi,
                Mebi,
                Pebi,
                Tebi,
                Yobi,
                Zebi
            };
            return list;
        });

        /// <summary>
        /// Gets the binary-multiple prefix kibi (symbol 'Ki'), 2^10 = 1024.
        /// </summary>
        /// <value>The binary-multiple prefix kibi (symbol 'Ki').</value>
        public static BinaryPrefix Kibi => new("kibi", "Ki", 10);

        /// <summary>
        /// Gets the binary-multiple prefix mebi (symbol 'Mi'), 2^20 = 1048576.
        /// </summary>
        /// <value>The binary-multiple prefix mebi (symbol 'Mi').</value>
        public static BinaryPrefix Mebi => new("mebi", "Mi", 20);

        /// <summary>
        /// Gets the binary-multiple prefix gibi (symbol 'Gi'), 2^30 = 1073741824.
        /// </summary>
        /// <value>The binary-multiple prefix gibi (symbol 'Gi').</value>
        public static BinaryPrefix Gibi => new("gibi", "Gi", 30);

        /// <summary>
        /// Gets the binary-multiple prefix tebi (symbol 'Ti'), 2^40 = 1099511627776.
        /// </summary>
        /// <value>The binary-multiple prefix tebi (symbol 'Ti').</value>
        public static BinaryPrefix Tebi => new("tebi", "Ti", 40);

        /// <summary>
        /// Gets the binary-multiple prefix pebi (symbol 'Pi'), 2^50 = 1125899906842624.
        /// </summary>
        /// <value>The binary-multiple prefix pebi (symbol 'Pi').</value>
        public static BinaryPrefix Pebi => new("pebi", "Pi", 50);

        /// <summary>
        /// Gets the binary-multiple prefix exbi (symbol 'Ei'), 2^60 = 1152921504606846976.
        /// </summary>
        /// <value>The binary-multiple prefix exbi (symbol 'Ei').</value>
        public static BinaryPrefix Exbi => new("exbi", "Ei", 60);

        /// <summary>
        /// Gets the binary-multiple prefix zebi (symbol 'Zi'), 2^70 = 1180591620717411303424.
        /// </summary>
        /// <value>The binary-multiple prefix zebi (symbol 'Zi').</value>
        public static BinaryPrefix Zebi => new("zebi", "Zi", 70);

        /// <summary>
        /// Gets the binary-multiple prefix yobi (symbol 'Yi'), 2^80 = 1208925819614629174706176.
        /// </summary>
        /// <value>The binary-multiple prefix yobi (symbol 'Yi').</value>
        public static BinaryPrefix Yobi => new("yobi", "Yi", 80);

        /// <summary>
        /// Gets the complete sequence of multiples binary prefixes as specified by Institute of Electrical and Electronics Engineers (IEEE).
        /// </summary>
        /// <value>The complete sequence of multiples binary prefixes as specified by Institute of Electrical and Electronics Engineers (IEEE).</value>
        public static IEnumerable<BinaryPrefix> BinaryPrefixes => LazyPrefixes.Value;

        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryPrefix"/> class.
        /// </summary>
        /// <param name="name">The name of the binary prefix.</param>
        /// <param name="symbol">The symbol of the binary prefix.</param>
        /// <param name="exponent">The number that specifies a power.</param>
        public BinaryPrefix(string name, string symbol, double exponent) : base(name, symbol, 2, exponent)
        {
        }
    }
}
