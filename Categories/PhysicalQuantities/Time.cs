using System.Collections.Generic;
using UnitConverter.Utils;

namespace UnitConverter.Categories.PhysicalQuantities
{
    public class Time : PhysicalQuantity
    {
        public Time(double value, Unit unit, Multiplier multiplier) :  base(value, unit, multiplier) { }

        public override void ConvertTo(Unit targetUnit, Multiplier targetMultiplier)
        {
            
        }
        
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