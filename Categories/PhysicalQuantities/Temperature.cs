using System.Collections.Generic;
using UnitConverter.Utils;

namespace UnitConverter.Categories.PhysicalQuantities
{
    public class Temperature : PhysicalQuantity
    {
        public Temperature(double value, Unit unit, Multiplier unitMultiplier) : base(value, unit, unitMultiplier)
        {
        }
        
        public override void ConvertTo(Unit targetUnit, Multiplier targetMultiplier)
        {
            double k;

            // Converts to Kelvin
            if (Unit == Unit.Celsius)
                k = Value + 273.15;
            else if (Unit == Unit.Fahrenheit)
                k = (Value - 32) * (5.0 / 9.0) + 273.15;
            else
                k = Value;
            
            // Converts to final Unit
            if (targetUnit == Unit.Celsius)
                Value = k - 273.15;
            else if (targetUnit == Unit.Fahrenheit)
                Value = (k - 273.15) * 1.8 + 32;
            else
                Value = k;
        }

        internal readonly Dictionary<string, Unit> UnitsDictionary = new Dictionary<string, Unit>
        {
            { "°C", Unit.Celsius },
            { "K", Unit.Kelvin },
            { "°F", Unit.Fahrenheit },
        };
    }
}