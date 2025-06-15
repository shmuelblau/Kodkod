using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation
{
    internal class Typs
    {
        public static Dictionary<string , Type> sensors = new Dictionary<string , Type>
        {
            { "AudioSensor",typeof(AudioSensor)},
            { "PulseSensor",typeof(PulseSensor)}
            
        };
    }
}
