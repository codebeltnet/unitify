using System;

namespace Codebelt.Unitify
{
    /// <summary>
    /// Provides a set of static methods for generating different types of unit of measure or the option to define your own with <see cref="Create"/>.
    /// </summary>
    public static class UnitFactory
    {
        /// <summary>
        /// Creates a custom unit of measure.
        /// </summary>
        /// <param name="category">The category of the unit.</param>
        /// <param name="name">The name of the unit.</param>
        /// <param name="symbol">The symbol of the unit.</param>
        /// <param name="value">The value of the unit.</param>
        /// <param name="prefix">The prefix of the unit.</param>
        /// <param name="setup">The <see cref="UnitFormatOptions"/> which may be configured.</param>
        /// <returns>A custom unit of measure.</returns>
        public static IPrefixUnit Create(string category, string name, string symbol, double value, IPrefix prefix, Action<UnitFormatOptions> setup = null)
        {
            var baseUnit = new BaseUnit(category, name, symbol);
            return CreateUnit(baseUnit, value, prefix, setup);
        }

        /// <summary>
        /// Creates a unit of measure for Data Quantity in bits.
        /// </summary>
        /// <param name="value">The value of the unit.</param>
        /// <param name="prefix">The optional prefix of the unit.</param>
        /// <param name="setup">The <see cref="UnitFormatOptions"/> which may be configured.</param>
        /// <returns>A unit of measure for Data Quantity in bits.</returns>
        /// <seealso cref="Unit.Bit"/>
        public static IPrefixUnit CreateBit(double value, IPrefix prefix = null, Action<UnitFormatOptions> setup = null)
        {
            return CreateUnit(Unit.Bit, value, prefix, setup);
        }

        /// <summary>
        /// Creates a unit of measure for Data Quantity in bytes.
        /// </summary>
        /// <param name="value">The value of the unit.</param>
        /// <param name="prefix">The optional prefix of the unit.</param>
        /// <param name="setup">The <see cref="UnitFormatOptions"/> which may be configured.</param>
        /// <returns>A unit of measure for Data Quantity in bytes.</returns>
        /// <seealso cref="Unit.Byte"/>
        public static IPrefixUnit CreateByte(double value, IPrefix prefix = null, Action<UnitFormatOptions> setup = null)
        {
            return CreateUnit(Unit.Byte, value, prefix, setup);
        }

        /// <summary>
        /// Creates a unit of measure for Transmission Rate in bits per second.
        /// </summary>
        /// <param name="value">The value of the unit.</param>
        /// <param name="prefix">The prefix of the unit.</param>
        /// <param name="setup">The <see cref="UnitFormatOptions"/> which may be configured.</param>
        /// <returns>A unit of measure for Transmission Rate in bits per second.</returns>
        /// <seealso cref="Unit.BitPerSecond"/>
        public static IPrefixUnit CreateBitPerSecond(double value, IPrefix prefix = null, Action<UnitFormatOptions> setup = null)
        {
            return CreateUnit(Unit.BitPerSecond, value, prefix, setup);
        }

        /// <summary>
        /// Creates a unit of measure for Electric Current in amperes.
        /// </summary>
        /// <param name="value">The value of the unit.</param>
        /// <param name="prefix">The prefix of the unit.</param>
        /// <param name="setup">The <see cref="UnitFormatOptions"/> which may be configured.</param>
        /// <returns>A unit of measure for Electric Current in amperes.</returns>
        /// <seealso cref="Unit.Ampere"/>
        public static IPrefixUnit CreateAmpere(double value, IPrefix prefix = null, Action<UnitFormatOptions> setup = null)
        {
            return CreateUnit(Unit.Ampere, value, prefix, setup);
        }

        /// <summary>
        /// Creates a unit of measure for Radioactivity in becquerels.
        /// </summary>
        /// <param name="value">The value of the unit.</param>
        /// <param name="prefix">The prefix of the unit.</param>
        /// <param name="setup">The <see cref="UnitFormatOptions"/> which may be configured.</param>
        /// <returns>A unit of measure for Radioactivity in becquerels.</returns>
        /// <seealso cref="Unit.Becquerel"/>
        public static IPrefixUnit CreateBecquerel(double value, IPrefix prefix = null, Action<UnitFormatOptions> setup = null)
        {
            return CreateUnit(Unit.Becquerel, value, prefix, setup);
        }

        /// <summary>
        /// Creates a unit of measure for Luminous Intensity in candelas.
        /// </summary>
        /// <param name="value">The value of the unit.</param>
        /// <param name="prefix">The prefix of the unit.</param>
        /// <param name="setup">The <see cref="UnitFormatOptions"/> which may be configured.</param>
        /// <returns>A unit of measure for Luminous Intensity in candelas.</returns>
        /// <seealso cref="Unit.Candela"/>
        public static IPrefixUnit CreateCandela(double value, IPrefix prefix = null, Action<UnitFormatOptions> setup = null)
        {
            return CreateUnit(Unit.Candela, value, prefix, setup);
        }

        /// <summary>
        /// Creates a unit of measure for Temperature in degrees Celsius.
        /// </summary>
        /// <param name="value">The value of the unit.</param>
        /// <param name="prefix">The prefix of the unit.</param>
        /// <param name="setup">The <see cref="UnitFormatOptions"/> which may be configured.</param>
        /// <returns>A unit of measure for Temperature in degrees Celsius.</returns>
        /// <seealso cref="Unit.Celsius"/>
        public static IPrefixUnit CreateCelsius(double value, IPrefix prefix = null, Action<UnitFormatOptions> setup = null)
        {
            return CreateUnit(Unit.Celsius, value, prefix, setup);
        }

        /// <summary>
        /// Creates a unit of measure for Electric Charge in coulombs.
        /// </summary>
        /// <param name="value">The value of the unit.</param>
        /// <param name="prefix">The prefix of the unit.</param>
        /// <param name="setup">The <see cref="UnitFormatOptions"/> which may be configured.</param>
        /// <returns>A unit of measure for Electric Charge in coulombs.</returns>
        /// <seealso cref="Unit.Coulomb"/>
        public static IPrefixUnit CreateCoulomb(double value, IPrefix prefix = null, Action<UnitFormatOptions> setup = null)
        {
            return CreateUnit(Unit.Coulomb, value, prefix, setup);
        }

        /// <summary>
        /// Creates a unit of measure for Electric Capacitance in farads.
        /// </summary>
        /// <param name="value">The value of the unit.</param>
        /// <param name="prefix">The prefix of the unit.</param>
        /// <param name="setup">The <see cref="UnitFormatOptions"/> which may be configured.</param>
        /// <returns>A unit of measure for Electric Capacitance in farads.</returns>
        /// <seealso cref="Unit.Farad"/>
        public static IPrefixUnit CreateFarad(double value, IPrefix prefix = null, Action<UnitFormatOptions> setup = null)
        {
            return CreateUnit(Unit.Farad, value, prefix, setup);
        }

        /// <summary>
        /// Creates a unit of measure for Absorbed Dose in grays.
        /// </summary>
        /// <param name="value">The value of the unit.</param>
        /// <param name="prefix">The prefix of the unit.</param>
        /// <param name="setup">The <see cref="UnitFormatOptions"/> which may be configured.</param>
        /// <returns>A unit of measure for Absorbed Dose in grays.</returns>
        /// <seealso cref="Unit.Gray"/>
        public static IPrefixUnit CreateGray(double value, IPrefix prefix = null, Action<UnitFormatOptions> setup = null)
        {
            return CreateUnit(Unit.Gray, value, prefix, setup);
        }

        /// <summary>
        /// Creates a unit of measure for Inductance in henries.
        /// </summary>
        /// <param name="value">The value of the unit.</param>
        /// <param name="prefix">The prefix of the unit.</param>
        /// <param name="setup">The <see cref="UnitFormatOptions"/> which may be configured.</param>
        /// <returns>A unit of measure for Inductance in henries.</returns>
        /// <seealso cref="Unit.Henry"/>
        public static IPrefixUnit CreateHenry(double value, IPrefix prefix = null, Action<UnitFormatOptions> setup = null)
        {
            return CreateUnit(Unit.Henry, value, prefix, setup);
        }

        /// <summary>
        /// Creates a unit of measure for Frequency in hertz.
        /// </summary>
        /// <param name="value">The value of the unit.</param>
        /// <param name="prefix">The prefix of the unit.</param>
        /// <param name="setup">The <see cref="UnitFormatOptions"/> which may be configured.</param>
        /// <returns>A unit of measure for Frequency in hertz.</returns>
        /// <seealso cref="Unit.Hertz"/>
        public static IPrefixUnit CreateHertz(double value, IPrefix prefix = null, Action<UnitFormatOptions> setup = null)
        {
            return CreateUnit(Unit.Hertz, value, prefix, setup);
        }

        /// <summary>
        /// Creates a unit of measure for Energy in joules.
        /// </summary>
        /// <param name="value">The value of the unit.</param>
        /// <param name="prefix">The prefix of the unit.</param>
        /// <param name="setup">The <see cref="UnitFormatOptions"/> which may be configured.</param>
        /// <returns>A unit of measure for Energy in joules.</returns>
        /// <seealso cref="Unit.Joule"/>
        public static IPrefixUnit CreateJoule(double value, IPrefix prefix = null, Action<UnitFormatOptions> setup = null)
        {
            return CreateUnit(Unit.Joule, value, prefix, setup);
        }

        /// <summary>
        /// Creates a unit of measure for Temperature in kelvin.
        /// </summary>
        /// <param name="value">The value of the unit.</param>
        /// <param name="prefix">The prefix of the unit.</param>
        /// <param name="setup">The <see cref="UnitFormatOptions"/> which may be configured.</param>
        /// <returns>A unit of measure for Temperature in kelvin.</returns>
        /// <seealso cref="Unit.Kelvin"/>
        public static IUnit CreateKelvin(double value, IPrefix prefix = null, Action<UnitFormatOptions> setup = null)
        {
            return CreateUnit(Unit.Kelvin, value, prefix, setup);
        }

        /// <summary>
        /// Creates a unit of measure for Catalytic Activity in katals.
        /// </summary>
        /// <param name="value">The value of the unit.</param>
        /// <param name="prefix">The prefix of the unit.</param>
        /// <param name="setup">The <see cref="UnitFormatOptions"/> which may be configured.</param>
        /// <returns>A unit of measure for Catalytic Activity in katals.</returns>
        /// <seealso cref="Unit.Katal"/>
        public static IUnit CreateKatal(double value, IPrefix prefix = null, Action<UnitFormatOptions> setup = null)
        {
            return CreateUnit(Unit.Katal, value, prefix, setup);
        }

        /// <summary>
        /// Creates a unit of measure for Mass in grams.
        /// </summary>
        /// <param name="value">The value of the unit.</param>
        /// <param name="prefix">The prefix of the unit.</param>
        /// <param name="setup">The <see cref="UnitFormatOptions"/> which may be configured.</param>
        /// <returns>A unit of measure for Mass in grams.</returns>
        /// <seealso cref="Unit.Gram"/>
        public static IUnit CreateGram(double value, IPrefix prefix = null, Action<UnitFormatOptions> setup = null)
        {
            return CreateUnit(Unit.Gram, value, prefix, setup);
        }

        /// <summary>
        /// Creates a unit of measure for Mass in kilograms.
        /// </summary>
        /// <param name="value">The value of the unit.</param>
        /// <param name="setup">The <see cref="UnitFormatOptions"/> which may be configured.</param>
        /// <returns>A unit of measure for Mass in kilograms.</returns>
        /// <seealso cref="Unit.Gram"/>
        /// <seealso cref="CreateGram"/>
        public static IPrefixUnit CreateKilogram(double value, Action<UnitFormatOptions> setup = null)
        {
            return CreateUnit(Unit.Gram, value, DecimalPrefix.Kilo, setup);
        }

        /// <summary>
        /// Creates a unit of measure for Luminous Flux in lumens.
        /// </summary>
        /// <param name="value">The value of the unit.</param>
        /// <param name="prefix">The prefix of the unit.</param>
        /// <param name="setup">The <see cref="UnitFormatOptions"/> which may be configured.</param>
        /// <returns>A unit of measure for Luminous Flux in lumens.</returns>
        /// <seealso cref="Unit.Lumen"/>
        public static IPrefixUnit CreateLumen(double value, IPrefix prefix = null, Action<UnitFormatOptions> setup = null)
        {
            return CreateUnit(Unit.Lumen, value, prefix, setup);
        }

        /// <summary>
        /// Creates a unit of measure for Illuminance in lux.
        /// </summary>
        /// <param name="value">The value of the unit.</param>
        /// <param name="prefix">The prefix of the unit.</param>
        /// <param name="setup">The <see cref="UnitFormatOptions"/> which may be configured.</param>
        /// <returns>A unit of measure for Illuminance in lux.</returns>
        /// <seealso cref="Unit.Lux"/>
        public static IPrefixUnit CreateLux(double value, IPrefix prefix = null, Action<UnitFormatOptions> setup = null)
        {
            return CreateUnit(Unit.Lux, value, prefix, setup);
        }

        /// <summary>
        /// Creates a unit of measure for Length in meters.
        /// </summary>
        /// <param name="value">The value of the unit.</param>
        /// <param name="prefix">The prefix of the unit.</param>
        /// <param name="setup">The <see cref="UnitFormatOptions"/> which may be configured.</param>
        /// <returns>A unit of measure for Length in meters.</returns>
        /// <seealso cref="Unit.Meter"/>
        public static IPrefixUnit CreateMeter(double value, IPrefix prefix = null, Action<UnitFormatOptions> setup = null)
        {
            return CreateUnit(Unit.Meter, value, prefix, setup);
        }

        /// <summary>
        /// Creates a unit of measure for Amount of Substance in moles.
        /// </summary>
        /// <param name="value">The value of the unit.</param>
        /// <param name="prefix">The prefix of the unit.</param>
        /// <param name="setup">The <see cref="UnitFormatOptions"/> which may be configured.</param>
        /// <returns>A unit of measure for Amount of Substance in moles.</returns>
        /// <seealso cref="Unit.Mole"/>
        public static IPrefixUnit CreateMole(double value, IPrefix prefix = null, Action<UnitFormatOptions> setup = null)
        {
            return CreateUnit(Unit.Mole, value, prefix, setup);
        }

        /// <summary>
        /// Creates a unit of measure for Force in newtons.
        /// </summary>
        /// <param name="value">The value of the unit.</param>
        /// <param name="prefix">The prefix of the unit.</param>
        /// <param name="setup">The <see cref="UnitFormatOptions"/> which may be configured.</param>
        /// <returns>A unit of measure for Force in newtons.</returns>
        /// <seealso cref="Unit.Newton"/>
        public static IPrefixUnit CreateNewton(double value, IPrefix prefix = null, Action<UnitFormatOptions> setup = null)
        {
            return CreateUnit(Unit.Newton, value, prefix, setup);
        }

        /// <summary>
        /// Creates a unit of measure for Electric Resistance in ohms.
        /// </summary>
        /// <param name="value">The value of the unit.</param>
        /// <param name="prefix">The prefix of the unit.</param>
        /// <param name="setup">The <see cref="UnitFormatOptions"/> which may be configured.</param>
        /// <returns>A unit of measure for Electric Resistance in ohms.</returns>
        /// <seealso cref="Unit.Ohm"/>
        public static IPrefixUnit CreateOhm(double value, IPrefix prefix = null, Action<UnitFormatOptions> setup = null)
        {
            return CreateUnit(Unit.Ohm, value, prefix, setup);
        }

        /// <summary>
        /// Creates a unit of measure for Pressure in pascals.
        /// </summary>
        /// <param name="value">The value of the unit.</param>
        /// <param name="prefix">The prefix of the unit.</param>
        /// <param name="setup">The <see cref="UnitFormatOptions"/> which may be configured.</param>
        /// <returns>A unit of measure for Pressure in pascals.</returns>
        /// <seealso cref="Unit.Pascal"/>
        public static IPrefixUnit CreatePascal(double value, IPrefix prefix = null, Action<UnitFormatOptions> setup = null)
        {
            return CreateUnit(Unit.Pascal, value, prefix, setup);
        }

        /// <summary>
        /// Creates a unit of measure for Plane Angle in radians.
        /// </summary>
        /// <param name="value">The value of the unit.</param>
        /// <param name="prefix">The prefix of the unit.</param>
        /// <param name="setup">The <see cref="UnitFormatOptions"/> which may be configured.</param>
        /// <returns>A unit of measure for Plane Angle in radians.</returns>
        /// <seealso cref="Unit.Radian"/>
        public static IPrefixUnit CreateRadian(double value, IPrefix prefix = null, Action<UnitFormatOptions> setup = null)
        {
            return CreateUnit(Unit.Radian, value, prefix, setup);
        }

        /// <summary>
        /// Creates a unit of measure for Time in seconds.
        /// </summary>
        /// <param name="value">The value of the unit.</param>
        /// <param name="prefix">The prefix of the unit.</param>
        /// <param name="setup">The <see cref="UnitFormatOptions"/> which may be configured.</param>
        /// <returns>A unit of measure for Time in seconds.</returns>
        /// <seealso cref="Unit.Second"/>
        public static IPrefixUnit CreateSecond(double value, IPrefix prefix = null, Action<UnitFormatOptions> setup = null)
        {
            return CreateUnit(Unit.Second, value, prefix, setup);
        }

        /// <summary>
        /// Creates a unit of measure for Electric Conductance in siemens.
        /// </summary>
        /// <param name="value">The value of the unit.</param>
        /// <param name="prefix">The prefix of the unit.</param>
        /// <param name="setup">The <see cref="UnitFormatOptions"/> which may be configured.</param>
        /// <returns>A unit of measure for Electric Conductance in siemens.</returns>
        /// <seealso cref="Unit.Siemens"/>
        public static IPrefixUnit CreateSiemens(double value, IPrefix prefix = null, Action<UnitFormatOptions> setup = null)
        {
            return CreateUnit(Unit.Siemens, value, prefix, setup);
        }

        /// <summary>
        /// Creates a unit of measure for Equivalent Dose in sieverts.
        /// </summary>
        /// <param name="value">The value of the unit.</param>
        /// <param name="prefix">The prefix of the unit.</param>
        /// <param name="setup">The <see cref="UnitFormatOptions"/> which may be configured.</param>
        /// <returns>A unit of measure for Equivalent Dose in sieverts.</returns>
        /// <seealso cref="Unit.Sievert"/>
        public static IPrefixUnit CreateSievert(double value, IPrefix prefix = null, Action<UnitFormatOptions> setup = null)
        {
            return CreateUnit(Unit.Sievert, value, prefix, setup);
        }

        /// <summary>
        /// Creates a unit of measure for Solid Angle in steradians.
        /// </summary>
        /// <param name="value">The value of the unit.</param>
        /// <param name="prefix">The prefix of the unit.</param>
        /// <param name="setup">The <see cref="UnitFormatOptions"/> which may be configured.</param>
        /// <returns>A unit of measure for Solid Angle in steradians.</returns>
        /// <seealso cref="Unit.Steradian"/>
        public static IPrefixUnit CreateSteradian(double value, IPrefix prefix = null, Action<UnitFormatOptions> setup = null)
        {
            return CreateUnit(Unit.Steradian, value, prefix, setup);
        }

        /// <summary>
        /// Creates a unit of measure for Magnetic Flux Density in teslas.
        /// </summary>
        /// <param name="value">The value of the unit.</param>
        /// <param name="prefix">The prefix of the unit.</param>
        /// <param name="setup">The <see cref="UnitFormatOptions"/> which may be configured.</param>
        /// <returns>A unit of measure for Magnetic Flux Density in teslas.</returns>
        /// <seealso cref="Unit.Tesla"/>
        public static IPrefixUnit CreateTesla(double value, IPrefix prefix = null, Action<UnitFormatOptions> setup = null)
        {
            return CreateUnit(Unit.Tesla, value, prefix, setup);
        }

        /// <summary>
        /// Creates a unit of measure for Electric Potential in volts.
        /// </summary>
        /// <param name="value">The value of the unit.</param>
        /// <param name="prefix">The prefix of the unit.</param>
        /// <param name="setup">The <see cref="UnitFormatOptions"/> which may be configured.</param>
        /// <returns>A unit of measure for Electric Potential in volts.</returns>
        /// <seealso cref="Unit.Volt"/>
        public static IPrefixUnit CreateVolt(double value, IPrefix prefix = null, Action<UnitFormatOptions> setup = null)
        {
            return CreateUnit(Unit.Volt, value, prefix, setup);
        }

        /// <summary>
        /// Creates a unit of measure for Power in watts.
        /// </summary>
        /// <param name="value">The value of the unit.</param>
        /// <param name="prefix">The prefix of the unit.</param>
        /// <param name="setup">The <see cref="UnitFormatOptions"/> which may be configured.</param>
        /// <returns>A unit of measure for Power in watts.</returns>
        /// <seealso cref="Unit.Watt"/>
        public static IPrefixUnit CreateWatt(double value, IPrefix prefix = null, Action<UnitFormatOptions> setup = null)
        {
            return CreateUnit(Unit.Watt, value, prefix, setup);
        }

        /// <summary>
        /// Creates a unit of measure for Magnetic Flux in webers.
        /// </summary>
        /// <param name="value">The value of the unit.</param>
        /// <param name="prefix">The prefix of the unit.</param>
        /// <param name="setup">The <see cref="UnitFormatOptions"/> which may be configured.</param>
        /// <returns>A unit of measure for Magnetic Flux in webers.</returns>
        /// <seealso cref="Unit.Weber"/>
        public static IPrefixUnit CreateWeber(double value, IPrefix prefix = null, Action<UnitFormatOptions> setup = null)
        {
            return CreateUnit(Unit.Weber, value, prefix, setup);
        }

        private static PrefixUnit CreateUnit(IBaseUnit baseUnit, double value, IPrefix prefix, Action<UnitFormatOptions> setup = null)
        {
            return prefix == null
                ? new PrefixUnit(baseUnit, value, setup: setup)
                : new PrefixUnit(baseUnit, prefix.ToBaseValue(value), prefix, setup);
        }
    }
}
