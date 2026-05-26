using System.Collections.Generic;
using UnitConverter.Utils;

namespace UnitConverter.Categories.PhysicalQuantities
{
    public class Area : PhysicalQuantity
    {
        public Area(double value, Unit unit) :  base(value, unit) { }

        public override void ConvertTo(Unit targetUnit)
        {
            double baseValue = Value * Ref[Unit];
            Value = baseValue / Ref[targetUnit];
            Unit = targetUnit;
        }
        
        private static Dictionary<Unit, double> Ref = new Dictionary<Unit, double>
        {
            // unità riferimento
            { Unit.SquareMeter, 1 },
            { Unit.SquareKilometer, 1000000 },
            { Unit.SquareDecimeter, 0.01 },
            { Unit.SquareCentimeter, 0.0001 },
            { Unit.SquareMillimeter, 0.000001 },
            
            { Unit.Hectare, 10000 },
            { Unit.Acre, 4046.8564224 },
            { Unit.SquareMile, 2589988.110336 },
            { Unit.SquareInch, 0.00064516 },
        };

        internal readonly Dictionary<string, Unit> UnitsDictionary = new Dictionary<string, Unit>
        {
            { "km2", Unit.SquareKilometer},
            { "m2", Unit.SquareMeter},
            { "dm2", Unit.SquareDecimeter},
            { "cm2", Unit.SquareCentimeter},
            { "mm2", Unit.SquareMillimeter},
            
            { "acre", Unit.Acre},
            { "ha", Unit.Hectare},
            
            { "mi2", Unit.SquareMile},
            { "in2", Unit.SquareInch},
        };
    }
}