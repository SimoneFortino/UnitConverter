using System.Collections.Generic;
using UnitConverter.Utils;

namespace UnitConverter.Categories.PhysicalQuantities
{
    public class Energy : PhysicalQuantity
    {
        public Energy(double value, Unit unit, Multiplier multiplier) :  base(value, unit, multiplier) { }

        public override void ConvertTo(Unit targetUnit, Multiplier targetMultiplier)
        {
            double baseValue = Value * Ref[Unit];
            Value = baseValue / Ref[targetUnit];
            Unit = targetUnit;
        }
        private static Dictionary<Unit, double> Ref = new Dictionary<Unit, double>
        {
            // unità riferimento
            { Unit.Joule, 1 },
            { Unit.Kilojoule, 1000 },
            { Unit.Megajoule, 1000000 },
            { Unit.Gigajoule, 1e9 },
            
            { Unit.WattHour, 3600.0 },
            { Unit.KilowattHour, 3600000 },
            { Unit.MegawattHour, 3600000000 },
            { Unit.GigawattHour, 3600000000000 },
            
            { Unit.Calorie, 4.184 },
            { Unit.Kilocalorie, 4184 },
        };
        
        
        internal readonly Dictionary<string, Unit> UnitsDictionary = new Dictionary<string, Unit>
        {
            { "GJ", Unit.Gigajoule},
            { "MJ", Unit.Megajoule},
            { "kJ", Unit.Kilojoule},
            { "J", Unit.Joule},
            
            { "kcal", Unit.Kilocalorie},
            { "cal", Unit.Calorie},
            
            { "GWh", Unit.GigawattHour},
            { "MWh", Unit.MegawattHour},
            { "kWh", Unit.KilowattHour},
            { "Wh", Unit.WattHour}
        };
    }
}