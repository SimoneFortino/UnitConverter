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
        
        private static Dictionary<Unit, double> TeslaRef = new Dictionary<Unit, double>
        {
            // unità riferimento
            { Unit.Tesla, 1 },
            
            { Unit.Gauss, 1e-4 }
        };
        
        internal readonly Dictionary<string, Unit> UnitsDictionary = new Dictionary<string, Unit>
        {
            { "T", Unit.Tesla },
            { "Gs", Unit.Gauss }
        };
    }
}