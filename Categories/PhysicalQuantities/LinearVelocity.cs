using System.Collections.Generic;
using UnitConverter.Utils;

namespace UnitConverter.Categories.PhysicalQuantities
{
    public class LinearVelocity : PhysicalQuantity
    {
        public LinearVelocity(double value, Unit unit) : base(value, unit)
        {
        }

        protected override Dictionary<Unit, double> Ref { get; } = new Dictionary<Unit, double>
        {
            { Unit.Meterspersecond, 1 },
            { Unit.Kilometerspersecond, 1000 },
            { Unit.Kilometersperhour, 2.77778e-1 },
            { Unit.Inchespersecond, 0.0254 },
            { Unit.Mach, 340.29 },
            { Unit.Milesperhour, 4.4704e-1 },
            { Unit.Knot, 5.144444e-1 },
        };
        
        internal readonly Dictionary<string, Unit> UnitsDictionary = new Dictionary<string, Unit>
        {
            { "m/s", Unit.Meterspersecond },
            { "in/s", Unit.Inchespersecond },
            { "km/s", Unit.Kilometerspersecond },
            { "km/h", Unit.Kilometersperhour },
            { "mph", Unit.Milesperhour },
            { "Ma", Unit.Mach },
            { "knot", Unit.Knot },
        };
    }
}