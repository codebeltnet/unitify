---
uid: Codebelt.Unitify.PrefixUnitFormatter
---

## Examples

Format prefix units with custom numeric and culture-specific representations. This example demonstrates creating a prefix unit with custom format options, shows the default string representation, uses a `PrefixUnitFormatter` instance for custom formatting with a `CultureInfo`, and displays how to create a metric prefix table from a prefix unit to show multiple scaled representations:

```csharp
using System;
using System.Globalization;
using Codebelt.Unitify;

namespace Unitify.Samples;

public class PrefixUnitFormatterExample
{
    public static void Main()
    {
        // Create a formatted prefix unit
        var kilowatt = new PrefixUnit(Unit.Watt, 5.5, DecimalPrefix.Kilo, options =>
        {
            options.NumberFormat = "F2"; // 2 decimal places
        });
        
        // Default formatting
        Console.WriteLine($"Default: {kilowatt}");
        
        // Create a formatter instance
        var formatter = new PrefixUnitFormatter();
        
        // Format with custom format string
        var formatted = formatter.Format("{0:F1} {1}", kilowatt, CultureInfo.CurrentCulture);
        Console.WriteLine($"Formatted: {formatted}");
        
        // Format with metric prefix table for detailed output
        var table = new MetricPrefixTable(kilowatt);
        Console.WriteLine("Prefix table:");
        Console.WriteLine(table.ToString());
    }
}
```
