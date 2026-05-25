using System.Collections.Generic;
using UnitConverter.Utils;

namespace UnitConverter.Categories.PhysicalQuantities
{
    public class Angle : PhysicalQuantity
    {
        public Angle(double value, Unit unit, Multiplier multiplier) :  base(value, unit, multiplier) { }

        public override void ConvertTo(Unit targetUnit, Multiplier targetMultiplier)
        {
            
        }
        
        private static Dictionary<Unit, double> RadRef = new Dictionary<Unit, double>
        {
            // unità riferimento
            { Unit.Radian, 1 },
            { Unit.Degree, 0.017453292519943295 }
        };

        internal readonly Dictionary<string, Unit> UnitsDictionary = new Dictionary<string, Unit>
        {
            { "deg", Unit.Degree },
            { "rad", Unit.Radian }
        };
    }
}