namespace Codebelt.Unitify
{
    /// <summary>
    /// Defines a unit of measurement that is used as a standard for measurement of the same kind of quantity.
    /// Any other quantity of that kind can be expressed as a multiple or fraction of the unit of measurement.
    /// </summary>
    /// <seealso cref="IUnit" />
    public interface IPrefixUnit : IUnit
    {
        /// <summary>
        /// Gets the prefix that can be either a multiple or a submultiple to the base unit.
        /// </summary>
        /// <value>The prefix that can be either a multiple or a submultiple to the base unit.</value>
        IPrefix Prefix { get; }
    }
}
