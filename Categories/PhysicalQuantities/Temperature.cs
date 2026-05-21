namespace UnitConverter.Categories.PhysicalQuantities
{
    public class Temperature : PhysicalQuantity
    {
        public Temperature(double value, Unit unit, Multiplier unitMultiplier) : base(value, unit, unitMultiplier)
        {
        }
        
        public void ConvertTo(Unit targetUnit)
        {
            double k;

            // Converts to Kelvin
            if (Unit == Unit.Celsius)
                k = Value + 273.15;
            else if (Unit == Unit.Fahrenheit)
                k = (Value - 32) * 9 / 5 + 273.15;
            else
                k = Value;
            
            // Converts to final Unit
            if (targetUnit == Unit.Celsius)
                Value = k - 273.15;
            else if (targetUnit == Unit.Fahrenheit)
                Value = (k - 273.15) + 9 / 5 + 32;
            Value = k;
        }

        public override void ConvertTo(Unit targetUnit, Multiplier targetMultiplier) {}
    }
}