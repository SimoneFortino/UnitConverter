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
        
        private static Dictionary<Unit, double> GramRef = new Dictionary<Unit, double>
        {
            // unità riferimento
            { Unit.Gram, 1 },
            
            { Unit.Pound, 453.59237 },
            { Unit.Ounce, 28.349523125 },
            { Unit.AtomicMass, 1.66053906660e-24 }
        };
        
        internal readonly Dictionary<string, Unit> UnitsDictionary = new Dictionary<string, Unit>
        {
            { "g", Unit.Gram },
            { "lb", Unit.Pound },
            { "oz", Unit.Ounce },
            { "amu", Unit.AtomicMass }
        };
    }
}