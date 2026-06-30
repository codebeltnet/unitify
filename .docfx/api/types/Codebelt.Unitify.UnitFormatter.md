---
uid: Codebelt.Unitify.UnitFormatter
---

## Examples

Format units with custom numeric representations and culture-specific formatting. This example demonstrates creating units with different base values, shows the default string representation, applies custom format options via the factory method, and demonstrates using a `UnitFormatter` instance for explicit formatting with a specific `CultureInfo`:

```csharp
using System;
using System.Globalization;
using Codebelt.Unitify;

namespace Unitify.Samples;

public class UnitFormatterExample
{
    public static void Main()
    {
        // Create units with different values
        var watt = UnitFactory.CreateWatt(1234.5);
        var kilowatt = UnitFactory.CreateWatt(1234.5, DecimalPrefix.Kilo);
        
        // Display default string representation
        Console.WriteLine($"1 Watt: {watt}");
        Console.WriteLine($"1 Kilowatt: {kilowatt}");
        
        // Create a unit with custom formatting options
        var formattedWatt = UnitFactory.CreateWatt(1234.5, setup: options =>
        {
            options.NumberFormat = "N2";
            options.Style = NamingStyle.Compound;
        });
        
        Console.WriteLine($"With custom formatting: {formattedWatt}");
        
        // Create a formatter instance for custom formatting scenarios
        var formatter = new UnitFormatter();
        string customFormat = formatter.Format("Power: {0:F1}", watt, CultureInfo.InvariantCulture);
        Console.WriteLine(customFormat);
    }
}
```
