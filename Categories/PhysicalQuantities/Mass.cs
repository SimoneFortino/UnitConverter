using System.Collections.Generic;
using UnitConverter.Utils;

namespace UnitConverter.Categories.PhysicalQuantities
{
    public class Mass : PhysicalQuantity
    {
        public Mass(double value, Unit unit, Multiplier multiplier) :  base(value, unit, multiplier) { }

        public override void ConvertTo(Unit targetUnit, Multiplier targetMultiplier)
        {
            double baseValue = Value * Ref[Unit];
            Value = baseValue / Ref[targetUnit];
            Unit = targetUnit;
        }
        
        private static Dictionary<Unit, double> Ref = new Dictionary<Unit, double>
        {
            // unità riferimento
            { Unit.Gram, 1 },
            { Unit.Kilogram, 1000 },
            { Unit.Milligram, 0.001 },
            { Unit.Microgram, 0.000001 },
            { Unit.Nanogram, 1e-9 },
            { Unit.Tonne, 1000000 },
            
            { Unit.Pound, 453.59237 },
            { Unit.Ounce, 28.349523125 },
            { Unit.Stone, 6350.29318 },
            { Unit.UsTon, 907184.74 },
            { Unit.UkTon, 1016046.9088 },
            
            { Unit.AtomicMass, 1.66053906660e-24 }
        };
        
        internal readonly Dictionary<string, Unit> UnitsDictionary = new Dictionary<string, Unit>
        {
            { "t", Unit.Tonne },
            { "Kg", Unit.Kilogram },
            { "g", Unit.Gram },
            { "mg", Unit.Milligram },
            { "ug", Unit.Microgram },
            { "nm", Unit.Nanogram },

            
            { "USton", Unit.UsTon },
            { "UKton", Unit.UkTon },
            
            { "lb", Unit.Pound },
            { "oz", Unit.Ounce },
            { "st", Unit.Stone },
            
            { "amu", Unit.AtomicMass }
        };
    }
}