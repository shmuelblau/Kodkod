using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation
{
    public class AudioSensor : ISensor
    {
        public Agent agent {  get; set; }

        public string name { get; set; } = "AudioSensor";


        public AudioSensor(Agent agent)
        {
            this.agent = agent;
        }

        public string Activate()
        {
            return name;
        }
    }
}
