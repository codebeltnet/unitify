---
uid: Codebelt.Unitify.PrefixTableExtensions
---

## Examples

Lookup specific SI and binary prefix scales from a table to obtain scaled representations at each available magnitude. The setup prerequisite is a unit value large enough to have multiple valid prefix scales (for example, 1E21 watts or 1 TiB of bytes). This example creates `MetricPrefixTable` and `DataPrefixTable` instances (setup phase), then demonstrates the lookup workflow by calling available `*OrDefault()` extension methods to check which prefix scales exist at each magnitude level. The outcome displays all available prefix representations organized by scale category (SI decimal large/small scales, binary data scales, and miscellaneous decimal scales), allowing you to see the complete prefix transformation options. In production code, you would typically call only the specific `*OrDefault()` methods relevant to your domain (for example, `KiloOrDefault()` and `MebiOrDefault()`) to avoid unnecessary allocations and focus on the prefix scales needed for your use case.

```csharp
using System;
using Codebelt.Unitify;

namespace Unitify.Samples;

public class PrefixTableExtensionsExample
{
    public static void Main()
    {
        // Create a metric prefix table from a large watt value
        var wattUnit = UnitFactory.CreateWatt(1E21); // Very large value in watts
        var table = new MetricPrefixTable(wattUnit);
        
        // QuettaOrDefault: Scale the unit to the quetta (10^30) prefix, returning null if the value
        // does not have a valid quetta representation. Use this for extremely large scientific values.
        Console.WriteLine("=== SI Decimal Prefixes (Large Scales) ===");
        var quetta = table.QuettaOrDefault();
        if (quetta != null) Console.WriteLine($"Quetta: {quetta}");
        
        // ZettaOrDefault: Scale the unit to the zetta (10^21) prefix, returning null if unavailable.
        // Common for very large data or energy quantities in scientific computing.
        var zetta = table.ZettaOrDefault();
        if (zetta != null) Console.WriteLine($"Zetta: {zetta}");
        
        // YottaOrDefault: Scale the unit to the yotta (10^24) prefix, returning null if not applicable.
        // Used for astronomical or theoretical quantities exceeding exabytes or exawatts.
        var yotta = table.YottaOrDefault();
        if (yotta != null) Console.WriteLine($"Yotta: {yotta}");
        
        // Common SI decimal prefixes: Scale from very large (mega, giga) to medium scales.
        // KiloOrDefault, MegaOrDefault, GigaOrDefault, TeraOrDefault, and PetaOrDefault cover
        // the most frequently used commercial and engineering scales.
        var kilo = table.KiloOrDefault();
        if (kilo != null) Console.WriteLine($"Kilo: {kilo}");
        
        var mega = table.MegaOrDefault();
        if (mega != null) Console.WriteLine($"Mega: {mega}");
        
        var giga = table.GigaOrDefault();
        if (giga != null) Console.WriteLine($"Giga: {giga}");
        
        var tera = table.TeraOrDefault();
        if (tera != null) Console.WriteLine($"Tera: {tera}");
        
        var peta = table.PetaOrDefault();
        if (peta != null) Console.WriteLine($"Peta: {peta}");
        
        var exa = table.ExaOrDefault();
        if (exa != null) Console.WriteLine($"Exa: {exa}");
        
        // Small SI decimal prefixes: Scale from milli (10^-3) down to quecto (10^-30).
        // These are essential for medical, laboratory, and precision manufacturing applications.
        // MilliOrDefault and MicroOrDefault are the most common for everyday engineering.
        Console.WriteLine("\n=== SI Decimal Prefixes (Small Scales) ===");
        var milli = table.MilliOrDefault();
        if (milli != null) Console.WriteLine($"Milli: {milli}");
        
        var micro = table.MicroOrDefault();
        if (micro != null) Console.WriteLine($"Micro: {micro}");
        
        var nano = table.NanoOrDefault();
        if (nano != null) Console.WriteLine($"Nano: {nano}");
        
        var pico = table.PicoOrDefault();
        if (pico != null) Console.WriteLine($"Pico: {pico}");
        
        var femto = table.FemtoOrDefault();
        if (femto != null) Console.WriteLine($"Femto: {femto}");
        
        var atto = table.AttoOrDefault();
        if (atto != null) Console.WriteLine($"Atto: {atto}");
        
        var zepto = table.ZeptoOrDefault();
        if (zepto != null) Console.WriteLine($"Zepto: {zepto}");
        
        var yocto = table.YoctoOrDefault();
        if (yocto != null) Console.WriteLine($"Yocto: {yocto}");
        
        var ronto = table.RontoOrDefault();
        if (ronto != null) Console.WriteLine($"Ronto: {ronto}");
        
        var quecto = table.QuectoOrDefault();
        if (quecto != null) Console.WriteLine($"Quecto: {quecto}");
        
        // Binary prefix scales in a data table: Scale from kibi (2^10) through yobi (2^80).
        // QuebiOrDefault and RobiOrDefault represent the newest binary scales (added in 2022).
        // Use binary prefixes exclusively for data storage and network bandwidth to avoid
        // confusion with decimal SI scales; 1 KiB = 1024 bytes, while 1 kB = 1000 bytes.
        Console.WriteLine("\n=== Binary Prefixes (Data Table) ===");
        var byteUnit = UnitFactory.CreateByte(1099511627776); // 1 TiB
        var dataTable = new DataPrefixTable(byteUnit);
        
        // QuebiOrDefault: Scale to the quebi (2^100) prefix for data storage.
        // Used in theoretical or future-scale data center planning.
        var quobi = dataTable.QuebiOrDefault();
        if (quobi != null) Console.WriteLine($"Quebi: {quobi}");
        
        // RobiOrDefault: Scale to the robi (2^90) prefix, the second-newest binary scale.
        var robi = dataTable.RobiOrDefault();
        if (robi != null) Console.WriteLine($"Robi: {robi}");
        
        // Common binary prefixes: KibiOrDefault (1024 bytes), MebiOrDefault (1 million bytes),
        // GibiOrDefault (1 billion bytes), and TebiOrDefault (1 trillion bytes) are the most
        // commonly encountered in modern storage and memory specifications.
        var kibi = dataTable.KibiOrDefault();
        if (kibi != null) Console.WriteLine($"Kibi: {kibi}");
        
        var mebi = dataTable.MebiOrDefault();
        if (mebi != null) Console.WriteLine($"Mebi: {mebi}");
        
        var gibi = dataTable.GibiOrDefault();
        if (gibi != null) Console.WriteLine($"Gibi: {gibi}");
        
        var tebi = dataTable.TebiOrDefault();
        if (tebi != null) Console.WriteLine($"Tebi: {tebi}");
        
        var pebi = dataTable.PebiOrDefault();
        if (pebi != null) Console.WriteLine($"Pebi: {pebi}");
        
        var exbi = dataTable.ExbiOrDefault();
        if (exbi != null) Console.WriteLine($"Exbi: {exbi}");
        
        var zebi = dataTable.ZebiOrDefault();
        if (zebi != null) Console.WriteLine($"Zebi: {zebi}");
        
        var yobi = dataTable.YobiOrDefault();
        if (yobi != null) Console.WriteLine($"Yobi: {yobi}");
        
        // Additional decimal prefixes: CentiOrDefault, DeciOrDefault, DecaOrDefault, and HectoOrDefault
        // cover non-standard but occasionally used scales in specialized fields like chemistry
        // and older engineering references. RonnaOrDefault and RontoOrDefault are the newest decimal scales.
        Console.WriteLine("\n=== Additional Decimal Prefixes ===");
        var centi = table.CentiOrDefault();
        if (centi != null) Console.WriteLine($"Centi: {centi}");
        
        var deci = table.DeciOrDefault();
        if (deci != null) Console.WriteLine($"Deci: {deci}");
        
        var deca = table.DecaOrDefault();
        if (deca != null) Console.WriteLine($"Deca: {deca}");
        
        var hecto = table.HectoOrDefault();
        if (hecto != null) Console.WriteLine($"Hecto: {hecto}");
        
        var ronna = table.RonnaOrDefault();
        if (ronna != null) Console.WriteLine($"Ronna: {ronna}");
    }
}
```
