using System.Collections.Generic;
using UnitConverter.Utils;

namespace UnitConverter.Categories.PhysicalQuantities
{
    public class Volume : PhysicalQuantity
    {
        public Volume(double value, Unit unit, Multiplier multiplier) :  base(value, unit, multiplier) { }

        public override void ConvertTo(Unit targetUnit, Multiplier targetMultiplier)
        {
            double baseValue = Value * Ref[Unit];
            Value = baseValue / Ref[targetUnit];
            Unit = targetUnit;
        }
        
        private static Dictionary<Unit, double> Ref = new Dictionary<Unit, double>
        {
            // unità riferimento
            { Unit.Liter, 1 },
            
            { Unit.CubicMeter, 1000 },
            { Unit.Gallon, 3.785411784 },
            { Unit.Pint, 0.473176473 },
        };
        
        internal readonly Dictionary<string, Unit> UnitsDictionary = new Dictionary<string, Unit>
        {
            { "l", Unit.Liter  },
            { "m3", Unit.CubicMeter },
            { "gal", Unit.Gallon },
            { "pt", Unit.Pint }
        };
    }
}