using System;
using System.Collections.Generic;
using UnitConverter.Utils;

namespace UnitConverter.Categories.PhysicalQuantities
{
    public class Temperature : PhysicalQuantity
    {
        public Temperature(double value, Unit unit) :  base(value, unit)
        {
        }

        protected override Dictionary<Unit, double> Ref { get; } = new Dictionary<Unit, double> { };

        protected readonly Dictionary<Unit, Func<double, double>> ToKelvin = new Dictionary<Unit, Func<double, double>>
        {
            { Unit.Kelvin, x => x },
            { Unit.Celsius, x => x + 273.15 },
            { Unit.Fahrenheit, x => (x - 459.67) * (5.0 / 9.0) },
            { Unit.Rankine, x => x * (5.0 / 9.0) },
        };
        
        protected readonly Dictionary<Unit, Func<double, double>> FromKelvin = new Dictionary<Unit, Func<double, double>>
        {
            { Unit.Kelvin, x => x },
            { Unit.Celsius, x => x - 273.15 },
            { Unit.Fahrenheit, x => x * (9.0 / 5.0) - 459.67 },
            { Unit.Rankine, x => x * (9.0 / 5.0) },
        };

        public override void ConvertTo(Unit targetUnit)
        {
            double k = ToKelvin[Unit](Value);
            Value = FromKelvin[targetUnit](k);
        }
        
        internal readonly Dictionary<string, Unit> UnitsDictionary = new Dictionary<string, Unit>
        {
            { "°C", Unit.Celsius },
            { "K", Unit.Kelvin },
            { "°F", Unit.Fahrenheit },
            { "°R", Unit.Rankine },

        };
    }
}