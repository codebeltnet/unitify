---
uid: Codebelt.Unitify.NamingStyle
---

## Examples

Control how units are formatted as text by choosing between symbol-based and compound naming styles. This example creates a prefix unit, displays its default representation, then creates another using a setup action to apply `NamingStyle.Compound` so the output shows full names instead of abbreviations:

```csharp
using System;
using Codebelt.Unitify;

namespace Unitify.Samples;

public class NamingStyleExample
{
    public static void Main()
    {
        // Create a kilometer with Default naming
        var kilometer = new PrefixUnit(Unit.Meter, 1.0, DecimalPrefix.Kilo);
        Console.WriteLine($"Default: {kilometer}");
        
        // Use Compound naming style to show compound names
        var compoundKilometer = new PrefixUnit(Unit.Meter, 5.0, DecimalPrefix.Kilo, o => 
        {
            o.Style = NamingStyle.Compound;
        });
        Console.WriteLine($"Compound: {compoundKilometer}");
    }
}
```
