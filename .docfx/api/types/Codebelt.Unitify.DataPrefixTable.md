---
uid: Codebelt.Unitify.DataPrefixTable
---

## Examples

Browse all binary prefix representations of a data storage unit. This example creates a `DataPrefixTable` from a byte quantity, then displays both the full table of all binary-scaled representations and an aggregate summary showing which scales are available for that unit value:

```csharp
using System;
using Codebelt.Unitify;

namespace Unitify.Samples;

public class DataPrefixTableExample
{
    public static void Main()
    {
        // Create a unit representing 1,048,576 bytes (1 MiB)
        var byteUnit = UnitFactory.CreateByte(1048576);
        
        // Create a data prefix table to see all binary scales
        var table = new DataPrefixTable(byteUnit);
        
        // Display all representations
        Console.WriteLine("Data storage representations:");
        Console.WriteLine(table.ToString());
        
        // Show aggregate summary
        Console.WriteLine("\nAggregate:");
        Console.WriteLine(table.ToAggregateString());
    }
}
```
