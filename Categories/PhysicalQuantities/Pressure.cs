using System.Collections.Generic;
using UnitConverter.Utils;

namespace UnitConverter.Categories.PhysicalQuantities
{
    public class Pressure : PhysicalQuantity
    {
        public Pressure(double value, Unit unit, Multiplier multiplier) :  base(value, unit, multiplier) { }

        public override void ConvertTo(Unit targetUnit, Multiplier targetMultiplier)
        {
            
        }
        
        internal readonly Dictionary<string, Unit> UnitsDictionary = new Dictionary<string, Unit>
        {
            { "PSI", Unit.Psi },
            { "BAR", Unit.Bar },
            { "atm", Unit.Atmosphere },
            { "mmHg", Unit.MillimeterHg}
        };
    }
}