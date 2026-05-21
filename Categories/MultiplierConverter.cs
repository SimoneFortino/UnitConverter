using System.Collections.Generic;

namespace UnitConverter.Categories
{
    public abstract class MultiplierConverter
    {
        private double Value;
        private static readonly Dictionary<Multiplier, double> Factor = new Dictionary<Multiplier, double>()
        {
            { Multiplier.Femto, 1e-15 },
            { Multiplier.Pico, 1e-12 },
            { Multiplier.Nano, 1e-9 },
            { Multiplier.Micro, 1e-6 },
            { Multiplier.Milli, 1e-3 },
            { Multiplier.Centi, 1e-2 },
            { Multiplier.Deci, 1e-1 },
            { Multiplier.None, 1 },
            { Multiplier.Deca, 1e1 },
            { Multiplier.Hecto, 1e2 },
            { Multiplier.Kilo, 1e3 },
            { Multiplier.Mega, 1e6 },
            { Multiplier.Giga, 1e9 },
            { Multiplier.Tera, 1e12 },
            { Multiplier.Peta, 1e15 }
        };

        void ConvertByMultiplier(Multiplier from, Multiplier to)
        {
            double baseValue = Value * Factor[from]; 
        }
    }
}