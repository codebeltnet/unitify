# Changelog

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/), and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

For more details, please refer to `PackageReleaseNotes.txt` on a per assembly basis in the `.nuget` folder.

> [!NOTE]  
> Changelog entries prior to version 9.0.0 was migrated from previous versions of [Cuemon.Core](https://github.com/gimlichael/Cuemon/commit/83e0c7af2cdaa07351e878fa7276558838f2e7e6).

## [9.0.3] - 2025-05-25

This is a service update that focuses on package dependencies.

## [9.0.2] - 2025-04-16

This is a service update that focuses on package dependencies.

## [9.0.1] - 2025-01-31

This is a service update that primarily focuses on package dependencies and minor improvements.

## [9.0.0] - 2024-11-13

### Added

- BaseUnit struct in the Codebelt.Unitify namespace that represents a base unit of measurement, including its category, name, and symbol
- IBaseUnit interface in the Codebelt.Unitify namespace that defines a base unit of measure, including its category, name, and symbol
- MetricPrefixTable class in the Codebelt.Unitify namespace that represents a table of metric prefixes for units of measure, optimized for metric measurement standards
- PrefixExtensions class in the Codebelt.Unitify namespace that provides extension methods for the Prefix class: ToPrefixUnit and ToBaseUnit
- PrefixTableExtensions class in the Codebelt.Unitify namespace that provides extension methods for the PrefixTable class: QuectoOrDefault, RontoOrDefault, YoctoOrDefault, ZeptoOrDefault, AttoOrDefault, FemtoOrDefault, PicoOrDefault, NanoOrDefault, MicroOrDefault, MilliOrDefault, CentiOrDefault, DeciOrDefault, DecaOrDefault, HectoOrDefault, KiloOrDefault, MegaOrDefault, GigaOrDefault, TeraOrDefault, PetaOrDefault, ExaOrDefault, ZettaOrDefault, YottaOrDefault, RonnaOrDefault, QuettaOrDefault, KibiOrDefault, MebiOrDefault, GibiOrDefault, TebiOrDefault, PebiOrDefault, ExbiOrDefault, ZebiOrDefault and YobiOrDefault
- PrefixUnitExtensions class in the Codebelt.Unitify namespace that provides extension methods for the PrefixUnit class: ToPrefixValue, ToBaseValue, ToBaseUnit, ToPrefixString, ToMetricPrefixTable and ToDataPrefixTable
- Unit class in the Codebelt.Unitify namespace that represents the base class from which all implementations of a unit of measure should derive
- UnitFactory class in the Codebelt.Unitify namespace that provides a set of static methods for generating different types of unit of measure and the option to define your own with CreateUnit
- UnitFormatter class in the Codebelt.Unitify namespace that defines the string formatting of objects having an implementation of IUnit

### Changed

- BitStorageCapacity class was removed from the Codebelt.Unitify namespace
- ByteStorageCapacity class was removed from the Codebelt.Unitify namespace
- StorageCapacity class in the Codebelt.Unitify namespace was refactored to DataPrefixTable that represents a table of both binary and metric prefixes for units of measure, optimized for data quantity and transmission measurement standards
- MultipleTable class in the Codebelt.Unitify namespace was refactored to PrefixTable that represents a table of unit prefixes, indicating multiples or submultiples of a base unit
- PrefixMultiple class in the Codebelt.Unitify namespace was refactored to Prefix that represents the base class from which all implementations of unit prefix that can can be expressed as either a multiple or a submultiple should derive
- IPrefixMultiple interface in the Codebelt.Unitify namespace was refactored to IPrefix that defines a unit prefix that can can be expressed as either a multiple or a submultiple of the unit of measurement
- IPrefixUnit interface in the Codebelt.Unitify namespace was refactored to not include PrefixValue property
- UnitPrefix enum in the Codebelt.Unitify namespace was refactored to PrefixStyle that specifies ways that a string must be represented in terms of prefix style
- PrefixUnit class in the Codebelt.Unitify namespace was refactored to a non-abstract class that represents the prefix of a unit of measurement
- UnitPrefixFormatter class in the Codebelt.Unitify namespace was refactored to PrefixUnitFormatter that defines the string formatting of objects having an implementation of IPrefixUnit

## [6.0.0] - 2021-04-18

### Added

- BinaryPrefix class in the Codebelt.Unitify namespace that defines a binary unit prefix for multiples of measurement for data that refers strictly to powers of 2
- BitStorageCapacity class in the Codebelt.Unitify namespace that represent a table of both binary and metric prefixes for a BitUnit
- BitUnit class in the Codebelt.Unitify namespace that represents a unit of measurement for bits and is used with measurement of data
- ByteStorageCapacity class in the Codebelt.Unitify namespace that represent a table of both binary and metric prefixes for a ByteUnit
- DecimalPrefix class in the Codebelt.Unitify namespace that defines a decimal (metric) unit prefix for multiples and submultiples of measurement that refers strictly to powers of 10
- IPrefixMultiple interface in the Codebelt.Unitify namespace that defines a unit prefix that can can be expressed as a either a multiple or a submultiple of the unit of measurement
- IUnit interface in the Codebelt.Unitify namespace that defines a unit of measurement that is used as a standard for measurement of the same kind of quantity
- MultipleTable class in the Codebelt.Unitify namespace that defines a unit of measurement that provides a way to represent a table of both binary and metric prefixes that precedes a unit of measure to indicate a multiple of the unit
- NamingStyle enum in the Codebelt.Unitify namespace that specifies ways that a string must be represented in terms of naming style
- UnitFormatOptions class in the Codebelt.Unitify namespace that specifies options related to BitUnit and ByteUnit
- UnitPrefix class in the Codebelt.Unitify namespace that specifies the two standards for binary multiples and decimal multiples
- UnitPrefixFormatter class in the Codebelt.Unitify namespace that defines the string formatting of objects having an implementation of either IPrefixUnit or IUnit
- PrefixMultiple class in the Codebelt.Unitify namespace that represents the base class from which all implementations of unit prefix that can can be expressed as a either a multiple or a submultiple of the unit of measurement should derive
- StorageCapacity class in the Codebelt.Unitify namespace that provides a way to represent a table of both binary and metric prefixes that precedes a unit of measure optimized for storage capacity measurement standards
- StorageCapacityOptions class in the Codebelt.Unitify namespace that specifies options related to StorageCapacity
- PrefixUnit class in the Codebelt.Unitify namespace that represents the base class from which all implementations of a unit of measurement should derive

### Changed

- BinaryPrefix in the Codebelt.Unitify namespace from struct to sealed class
- DecimalPrefix in the Codebelt.Unitify namespace from struct to sealed class
- MultipleTable in the Codebelt.Unitify namespace to be more generic and moved non-generic functionality to the new StorageCapacity class
- BitUnit in the Codebelt.Unitify namespace from struct to sealed class
- ByteUnit in the Codebelt.Unitify namespace from struct to sealed class

### Fixed

- UnitPrefixFormatter class in the Codebelt.Unitify namespace to be compliant with https://rules.sonarsource.com/csharp/RSPEC-927
- BinaryPrefix class in the Codebelt.Unitify namespace to have 0 duplicated blocks of lines of code
- DecimalPrefix class in the Codebelt.Unitify namespace to have 0 duplicated blocks of lines of code
- BitUnit class in the Codebelt.Unitify namespace to have 0 duplicated blocks of lines of code
- ByteUnit class in the Codebelt.Unitify namespace to have 0 duplicated blocks of lines of code
- UnitPrefixFormatter class in the Codebelt.Unitify namespace to be compliant with https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1822
