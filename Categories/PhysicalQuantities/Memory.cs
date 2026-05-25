using System.Collections.Generic;
using UnitConverter.Utils;

namespace UnitConverter.Categories.PhysicalQuantities
{
    public class Memory : PhysicalQuantity
    {
        public Memory(double value, Unit unit, Multiplier multiplier) :  base(value, unit, multiplier) { }

        public override void ConvertTo(Unit targetUnit, Multiplier targetMultiplier)
        {
            
        }
        
        internal readonly Dictionary<string, Unit> UnitsDictionary = new Dictionary<string, Unit>
        {
            { "B", Unit.Byte },
            { "b", Unit.Bit }
        };
    }
}