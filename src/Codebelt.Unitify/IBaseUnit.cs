namespace Codebelt.Unitify
{
    /// <summary>
    /// Defines a base unit of measure, including its category, name, and symbol.
    /// </summary>
    public interface IBaseUnit
    {
        /// <summary>
        /// Gets the category of the base unit.
        /// </summary>
        /// <value>The category of the base unit.</value>
        string Category { get; }

        /// <summary>
        /// Gets the name of the base unit.
        /// </summary>
        /// <value>The name of the base unit.</value>
        string Name { get; }

        /// <summary>
        /// Gets the symbol of the base unit.
        /// </summary>
        /// <value>The symbol of the base unit.</value>
        string Symbol { get; }
    }
}
