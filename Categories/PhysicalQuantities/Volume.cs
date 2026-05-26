using System.Collections.Generic;
using UnitConverter.Utils;

namespace UnitConverter.Categories.PhysicalQuantities
{
    public class Volume : PhysicalQuantity
    {
        public Volume(double value, Unit unit) :  base(value, unit) { }

        public override void ConvertTo(Unit targetUnit)
        {
            double baseValue = Value * Ref[Unit];
            Value = baseValue / Ref[targetUnit];
            Unit = targetUnit;
        }
        
        private static readonly Dictionary<Unit, double> Ref = new Dictionary<Unit, double>
        {
            // unità riferimento
            { Unit.Liter, 1 },
            { Unit.Deciliter, 0.1 },
            { Unit.Centiliter, 0.01 },
            { Unit.Milliliter, 0.001 },
            { Unit.Decaliter, 10 },
            { Unit.Hectoliter, 100 },
            
            { Unit.CubicMeter, 1000 },
            { Unit.CubicDecimeter, 1 },
            { Unit.CubicCentimeter, 0.001 },
            { Unit.CubicMillimeter, 0.000001 },
            
            { Unit.UsGallon, 3.785411784 },
            { Unit.UsPint, 0.473176473 },
            
            { Unit.OilBarrel, 158.987294928 },

        };
        
        internal readonly Dictionary<string, Unit> UnitsDictionary = new Dictionary<string, Unit>
        {
            { "hL", Unit.Hectoliter },
            { "daL", Unit.Decaliter },
            { "L", Unit.Liter },
            { "dL", Unit.Deciliter },
            { "cL", Unit.Centiliter },
            { "mL", Unit.Milliliter },
            
            { "m3", Unit.CubicMeter },
            { "dm3", Unit.CubicDecimeter },
            { "cm3", Unit.CubicCentimeter },
            { "mm3", Unit.CubicMillimeter },
            
            { "gal", Unit.UsGallon },
            { "pt", Unit.UsPint },
            
            { "bbl", Unit.OilBarrel },
            
        };
    }
}