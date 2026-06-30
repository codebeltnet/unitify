---
uid: Codebelt.Unitify.PrefixExtensions
---

## Examples

Use extension methods on prefix types to extract base unit information and convert values. This example demonstrates a realistic workflow where you start with decimal and binary prefix instances (prerequisites: `DecimalPrefix.Kilo` and `BinaryPrefix.Kibi`), then use the `ToPrefixUnit()` extension method to combine a prefix with a unit type to create scaled units (setup), and finally invoke `ToBaseUnit()` and `ToPrefixValue()` methods to demonstrate conversion and scaling operations. The outcome shows how extension methods simplify the creation of prefix-unit combinations and value scaling without requiring manual unit construction:

```csharp
using System;
using Codebelt.Unitify;

namespace Unitify.Samples;

public class PrefixExtensionsExample
{
    public static void Main()
    {
        // Create instances of DecimalPrefix and BinaryPrefix
        var kilo = DecimalPrefix.Kilo;
        var kibi = BinaryPrefix.Kibi;
        
        // Use the ToPrefixUnit extension method to create scaled units
        // Create a kilo-meter by combining the Kilo prefix with a meter unit
        var meterUnit = new UnitTestWrapper(); // Implement IUnit
        var kilometer = kilo.ToPrefixUnit(meterUnit);
        Console.WriteLine($"Kilometer: {kilometer}");
        
        // Create a kibi-byte using the Kibi prefix
        var byteUnit = new UnitTestWrapper(); // Implement IUnit
        var kibibyte = kibi.ToPrefixUnit(byteUnit);
        Console.WriteLine($"Kibibyte: {kibibyte}");
        
        // Use ToBaseUnit extension method to create a unit with prefix applied to a base unit
        var wattUnit = kilo.ToBaseUnit(Unit.Watt, 5.0);
        Console.WriteLine($"Kilowatt (5 kW): {wattUnit}");
        
        // Use ToPrefixValue to convert a raw value to prefix scale
        var rawValue = 5000.0;
        var prefixedValue = kilo.ToPrefixValue(rawValue);
        Console.WriteLine($"{rawValue} base units = {prefixedValue} kilo units");
    }
}

// Simple test implementation of IUnit
public class UnitTestWrapper : IUnit
{
    public string Category => "Data";
    public string Name => "byte";
    public string Symbol => "B";
    public double Value => 1.0;
    public UnitFormatOptions FormatOptions => new();
}
```
