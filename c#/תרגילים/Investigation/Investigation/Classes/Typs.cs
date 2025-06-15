using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation.Classes
{
    internal class Typs
    {
        public static Dictionary<string , Type> sensors = new Dictionary<string , Type>
        {
            { "Sensor",typeof(AudioSensor)},
            { "Sensor",typeof(PulseSensor)}
            
        };
    }
}
