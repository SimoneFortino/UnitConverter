using System.Collections.Generic;
using UnitConverter.Utils;

namespace UnitConverter.Categories.PhysicalQuantities
{
    public class Lenght : PhysicalQuantity
    {
        public Lenght(double value, Unit unit) :  base(value, unit)
        {
        }
        
        protected override Dictionary<Unit, double> Ref { get;  } = new Dictionary<Unit, double>        {
            // unità riferimento
            { Unit.Meter, 1 },
            { Unit.Kilometer, 1000 },
            { Unit.Hectometer, 100 },
            { Unit.Decameter, 10 },
            { Unit.Decimeter, 0.1 },
            { Unit.Centimeter, 0.01 },
            { Unit.Millimeter, 0.001 },
            { Unit.Micrometer, 0.000001 },
            { Unit.Nanometer, 1e-9 },
            
            // unità imperiali
            { Unit.Mile, 1609.34 },
            { Unit.Yard, 0.9144},
            { Unit.Foot, 0.3048 },
            { Unit.Inch, 0.0254 },
            
            // unità nautiche
            { Unit.NauticalMile , 1852 },
            
            // unità astronomiche
            { Unit.AstronomicalUnit, 149597870700 },
            { Unit.LightYear, 3.08567e15 },
            
        };

        internal readonly Dictionary<string, Unit> UnitsDictionary = new Dictionary<string, Unit>
        {
            { "Km", Unit.Kilometer },
            { "hm", Unit.Hectometer },
            { "dam", Unit.Decameter },
            { "m", Unit.Meter },
            { "dm", Unit.Decimeter },
            { "cm", Unit.Centimeter },
            { "mm", Unit.Millimeter },
            { "um", Unit.Micrometer },
            { "nm", Unit.Nanometer },
            
            { "mi", Unit.Mile },
            { "yrd", Unit.Yard },
            { "ft", Unit.Foot },
            { "in", Unit.Inch },
            
            { "NM", Unit.NauticalMile},
            
            { "AU", Unit.AstronomicalUnit},
            { "ly", Unit.LightYear}
        };
    }
}