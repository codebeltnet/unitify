---
uid: Codebelt.Unitify.BinaryPrefix
---

## Examples

Work with binary prefixes (kibi, mebi, gibi, etc.) for data storage measurements. This example retrieves binary prefix constants, demonstrates property access to find their symbols and multiplier values, converts raw byte values to binary scales using `ToPrefixValue()`, and shows how to construct `PrefixUnit` objects that combine a unit with a binary prefix:

```csharp
using System;
using Codebelt.Unitify;

namespace Unitify.Samples;

public class BinaryPrefixExample
{
    public static void Main()
    {
        // Get the kibi prefix (2^10)
        var kibi = BinaryPrefix.Kibi;
        Console.WriteLine($"Kibi symbol: {kibi.Symbol}");
        Console.WriteLine($"Kibi multiplier: {kibi.Multiplier}");
        
        // Work with data prefix values
        var bytes = 1024.0;
        var kibibytes = kibi.ToPrefixValue(bytes); // Convert to kibi scale
        Console.WriteLine($"{bytes} bytes = {kibibytes} KiB");
        
        // Create a base unit value with binary prefix
        var dataUnit = new PrefixUnit(Unit.Byte, 1048576, BinaryPrefix.Mebi); // 1 MiB
        Console.WriteLine($"Data unit: {dataUnit}");
    }
}
```
