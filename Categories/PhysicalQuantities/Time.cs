using System.Collections.Generic;
using UnitConverter.Utils;

namespace UnitConverter.Categories.PhysicalQuantities
{
    public class Time : PhysicalQuantity
    {
        public Time(double value, Unit unit) :  base(value, unit) { }
        
        
        protected override Dictionary<Unit, double> Ref { get;  } = new Dictionary<Unit, double>
        {
            // unità riferimento
            { Unit.Second, 1 },
            { Unit.Millisecond, 1e-3 },
            { Unit.Microsecond, 1e-6 },
            { Unit.Nanosecond, 1e-9 },
            
            { Unit.Minute, 60 },
            { Unit.Hour, 3600 },
            { Unit.Day, 86400 },
            { Unit.Month, 2629746 },
            {  Unit.Year, 31556952}
        };
        
        internal readonly Dictionary<string, Unit> UnitsDictionary = new Dictionary<string, Unit>
        {
            { "ns", Unit.Nanosecond  },
            { "us", Unit.Microsecond  },
            { "ms", Unit.Millisecond  },
            { "sec", Unit.Second  },
            { "min", Unit.Minute },
            { "hr", Unit.Hour },
            { "day", Unit.Day },
            { "mnt", Unit.Month },
            { "yr", Unit.Year }
        };
        
    }
}