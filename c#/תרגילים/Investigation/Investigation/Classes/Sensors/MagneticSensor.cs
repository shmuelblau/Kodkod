using Investigation.Classes.Sensors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation
{
    public class MagneticSensor:Sensor
    {
        public MagneticSensor(Agent agent) : base("MagneticSensor", agent) { }
    }
}
