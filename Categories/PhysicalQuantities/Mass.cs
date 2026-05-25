using System.Collections.Generic;
using UnitConverter.Utils;

namespace UnitConverter.Categories.PhysicalQuantities
{
    public class Mass : PhysicalQuantity
    {
        public Mass(double value, Unit unit, Multiplier multiplier) :  base(value, unit, multiplier) { }

        public override void ConvertTo(Unit targetUnit, Multiplier targetMultiplier)
        {
            
        }
        
        internal readonly Dictionary<string, Unit> UnitsDictionary = new Dictionary<string, Unit>
        {
            { "g", Unit.Gram },
            { "lb", Unit.Pound },
            { "oz", Unit.Ounce },
            { "amu", Utils.Unit.AtomicMass }
        };
    }
}