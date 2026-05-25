using System.Collections.Generic;
using UnitConverter.Utils;

namespace UnitConverter.Categories.PhysicalQuantities
{
    public class Lenght : PhysicalQuantity
    {
        public Lenght(double value, Unit unit, Multiplier unitMultiplier) : base(value, unit, unitMultiplier)
        {
        }

        public override void ConvertTo(Unit targetUnit, Multiplier targetMultiplier)
        {
            double baseValue = Value * Ref[Unit];
            Value = baseValue / Ref[targetUnit];
            Unit = targetUnit;
            
            ConvertByMultiplier(targetMultiplier);
        }

        private static Dictionary<Unit, double> Ref = new Dictionary<Unit, double>
        {
            // unità riferimento
            { Unit.Meter, 1 },
            
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
            { "m", Unit.Meter },
            { "mi", Unit.Mile },
            { "in", Unit.Inch },
            { "ft", Unit.Foot },
            { "yrd", Unit.Yard },
            { "NM", Unit.NauticalMile},
            { "AU", Unit.AstronomicalUnit},
            { "ly", Unit.LightYear}
        };
    }
}