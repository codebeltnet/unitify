---
uid: Codebelt.Unitify.PrefixStyle
---

## Examples

Control how data prefix tables format output using binary (powers of 1024) or decimal (powers of 10) scales. This example demonstrates the `ToString(PrefixStyle)` method on `DataPrefixTable` to display the same byte quantity in two different prefix styles, allowing you to see how the same value appears with binary vs. decimal formatting:

```csharp
using System;
using Codebelt.Unitify;

namespace Unitify.Samples;

public class PrefixStyleExample
{
    public static void Main()
    {
        // Create a data unit table
        var byteUnit = UnitFactory.CreateByte(1048576); // 1,048,576 bytes
        var dataTable = new DataPrefixTable(byteUnit);
        
        // Display with binary style formatting (1024-based prefixes)
        Console.WriteLine("Binary prefix style (powers of 1024):");
        Console.WriteLine(dataTable.ToString(PrefixStyle.Binary));
        
        Console.WriteLine("\nDecimal prefix style (powers of 10):");
        Console.WriteLine(dataTable.ToString(PrefixStyle.Decimal));
    }
}
```
