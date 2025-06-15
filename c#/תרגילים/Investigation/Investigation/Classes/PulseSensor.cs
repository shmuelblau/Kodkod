using Investigation.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation
{
    public class PulseSensor: ISensor
    {

        public Agent agent { get; set; }

        public string name { get; set; } = "AudioSensor";

        public int count { get; set; }

        public PulseSensor(Agent agent)
        {
            this.agent = agent;
        }

        public string Activate()
        {
            if (count > 3)
            {
                Pulse();
            }


            count += 1;

            return name;
        }
        public void Pulse()
        {
            for(int i = 0; i < agent.Sensors.Count; i++)
            {
                if (agent.Sensors[i] != null  && agent.Sensors[i] is PulseSensor)
                {
                    agent.Sensors[i] = null;
                }
                
            }
        }
    }


}
