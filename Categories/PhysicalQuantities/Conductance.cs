using UnitConverter.Utils;

namespace UnitConverter.Categories.PhysicalQuantities
{
    public class Conductance : PhysicalQuantity
    {
        public Conductance(double value, Unit unit, Multiplier multiplier) :  base(value, unit, multiplier) { }

        public override void ConvertTo(Unit targetUnit, Multiplier targetMultiplier)
        {
            
        }
    }
}