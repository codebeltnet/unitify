---
uid: Codebelt.Unitify.MetricPrefixTable
---

## Examples

Browse all decimal prefix representations of a SI unit. This example creates a `MetricPrefixTable` from a watt quantity, then displays both the full table showing all decimal-scaled (power-of-10) representations and an aggregate summary indicating which SI prefix scales are available for that unit value:

```csharp
using System;
using Codebelt.Unitify;

namespace Unitify.Samples;

public class MetricPrefixTableExample
{
    public static void Main()
    {
        // Create a unit: 11,745 watts (approximately 11.745 kW)
        var wattUnit = UnitFactory.CreateWatt(11745);
        
        // Create a metric prefix table to see all decimal scales
        var table = new MetricPrefixTable(wattUnit);
        
        // Display all representations from quecto to yotta
        Console.WriteLine("Metric prefix representations:");
        Console.WriteLine(table.ToString());
        
        // Show aggregate summary
        Console.WriteLine("\nAggregate:");
        Console.WriteLine(table.ToAggregateString());
    }
}
```
