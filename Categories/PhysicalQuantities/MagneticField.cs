using System.Collections.Generic;
using UnitConverter.Utils;

namespace UnitConverter.Categories.PhysicalQuantities
{
    public class MagneticField : PhysicalQuantity
    {
        public MagneticField(double value, Unit unit, Multiplier multiplier) :  base(value, unit, multiplier) { }

        public override void ConvertTo(Unit targetUnit, Multiplier targetMultiplier)
        {
            double baseValue = Value * Ref[Unit];
            Value = baseValue / Ref[targetUnit];
            Unit = targetUnit;
        }
        
        private static Dictionary<Unit, double> Ref = new Dictionary<Unit, double>
        {
            // unità riferimento
            { Unit.Tesla, 1 },
            { Unit.Millitesla, 1e-3 },
            { Unit.Microtesla, 1e-6 },
            
            { Unit.Gauss, 1e-4 }
        };
        
        internal readonly Dictionary<string, Unit> UnitsDictionary = new Dictionary<string, Unit>
        {
            { "T", Unit.Tesla },
            { "mT", Unit.Millitesla },
            { "uT", Unit.Microtesla },
            { "Gs", Unit.Gauss }
        };
    }
}