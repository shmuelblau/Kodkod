using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation.Classes.Sensors
{
    public class Sensor: ISensor
    {
        public Agent agent { get; set; }

        public string name { get; set; }


        public Sensor(string name , Agent agent)
        {
            this.name = name;
            this.agent = agent;
        }

        public virtual string Activate()
        {
            return name;
        }
    }
}
