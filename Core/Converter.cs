using System;
using System.Collections.Generic;
using System.Windows.Forms.VisualStyles;
using UnitConverter.Categories;
using UnitConverter.Categories.PhysicalQuantities;
using UnitConverter.Utils;

namespace UnitConverter.Core
{
    public class Converter
    {
        public object Obj;
        
        private static readonly Dictionary<ObjectToConvert, Func<double, Unit, Multiplier, object>> Factory = 
            new Dictionary<ObjectToConvert, Func<double, Unit, Multiplier, object>> 
            { 
                { ObjectToConvert.Temperature, (v, u, m) => new Temperature(v, u, m) },
                { ObjectToConvert.Pressure, (v, u, m) => new Pressure(v, u, m) },
                { ObjectToConvert.Lenght, (v, u, m) => new Lenght(v, u, m) },
                { ObjectToConvert.Area, (v, u, m) => new Area(v, u, m) },
                { ObjectToConvert.Volume, (v, u, m) => new Volume(v, u, m) },
                { ObjectToConvert.Mass, (v, u, m) => new Mass(v, u, m) },
                { ObjectToConvert.ElectricCharge, (v, u, m) => new ElectricCharge(v, u, m) },
                { ObjectToConvert.Power, (v, u, m) => new Power(v, u, m) },
                { ObjectToConvert.Energy, (v, u, m) => new Energy(v, u, m) },
                { ObjectToConvert.Force, (v, u, m) => new Force(v, u, m) },
                { ObjectToConvert.Time, (v, u, m) => new Time(v, u, m) },
                { ObjectToConvert.Angle, (v, u, m) => new Angle(v, u, m) },
                { ObjectToConvert.MagneticField, (v, u, m) => new MagneticField(v, u, m) },
                { ObjectToConvert.DataSize, (v, u, m) => new DataSize(v, u, m) },
            };
        
        public void InitializeObject(ObjectToConvert objectToConvert, double val, Unit unit, Multiplier multiplier)
        {
            Obj = Factory[objectToConvert](val, unit, multiplier);
        }
        
    }
}