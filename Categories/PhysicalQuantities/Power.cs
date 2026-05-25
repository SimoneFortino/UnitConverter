using System.Collections.Generic;
using UnitConverter.Utils;

namespace UnitConverter.Categories.PhysicalQuantities
{
    public class Power : PhysicalQuantity
    {
        public Power(double value, Unit unit, Multiplier multiplier) :  base(value, unit, multiplier) { }

        public override void ConvertTo(Unit targetUnit, Multiplier targetMultiplier)
        {
            double baseValue = Value * Ref[Unit];
            Value = baseValue / Ref[targetUnit];
            Unit = targetUnit;
        }
        
        private static Dictionary<Unit, double> Ref = new Dictionary<Unit, double>
        {
            // unità riferimento
            { Unit.Watt, 1 },
            { Unit.Milliwatt, 0.001 },
            { Unit.Kilowatt, 1000 },
            { Unit.Megawatt, 1e6 },
            { Unit.Gigawatt, 1e9 },
            
            { Unit.MetricHorsePower, 735.49875 },
            { Unit.HorsePower, 745.6998715822702 },
        };
        
        internal readonly Dictionary<string, Unit> UnitsDictionary = new Dictionary<string, Unit>
        {
            { "GW", Unit.Gigawatt },
            { "MW", Unit.Megawatt },
            { "kW", Unit.Kilowatt },
            { "W", Unit.Watt },
            { "mW", Unit.Milliwatt },
            
            { "CV", Unit.MetricHorsePower },
            { "HP", Unit.HorsePower },
        };
    }
}