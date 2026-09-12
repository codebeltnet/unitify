# Changelog

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/), and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

For more details, please refer to `PackageReleaseNotes.txt` on a per assembly basis in the `.nuget` folder.

> [!NOTE]  
> Changelog entries prior to version 9.0.0 was migrated from previous versions of [Cuemon.Core](https://github.com/gimlichael/Cuemon/commit/83e0c7af2cdaa07351e878fa7276558838f2e7e6).

## [10.0.12] - 2026-09-12

This is a patch release focused on test infrastructure modernization, code coverage tooling modernization,
build system enhancements, and contribution guidelines alignment with the Codebelt estate.

### Added

- `global.json` configuration for explicit Microsoft.Testing.Platform test runner specification,
- `.gitattributes` file for consistent line-ending normalization across the repository.

### Changed

- Codebelt.Extensions.Xunit.App upgraded from 11.2.1 to 12.0.1 for enhanced xUnit v3 and Microsoft.Testing.Platform support,
- Microsoft.NET.Test.Sdk upgraded from 18.9.0 to 18.10.0 for improved test runner compatibility,
- Cuemon.Core upgraded from 10.7.0 to 10.7.1 with latest improvements across all supported target frameworks,
- MinVer upgraded from 7.0.0 to 8.0.0 for semantic versioning enhancements,
- xunit.v3 upgraded from 3.2.2 to 4.0.0 for major test framework improvements,
- xunit.v3.runner.console upgraded from 3.2.2 to 4.0.0 for Microsoft.Testing.Platform alignment,
- xunit.runner.visualstudio upgraded from 3.1.5 to 4.0.0 for Visual Studio integration with the latest test infrastructure,
- `.editorconfig` cleaned up to remove obsolete analyzer rules (CA1200, IDE0330) and duplicate IDE0036 entry,
- `.github/CONTRIBUTING.md` completely restructured to align with Codebelt estate guidelines, including clear build instructions, per-project testing procedures, integration environment documentation, and pull request workflow.

### Removed

- coverlet.msbuild and coverlet.collector packages, replaced by Microsoft.Testing.Extensions.CodeCoverage for modern test coverage analysis.

## [10.0.11] - 2026-08-16

This is a patch release focused on dependency upgrades, Docker test environment consolidation, and test infrastructure improvements.

### Changed

- Codebelt.Extensions.Xunit.App upgraded from 11.1.2 to 11.2.1 for enhanced test infrastructure support,
- Cuemon.Core upgraded from 10.5.5 to 10.7.0 with latest improvements across all supported target frameworks,
- Microsoft.NET.Test.Sdk upgraded from 18.8.1 to 18.9.0 for improved test runner compatibility,
- Docker test environment configuration consolidated from separate net9 and net10 runners into a single multi-TFM image supporting .NET 8, 9, 10, and 11, simplifying test matrix management and CI configuration.

## [10.0.10] - 2026-07-20

This is a patch release focused on dependency upgrades, code formatting standardization,
documentation improvements, and infrastructure refinements.

### Added

- Editor configuration file (`.editorconfig`) establishing shared UTF-8 encoding, line ending consistency,
  and code analysis rule customizations across the repository.

### Changed

- Codebelt.Extensions.Xunit.App upgraded from 11.1.1 to 11.1.2,
- Cuemon.Core upgraded from 10.5.4 to 10.5.5,
- Microsoft.NET.Test.Sdk upgraded from 18.7.0 to 18.8.1,
- All 25 source files in `src/Codebelt.Unitify/` converted to file-scoped namespace declarations per IDE0161 analyzer recommendation,
- All 16 test files in `test/Codebelt.Unitify/` converted to file-scoped namespace declarations for standardization,
- DocFX container nginx base image refined from 1.31.2-alpine to 1.31-alpine for improved container compatibility.

### Fixed

- XML documentation symbol references in DecimalPrefix class corrected (pico: 'f' → 'p', milli: 'μ' → 'm'),
- Abbreviation style standardized from 'eg.' to 'e.g.' in NamingStyle and PrefixStyle enums.

## [10.0.9] - 2026-06-30

This is a patch release focused on comprehensive API documentation, test infrastructure updates, and continuous integration improvements.

### Added

- Complete DocFX API documentation for all public types in the Codebelt.Unitify namespace with per-type overwrite files covering examples and usage guidance,
- Namespace overview documentation for Codebelt.Unitify providing Start Here, When to Use, and Getting Started sections with practical guidance on unit creation, prefix application, and metric vs binary prefix table usage,
- Comprehensive DocFX documentation maintenance guidelines in AGENTS.md covering API documentation requirements, namespace and type page guidelines, example validation, link preservation, availability documentation, and final verification procedures for code sample compilation and DocFX build validation.

### Changed

- Codebelt.Extensions.Xunit.App upgraded from 11.1.0 to 11.1.1 for enhanced unit test infrastructure support,
- Cuemon.Core upgraded from 10.5.3 to 10.5.4 with latest improvements across all supported target frameworks,
- Documentation infrastructure updated with Dockerfile.docfx nginx image upgraded to 1.31.2 and docfx.json restructured to separate namespace and type API documentation into distinct subdirectories,
- Continuous integration deployment condition refactored to explicitly check all required job results, preventing skipped optional jobs from suppressing deployment,
- Microsoft.NET.Test.SDK upgraded from 18.6.0 to 18.7.0 for improved test runner compatibility and latest test infrastructure improvements.

### Fixed

- CI/CD deployment workflow now correctly respects all job results using always() condition check instead of only preventing pull request deployments.

## [10.0.8] - 2026-06-05

This is a service update that focuses on package dependencies.

## [10.0.7] - 2026-05-22

This is a service update that focuses on package dependencies.

## [10.0.6] - 2026-04-17

This is a service update that focuses on package dependencies.

## [10.0.5] - 2026-03-25

This is a patch release focusing on dependency upgrades across all supported target frameworks, modernization of build tooling, updates to documentation infrastructure, and expanded package management coverage.

### Changed

- Codebelt.Extensions.Xunit.App upgraded from 11.0.7 to 11.0.8 for unit test support,
- Cuemon.Core upgraded from 10.4.0 to 10.5.0 with latest improvements across all supported target frameworks (.NET 10 and .NET 9),
- docfx base image updated from 2.78.4 to 2.78.5 for improved documentation generation,
- Service update workflow improved with clarified formatting and consistency standards,
- NuGet package update detection extended to include Carter package mapping for Codebelt.Extensions.Carter.

## [10.0.4] - 2026-02-28

This is a service update that focuses on package dependencies.

## [10.0.3] - 2026-02-20

This is a service update that focuses on package dependencies.

## [10.0.2] - 2026-02-15

This is a service update that focuses on package dependencies.

## [10.0.1] - 2026-01-22

This is a service update that focuses on package dependencies.

## [10.0.0] - 2025-11-13

This is a major release that focuses on adapting the latest `.NET 10` release (LTS) in exchange for current `.NET 8` (LTS).

> To ensure access to current features, improvements, and security updates, and to keep the codebase clean and easy to maintain, we target only the latest long-term (LTS), short-term (STS) and (where applicable) cross-platform .NET versions.

## [9.0.8] - 2025-10-20

This is a service update that focuses on package dependencies.

## [9.0.7] - 2025-09-15

This is a service update that focuses on package dependencies.

## [9.0.6] - 2025-08-20

This is a service update that focuses on package dependencies.

## [9.0.5] - 2025-07-11

This is a service update that focuses on package dependencies.

## [9.0.4] - 2025-06-16

This is a service update that focuses on package dependencies.

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

[Unreleased]: https://github.com/codebeltnet/unitify/compare/v10.0.12...HEAD
[10.0.12]: https://github.com/codebeltnet/unitify/compare/v10.0.11...v10.0.12
[10.0.11]: https://github.com/codebeltnet/unitify/compare/v10.0.10...v10.0.11
[10.0.10]: https://github.com/codebeltnet/unitify/compare/v10.0.9...v10.0.10
[10.0.9]: https://github.com/codebeltnet/unitify/compare/v10.0.8...v10.0.9
[10.0.8]: https://github.com/codebeltnet/unitify/compare/v10.0.7...v10.0.8
[10.0.7]: https://github.com/codebeltnet/unitify/compare/v10.0.6...v10.0.7
[10.0.6]: https://github.com/codebeltnet/unitify/compare/v10.0.5...v10.0.6
[10.0.5]: https://github.com/codebeltnet/unitify/compare/v10.0.4...v10.0.5
[10.0.4]: https://github.com/codebeltnet/unitify/compare/v10.0.3...v10.0.4
[10.0.3]: https://github.com/codebeltnet/unitify/compare/v10.0.2...v10.0.3
[10.0.2]: https://github.com/codebeltnet/unitify/compare/v10.0.1...v10.0.2
[10.0.1]: https://github.com/codebeltnet/unitify/compare/v10.0.0...v10.0.1
[10.0.0]: https://github.com/codebeltnet/unitify/compare/v9.0.8...v10.0.0
[9.0.8]: https://github.com/codebeltnet/unitify/compare/v9.0.7...v9.0.8
[9.0.7]: https://github.com/codebeltnet/unitify/compare/v9.0.6...v9.0.7
[9.0.6]: https://github.com/codebeltnet/unitify/compare/v9.0.5...v9.0.6
[9.0.5]: https://github.com/codebeltnet/unitify/compare/v9.0.4...v9.0.5
[9.0.4]: https://github.com/codebeltnet/unitify/compare/v9.0.3...v9.0.4
[9.0.3]: https://github.com/codebeltnet/unitify/compare/v9.0.2...v9.0.3
[9.0.2]: https://github.com/codebeltnet/unitify/compare/v9.0.1...v9.0.2
[9.0.1]: https://github.com/codebeltnet/unitify/compare/v9.0.0...v9.0.1
[9.0.0]: https://github.com/codebeltnet/unitify/releases/tag/v9.0.0
[6.0.0]: https://github.com/codebeltnet/unitify/releases/tag/v6.0.0
