using System.Collections.Generic;
using UnitConverter.Utils;

namespace UnitConverter.Categories.PhysicalQuantities
{
    public class Pressure : PhysicalQuantity
    {
        public Pressure(double value, Unit unit, Multiplier multiplier) :  base(value, unit, multiplier) { }

        public override void ConvertTo(Unit targetUnit, Multiplier targetMultiplier)
        {
            double baseValue = Value * Ref[Unit];
            Value = baseValue / Ref[targetUnit];
            Unit = targetUnit;
        }
        
        private static Dictionary<Unit, double> Ref = new Dictionary<Unit, double>
        {
            // unità riferimento
            { Unit.Pascal, 1 },
            { Unit.Hectopascal, 100 },
            { Unit.Kilopascal, 1e3 },
            { Unit.Megapascal, 1e6 },
            
            { Unit.Atmosphere, 101325 },
            { Unit.Bar, 100000 },
            { Unit.Millibar, 100 },
            
            { Unit.MillimeterHg, 133.322387415 },
            { Unit.Torr, 133.322 },
            { Unit.Psi, 6894.757293168 }
        };
        
        internal readonly Dictionary<string, Unit> UnitsDictionary = new Dictionary<string, Unit>
        {
            { "psi", Unit.Psi },
            { "bar", Unit.Bar },
            { "mbar", Unit.Millibar },
            { "atm", Unit.Atmosphere },
            { "mmHg", Unit.MillimeterHg},
            { "Torr", Unit.Torr },
            
            { "Pa", Unit.Pascal },
            { "hPa", Unit.Hectopascal },
            { "kPa", Unit.Kilopascal },
            { "MPa", Unit.Megapascal },
        };
    }
}