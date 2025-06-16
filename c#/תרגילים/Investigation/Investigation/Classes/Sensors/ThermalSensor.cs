using Investigation.Classes.Sensors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation
{
    public class ThermalSensor:Sensor
    {
        public ThermalSensor(Agent agent) : base("ThermalSensor", agent) { }
    }
}
