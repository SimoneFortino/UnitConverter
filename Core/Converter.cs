using UnitConverter.Categories;
using UnitConverter.Categories.PhysicalQuantities;
using UnitConverter.Utils;

namespace UnitConverter.Core
{
    public class Converter
    {
        public void InitializeObject(ObjectToConvert objectToConvert, double val, Unit unit, Multiplier multiplier)
        {
            var obj = ObjectToConvert switch
            {
                ObjectToConvert.Temperature     => new Temperature(val, unit, multiplier),
                ObjectToConvert.Humidity        => new Humidity(val, unit, multiplier),
                ObjectToConvert.Pressure        => new Pressure(val, unit, multiplier),
                ObjectToConvert.Lenght          => new Lenght(val, unit, multiplier),
                ObjectToConvert.Area            => new Area(val, unit, multiplier),
                ObjectToConvert.Volume          => new Volume(val, unit, multiplier),
                ObjectToConvert.Mass            => new Mass(val, unit, multiplier),
                ObjectToConvert.ElectricCurrent => new ElectricCurrent(val, unit, multiplier),
                ObjectToConvert.Resistance      => new Resistance(val, unit, multiplier),
                ObjectToConvert.Voltage         => new Voltage(val, unit, multiplier),
                ObjectToConvert.Inductance      => new Inductance(val, unit, multiplier),
                ObjectToConvert.Capacitance     => new Capacitance(val, unit, multiplier),
                ObjectToConvert.Conductance     => new Conductance(val, unit, multiplier),
                ObjectToConvert.ElectricCharge  => new ElectricCharge(val, unit, multiplier),
                ObjectToConvert.Frequency       => new Frequency(val, unit, multiplier),
                ObjectToConvert.Power           => new Power(val, unit, multiplier),
                ObjectToConvert.Energy          => new Energy(val, unit, multiplier),
                ObjectToConvert.Force           => new Force(val, unit, multiplier),
                ObjectToConvert.Time            => new Time(val, unit, multiplier),
                ObjectToConvert.Angles          => new Angles(val, unit, multiplier),
                ObjectToConvert.MagneticField   => new MagneticField(val, unit, multiplier),
                ObjectToConvert.Memory          => new Memory(val, unit, multiplier),

                _ => throw new NotImplementedException()
            };



        }
    }
}