using System.Collections.Generic;

namespace UnitConverter.Categories.PhysicalQuantities
{
    public class Lenght : PhysicalQuantity
    {
        public Lenght(double value, Unit unit, Multiplier unitMultiplier) : base(value, unit, unitMultiplier)
        {
        }

        public override void ConvertTo(Unit targetUnit, Multiplier targetMultiplier)
        {
            ConvertByMultiplier(targetMultiplier);
        }

        private static Dictionary<Unit, double> ToMeter = new Dictionary<Unit, double>
        {
            { Unit.Meter, 1 },
            { Unit.Mile, 1609.34 },
            
        };
    }
}