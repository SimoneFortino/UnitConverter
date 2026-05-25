using System.Collections.Generic;
using UnitConverter.Utils;

namespace UnitConverter.Categories.PhysicalQuantities
{
    public class ElectricCharge : PhysicalQuantity
    {
        public ElectricCharge(double value, Unit unit, Multiplier multiplier) :  base(value, unit, multiplier) { }

        public override void ConvertTo(Unit targetUnit, Multiplier targetMultiplier)
        {
            
        }
        
        private static Dictionary<Unit, double> CoulombRef = new Dictionary<Unit, double>
        {
            // unità riferimento
            { Unit.Coulomb, 1 },
            { Unit.AmpereHour, 3600.0 }
        };
        
        internal readonly Dictionary<string, Unit> UnitsDictionary = new Dictionary<string, Unit>
        {
            { "C", Unit.Coulomb},
            { "Ah", Unit.AmpereHour}
        };
    }
}