using System.Collections.Generic;
using UnitConverter.Utils;

namespace UnitConverter.Categories.PhysicalQuantities
{
    public class LinearAcceleration : PhysicalQuantity
    {
        public LinearAcceleration(double value, Unit unit) : base(value, unit) { }

        protected override Dictionary<Unit, double> Ref { get; } = new Dictionary<Unit, double>
        {
            { Unit.Meterspersecond2, 1 },
            { Unit.Kilometerspersecond2, 1000 },
            { Unit.Gravity, 9.80665 },
            { Unit.Inchespersecond2, 0.0254  },
        };
        
        internal readonly Dictionary<string, Unit> UnitsDictionary = new Dictionary<string, Unit>
        {
            { "m/s2", Unit.Meterspersecond2 },
            { "km/s2", Unit.Kilometerspersecond2 },
            { "g", Unit.Gravity },
            { "in/s2", Unit.Inchespersecond2 },
        };
    }
}