using System.Collections.Generic;
using UnitConverter.Utils;

namespace UnitConverter.Categories.PhysicalQuantities
{
    public class Power : PhysicalQuantity
    {
        public Power(double value, Unit unit, Multiplier multiplier) :  base(value, unit, multiplier) { }

        public override void ConvertTo(Unit targetUnit, Multiplier targetMultiplier)
        {
            
        }
        
        private static Dictionary<Unit, double> WattRef = new Dictionary<Unit, double>
        {
            // unità riferimento
            { Unit.Watt, 1 },
            
            { Unit.HorsePower, 735.49875 }
        };
        
        internal readonly Dictionary<string, Unit> UnitsDictionary = new Dictionary<string, Unit>
        {
            { "W", Unit.Watt },
            { "HP", Unit.HorsePower }
        };
    }
}