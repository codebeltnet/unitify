---
uid: Codebelt.Unitify
summary: *content
---

Simplify unit measurement and conversion with **Codebelt.Unitify**, a comprehensive .NET library for managing units with SI unit support, metric prefixes (kilo, mega, milli, micro, etc.), and binary prefixes (kibi, mebi, gibi, etc.).

To get started, use [`UnitFactory`](xref:Codebelt.Unitify.UnitFactory) to create SI units, or access predefined SI base units via the [`Unit`](xref:Codebelt.Unitify.Unit) class.

## Start Here

Begin with **`UnitFactory`** — the primary API for creating SI units with custom precision and base values. Call static methods like `UnitFactory.CreateMeter()` or `UnitFactory.CreateWatt()` to construct units programmatically.

If you only need standard predefined base units, use the **`Unit`** class directly instead (e.g., `Unit.Meter`, `Unit.Kilogram`) to avoid factory overhead.

## When to Use

Use Codebelt.Unitify when you need to:

- Work with SI base units (meter, kilogram, second, ampere, kelvin, mole, candela) and derived units
- Apply metric (decimal) or binary prefixes to create unit variations (e.g., kilometer, megabyte, gibibyte)
- Convert between different prefix scales while preserving semantic meaning
- Format units using metric, data-centric, or custom naming conventions

## Getting Started

**Start here:** Call `UnitFactory.CreateMeter()`, `UnitFactory.CreateWatt()`, or other static factory methods to construct SI units with your desired precision and base values. `UnitFactory` is the primary entry point for programmatic unit creation.

**Alternative:** If you need one of the standard predefined SI base units (meter, kilogram, second, ampere, kelvin, mole, candela), access them directly via static properties on the `Unit` class (e.g., `Unit.Meter`, `Unit.Kilogram`) to avoid factory overhead.

Once you have a unit, you can apply metric or binary prefixes in three ways:

- **Single prefix**: Use `PrefixUnit` to combine a specific prefix with a unit (e.g., create a kilometer from `Unit.Meter` and `DecimalPrefix.Kilo`).
- **Full metric scale table**: Create a `MetricPrefixTable` to explore all available decimal-prefix representations (kilo, mega, giga, etc.) at once.
- **Full binary scale table**: Create a `DataPrefixTable` to explore all available binary-prefix representations (kibi, mebi, gibi, etc.) at once for data/storage contexts.

Choose `MetricPrefixTable` for general scientific and engineering units; choose `DataPrefixTable` exclusively for data storage and network bandwidth to avoid mixing decimal (1 kB = 1000 bytes) and binary (1 KiB = 1024 bytes) scales.

[!INCLUDE [availability-modern](../../includes/availability-modern.md)]

## Extension Members

|Type|Ext|Methods|
|--:|:-:|---|
|Prefix|⬇️|`ToPrefixUnit`, `ToBaseUnit`|
|PrefixTable|⬇️|`QuectoOrDefault`, `RontoOrDefault`, `YoctoOrDefault`, `ZeptoOrDefault`, `AttoOrDefault`, `FemtoOrDefault`, `PicoOrDefault`, `NanoOrDefault`, `MicroOrDefault`, `MilliOrDefault`, `CentiOrDefault`, `DeciOrDefault`, `DecaOrDefault`, `HectoOrDefault`, `KiloOrDefault`, `MegaOrDefault`, `GigaOrDefault`, `TeraOrDefault`, `PetaOrDefault`, `ExaOrDefault`, `ZettaOrDefault`, `YottaOrDefault`, `RonnaOrDefault`, `QuettaOrDefault`, `QuebiOrDefault`, `RobiOrDefault`, `KibiOrDefault`, `MebiOrDefault`, `GibiOrDefault`, `TebiOrDefault`, `PebiOrDefault`, `ExbiOrDefault`, `ZebiOrDefault`, `YobiOrDefault`|
|PrefixUnit|⬇️|`ToPrefixValue`, `ToBaseValue`, `ToBaseUnit`, `ToPrefixString`, `ToMetricPrefixTable`, `ToDataPrefixTable`|
