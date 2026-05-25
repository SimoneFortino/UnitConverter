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
        
        private static Dictionary<Unit, double> ByteRef = new Dictionary<Unit, double>
        {
            // unità riferimento
            { Unit.Byte, 1 },
            
            { Unit.Bit, 0.125 }
        };
        
        internal readonly Dictionary<string, Unit> UnitsDictionary = new Dictionary<string, Unit>
        {
            { "B", Unit.Byte },
            { "b", Unit.Bit }
        };
    }
}