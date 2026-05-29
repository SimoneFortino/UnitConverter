using System.Collections.Generic;
using UnitConverter.Utils;

namespace UnitConverter.Categories
{
    public abstract class PhysicalQuantity 
    {
        internal double Value { get; set; }
        internal Unit Unit { get; set; }

        // Costruttore
        protected PhysicalQuantity(double value, Unit unit)
        {
            Value = value;
            Unit = unit;
        }
        
        // Dictionary per conversioni in riferimento all'unità base
        protected abstract Dictionary<Unit, double> Ref { get; }

        // Funzione di conversione 
        public virtual void ConvertTo(Unit targetUnit)
        {
            double baseValue = Value * Ref[Unit];
            Value = baseValue / Ref[targetUnit];
            Unit = targetUnit;
        }
    }
}