using UnitConverter.Utils;

namespace UnitConverter.Categories.PhysicalQuantities
{
    public class Power : PhysicalQuantity
    {
        public Power(double value, Unit unit, Multiplier multiplier) :  base(value, unit, multiplier) { }

        public override void ConvertTo(Unit targetUnit, Multiplier targetMultiplier)
        {
            
        }
    }
}