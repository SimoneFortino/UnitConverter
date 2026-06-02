using System.Collections.Generic;
using UnitConverter.Utils;

namespace UnitConverter.Categories.PhysicalQuantities
{
    public class RadiationDose : PhysicalQuantity
    {
        public RadiationDose(double value, Unit unit) : base(value, unit)
        {
        }

        protected override Dictionary<Unit, double> Ref { get; } = new Dictionary<Unit, double>
        {
            { Unit.Sievert, 1 },
            { Unit.Millisievert, 0.001 },
            { Unit.Microsievert, 0.000001 },
            { Unit.Rem, 0.01 },
            { Unit.Millirem, 1e-5 },
        };
        
        internal readonly Dictionary<string, Unit> UnitsDictionary = new Dictionary<string, Unit>
        {
            { "Sv", Unit.Sievert },
            { "mSv", Unit.Millisievert },
            { "uSv", Unit.Microsievert },
            { "rem", Unit.Rem },
            { "mrem", Unit.Millirem }
        };
    }
}