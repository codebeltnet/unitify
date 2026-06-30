---
uid: Codebelt.Unitify.UnitFactory
---

## Examples

Create SI units with predefined base values using factory methods. This example demonstrates factory methods for different unit types (meter, watt, byte, and second), each creating a fully-configured unit instance with a base value so you can immediately start formatting and working with the result:

```csharp
using System;
using Codebelt.Unitify;

namespace Unitify.Samples;

public class UnitFactoryExample
{
    public static void Main()
    {
        // Create a meter unit
        var meter = UnitFactory.CreateMeter(100);
        Console.WriteLine($"Distance: {meter}");
        
        // Create a watt unit
        var watt = UnitFactory.CreateWatt(1500);
        Console.WriteLine($"Power: {watt}");
        
        // Create a byte unit for data storage
        var byte_unit = UnitFactory.CreateByte(1024);
        Console.WriteLine($"Data: {byte_unit}");
        
        // Create a second unit for time
        var second = UnitFactory.CreateSecond(3600);
        Console.WriteLine($"Time: {second}");
    }
}
```
