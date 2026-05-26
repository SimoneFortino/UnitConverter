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
        
        private static Dictionary<Unit, double> Ref = new Dictionary<Unit, double>
        {
            // unità riferimento
            { Unit.Byte, 1 },
            { Unit.Kilobyte, 1e3 },
            { Unit.Megabyte, 1e6 },
            { Unit.Gigabyte, 1e9 },
            { Unit.Terabyte, 1e12 },
            
            { Unit.Bit, 0.125 },
            { Unit.Kilobit, 125 },
            { Unit.Megabit, 125e3 },
            { Unit.Gigabit, 125e6 },
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