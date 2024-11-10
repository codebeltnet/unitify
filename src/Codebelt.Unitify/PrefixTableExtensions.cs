using System.Linq;

namespace Codebelt.Unitify
{
    /// <summary>
    /// Extension methods for the <see cref="PrefixTable"/> class.
    /// </summary>
    public static class PrefixTableExtensions
    {
        /// <summary>
        /// Returns the unit with the Quecto prefix or the default value if not found.
        /// </summary>
        /// <param name="prefixes">The table of multiple units.</param>
        /// <returns>The unit with the Quecto prefix or the default value.</returns>
        public static IPrefixUnit QuectoOrDefault(this PrefixTable prefixes)
        {
            return prefixes.SingleOrDefault(p => p.Prefix.Symbol == DecimalPrefix.Quecto.Symbol);
        }

        /// <summary>
        /// Returns the unit with the Ronto prefix or the default value if not found.
        /// </summary>
        /// <param name="prefixes">The table of multiple units.</param>
        /// <returns>The unit with the Ronto prefix or the default value.</returns>
        public static IPrefixUnit RontoOrDefault(this PrefixTable prefixes)
        {
            return prefixes.SingleOrDefault(p => p.Prefix.Symbol == DecimalPrefix.Ronto.Symbol);
        }

        /// <summary>
        /// Returns the unit with the Yocto prefix or the default value if not found.
        /// </summary>
        /// <param name="prefixes">The table of multiple units.</param>
        /// <returns>The unit with the Yocto prefix or the default value.</returns>
        public static IPrefixUnit YoctoOrDefault(this PrefixTable prefixes)
        {
            return prefixes.SingleOrDefault(p => p.Prefix.Symbol == DecimalPrefix.Yocto.Symbol);
        }

        /// <summary>
        /// Returns the unit with the Zepto prefix or the default value if not found.
        /// </summary>
        /// <param name="prefixes">The table of multiple units.</param>
        /// <returns>The unit with the Zepto prefix or the default value.</returns>
        public static IPrefixUnit ZeptoOrDefault(this PrefixTable prefixes)
        {
            return prefixes.SingleOrDefault(p => p.Prefix.Symbol == DecimalPrefix.Zepto.Symbol);
        }

        /// <summary>
        /// Returns the unit with the Atto prefix or the default value if not found.
        /// </summary>
        /// <param name="prefixes">The table of multiple units.</param>
        /// <returns>The unit with the Atto prefix or the default value.</returns>
        public static IPrefixUnit AttoOrDefault(this PrefixTable prefixes)
        {
            return prefixes.SingleOrDefault(p => p.Prefix.Symbol == DecimalPrefix.Atto.Symbol);
        }

        /// <summary>
        /// Returns the unit with the Femto prefix or the default value if not found.
        /// </summary>
        /// <param name="prefixes">The table of multiple units.</param>
        /// <returns>The unit with the Femto prefix or the default value.</returns>
        public static IPrefixUnit FemtoOrDefault(this PrefixTable prefixes)
        {
            return prefixes.SingleOrDefault(p => p.Prefix.Symbol == DecimalPrefix.Femto.Symbol);
        }

        /// <summary>
        /// Returns the unit with the Pico prefix or the default value if not found.
        /// </summary>
        /// <param name="prefixes">The table of multiple units.</param>
        /// <returns>The unit with the Pico prefix or the default value.</returns>
        public static IPrefixUnit PicoOrDefault(this PrefixTable prefixes)
        {
            return prefixes.SingleOrDefault(p => p.Prefix.Symbol == DecimalPrefix.Pico.Symbol);
        }

        /// <summary>
        /// Returns the unit with the Nano prefix or the default value if not found.
        /// </summary>
        /// <param name="prefixes">The table of multiple units.</param>
        /// <returns>The unit with the Nano prefix or the default value.</returns>
        public static IPrefixUnit NanoOrDefault(this PrefixTable prefixes)
        {
            return prefixes.SingleOrDefault(p => p.Prefix.Symbol == DecimalPrefix.Nano.Symbol);
        }

        /// <summary>
        /// Returns the unit with the Micro prefix or the default value if not found.
        /// </summary>
        /// <param name="prefixes">The table of multiple units.</param>
        /// <returns>The unit with the Micro prefix or the default value.</returns>
        public static IPrefixUnit MicroOrDefault(this PrefixTable prefixes)
        {
            return prefixes.SingleOrDefault(p => p.Prefix.Symbol == DecimalPrefix.Micro.Symbol);
        }

        /// <summary>
        /// Returns the unit with the Milli prefix or the default value if not found.
        /// </summary>
        /// <param name="prefixes">The table of multiple units.</param>
        /// <returns>The unit with the Milli prefix or the default value.</returns>
        public static IPrefixUnit MilliOrDefault(this PrefixTable prefixes)
        {
            return prefixes.SingleOrDefault(p => p.Prefix.Symbol == DecimalPrefix.Milli.Symbol);
        }

        /// <summary>
        /// Returns the unit with the Centi prefix or the default value if not found.
        /// </summary>
        /// <param name="prefixes">The table of multiple units.</param>
        /// <returns>The unit with the Centi prefix or the default value.</returns>
        public static IPrefixUnit CentiOrDefault(this PrefixTable prefixes)
        {
            return prefixes.SingleOrDefault(p => p.Prefix.Symbol == DecimalPrefix.Centi.Symbol);
        }

        /// <summary>
        /// Returns the unit with the Deci prefix or the default value if not found.
        /// </summary>
        /// <param name="prefixes">The table of multiple units.</param>
        /// <returns>The unit with the Deci prefix or the default value.</returns>
        public static IPrefixUnit DeciOrDefault(this PrefixTable prefixes)
        {
            return prefixes.SingleOrDefault(p => p.Prefix.Symbol == DecimalPrefix.Deci.Symbol);
        }

        /// <summary>
        /// Returns the unit with the Deca prefix or the default value if not found.
        /// </summary>
        /// <param name="prefixes">The table of multiple units.</param>
        /// <returns>The unit with the Deca prefix or the default value.</returns>
        public static IPrefixUnit DecaOrDefault(this PrefixTable prefixes)
        {
            return prefixes.SingleOrDefault(p => p.Prefix.Symbol == DecimalPrefix.Deca.Symbol);
        }

        /// <summary>
        /// Returns the unit with the Hecto prefix or the default value if not found.
        /// </summary>
        /// <param name="prefixes">The table of multiple units.</param>
        /// <returns>The unit with the Hecto prefix or the default value.</returns>
        public static IPrefixUnit HectoOrDefault(this PrefixTable prefixes)
        {
            return prefixes.SingleOrDefault(p => p.Prefix.Symbol == DecimalPrefix.Hecto.Symbol);
        }

        /// <summary>
        /// Returns the unit with the Kilo prefix or the default value if not found.
        /// </summary>
        /// <param name="prefixes">The table of multiple units.</param>
        /// <returns>The unit with the Kilo prefix or the default value.</returns>
        public static IPrefixUnit KiloOrDefault(this PrefixTable prefixes)
        {
            return prefixes.SingleOrDefault(p => p.Prefix.Symbol == DecimalPrefix.Kilo.Symbol);
        }

        /// <summary>
        /// Returns the unit with the Mega prefix or the default value if not found.
        /// </summary>
        /// <param name="prefixes">The table of multiple units.</param>
        /// <returns>The unit with the Mega prefix or the default value.</returns>
        public static IPrefixUnit MegaOrDefault(this PrefixTable prefixes)
        {
            return prefixes.SingleOrDefault(p => p.Prefix.Symbol == DecimalPrefix.Mega.Symbol);
        }

        /// <summary>
        /// Returns the unit with the Giga prefix or the default value if not found.
        /// </summary>
        /// <param name="prefixes">The table of multiple units.</param>
        /// <returns>The unit with the Giga prefix or the default value.</returns>
        public static IPrefixUnit GigaOrDefault(this PrefixTable prefixes)
        {
            return prefixes.SingleOrDefault(p => p.Prefix.Symbol == DecimalPrefix.Giga.Symbol);
        }

        /// <summary>
        /// Returns the unit with the Tera prefix or the default value if not found.
        /// </summary>
        /// <param name="prefixes">The table of multiple units.</param>
        /// <returns>The unit with the Tera prefix or the default value.</returns>
        public static IPrefixUnit TeraOrDefault(this PrefixTable prefixes)
        {
            return prefixes.SingleOrDefault(p => p.Prefix.Symbol == DecimalPrefix.Tera.Symbol);
        }

        /// <summary>
        /// Returns the unit with the Peta prefix or the default value if not found.
        /// </summary>
        /// <param name="prefixes">The table of multiple units.</param>
        /// <returns>The unit with the Peta prefix or the default value.</returns>
        public static IPrefixUnit PetaOrDefault(this PrefixTable prefixes)
        {
            return prefixes.SingleOrDefault(p => p.Prefix.Symbol == DecimalPrefix.Peta.Symbol);
        }

        /// <summary>
        /// Returns the unit with the Exa prefix or the default value if not found.
        /// </summary>
        /// <param name="prefixes">The table of multiple units.</param>
        /// <returns>The unit with the Exa prefix or the default value.</returns>
        public static IPrefixUnit ExaOrDefault(this PrefixTable prefixes)
        {
            return prefixes.SingleOrDefault(p => p.Prefix.Symbol == DecimalPrefix.Exa.Symbol);
        }

        /// <summary>
        /// Returns the unit with the Zetta prefix or the default value if not found.
        /// </summary>
        /// <param name="prefixes">The table of multiple units.</param>
        /// <returns>The unit with the Zetta prefix or the default value.</returns>
        public static IPrefixUnit ZettaOrDefault(this PrefixTable prefixes)
        {
            return prefixes.SingleOrDefault(p => p.Prefix.Symbol == DecimalPrefix.Zetta.Symbol);
        }

        /// <summary>
        /// Returns the unit with the Yotta prefix or the default value if not found.
        /// </summary>
        /// <param name="prefixes">The table of multiple units.</param>
        /// <returns>The unit with the Yotta prefix or the default value.</returns>
        public static IPrefixUnit YottaOrDefault(this PrefixTable prefixes)
        {
            return prefixes.SingleOrDefault(p => p.Prefix.Symbol == DecimalPrefix.Yotta.Symbol);
        }

        /// <summary>
        /// Returns the unit with the Ronna prefix or the default value if not found.
        /// </summary>
        /// <param name="prefixes">The table of multiple units.</param>
        /// <returns>The unit with the Ronna prefix or the default value.</returns>
        public static IPrefixUnit RonnaOrDefault(this PrefixTable prefixes)
        {
            return prefixes.SingleOrDefault(p => p.Prefix.Symbol == DecimalPrefix.Ronna.Symbol);
        }

        /// <summary>
        /// Returns the unit with the Quetta prefix or the default value if not found.
        /// </summary>
        /// <param name="prefixes">The table of multiple units.</param>
        /// <returns>The unit with the Quetta prefix or the default value.</returns>
        public static IPrefixUnit QuettaOrDefault(this PrefixTable prefixes)
        {
            return prefixes.SingleOrDefault(p => p.Prefix.Symbol == DecimalPrefix.Quetta.Symbol);
        }

        /// <summary>
        /// Returns the unit with the Kibi prefix or the default value if not found.
        /// </summary>
        /// <param name="prefixes">The table of multiple units.</param>
        /// <returns>The unit with the Kibi prefix or the default value.</returns>
        public static IPrefixUnit KibiOrDefault(this PrefixTable prefixes)
        {
            return prefixes.SingleOrDefault(p => p.Prefix.Symbol == BinaryPrefix.Kibi.Symbol);
        }

        /// <summary>
        /// Returns the unit with the Mebi prefix or the default value if not found.
        /// </summary>
        /// <param name="prefixes">The table of multiple units.</param>
        /// <returns>The unit with the Mebi prefix or the default value.</returns>
        public static IPrefixUnit MebiOrDefault(this PrefixTable prefixes)
        {
            return prefixes.SingleOrDefault(p => p.Prefix.Symbol == BinaryPrefix.Mebi.Symbol);
        }

        /// <summary>
        /// Returns the unit with the Gibi prefix or the default value if not found.
        /// </summary>
        /// <param name="prefixes">The table of multiple units.</param>
        /// <returns>The unit with the Gibi prefix or the default value.</returns>
        public static IPrefixUnit GibiOrDefault(this PrefixTable prefixes)
        {
            return prefixes.SingleOrDefault(p => p.Prefix.Symbol == BinaryPrefix.Gibi.Symbol);
        }

        /// <summary>
        /// Returns the unit with the Tebi prefix or the default value if not found.
        /// </summary>
        /// <param name="prefixes">The table of multiple units.</param>
        /// <returns>The unit with the Tebi prefix or the default value.</returns>
        public static IPrefixUnit TebiOrDefault(this PrefixTable prefixes)
        {
            return prefixes.SingleOrDefault(p => p.Prefix.Symbol == BinaryPrefix.Tebi.Symbol);
        }

        /// <summary>
        /// Returns the unit with the Pebi prefix or the default value if not found.
        /// </summary>
        /// <param name="prefixes">The table of multiple units.</param>
        /// <returns>The unit with the Pebi prefix or the default value.</returns>
        public static IPrefixUnit PebiOrDefault(this PrefixTable prefixes)
        {
            return prefixes.SingleOrDefault(p => p.Prefix.Symbol == BinaryPrefix.Pebi.Symbol);
        }

        /// <summary>
        /// Returns the unit with the Exbi prefix or the default value if not found.
        /// </summary>
        /// <param name="prefixes">The table of multiple units.</param>
        /// <returns>The unit with the Exbi prefix or the default value.</returns>
        public static IPrefixUnit ExbiOrDefault(this PrefixTable prefixes)
        {
            return prefixes.SingleOrDefault(p => p.Prefix.Symbol == BinaryPrefix.Exbi.Symbol);
        }

        /// <summary>
        /// Returns the unit with the Zebi prefix or the default value if not found.
        /// </summary>
        /// <param name="prefixes">The table of multiple units.</param>
        /// <returns>The unit with the Zebi prefix or the default value.</returns>
        public static IPrefixUnit ZebiOrDefault(this PrefixTable prefixes)
        {
            return prefixes.SingleOrDefault(p => p.Prefix.Symbol == BinaryPrefix.Zebi.Symbol);
        }

        /// <summary>
        /// Returns the unit with the Yobi prefix or the default value if not found.
        /// </summary>
        /// <param name="prefixes">The table of multiple units.</param>
        /// <returns>The unit with the Yobi prefix or the default value.</returns>
        public static IPrefixUnit YobiOrDefault(this PrefixTable prefixes)
        {
            return prefixes.SingleOrDefault(p => p.Prefix.Symbol == BinaryPrefix.Yobi.Symbol);
        }
    }
}
