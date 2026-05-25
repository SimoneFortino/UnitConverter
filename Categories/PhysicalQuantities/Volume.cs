using System.Collections.Generic;
using UnitConverter.Utils;

namespace UnitConverter.Categories.PhysicalQuantities
{
    public class Volume : PhysicalQuantity
    {
        public Volume(double value, Unit unit, Multiplier multiplier) :  base(value, unit, multiplier) { }

        public override void ConvertTo(Unit targetUnit, Multiplier targetMultiplier)
        {
            
        }
        
        internal readonly Dictionary<string, Unit> UnitsDictionary = new Dictionary<string, Unit>
        {
            { "l", Unit.Liter  },
            { "m3", Unit.CubicMeter },
            { "gal", Unit.Gallon },
            { "pt", Unit.Pint }
        };
    }
}