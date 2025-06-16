using Investigation.Classes.Sensors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation
{
    public class SignalSensor:Sensor
    {
        public SignalSensor(Agent agent) : base("SignalSensor", agent) { }
    }
}
