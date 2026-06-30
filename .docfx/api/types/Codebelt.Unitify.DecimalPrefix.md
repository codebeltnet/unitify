---
uid: Codebelt.Unitify.DecimalPrefix
---

## Examples

Use decimal (metric) prefixes (kilo, mega, milli, micro, etc.) for SI measurements. This example retrieves prefix constants, extracts their symbols and multiplier values, converts raw measurements to prefixed scales using `ToPrefixValue()`, and shows how to construct `PrefixUnit` objects that apply different scales to physical quantities:

```csharp
using System;
using Codebelt.Unitify;

namespace Unitify.Samples;

public class DecimalPrefixExample
{
    public static void Main()
    {
        // Get the kilo prefix (10^3)
        var kilo = DecimalPrefix.Kilo;
        Console.WriteLine($"Kilo symbol: {kilo.Symbol}");
        Console.WriteLine($"Kilo multiplier: {kilo.Multiplier}");
        
        // Convert a value to kilo scale
        var meters = 5000.0;
        var kilometers = kilo.ToPrefixValue(meters);
        Console.WriteLine($"{meters} m = {kilometers} km");
        
        // Create a watt unit with kilo prefix
        var kilowatt = new PrefixUnit(Unit.Watt, 5, DecimalPrefix.Kilo);
        Console.WriteLine($"Power: {kilowatt}");
        
        // Work with micro prefix for small values
        var micro = DecimalPrefix.Micro;
        var amperes = 0.000005;
        var microamperes = micro.ToPrefixValue(amperes);
        Console.WriteLine($"{amperes} A = {microamperes} µA");
    }
}
```
