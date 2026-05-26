using System.Collections.Generic;
using UnitConverter.Utils;

namespace UnitConverter.Categories.PhysicalQuantities
{
    public class ElectricCharge : PhysicalQuantity
    {
        public ElectricCharge(double value, Unit unit) :  base(value, unit) { }

        public override void ConvertTo(Unit targetUnit)
        {
            double baseValue = Value * Ref[Unit];
            Value = baseValue / Ref[targetUnit];
            Unit = targetUnit;
        }
        
        private static Dictionary<Unit, double> Ref = new Dictionary<Unit, double>
        {
            // unità riferimento
            { Unit.Coulomb, 1 },
            { Unit.Millicoulomb, 0.001 },
            { Unit.Microcoulomb, 0.000001 },
            { Unit.Nanocoulomb, 1e-9 },
            
            { Unit.AmpereHour, 3600.0 },
            { Unit.MilliampereHour, 1 },
            
            { Unit.Faraday, 96485.33212 },
        };
        
        internal readonly Dictionary<string, Unit> UnitsDictionary = new Dictionary<string, Unit>
        {
            { "C", Unit.Coulomb},
            { "mC", Unit.Millicoulomb},
            { "uC", Unit.Microcoulomb},
            { "nC", Unit.Nanocoulomb},
            
            { "Ah", Unit.AmpereHour},
            { "mAh", Unit.MilliampereHour},
            
            { "Fd", Unit.Faraday},
        };
    }
}