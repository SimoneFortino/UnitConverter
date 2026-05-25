using System.Collections.Generic;
using UnitConverter.Utils;

namespace UnitConverter.Categories.PhysicalQuantities
{
    public class Time : PhysicalQuantity
    {
        public Time(double value, Unit unit, Multiplier multiplier) :  base(value, unit, multiplier) { }

        public override void ConvertTo(Unit targetUnit, Multiplier targetMultiplier)
        {
            double baseValue = Value * Ref[Unit];
            Value = baseValue / Ref[targetUnit];
            Unit = targetUnit;
        }
        
        private static Dictionary<Unit, double> Ref = new Dictionary<Unit, double>
        {
            // unità riferimento
            { Unit.Second, 1 },
            
            { Unit.Minute, 60 },
            { Unit.Hour, 3600 },
            { Unit.Day, 86400 },
            { Unit.Month, 2629746 },
            {  Unit.Year, 31556952}
        };
        
        internal readonly Dictionary<string, Unit> UnitsDictionary = new Dictionary<string, Unit>
        {
            { "sec", Unit.Second  },
            { "min", Unit.Minute },
            { "hr", Unit.Hour },
            { "day", Unit.Day },
            { "mnt", Unit.Month },
            { "yr", Unit.Year }
        };
    }
}