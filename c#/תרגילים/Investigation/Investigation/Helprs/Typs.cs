using Investigation.Classes;
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
            { "PulseSensor",typeof(PulseSensor)},
            { "ThermalSensor",typeof(ThermalSensor)},
            { "MagneticSensor",typeof(MagneticSensor)},
            { "SignalSensor",typeof(SignalSensor)},
            { "LightSensor",typeof(LightSensor)}
            
        };
        
        
        
        
        public static Dictionary<string , Type> Agents = new Dictionary<string , Type>
        {
            { "Rank2Agent",typeof(Rank2Agent)},
            { "Rank4Agent",typeof(Rank4Agent)},
            { "Rank6Agent",typeof(Rank6Agent)},
            { "Rank8Agent",typeof(Rank8Agent)}
           
            
        };


        
    }
}
