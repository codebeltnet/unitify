---
uid: Codebelt.Unitify.UnitFormatOptions
---

## Examples

Configure how units are formatted when converted to strings by creating and using `UnitFormatOptions` instances. This example demonstrates creating `UnitFormatOptions` directly with custom settings, applying those settings to units via factory methods, and shows how different number formats and naming styles produce different string representations:

```csharp
using System;
using Codebelt.Unitify;

namespace Unitify.Samples;

public class UnitFormatOptionsExample
{
    public static void Main()
    {
        // Create a UnitFormatOptions instance directly
        var options = new UnitFormatOptions
        {
            NumberFormat = "F2",
            Style = NamingStyle.Compound
        };
        
        // Apply the options to a unit via UnitFactory
        var watt = UnitFactory.CreateWatt(1234.567, setup: opts =>
        {
            opts.NumberFormat = options.NumberFormat;
            opts.Style = options.Style;
        });
        
        Console.WriteLine($"With custom options: {watt}");
        
        // Create another UnitFormatOptions with different settings
        var symbolOptions = new UnitFormatOptions
        {
            NumberFormat = "#,##0.##",
            Style = NamingStyle.Symbol
        };
        
        // Display the configured options
        Console.WriteLine($"Number Format: {symbolOptions.NumberFormat}");
        Console.WriteLine($"Style: {symbolOptions.Style}");
        
        // Apply symbol options to a meter unit
        var meter = UnitFactory.CreateMeter(1500.0, setup: opts =>
        {
            opts.NumberFormat = symbolOptions.NumberFormat;
            opts.Style = symbolOptions.Style;
        });
        
        Console.WriteLine($"Meter with symbol options: {meter}");
    }
}
```
