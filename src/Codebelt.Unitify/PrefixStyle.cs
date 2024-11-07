namespace Codebelt.Unitify
{
    /// <summary>
    /// Specifies ways that a string must be represented in terms of prefix style.
    /// </summary>
    public enum PrefixStyle
    {
        /// <summary>
        /// Defines the IEEE 1541 standard for binary prefix that refers strictly to powers of 2 (eg. one kibibit represents 1024 bits and not 1000 bits).
        /// </summary>
        Binary,
        /// <summary>
        /// Defines the International System of Units (SI) standard for metric prefixes that refers strictly to powers of 10 (eg. one kilobit represents 1000 bits and not 1024 bits).
        /// </summary>
        Decimal
    }
}
