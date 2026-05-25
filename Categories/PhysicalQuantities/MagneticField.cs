using System.Collections.Generic;
using UnitConverter.Utils;

namespace UnitConverter.Categories.PhysicalQuantities
{
    public class MagneticField : PhysicalQuantity
    {
        public MagneticField(double value, Unit unit, Multiplier multiplier) :  base(value, unit, multiplier) { }

        public override void ConvertTo(Unit targetUnit, Multiplier targetMultiplier)
        {
            
        }
        
        internal readonly Dictionary<string, Unit> UnitsDictionary = new Dictionary<string, Unit>
        {
            { "T", Unit.Tesla },
            { "Gs", Unit.Gauss }
        };
    }
}