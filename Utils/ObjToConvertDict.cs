using System.Collections.Generic;

namespace UnitConverter.Utils
{
    public static class ObjToConvertDict
    {
        public static readonly Dictionary<string, ObjectToConvert> CategoryDisplayNames =
            new Dictionary<string, ObjectToConvert>
            {
                { "Temperature", ObjectToConvert.Temperature },
                { "Pressure", ObjectToConvert.Pressure },
                { "Length", ObjectToConvert.Lenght },
                { "Area", ObjectToConvert.Area },
                { "Volume", ObjectToConvert.Volume },
                { "Mass", ObjectToConvert.Mass },
                { "Electric Charge", ObjectToConvert.ElectricCharge },
                { "Power", ObjectToConvert.Power },
                { "Energy", ObjectToConvert.Energy },
                { "Force", ObjectToConvert.Force },
                { "Time", ObjectToConvert.Time },
                { "Angle", ObjectToConvert.Angle },
                { "Magnetic Field", ObjectToConvert.MagneticField },
                { "Data Size (SI)", ObjectToConvert.DataSize },
                { "Radiation Dose", ObjectToConvert.RadiationDose },
                { "Linear Velocity", ObjectToConvert.LinearVelocity },
                { "Linear Acceleration", ObjectToConvert.LinearAcceleration }
            };
    }
}