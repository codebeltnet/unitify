namespace Codebelt.Unitify
{
    public abstract partial class Unit
    {
        /// <summary>
        /// Gets the base unit for Data Quantity.
        /// </summary>
        /// <value>The base unit for Data Quantity.</value>
        /// <seealso cref="UnitFactory.CreateBit"/>
        public static IBaseUnit Bit { get; } = new BaseUnit("Data Quantity", "bit", "b");

        /// <summary>
        /// Gets the unit for Data Quantity.
        /// </summary>
        /// <value>The unit for Data Quantity.</value>
        /// <seealso cref="UnitFactory.CreateByte"/>
        public static IBaseUnit Byte { get; } = new BaseUnit("Data Quantity", "byte", "B");

        /// <summary>
        /// Gets the base unit for Transmission Rate.
        /// </summary>
        /// <value>The base unit for Transmission Rate.</value>
        /// <seealso cref="UnitFactory.CreateBitPerSecond"/>
        public static IBaseUnit BitPerSecond { get; } = new BaseUnit("Transmission Rate", "Bit per second", "bit/s");
    }
}
