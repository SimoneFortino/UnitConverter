using UnitConverter.Utils;

namespace UnitConverter.Categories.PhysicalQuantities
{
    public class Angle : PhysicalQuantity
    {
        public Angle(double value, Unit unit, Multiplier multiplier) :  base(value, unit, multiplier)
        {
            Value = value;
            Unit = unit;
            UnitMultiplier = multiplier;
        }

        public override void ConvertTo(Unit targetUnit, Multiplier targetMultiplier)
        {
            
        }
    }
}