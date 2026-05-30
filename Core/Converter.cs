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
        
        private static readonly Dictionary<ObjectToConvert, Func<double, Unit, object>> Factory = 
            new Dictionary<ObjectToConvert, Func<double, Unit, object>> 
            { 
                { ObjectToConvert.Temperature, (v, u) => new Temperature(v, u) },
                { ObjectToConvert.Pressure, (v, u) => new Pressure(v, u) },
                { ObjectToConvert.Lenght, (v, u) => new Lenght(v, u) },
                { ObjectToConvert.Area, (v, u) => new Area(v, u) },
                { ObjectToConvert.Volume, (v, u) => new Volume(v, u) },
                { ObjectToConvert.Mass, (v, u) => new Mass(v, u) },
                { ObjectToConvert.ElectricCharge, (v, u) => new ElectricCharge(v, u) },
                { ObjectToConvert.Power, (v, u) => new Power(v, u) },
                { ObjectToConvert.Energy, (v, u) => new Energy(v, u) },
                { ObjectToConvert.Force, (v, u) => new Force(v, u) },
                { ObjectToConvert.Time, (v, u) => new Time(v, u) },
                { ObjectToConvert.Angle, (v, u) => new Angle(v, u) },
                { ObjectToConvert.MagneticField, (v, u) => new MagneticField(v, u) },
                { ObjectToConvert.DataSize, (v, u) => new DataSize(v, u) },
                { ObjectToConvert.RadiationDose, (v, u) => new RadiationDose(v, u) },
                { ObjectToConvert.LinearVelocity, (v, u) => new LinearVelocity(v, u) },
                { ObjectToConvert.LinearAcceleration, (v, u) => new LinearAcceleration(v, u) },
            };
        
        public void InitializeObject(ObjectToConvert objectToConvert, double val, Unit unit)
        {
            Obj = Factory[objectToConvert](val, unit);
        }
        
    }
}