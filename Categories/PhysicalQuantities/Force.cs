using System.Collections.Generic;
using UnitConverter.Utils;

namespace UnitConverter.Categories.PhysicalQuantities
{
    public class Force : PhysicalQuantity
    {
        public Force(double value, Unit unit) :  base(value, unit) { }

        public override void ConvertTo(Unit targetUnit)
        {
            double baseValue = Value * Ref[Unit];
            Value = baseValue / Ref[targetUnit];
            Unit = targetUnit; 
        }
        
        protected override Dictionary<Unit, double> Ref { get; } = new Dictionary<Unit, double>
        {
            // unità riferimento
            { Unit.Newton, 1 },
            { Unit.Kilonewton, 1000 },
            { Unit.Meganewton, 1000000 },
            { Unit.Micronewton, 1e-6 },
            { Unit.Millinewton, 1e-3 },
            
            { Unit.Dyne, 1e-5 }
        };
        
        internal readonly Dictionary<string, Unit> UnitsDictionary = new Dictionary<string, Unit>
        {
            { "MN", Unit.Meganewton},
            { "kN", Unit.Kilonewton},
            { "N", Unit.Newton},
            { "mN", Unit.Millinewton},
            { "uN", Unit.Micronewton},
            
            { "dyn", Unit.Dyne}
        };
    }
}