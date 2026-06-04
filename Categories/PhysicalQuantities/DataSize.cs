using System.Collections.Generic;
using UnitConverter.Utils;

namespace UnitConverter.Categories.PhysicalQuantities
{
    public class DataSize : PhysicalQuantity
    {
        public DataSize(double value, Unit unit) :  base(value, unit) { }

        public override void ConvertTo(Unit targetUnit)
        {
            double baseValue = Value * Ref[Unit];
            Value = baseValue / Ref[targetUnit];
            Unit = targetUnit;
        }
        
        protected override Dictionary<Unit, double> Ref { get; } = new Dictionary<Unit, double>
        {
            // S.I.
            { Unit.Byte, 1.0 },                     // B
            { Unit.Kilobyte, 1024.0 },              // KiB
            { Unit.Megabyte, 1_048_576.0 },         // MiB
            { Unit.Gigabyte, 1_073_741_824.0 },     // GiB
            { Unit.Terabyte, 1_099_511_627_776.0 }, // TiB
            
            { Unit.Bit, 0.125 },                     // b
            { Unit.Kilobit, 128.0 },                 // Kib = 1024 b
            { Unit.Megabit, 131_072.0 },             // Mib
            { Unit.Gigabit, 134_217_728.0 },         // Gib
        };
        
        internal readonly Dictionary<string, Unit> UnitsDictionary = new Dictionary<string, Unit>
        {
            { "TB", Unit.Terabyte },
            { "GB", Unit.Gigabyte },
            { "MB", Unit.Megabyte },
            { "KB", Unit.Kilobyte },
            { "B", Unit.Byte },
            
            { "Gbit", Unit.Gigabit },
            { "Mbit", Unit.Megabit },
            { "Kbit", Unit.Kilobit },
            { "bit", Unit.Bit }
        };
    }
}