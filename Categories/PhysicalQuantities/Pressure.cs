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
        
        private static Dictionary<Unit, double> PascalRef = new Dictionary<Unit, double>
        {
            // unità riferimento
            { Unit.Pascal, 1 },
            
            { Unit.Atmosphere, 101325 },
            { Unit.Bar, 100000 },
            { Unit.MillimeterHg, 133.322387415 },
            { Unit.Psi, 6894.757293168 }
        };
        
        internal readonly Dictionary<string, Unit> UnitsDictionary = new Dictionary<string, Unit>
        {
            { "PSI", Unit.Psi },
            { "BAR", Unit.Bar },
            { "atm", Unit.Atmosphere },
            { "mmHg", Unit.MillimeterHg},
            { "Pa", Unit.Pascal }
        };
    }
}