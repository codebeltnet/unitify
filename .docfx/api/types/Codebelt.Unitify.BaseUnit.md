---
uid: Codebelt.Unitify.BaseUnit
---

## Examples

Represent a unit of measurement with its category, name, and symbol. This example creates several `BaseUnit` instances, demonstrates property access, and shows how to compare units for equality to verify that units with identical properties are considered equal:

```csharp
using System;
using Codebelt.Unitify;

namespace Unitify.Samples;

public class BaseUnitExample
{
    public static void Main()
    {
        // Create a meter base unit
        var meter = new BaseUnit("Length", "Meter", "m");
        
        Console.WriteLine($"Category: {meter.Category}");
        Console.WriteLine($"Name: {meter.Name}");
        Console.WriteLine($"Symbol: {meter.Symbol}");
        
        // Create a kilogram base unit
        var kilogram = new BaseUnit("Mass", "Kilogram", "kg");
        
        // Compare base units
        var sameUnit = new BaseUnit("Length", "Meter", "m");
        Console.WriteLine($"meter == sameUnit: {meter == sameUnit}");
    }
}
```
