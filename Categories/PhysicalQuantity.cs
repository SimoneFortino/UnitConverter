using System.Collections.Generic;
using UnitConverter.Utils;

namespace UnitConverter.Categories
{
    public abstract class PhysicalQuantity 
    {
        public double Value { get; set; }
        public Unit Unit { get; set; }

        protected PhysicalQuantity(double value, Unit unit)
        {
            Value = value;
            Unit = unit;
        }
        
        protected abstract Dictionary<Unit, double> Ref { get; }

        public virtual void ConvertTo(Unit targetUnit)
        {
            double baseValue = Value * Ref[Unit];
            Value = baseValue / Ref[targetUnit];
            Unit = targetUnit;
        }
    }
}