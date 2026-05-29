using System.Collections.Generic;
using UnitConverter.Utils;

namespace UnitConverter.Core
{
    public class ConversionEngine
    {
        private readonly Converter _converter = new Converter();

        internal dynamic DynamicObject;

        public ObjectToConvert Selection { get; set; }
        public double StartingValue { get; set; }
        public Unit StartingUnit { get; set; }
        public Unit TargetUnit { get; set; }

        public double ConvertedValue { get; private set; }
        

        public void SetObject(ObjectToConvert selection)
        {
            Selection = selection;
            _converter.InitializeObject(selection, StartingValue, StartingUnit);

            DynamicObject = _converter.Obj;
        }

        public void SetStarting(double value, Unit unit)
        {
            StartingValue = value;
            StartingUnit = unit;
        }

        public void SetTarget(Unit unit)
        {
            TargetUnit = unit;
        }

        public void Convert()
        {
            dynamic dyn = _converter.Obj;
            dyn.Value = StartingValue;
            dyn.Unit = StartingUnit;

            dyn.ConvertTo(TargetUnit);

            ConvertedValue = dyn.Value;
        }
        
    }
}