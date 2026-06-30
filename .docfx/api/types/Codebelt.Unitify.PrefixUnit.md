---
uid: Codebelt.Unitify.PrefixUnit
---

## Examples

Represent a unit of measurement with an associated prefix. This example demonstrates creating `PrefixUnit` instances with different combinations of base units and prefixes, shows how to construct one from an existing unit, and demonstrates that the prefix parameter is optional (a unit with no prefix has the default `None` prefix):

```csharp
using System;
using Codebelt.Unitify;

namespace Unitify.Samples;

public class PrefixUnitExample
{
    public static void Main()
    {
        // Create a kilometer (meter with kilo prefix)
        var kilometer = new PrefixUnit(Unit.Meter, 1.0, DecimalPrefix.Kilo);
        Console.WriteLine($"Distance: {kilometer}");
        
        // Create from an existing unit
        var wattUnit = UnitFactory.CreateWatt(500);
        var kilowatt = new PrefixUnit(wattUnit, DecimalPrefix.Kilo);
        Console.WriteLine($"Power: {kilowatt}");
        
        // Create a megahertz
        var megahertz = new PrefixUnit(Unit.Hertz, 100.0, DecimalPrefix.Mega);
        Console.WriteLine($"Frequency: {megahertz}");
        
        // Prefix can be None (no prefix applied)
        var baseWatt = new PrefixUnit(Unit.Watt, 2500.0);
        Console.WriteLine($"No prefix: {baseWatt}");
    }
}
```
