using System.Collections.Generic;
using UnitConverter.Utils;

namespace UnitConverter.Categories.PhysicalQuantities
{
    public class Energy : PhysicalQuantity
    {
        public Energy(double value, Unit unit, Multiplier multiplier) :  base(value, unit, multiplier) { }

        public override void ConvertTo(Unit targetUnit, Multiplier targetMultiplier)
        {
            
        }
        private static Dictionary<Unit, double> JouleRef = new Dictionary<Unit, double>
        {
            // unità riferimento
            { Unit.Joule, 1 },
            
            { Unit.WattHour, 3600.0 },
            { Unit.Calorie, 4.184 },
        };
        
        
        internal readonly Dictionary<string, Unit> UnitsDictionary = new Dictionary<string, Unit>
        {
            { "J", Unit.Joule},
            { "cal", Unit.Calorie},
            { "Wh", Unit.WattHour}
        };
    }
}