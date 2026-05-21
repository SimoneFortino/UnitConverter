using System.Collections.Generic;
using UnitConverter.Categories;

namespace UnitConverter.Utils
{
    public static class MeasurementUnitsDictionary
    {
        public static readonly Dictionary<string, Unit> MeasurementUnits = new Dictionary<string, Unit>
        {
            { "°C", Unit.Celsius },
            { "K", Unit.Kelvin },
            { "°F", Unit.Fahrenheit },
        };
    }
}