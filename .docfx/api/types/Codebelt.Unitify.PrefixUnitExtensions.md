---
uid: Codebelt.Unitify.PrefixUnitExtensions
---

## Examples

Convert and transform prefix units to other prefix scales and formats. This example demonstrates extension methods like `ToBaseUnit()`, `ToBaseValue()`, `ToPrefixValue()`, `ToMetricPrefixTable()`, `ToDataPrefixTable()`, and `ToPrefixString()`, showing how to extract different representations and scale conversions from a prefix unit:

```csharp
using System;
using Codebelt.Unitify;

namespace Unitify.Samples;

public class PrefixUnitExtensionsExample
{
    public static void Main()
    {
        // Create a kilowatt
        var kilowatt = new PrefixUnit(Unit.Watt, 5.0, DecimalPrefix.Kilo);
        Console.WriteLine($"Original: {kilowatt}");
        
        // Convert to base unit using extension method
        var wattUnit = kilowatt.ToBaseUnit();
        Console.WriteLine($"Base unit: {wattUnit}");
        
        // Get the base value in watts
        var baseValue = kilowatt.ToBaseValue();
        Console.WriteLine($"Base value: {baseValue} W");
        
        // Get the prefix value (the numeric part with the prefix applied)
        var prefixValue = kilowatt.ToPrefixValue();
        Console.WriteLine($"Prefix value: {prefixValue}");
        
        // Convert to a metric prefix table and look up different scales
        var metricTable = kilowatt.ToMetricPrefixTable();
        var megawatt = metricTable?.MegaOrDefault();
        if (megawatt != null)
        {
            Console.WriteLine($"Mega scale: {megawatt}");
        }
        
        // Convert to a data prefix table for binary scales
        var dataTable = kilowatt.ToDataPrefixTable();
        Console.WriteLine($"Data table available: {dataTable != null}");
        
        // Get a formatted prefix string
        var prefixString = kilowatt.ToPrefixString();
        Console.WriteLine($"Prefix string: {prefixString}");
    }
}
```
