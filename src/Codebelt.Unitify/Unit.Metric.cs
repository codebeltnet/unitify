namespace Codebelt.Unitify
{
    public abstract partial class Unit
    {
        /// <summary>
        /// Gets the SI base unit for Electric Current.
        /// </summary>
        /// <value>The SI base unit for Electric Current.</value>
        /// <seealso cref="UnitFactory.CreateAmpere"/>
        public static IBaseUnit Ampere { get; } = new BaseUnit("Electric Current", "Ampere", "A");

        /// <summary>
        /// Gets the SI unit for Radioactivity.
        /// </summary>
        /// <value>The SI unit for Radioactivity.</value>
        /// <seealso cref="UnitFactory.CreateBecquerel"/>
        public static IBaseUnit Becquerel { get; } = new BaseUnit("Radioactivity", "Becquerel", "Bq");

        /// <summary>
        /// Gets the SI base unit for Luminous Intensity.
        /// </summary>
        /// <value>The SI base unit for Luminous Intensity.</value>
        /// <seealso cref="UnitFactory.CreateCandela"/>
        public static IBaseUnit Candela { get; } = new BaseUnit("Luminous Intensity", "Candela", "cd");

        /// <summary>
        /// Gets the SI unit for Temperature.
        /// </summary>
        /// <value>The SI unit for Temperature.</value>
        /// <seealso cref="UnitFactory.CreateCelsius"/>
        public static IBaseUnit Celsius { get; } = new BaseUnit("Temperature", "Celsius", "°C");

        /// <summary>
        /// Gets the SI unit for Electric Charge.
        /// </summary>
        /// <value>The SI unit for Electric Charge.</value>
        /// <seealso cref="UnitFactory.CreateCoulomb"/>
        public static IBaseUnit Coulomb { get; } = new BaseUnit("Electric Charge", "Coulomb", "C");

        /// <summary>
        /// Gets the SI unit for Electric Capacitance.
        /// </summary>
        /// <value>The SI unit for Electric Capacitance.</value>
        /// <seealso cref="UnitFactory.CreateFarad"/>
        public static IBaseUnit Farad { get; } = new BaseUnit("Electric Capacitance", "Farad", "F");

        /// <summary>
        /// Gets the SI unit for Absorbed Dose.
        /// </summary>
        /// <value>The SI unit for Absorbed Dose.</value>
        /// <seealso cref="UnitFactory.CreateGray"/>
        public static IBaseUnit Gray { get; } = new BaseUnit("Absorbed Dose", "Gray", "Gy");

        /// <summary>
        /// Gets the opinionated base unit for Inductance.
        /// </summary>
        /// <value>The opinionated base unit for Inductance.</value>
        /// <seealso cref="UnitFactory.CreateHenry"/>
        public static IBaseUnit Henry { get; } = new BaseUnit("Inductance", "Henry", "H");

        /// <summary>
        /// Gets the SI unit for Frequency.
        /// </summary>
        /// <value>The SI unit for Frequency.</value>
        /// <seealso cref="UnitFactory.CreateHertz"/>
        public static IBaseUnit Hertz { get; } = new BaseUnit("Frequency", "Hertz", "Hz");

        /// <summary>
        /// Gets the SI unit for Energy.
        /// </summary>
        /// <value>The SI unit for Energy.</value>
        /// <seealso cref="UnitFactory.CreateJoule"/>
        public static IBaseUnit Joule { get; } = new BaseUnit("Energy", "Joule", "J");

        /// <summary>
        /// Gets the SI base unit for Temperature.
        /// </summary>
        /// <value>The SI base unit for Temperature.</value>
        /// <seealso cref="UnitFactory.CreateKelvin"/>
        public static IBaseUnit Kelvin { get; } = new BaseUnit("Temperature", "Kelvin", "K");

        /// <summary>
        /// Gets the SI unit for Catalytic Activity.
        /// </summary>
        /// <value>The SI unit for Catalytic Activity.</value>
        /// <seealso cref="UnitFactory.CreateKatal"/>
        public static IBaseUnit Katal { get; } = new BaseUnit("Catalytic Activity", "Katal", "kat");

        /// <summary>
        /// Gets the opinionated base unit for Mass.
        /// </summary>
        /// <value>The opinionated base unit for Mass.</value>
        /// <remarks>For consistency with this library, Kilogram (which is the official SI base unit for Mass) has been replaced with Gram.</remarks>
        /// <seealso cref="UnitFactory.CreateGram"/>
        /// <seealso cref="UnitFactory.CreateKilogram"/>
        public static IBaseUnit Gram { get; } = new BaseUnit("Mass", "Gram", "g");

        /// <summary>
        /// Gets the SI unit for Luminous Flux.
        /// </summary>
        /// <value>The SI unit for Luminous Flux.</value>
        /// <seealso cref="UnitFactory.CreateLumen"/>
        public static IBaseUnit Lumen { get; } = new BaseUnit("Luminous Flux", "Lumen", "lm");

        /// <summary>
        /// Gets the SI unit for Illuminance.
        /// </summary>
        /// <value>The SI unit for Illuminance.</value>
        /// <seealso cref="UnitFactory.CreateLux"/>
        public static IBaseUnit Lux { get; } = new BaseUnit("Illuminance", "Lux", "lx");

        /// <summary>
        /// Gets the SI base unit for Length.
        /// </summary>
        /// <value>The SI base unit for Length.</value>
        /// <seealso cref="UnitFactory.CreateMeter"/>
        public static IBaseUnit Meter { get; } = new BaseUnit("Length", "Meter", "m");

        /// <summary>
        /// Gets the SI base unit for Amount of Substance.
        /// </summary>
        /// <value>The SI base unit for Amount of Substance.</value>
        /// <seealso cref="UnitFactory.CreateMole"/>
        public static IBaseUnit Mole { get; } = new BaseUnit("Amount of Substance", "Mole", "mol");

        /// <summary>
        /// Gets the SI unit for Force.
        /// </summary>
        /// <value>The SI unit for Force.</value>
        /// <seealso cref="UnitFactory.CreateNewton"/>
        public static IBaseUnit Newton { get; } = new BaseUnit("Force", "Newton", "N");

        /// <summary>
        /// Gets the SI unit for Electric Resistance.
        /// </summary>
        /// <value>The SI unit for Electric Resistance.</value>
        /// <seealso cref="UnitFactory.CreateOhm"/>
        public static IBaseUnit Ohm { get; } = new BaseUnit("Electric Resistance", "Ohm", "Ω");

        /// <summary>
        /// Gets the SI unit for Pressure.
        /// </summary>
        /// <value>The SI unit for Pressure.</value>
        /// <seealso cref="UnitFactory.CreatePascal"/>
        public static IBaseUnit Pascal { get; } = new BaseUnit("Pressure", "Pascal", "Pa");

        /// <summary>
        /// Gets the SI unit for Plane Angle.
        /// </summary>
        /// <value>The SI unit for Plane Angle.</value>
        /// <seealso cref="UnitFactory.CreateRadian"/>
        public static IBaseUnit Radian { get; } = new BaseUnit("Plane Angle", "Radian", "rad");

        /// <summary>
        /// Gets the SI base unit for Time.
        /// </summary>
        /// <value>The SI base unit for Time.</value>
        /// <seealso cref="UnitFactory.CreateSecond"/>
        public static IBaseUnit Second { get; } = new BaseUnit("Time", "Second", "s");

        /// <summary>
        /// Gets the SI unit for Electric Conductance.
        /// </summary>
        /// <value>The SI unit for Electric Conductance.</value>
        /// <seealso cref="UnitFactory.CreateSiemens"/>
        public static IBaseUnit Siemens { get; } = new BaseUnit("Electric Conductance", "Siemens", "S");

        /// <summary>
        /// Gets the SI unit for Equivalent Dose.
        /// </summary>
        /// <value>The SI unit for Equivalent Dose.</value>
        /// <seealso cref="UnitFactory.CreateSievert"/>
        public static IBaseUnit Sievert { get; } = new BaseUnit("Equivalent Dose", "Sievert", "Sv");

        /// <summary>
        /// Gets the SI unit for Solid Angle.
        /// </summary>
        /// <value>The SI unit for Solid Angle.</value>
        /// <seealso cref="UnitFactory.CreateSteradian"/>
        public static IBaseUnit Steradian { get; } = new BaseUnit("Solid Angle", "Steradian", "sr");

        /// <summary>
        /// Gets the SI unit for Magnetic Flux Density.
        /// </summary>
        /// <value>The SI unit for Magnetic Flux Density.</value>
        /// <seealso cref="UnitFactory.CreateTesla"/>
        public static IBaseUnit Tesla { get; } = new BaseUnit("Magnetic Flux Density", "Tesla", "T");

        /// <summary>
        /// Gets the SI unit for Electric Potential.
        /// </summary>
        /// <value>The SI unit for Electric Potential.</value>
        /// <seealso cref="UnitFactory.CreateVolt"/>
        public static IBaseUnit Volt { get; } = new BaseUnit("Electric Potential", "Volt", "V");

        /// <summary>
        /// Gets the SI unit for Power.
        /// </summary>
        /// <value>The SI unit for Power.</value>
        /// <seealso cref="UnitFactory.CreateWatt"/>
        public static IBaseUnit Watt { get; } = new BaseUnit("Power", "Watt", "W");

        /// <summary>
        /// Gets the SI unit for Magnetic Flux.
        /// </summary>
        /// <value>The SI unit for Magnetic Flux.</value>
        /// <seealso cref="UnitFactory.CreateWeber"/>
        public static IBaseUnit Weber { get; } = new BaseUnit("Magnetic Flux", "Weber", "Wb");
    }
}
