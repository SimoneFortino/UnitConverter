using System.Collections.Generic;
using UnitConverter.Utils;

namespace UnitConverter.Categories.PhysicalQuantities
{
    public class Force : PhysicalQuantity
    {
        public Force(double value, Unit unit, Multiplier multiplier) :  base(value, unit, multiplier) { }

        public override void ConvertTo(Unit targetUnit, Multiplier targetMultiplier)
        {
            
        }
        
        private static Dictionary<Unit, double> NewtonRef = new Dictionary<Unit, double>
        {
            // unità riferimento
            { Unit.Newton, 1 },
            
            { Unit.Dyne, 1e-5 }
        };
        
        internal readonly Dictionary<string, Unit> UnitsDictionary = new Dictionary<string, Unit>
        {
            { "N", Unit.Newton},
            { "dyn", Unit.Dyne}
        };
    }
}