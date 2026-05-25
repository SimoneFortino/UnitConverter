using System.Collections.Generic;

namespace UnitConverter.Utils
{
    public class MultiplierDictionary
    {
        public readonly Dictionary<string, Multiplier> Multipliers = new Dictionary<string, Multiplier>
        {
            { "P", Multiplier.Peta },
            { "T", Multiplier.Tera },
            { "G", Multiplier.Giga },
            { "M", Multiplier.Mega },
            { "K", Multiplier.Kilo },
            { "h", Multiplier.Hecto },
            { "da", Multiplier.Deca },
            { " ", Multiplier.None },
            { "d", Multiplier.Deci },
            { "c", Multiplier.Centi },
            { "m", Multiplier.Milli },
            { "u", Multiplier.Micro },
            { "n", Multiplier.Nano },
            { "p", Multiplier.Pico },
            { "f", Multiplier.Femto },
            
        };
    }
}